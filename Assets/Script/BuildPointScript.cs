using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildPointScript : MonoBehaviour
{
    [Header("Build on Bools")]
    public bool occupied, isBuilding;

    [Header("Build Objects")]
    public GameObject[] buildObjectsPrefab;
    public GameObject builtTurret;
    public LayerMask groundLayer;

    [Header("UI")]
    public GameObject canvas, upgradeMenu;
    public MoveCamera moveCamera;

    [Header("Random Numbers")]
    public int number, clickNumber;

    private float ySpeed = 0.03f;

    // Start is called before the first frame update
    void Start()
    {
        //SET VALUES
        clickNumber = 0;
        isBuilding = false;

        //FIND GAMEOBJECTS
        canvas = GameObject.FindGameObjectWithTag("Canvas");
        upgradeMenu = canvas.GetComponent<CanvasScript>().upgradeMenu;
        moveCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<MoveCamera>();

        InvokeRepeating(nameof(MoveDown), 0.01f, 0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseOver()
    {
        if (isBuilding){
            //CHECK IF PLAYER CLICKS
            if (Input.GetMouseButtonUp(0) && upgradeMenu.activeSelf == true)
            {
                //HIDE UPGRADE MENU
                upgradeMenu.SetActive(false);
            }

            if (Input.GetMouseButtonUp(0) && !occupied)
            {
                //SET VALUES
                canvas.GetComponent<CanvasScript>().buildPointNumber = number;
                canvas.GetComponent<CanvasScript>().StartBuild();
            }
        }
    }

    public void BuildObject()
    {
        builtTurret = Instantiate(buildObjectsPrefab[canvas.GetComponent<CanvasScript>().buildObject - 1], transform.position, Quaternion.identity);
        builtTurret.name = buildObjectsPrefab[canvas.GetComponent<CanvasScript>().buildObject - 1].name;

        canvas.GetComponent<CanvasScript>().turrets[number] = builtTurret;

        builtTurret.GetComponent<TurretScript>().turretNumber = number;

        occupied = true;
    }

    public void OnCollisionStay(Collision other){
        if (other.gameObject.layer == groundLayer){
            occupied = true;
        }
    }

    public void MoveDown(){
        if (transform.position.y > 0){
            transform.position = new Vector3(transform.position.x, transform.position.y - ySpeed, transform.position.z);

            ySpeed -= 0.0001f;
        }
        else if (transform.position.y <= 0.0f){
            CancelInvoke(nameof(MoveDown));
        }
    }
}