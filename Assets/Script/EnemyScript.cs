using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [Header("Basic Stats")]
    public float health;
    public float defense;
    public int earnAmmount;
    public float speed;
    private float slowedSpeed;

    public bool isEnhanced, isInvisible, isSpawerType, canMove;
    private float enhancedNumber;
    public float[] enhanced;

    public int arrayPosition;

    [Header("Gameobjects and Components")]
    public GameObject turret;
    private GameObject enemySpawnerObject, canvas, endBuilding;

    public GameObject[] Zombies;

    //TIMERS
    private float timer1 = 5.3f, timer2 = 5.4f, timer3 = 5.7f;

    [Header("Animations")]
    public Animator animator;
    public bool playAnimtaion;
    public float animSpeed;
    private float origAnimSpeed, origSpeed;

    public TypeState state;

    public enum TypeState{
        normal,
        spawner
    }


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        canvas = GameObject.FindGameObjectWithTag("Canvas");
        endBuilding = GameObject.FindGameObjectWithTag("Finish");
        enemySpawnerObject = GameObject.FindGameObjectWithTag("EnemySpawner");

        if (isEnhanced){
            AddEnchants();
        }

        origAnimSpeed = animSpeed;
        origSpeed = speed;
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 0 && canMove)
        {
            Move();
        }

        if (playAnimtaion){
            animator.SetFloat("speedMultiplier", animSpeed);

            if (health <= 0 )
            {
                if (turret != null)
                {
                    turret.GetComponent<TurretScript>().enemyKilled += 1;
                }

                DestroyObject();
            }
        }

        if (state == TypeState.spawner)
        {
            timer1 -= Time.deltaTime;
            timer2 -= Time.deltaTime;
            timer3 -= Time.deltaTime;

            if (timer1 <= 0.0f)
            {
                Debug.Log("-");
                Spawn1Zombies();
                timer1 = 5.3f;
            }

            if (timer2 <= 0.0f)
            {
                Debug.Log("--");
                Spawn2Zombies();
                timer2 = 5.4f;
            }

            if (timer3 <= 0.0f)
            {
                Debug.Log("---");
                Spawn3Zombies();
                timer3 = 5.7f;
            }
        }
    }

    private void Move()
    {
        if (turret != null && turret.GetComponent<TurretScript>().freezeTower == true)
        {
            slowedSpeed = speed / turret.GetComponent<TurretScript>().slowMultiplier;
            transform.position = new Vector3(transform.position.x - slowedSpeed, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Finish" && health > 0)
        {
            other.gameObject.GetComponent<EndScript>().health -= health;

            //GameObject Analytics = GameObject.FindGameObjectWithTag("Analytics");
            //Analytics.GetComponent<UGS_Analytics>().callEndHit(gameObject.name, other.gameObject.GetComponent<EndScript>().health);

            Destroy(gameObject);
        }
        else if (health < 0)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        turret = null;

        if (other.gameObject.tag == "Turret")
        {
            foreach(GameObject enemy in other.gameObject.GetComponent<TurretScript>().enemies)
            {
                if (enemy == null)
                {
                    arrayPosition += 1;
                }
                else if (enemy == gameObject)
                {
                    if (arrayPosition > other.gameObject.GetComponent<TurretScript>().enemies.Length)
                    {
                        return;
                    }

                    other.gameObject.GetComponent<TurretScript>().enemies[arrayPosition] = null;
                    other.gameObject.GetComponent<TurretScript>().maxArrayPosition = arrayPosition;
                    other.gameObject.GetComponent<TurretScript>().seesEnemy = false;

                    if (other.gameObject.GetComponent<TurretScript>().activeEnemy == gameObject)
                    {
                        other.gameObject.GetComponent<TurretScript>().activeEnemy = null;
                    }

                    arrayPosition = 0;

                    return;
                }
                else
                {
                    arrayPosition += 1;
                }
            }
        }
    }

    private void DestroyObject()
    {
        int earnMoneyAmmount = Random.Range(earnAmmount - 5, earnAmmount + 5);
        earnMoneyAmmount = earnMoneyAmmount + enemySpawnerObject.GetComponent<EnemySpawner>().currentWave;

        canvas.GetComponent<CanvasScript>().money += earnMoneyAmmount;

        Destroy(gameObject);
    }

    private void Spawn1Zombies(){
        int type1 = Random.Range(2, 8);

        Instantiate(Zombies[0], this.gameObject.transform.position, Quaternion.Euler(0, 0, 0));
    }

    private void Spawn2Zombies() {
        int type2 = Random.Range(6, 12);

        Instantiate(Zombies[1], this.gameObject.transform.position, Quaternion.Euler(0, 0, 0));
    }

    private void Spawn3Zombies() {
        int type3 = Random.Range(7, 15);

        Instantiate(Zombies[2], this.gameObject.transform.position, Quaternion.Euler(0, 0, 0));
    }

    private void AddEnchants(){
        enhancedNumber = Random.Range(0, 5);

        if (enhancedNumber == 1){
            enhanced[0] = health + Random.Range(5, 51);

            health = enhanced[0];
        }
        else if (enhancedNumber == 2){
            enhanced[0] = health + Random.Range(5, 51);
            enhanced[1] = defense + Random.Range(1, 10);

            health = enhanced[0];
            defense = enhanced[1];
        }
        else if (enhancedNumber == 3){
            enhanced[0] = health + Random.Range(5, 51);
            enhanced[1] = defense + Random.Range(1, 10);
            enhanced[2] = earnAmmount + Random.Range(5, 40);

            health = enhanced[0];
            defense = enhanced[1];
            earnAmmount = (int)enhanced[2];
        }
        else if (enhancedNumber == 4){
            enhanced[0] = health + Random.Range(5, 51);
            enhanced[1] = defense + Random.Range(1, 10);
            enhanced[2] = earnAmmount + Random.Range(5, 40);
            enhanced[3] = speed + Random.Range(0.001f, 0.004f);

            health = enhanced[0];
            defense = enhanced[1];
            earnAmmount = (int)enhanced[2];
            speed = enhanced[3];
        }
    }

    public void CheckSpeed()
    {
        if (endBuilding.GetComponent<EndScript>().state == EndScript.timeState.stopTime)
        {
            speed = 0;
            animSpeed = 0;
        }
        else if (endBuilding.GetComponent<EndScript>().state == EndScript.timeState.normalSpeed)
        {
            speed = origSpeed;
            animSpeed = origAnimSpeed;
        }
        else if (endBuilding.GetComponent<EndScript>().state == EndScript.timeState.doubleSpeed)
        {
            speed = origSpeed * 2;
            animSpeed = origAnimSpeed * 2;
        }
        else if (endBuilding.GetComponent<EndScript>().state == EndScript.timeState.tripleSpeed)
        {
            speed = origSpeed * 3;
            animSpeed = origAnimSpeed * 3;
        }
        else if (endBuilding.GetComponent<EndScript>().state == EndScript.timeState.fifthSpeed)
        {
            speed = origSpeed * 5;
            animSpeed = origAnimSpeed * 5;
        }
    }
}