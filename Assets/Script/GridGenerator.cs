using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    [SerializeField] private GameObject gridPrefab, floorObject;
    [SerializeField] private Material[] materials;
    [SerializeField] private float maxXPos, minXPos, maxZPos, minZPos, yPos, spawnedGrids;

    public bool isBuilding, skipGenerating;

    public KeyCode hideGridKeyCode;

    private float xPos, zPos;
    private int randomNumber;
    private GameObject spawnedGrid, canvas;
    private bool generate, isEven;

    // Start is called before the first frame update
    void Start()
    {
        randomNumber = UnityEngine.Random.Range(0, 2);

        generate = true;
        isEven = true;

        if (randomNumber == 0){
            xPos = maxXPos;
            zPos = maxZPos;
        }
        else if (randomNumber == 1){
            xPos = minXPos;
            zPos = minZPos; 
        }
        

        spawnedGrids = 0;

        canvas = GameObject.FindGameObjectWithTag("Canvas");

        if (skipGenerating)
        {
            InvokeRepeating(nameof(generateGrid), 0f, 0.001f);
        }
        else
        {
            InvokeRepeating(nameof(generateGrid), 0f, 0.015f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(hideGridKeyCode) && isBuilding){
            hideGrid();
        }
    }

    private void generateGrid(){
        if (generate){
            if (randomNumber == 0){
                //SET VALUES
                if (xPos == minXPos){
                zPos -= 1;
                xPos = maxXPos;
                }

                //SPAWN GRID BLOCK AND SET ITS VALUES
                spawnedGrid = Instantiate(gridPrefab, new Vector3(xPos, yPos + 0.5f, zPos), quaternion.identity, gameObject.transform);
                spawnedGrid.name = "X:" + xPos + " Z:" + zPos;
                spawnedGrid.GetComponent<BuildPointScript>().number = (int)spawnedGrids;
                canvas.GetComponent<CanvasScript>().buildPoints[(int)spawnedGrids] = spawnedGrid;
                spawnedGrids += 1;
                xPos -= 1;

                //ADD MATERIAL BASED ON THE LAST GRID
                if (isEven){
                    spawnedGrid.GetComponent<MeshRenderer>().material = materials[1];
                    isEven = false;
                }
                else{
                    spawnedGrid.GetComponent<MeshRenderer>().material = materials[0];
                    isEven = true;
                }

                //STOP GENERATING GRID
                if (zPos == minZPos){
                    generate = false;
                    Destroy(spawnedGrid);
                    floorObject.SetActive(true);

                    hideGrid();
                }
            }
            else if (randomNumber == 1){
                if (xPos == maxXPos){
                zPos += 1;
                xPos = minXPos;
                }

                spawnedGrid = Instantiate(gridPrefab, new Vector3(xPos, yPos + 0.5f, zPos), quaternion.identity, gameObject.transform);
                spawnedGrid.name = "X:" + xPos + " Z:" + zPos;
                spawnedGrid.GetComponent<BuildPointScript>().number = (int)spawnedGrids;
                canvas.GetComponent<CanvasScript>().buildPoints[(int)spawnedGrids] = spawnedGrid;
                spawnedGrids += 1;

                if (isEven){
                    spawnedGrid.GetComponent<MeshRenderer>().material = materials[1];
                    isEven = false;
                }
                else{
                    spawnedGrid.GetComponent<MeshRenderer>().material = materials[0];
                    isEven = true;
                    }

                xPos += 1;

                if (zPos == maxZPos){
                    generate = false;
                    Destroy(spawnedGrid);
                    floorObject.SetActive(true);

                    hideGrid();
                }
            }

            

            if (!generate){
                CancelInvoke(nameof(generateGrid));
            }
        }
        
    }

    public void showGrid(){
        foreach(GameObject gridBlock in canvas.GetComponent<CanvasScript>().buildPoints){
            if (gridBlock != null){
                gridBlock.SetActive(true);
            }
        }

        floorObject.SetActive(false);
    }

    public void hideGrid(){
        foreach(GameObject gridBlock in canvas.GetComponent<CanvasScript>().buildPoints){
            if (gridBlock != null){
                gridBlock.SetActive(false);
            }
        }

        floorObject.SetActive(true);
    }
}
