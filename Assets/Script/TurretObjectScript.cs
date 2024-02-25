using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretObjectScript : MonoBehaviour
{
    [Header("Upgrade Stats")]
    public string upgradeName;
    public int upgradePrice;

    public float damage, reloadTime, viewRadiusScale, slowMultiplier;
    public bool hiddenDetection;

    [Header("UI")]
    public GameObject canvas;
    public GameObject upgradeMenu;

    [Header("Usseles Things")]
    public int turretObjectNumber;
    private int clickNumber;

    // Start is called before the first frame update
    void Start()
    {
        //SET IMPORTANT VALUES
        clickNumber = 0;

        //FIND OBJECTS
        canvas = GameObject.FindGameObjectWithTag("Canvas");
        upgradeMenu = canvas.GetComponent<CanvasScript>().upgradeMenu;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseOver()
    {
        //SHOW OR HIDE UPGRADE MENU
        if (Input.GetMouseButtonUp(0) && clickNumber == 0)
        {
            //SHOW UPGRADE MENU AND HIDE BUILD MENU
            upgradeMenu.SetActive(true);
            gameObject.GetComponent<Outline>().enabled = true;

            //SET VALUES
            canvas.GetComponent<CanvasScript>().buildPointNumber = turretObjectNumber;
            GetComponentInParent<TurretScript>().isSelected = true;

            foreach (GameObject turret in canvas.GetComponent<CanvasScript>().turrets){
                if (turret != null && turret != gameObject.transform.parent){
                    turret.GetComponent<TurretScript>().isSelected = false;
                    turret.GetComponentInChildren<Outline>().enabled = false;
                    GetComponentInParent<TurretScript>().isSelected = true;
                }
            }

            clickNumber = 1;
        }
        else if (Input.GetMouseButtonUp(0) && clickNumber == 1)
        {
            //HIDE UPGRADE MENU
            upgradeMenu.SetActive(false);
            gameObject.GetComponent<Outline>().enabled = false;

            //SET VALUES
            clickNumber = 0;
            GetComponentInParent<TurretScript>().isSelected = false;
        }
    }
}