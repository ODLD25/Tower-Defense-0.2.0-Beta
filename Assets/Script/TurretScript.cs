using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{
    [Header("Price")]
    public int buildprice;
    public int objectUpgradePrice;
    public int objectSellValue;

    [Header("Ammo")]
    public GameObject[] ammo;
    public GameObject spawnedAmmo;
    public GameObject shootPoint;
    public float ammoSpeed;
    public bool upgradedAmmo;

    [Header("Stats")]
    public float damage, viewRadiusScale, reloadTime, slowMultiplier;
    public int turretNumber;
    public bool isSelected, hiddenDetection, freezeTower;
    public float attackTimer, yRotation, xRotation;

    [Header("Objects")]
    public GameObject buildPoint, viewRadius, cameraPoint;
    public GameObject zombieFinderObject;

    [Header("Upgrades")]
    public GameObject[] upgrades;
    public int currentUpgrade;

    [Header("Shake")]
    public float shakeTime, shakeOffset;
    public bool isShaking;
    private Vector3 startShakePos;
    private float shakeTimer, origShakeTime;

    [Header("Enemy")]
    public GameObject[] enemies;
    public GameObject activeEnemy;
    private GameObject enemySpawner;
    public bool seesEnemy;
    public int enemyKilled, maxArrayPosition;
    private float enemyHealth;
    public LayerMask EnemyLayerMask;

    public TurretState state;
    public enum TurretState
    {
        ShootingTurret,
        FreezingTurret,
        controlledTurret
    }

    // Start is called before the first frame update
    void Start()
    {
        enemySpawner = GameObject.FindGameObjectWithTag("EnemySpawner");

        //DISABLE UNBOUGHT UPGRADES
        foreach(GameObject upgrade in upgrades)
        {
            if (upgrade != upgrades[currentUpgrade])
            {
                upgrade.SetActive(false);
            }
        }

        //SET VALUES
        origShakeTime = shakeTime;

        currentUpgrade = 0;

        upgrades[currentUpgrade].SetActive(true);
        objectUpgradePrice = upgrades[currentUpgrade + 1].GetComponent<TurretObjectScript>().upgradePrice;
        upgrades[currentUpgrade].GetComponent<TurretObjectScript>().turretObjectNumber = turretNumber;
        objectSellValue = buildprice;
        viewRadiusScale =  upgrades[currentUpgrade].GetComponent<TurretObjectScript>().viewRadiusScale;

        viewRadius.transform.localScale = new Vector3(viewRadiusScale * 100, viewRadiusScale * 100, viewRadiusScale * 100);
        gameObject.GetComponent<SphereCollider>().radius = viewRadiusScale;

        damage = upgrades[currentUpgrade].GetComponent<TurretObjectScript>().damage;
        reloadTime = upgrades[currentUpgrade].GetComponent<TurretObjectScript>().reloadTime;
        slowMultiplier = upgrades[currentUpgrade].GetComponent<TurretObjectScript>().slowMultiplier;

        if(state == TurretState.FreezingTurret)
        {
            freezeTower = true;
        }

        InvokeRepeating(nameof(CheckIfSees), 0, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (state != TurretState.controlledTurret)
        {
            //CHECK IF ENEMY IS DEAD
            if (activeEnemy != null)
            {
                //SET VALUES
                activeEnemy.GetComponent<EnemyScript>().turret = gameObject;
                enemyHealth = activeEnemy.GetComponent<EnemyScript>().health;

                //CHECK IF DEAD
                if (enemyHealth <= 0)
                {
                    activeEnemy = null;
                    //CheckIfSees(0);
                    enemySpawner.GetComponent<EnemySpawner>().checkForZombies();

                    enemyKilled += 1;
                }
            }

            if (attackTimer <= 0f)
            {
                AttackEnemy();
                attackTimer = reloadTime;
            }

            //START METHODS
            if (seesEnemy)
            {
                FollowEnemy();
            }
        }
        else if (state == TurretState.controlledTurret)
        {
            ControllTurret();
        }
        
        if (isSelected)
        {
            viewRadius.SetActive(true);
        }
        else
        {
            viewRadius.SetActive(false);
        }

        attackTimer -= Time.deltaTime;

        if (isShaking)
        {
            shakeTimer -= Time.deltaTime;
            Shake();

            if (shakeTimer < 0f)
            {
                isShaking = false;
                transform.position = startShakePos;
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        //CHCEK IF ENEMY EXITED TRIGGER
        if (other.gameObject.tag == "Enemy")
        {
            //CHCEK IF EXITED ENEMY IS MAIN ENEMY
            if (other.gameObject == activeEnemy)
            {
                //SET MAIN ENEMY AS NULL
                activeEnemy = null;
            }
        }
    }

    public void CheckIfSees()
    {
        if (state != TurretState.controlledTurret)
        {
            GameObject spawnedZombieFinder = Instantiate(zombieFinderObject, transform.localPosition = new Vector3(transform.position.x - (viewRadiusScale / 2), transform.position.y, transform.position.z), Quaternion.identity);
            transform.position = new Vector3(transform.position.x + (viewRadiusScale / 2), transform.position.y, transform.position.z);
            spawnedZombieFinder.transform.localScale = new Vector3(0.5f, spawnedZombieFinder.transform.localScale.y, viewRadiusScale + 0.5f);
            spawnedZombieFinder.GetComponent<ZombieFinderScript>().parentTurret = gameObject;
            spawnedZombieFinder.GetComponent<ZombieFinderScript>().minPosX = transform.position.x + (viewRadiusScale / 2);

            if (enemies[0] != null)
            {
                activeEnemy = enemies[0];
                seesEnemy = true;
            }
            else
            {
                activeEnemy = null;
                seesEnemy = false;
            }
        }
    }

    public void FollowEnemy()
    {
        //CHECK IF SEE ENEMY
        if (activeEnemy == null)
        {

        }
        else if (activeEnemy != null && state != TurretState.FreezingTurret)
        {
            //FOLLOW ENEMY
            Vector3 targetEnemy = new Vector3(activeEnemy.transform.position.x, transform.position.y, activeEnemy.transform.position.z);
            Debug.Log("-");

            //LOOK AT ENEMY
            transform.LookAt(targetEnemy);
            Debug.Log("--");
        }
    }

    void AttackEnemy()
    {
        //CHECK IF SEES ENEMY 
        if (seesEnemy && state == TurretState.ShootingTurret && activeEnemy != null)
        {
            if (hiddenDetection || activeEnemy.GetComponent<EnemyScript>().isInvisible == false){
                //ATTACK ENEMY
                if (upgradedAmmo)
                {
                    //SPAWN AMMO AND SET ITS VALUES
                    spawnedAmmo = Instantiate(ammo[1], shootPoint.transform.position, Quaternion.identity);
                    spawnedAmmo.GetComponent<AmmoScript>().shootSpeed = ammoSpeed;
                    spawnedAmmo.GetComponent<AmmoScript>().turret = gameObject;
                    spawnedAmmo.GetComponent<AmmoScript>().enemy = activeEnemy;

                
                    float dealDamage = spawnedAmmo.GetComponent<AmmoScript>().damage + damage;
                    dealDamage = dealDamage - damage / 100 * activeEnemy.GetComponent<EnemyScript>().defense;

                    if (activeEnemy.tag == "Enemy"){
                        //DAMAGE ENEMY
                        activeEnemy.GetComponent<EnemyScript>().health -= dealDamage;
                    }
                    else if (activeEnemy.tag == "OrbScript"){
                    activeEnemy.GetComponent<OrbScript>().health -= dealDamage;
                    }
                }
                else
                {
                    //SPAWN AMMO AND SET ITS VALUES
                    spawnedAmmo = Instantiate(ammo[0], shootPoint.transform.position, Quaternion.identity);
                    spawnedAmmo.GetComponent<AmmoScript>().shootSpeed = ammoSpeed;
                    spawnedAmmo.GetComponent<AmmoScript>().turret = gameObject;
                    spawnedAmmo.GetComponent<AmmoScript>().enemy = activeEnemy;

                    //CALCULATE DAMAGE
                    float dealDamage = spawnedAmmo.GetComponent<AmmoScript>().damage + damage;
                    dealDamage = dealDamage - damage / 100 * activeEnemy.GetComponent<EnemyScript>().defense;

                    //DAMAGE ENEMY
                    activeEnemy.GetComponent<EnemyScript>().health -= dealDamage;
                }
            }
            
        }
        else if (seesEnemy && state == TurretState.FreezingTurret)
        {
            foreach(GameObject go in enemies)
            {
                if (go != null)
                {
                    //CALCULATE DAMAGE
                    float dealDamage = damage;
                    dealDamage = dealDamage - (damage / 100 * go.GetComponent<EnemyScript>().defense);

                    go.GetComponent<EnemyScript>().turret = this.gameObject;
                    go.GetComponent<EnemyScript>().health -= dealDamage;
                }
            }
        }                                                                                                                                                                                                                  
    }

    public void UpgradeTurret()
    {
        //CHANGE VALUES
        currentUpgrade += 1;

        //SHOW CURRENT UPGRADE
        upgrades[currentUpgrade].SetActive(true);

        //HIDE UNBOUGHT UPGRADES
        foreach(GameObject upgrade in upgrades)
        {
            if (upgrade != upgrades[currentUpgrade])
            {
                upgrade.SetActive(false);
            }
        }

        //SET OR CHANGE VALUES
        objectSellValue += upgrades[currentUpgrade].GetComponent<TurretObjectScript>().upgradePrice / 2;
        if (currentUpgrade != upgrades.Length - 1){
            objectUpgradePrice = upgrades[currentUpgrade + 1].GetComponent<TurretObjectScript>().upgradePrice;
        }
        damage = upgrades[currentUpgrade].GetComponent<TurretObjectScript>().damage;
        reloadTime = upgrades[currentUpgrade].GetComponent<TurretObjectScript>().reloadTime;
        upgrades[currentUpgrade].GetComponent<TurretObjectScript>().turretObjectNumber = turretNumber;
        viewRadiusScale =  upgrades[currentUpgrade].GetComponent<TurretObjectScript>().viewRadiusScale;
        hiddenDetection = upgrades[currentUpgrade].GetComponent<TurretObjectScript>().hiddenDetection;

        viewRadius.transform.localScale = new Vector3(viewRadiusScale * 100, viewRadiusScale * 100, viewRadiusScale * 100);
        gameObject.GetComponent<SphereCollider>().radius = viewRadiusScale;
    }

    public void ControllTurret()
    {
        float yMouse = Input.GetAxis("Mouse X");
        float xMouse = Input.GetAxis("Mouse Y");

        //CALUCLATE ROTATION
        yRotation = yRotation + yMouse;
        xRotation = xRotation + xMouse;

        //ROTATE Turret AND CAMERA
        transform.rotation = Quaternion.Euler(-xRotation, yRotation, transform.rotation.z);

        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
        camera.GetComponentInChildren<MoveCamera>().controllingTurret = true;
        camera.GetComponentInChildren<MoveCamera>().controlledTurret = gameObject;

        if (Input.GetMouseButtonDown(0) && attackTimer <= 0f)
        {
            spawnedAmmo = Instantiate(ammo[0], shootPoint.transform.position, Quaternion.identity);
            spawnedAmmo.GetComponent<AmmoScript>().shootSpeed = ammoSpeed;
            spawnedAmmo.GetComponent<AmmoScript>().turret = gameObject;

            spawnedAmmo.transform.rotation = transform.rotation;
            isShaking = true;
            shakeTimer = shakeTime;
            startShakePos = transform.position;

            cameraPoint.GetComponent<TurretCameraPosScript>().ShootRaycast();
            GameObject hitObject = cameraPoint.GetComponent<TurretCameraPosScript>().hitObject;

            if (hitObject != null && hitObject.gameObject.GetComponent<EnemyScript>() != null)
            {
                if (hiddenDetection || hitObject.gameObject.GetComponent<EnemyScript>().isInvisible == false)
                {
                    //CALCULATE DAMAGE
                    float dealDamage = spawnedAmmo.GetComponent<AmmoScript>().damage + damage;

                    hitObject.GetComponent<EnemyScript>().health = hitObject.GetComponent<EnemyScript>().health - dealDamage;
                }
            }
            else
            {
                Debug.DrawLine(transform.position, transform.forward, Color.red, 10f);
            }

            attackTimer = reloadTime;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            state = TurretState.ShootingTurret;

            camera.GetComponentInParent<Renderer>().enabled = false;
            camera.GetComponentInChildren<MoveCamera>().ChangeState();
            camera.GetComponentInChildren<MoveCamera>().controllingTurret = false;

            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    public void ChangeState()
    {
        state = TurretState.controlledTurret;
    }

    public void Shake()
    {
        float newPosX = Random.Range(transform.position.x - shakeOffset, transform.position.x + shakeOffset);
        float newPosZ = Random.Range(transform.position.z - shakeOffset, transform.position.z + shakeOffset);
        
        transform.position = new Vector3(newPosX, transform.position.y,  newPosZ);
    }
}