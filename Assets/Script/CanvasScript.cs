using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{
    [Header("BuildPoints")]
    public int buildObject;
    public int buildPointNumber;
    public GameObject[] buildPoints;
    public GameObject gridGenerator, floorObject;

    [Header("Player Stats")]
    public int money;
    public bool testMode;

    [Header("Keys")]
    public string turret1Key;
    public string turret2Key;
    public string turret3Key;
    public string turret4Key;
    public string turret5Key;

    [Header("Turrets")]
    public GameObject[] turrets;

    [Header("Menus")]
    public GameObject brokeMenu;

    [Header("Buttons")]
    public GameObject upgradeButton;
    public GameObject sellButton;

    [Header("Basic Stats Menu")]
    public GameObject moneyTextObject, waveTextObject, timeLeftTextObject, healthBarObject;

    public GameObject winMenu;

    [Header("FPS")]
    public GameObject fpsTextObject;
    public GameObject fpsBackground;

    [Header("Upgrade Menu")]
    public GameObject upgradeMenu;

    public GameObject currentDamageObject;
    public GameObject currentReloadTimeObject;
    public GameObject currentUpgradeObject;
    public GameObject currentUpgradeTextObject;

    public GameObject nextDamageObject;
    public GameObject nextReloadTimeObject;

    [Header("Text")]
    public string damageText;
    public string reloadTimeText;
    public string currentUpgradeText;
    public string maxUpgradeText;

    public string waveText;
    public string timeLeftText;
    public string moneyIcon;

    //FPS
    private float timer, fpsCount;

    //PRIVATE 
    private GameObject enemySpawner, finishObject, dontDestroyOnLoad;

    // Start is called before the first frame update
    void Start()
    {
        upgradeMenu.SetActive(false);
        floorObject.SetActive(false);

        enemySpawner = GameObject.FindGameObjectWithTag("EnemySpawner");
        finishObject = GameObject.FindGameObjectWithTag("Finish");
        dontDestroyOnLoad = GameObject.FindGameObjectWithTag("DontDestroyOnLoad");

        healthBarObject.GetComponent<Slider>().maxValue = finishObject.GetComponent<EndScript>().health;

        money = dontDestroyOnLoad.GetComponentInChildren<DontDestroyOnLoadScript>().startingMoney;

        turret1Key = GameObject.FindGameObjectWithTag("DontDestroyOnLoad").GetComponent<SettingScript>().turret1Key;
        turret2Key = GameObject.FindGameObjectWithTag("DontDestroyOnLoad").GetComponent<SettingScript>().turret2Key;
        turret3Key = GameObject.FindGameObjectWithTag("DontDestroyOnLoad").GetComponent<SettingScript>().turret3Key;
        turret4Key = GameObject.FindGameObjectWithTag("DontDestroyOnLoad").GetComponent<SettingScript>().turret4Key;
        turret5Key = GameObject.FindGameObjectWithTag("DontDestroyOnLoad").GetComponent<SettingScript>().turret5Key;

        if (!GameObject.FindGameObjectWithTag("DontDestroyOnLoad").GetComponent<SettingScript>().showFps)
        {
            fpsTextObject.SetActive(false);
        }

        if (!GameObject.FindGameObjectWithTag("DontDestroyOnLoad").GetComponent<SettingScript>().showFpsBackground)
        {
            fpsBackground.SetActive(false);
        }

        if (testMode)
        {
            money = 50000;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (upgradeMenu.activeSelf == true)
        {
            UpdateUpgradeMenu();
        }

        UpdateBasicInfo();

        if (Input.GetKeyDown(turret1Key))
        {
            GameObject turretManager = GameObject.Find("BuildingManager");
            turretManager.GetComponent<BuildingManager>().SetOne();
        }
        else if (Input.GetKeyDown(turret2Key))
        {
            GameObject turretManager = GameObject.Find("BuildingManager");
            turretManager.GetComponent<BuildingManager>().SetTwo();
        }
        else if (Input.GetKeyDown(turret3Key))
        {
            GameObject turretManager = GameObject.Find("BuildingManager");
            turretManager.GetComponent<BuildingManager>().SetThree();
        }
        else if (Input.GetKeyDown(turret4Key))
        {
            GameObject turretManager = GameObject.Find("BuildingManager");
            turretManager.GetComponent<BuildingManager>().SetFour();
        }
        else if (Input.GetKeyDown(turret5Key))
        {
            GameObject turretManager = GameObject.Find("BuildingManager");
            turretManager.GetComponent<BuildingManager>().SetFive();
        }

        if (GameObject.FindGameObjectWithTag("DontDestroyOnLoad").GetComponent<SettingScript>().showFps)
        {
            UpdateFramerate();
        }
    }

    private void UpdateFramerate()
    {
        timer -= Time.deltaTime;

        fpsCount += 1;

        if (timer <= 0f)
        {
            fpsTextObject.GetComponent<TextMeshProUGUI>().text = fpsCount.ToString();
            fpsCount = 0;
            timer = 1;
        }
    }

    public void UpdateBasicInfo()
    {
        moneyTextObject.GetComponent<TextMeshProUGUI>().text = money.ToString() + moneyIcon;
        waveTextObject.GetComponent<TextMeshProUGUI>().text = waveText + enemySpawner.GetComponent<EnemySpawner>().currentWave;
        timeLeftTextObject.GetComponent<TextMeshProUGUI>().text = timeLeftText + (int)enemySpawner.GetComponent<EnemySpawner>().minutes + ":" + (int)enemySpawner.GetComponent<EnemySpawner>().seconds;
        healthBarObject.GetComponent<Slider>().value = finishObject.GetComponent<EndScript>().health;
        healthBarObject.GetComponentInChildren<TextMeshProUGUI>().text = finishObject.GetComponent<EndScript>().health + "/" + healthBarObject.GetComponent<Slider>().maxValue;
    }

    public void UpdateUpgradeMenu()
    {
        //CURRENT INFO
        currentUpgradeObject.GetComponent<TextMeshProUGUI>().text = turrets[buildPointNumber].name;
        currentDamageObject.GetComponent<TextMeshProUGUI>().text = damageText + turrets[buildPointNumber].GetComponent<TurretScript>().damage;
        currentReloadTimeObject.GetComponent<TextMeshProUGUI>().text = reloadTimeText + turrets[buildPointNumber].GetComponent<TurretScript>().reloadTime;
        currentUpgradeTextObject.GetComponent<TextMeshProUGUI>().text = currentUpgradeText + turrets[buildPointNumber].GetComponent<TurretScript>().currentUpgrade;

        if (turrets[buildPointNumber].GetComponent<TurretScript>().currentUpgrade != turrets[buildPointNumber].GetComponent<TurretScript>().upgrades.Length - 1)
        {
            upgradeButton.GetComponentInChildren<TextMeshProUGUI>().text = "UPGRADE: " + turrets[buildPointNumber].GetComponent<TurretScript>().objectUpgradePrice + " $";
            upgradeButton.GetComponentInChildren<TextMeshProUGUI>().fontSize = 37.4f;
        }
        else
        {
            upgradeButton.GetComponentInChildren<TextMeshProUGUI>().text = "UPGRADE: " + maxUpgradeText;
            upgradeButton.GetComponentInChildren<TextMeshProUGUI>().fontSize = 29.52f;
        }

        int valueSellPrice;
        valueSellPrice = turrets[buildPointNumber].GetComponent<TurretScript>().objectSellValue;
        valueSellPrice = valueSellPrice / 2;
        sellButton.GetComponentInChildren<TextMeshProUGUI>().text = "SELL: " + valueSellPrice + " $";

        if (turrets[buildPointNumber].GetComponent<TurretScript>().currentUpgrade >= turrets[buildPointNumber].GetComponent<TurretScript>().upgrades.Length - 1)
        {
            nextDamageObject.GetComponent<TextMeshProUGUI>().text = maxUpgradeText;
            nextReloadTimeObject.GetComponent<TextMeshProUGUI>().text = maxUpgradeText;

            return;
        }
        else
        {
            //UPGRADED INFO
            nextDamageObject.GetComponent<TextMeshProUGUI>().text = "Next " + damageText + turrets[buildPointNumber].GetComponent<TurretScript>().upgrades[turrets[buildPointNumber].GetComponent<TurretScript>().currentUpgrade + 1].GetComponent<TurretObjectScript>().damage;
            nextReloadTimeObject.GetComponent<TextMeshProUGUI>().text = "Next " + reloadTimeText + turrets[buildPointNumber].GetComponent<TurretScript>().upgrades[turrets[buildPointNumber].GetComponent<TurretScript>().currentUpgrade + 1].GetComponent<TurretObjectScript>().reloadTime;
        }
    }

    public void StartBuild()
    {
        int price = buildPoints[buildPointNumber].GetComponent<BuildPointScript>().buildObjectsPrefab[buildObject - 1].GetComponent<TurretScript>().buildprice;

        if (money > price || money == price)
        {
            buildPoints[buildPointNumber].GetComponent<BuildPointScript>().BuildObject();
            gridGenerator.GetComponent<GridGenerator>().hideGrid();

            foreach (GameObject buildPoint in buildPoints)
            {
                if (buildPoint != null)
                {
                    buildPoint.GetComponent<BuildPointScript>().isBuilding = false;
                }
            }

            gridGenerator.GetComponent<GridGenerator>().isBuilding = false;
            buildObject = 0;

            money -= price;
        }
        else if (money < price)
        {
            Instantiate(brokeMenu, gameObject.transform);
        }
    }

    public void StartUpgrade()
    {
        int upgradePrice = turrets[buildPointNumber].GetComponent<TurretScript>().objectUpgradePrice;

        if (money >= upgradePrice)
        {
            if (turrets[buildPointNumber].GetComponent<TurretScript>().currentUpgrade < turrets[buildPointNumber].GetComponent<TurretScript>().upgrades.Length - 1)
            {
                turrets[buildPointNumber].GetComponent<TurretScript>().UpgradeTurret();

                money -= upgradePrice;
            }
        }
        else if (money <= upgradePrice)
        {
            ErrorMessage("You don't have enough money");
        }
    }

    public void StartSell()
    {
        int valueSellPrice;
        valueSellPrice = turrets[buildPointNumber].GetComponent<TurretScript>().objectSellValue;
        valueSellPrice = valueSellPrice / 2;

        Destroy(turrets[buildPointNumber]);

        money += valueSellPrice;
        upgradeMenu.SetActive(false);
    }

    public void StartControllingTurret()
    {
        if (turrets[buildPointNumber].GetComponent<TurretScript>().freezeTower)
        {
            ErrorMessage("You can't controll this turret/tower");
        }
        else
        {
            turrets[buildPointNumber].GetComponent<TurretScript>().ChangeState();
        }
    }

    public void SetOne()
    {
        buildObject = 1;
        gridGenerator.GetComponent<GridGenerator>().showGrid();
        floorObject.SetActive(false);

        gridGenerator.GetComponent<GridGenerator>().isBuilding = true;

        foreach (GameObject buildPoint in buildPoints)
        {
            if (buildPoint != null)
            {
                buildPoint.GetComponent<BuildPointScript>().isBuilding = true;
            }
            else
            {
                return;
            }
        }
    }

    public void SetTwo()
    {
        buildObject = 2;
        gridGenerator.GetComponent<GridGenerator>().showGrid();
        floorObject.SetActive(false);

        gridGenerator.GetComponent<GridGenerator>().isBuilding = true;

        foreach (GameObject buildPoint in buildPoints)
        {
            if (buildPoint != null)
            {
                buildPoint.GetComponent<BuildPointScript>().isBuilding = true;
            }
            else
            {
                return;
            }
        }
    }

    public void SetThree()
    {
        buildObject = 3;
        gridGenerator.GetComponent<GridGenerator>().showGrid();
        floorObject.SetActive(false);

        gridGenerator.GetComponent<GridGenerator>().isBuilding = true;

        foreach (GameObject buildPoint in buildPoints)
        {
            if (buildPoint != null)
            {
                buildPoint.GetComponent<BuildPointScript>().isBuilding = true;
            }
            else
            {
                return;
            }
        }
    }

    public void SetFour()
    {
        buildObject = 4;
        gridGenerator.GetComponent<GridGenerator>().showGrid();
        floorObject.SetActive(false);

        gridGenerator.GetComponent<GridGenerator>().isBuilding = true;

        foreach (GameObject buildPoint in buildPoints)
        {
            if (buildPoint != null)
            {
                buildPoint.GetComponent<BuildPointScript>().isBuilding = true;
            }
            else
            {
                return;
            }
        }
    }

    public void SetFive()
    {
        buildObject = 5;
        gridGenerator.GetComponent<GridGenerator>().showGrid();
        floorObject.SetActive(false);

        gridGenerator.GetComponent<GridGenerator>().isBuilding = true;

        foreach (GameObject buildPoint in buildPoints)
        {
            if (buildPoint != null)
            {
                buildPoint.GetComponent<BuildPointScript>().isBuilding = true;
            }
            else
            {
                return;
            }
        }
    }

    public void Win()
    {
        upgradeButton.SetActive(false);
        winMenu.SetActive(true);
    }

    public void ErrorMessage(string errorMessage)
    {
        GameObject spawnedMessage = Instantiate(brokeMenu, gameObject.transform);
        spawnedMessage.GetComponentInChildren<TextMeshProUGUI>().text = errorMessage;
    }
}