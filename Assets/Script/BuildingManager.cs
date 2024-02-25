using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{

    [Header("Demo")]
    public GameObject turretGhost;
    public bool isBuilding;
    public GameObject[] turretGhostObject;
    public GameObject[] turretObjects;
    public int buildPrefabNum;

    [Header("UI")]
    public GameObject canvas;
    public GameObject errorMessage;

    [Header("Test")]
    public Vector3 screenPos;
    public Vector3 worldPos;

    // Start is called before the first frame update
    void Start()
    {
        //FIND GAMEOBJECTS
        canvas = GameObject.FindGameObjectWithTag("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        if (isBuilding)
        {
            GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
            if (!camera.GetComponent<MoveCamera>().isPaused)
            {
                screenPos = Input.mousePosition;

                Ray ray = Camera.main.ScreenPointToRay(screenPos);
                if (Physics.Raycast(ray, out RaycastHit hitData))
                {
                    worldPos = hitData.point;
                }

                turretGhost.transform.position = worldPos;
            }

            if (Input.GetMouseButtonDown(0))
            {
                int price = turretObjects[buildPrefabNum - 1].GetComponent<TurretScript>().buildprice;
                Debug.Log(price);

                if (canvas.GetComponent<CanvasScript>().money >= price)
                {
                    GameObject spawnedTurret = Instantiate(turretObjects[buildPrefabNum - 1], new Vector3(turretGhost.transform.position.x, 0, turretGhost.transform.position.z), Quaternion.identity);
                    spawnedTurret.name = turretObjects[buildPrefabNum - 1].name;
                    Destroy(turretGhost);

                    isBuilding = false;

                    int arrayPos = 0;
                    foreach (GameObject go in canvas.GetComponent<CanvasScript>().turrets)
                    {
                        if (go == null)
                        {
                            canvas.GetComponent<CanvasScript>().turrets[arrayPos] = spawnedTurret;
                            break;
                        }
                        else
                        {
                            arrayPos++;
                        }
                    }

                    canvas.GetComponent<CanvasScript>().money -= price;
                }
                else
                {
                    Instantiate(errorMessage, canvas.transform);
                }
            }
        }
    }

    public void DemoBuild()
    {
        turretGhost = Instantiate(turretGhostObject[buildPrefabNum - 1]);

        isBuilding = true;
    }

    public void SetOne()
    {
        buildPrefabNum = 1;
        DemoBuild();
    }

    public void SetTwo()
    {
        buildPrefabNum = 2;
        DemoBuild();
    }

    public void SetThree()
    {
        buildPrefabNum = 3;
        DemoBuild();
    }

    public void SetFour()
    {
        buildPrefabNum = 4;
        DemoBuild();
    }

    public void SetFive()
    {
        buildPrefabNum = 5;
        DemoBuild();
    }
}
