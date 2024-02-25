using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Apple;
using UnityEngine.Timeline;

public class EndScript : MonoBehaviour
{
    [Header("Stats")]
    public float health;

    [Header("UI")]
    [SerializeField]private GameObject LostMenu, WonMenu, pauseMenu; 

    [Header("Enum/State")]
    public timeState state;

    private GameObject camera, enemySpawner, analyticsObject;

    private string lastTimeState, currentTimeState;
    private bool calledLost;

    public enum timeState
    {
        stopTime,
        halfSpeed,
        normalSpeed,
        doubleSpeed,
        tripleSpeed,
        fourthSpeed,
        fifthSpeed
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SetTimeSpeed), 1, 1);
        pauseMenu.SetActive(false);

        state = timeState.normalSpeed;
        lastTimeState = timeState.normalSpeed.ToString();
        Time.timeScale = 1;

        camera = GameObject.FindGameObjectWithTag("MainCamera");
        enemySpawner = GameObject.FindGameObjectWithTag("EnemySpawner");

        calledLost = false;

        analyticsObject = GameObject.FindGameObjectWithTag("Analytics");
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0){
            LostMenu.SetActive(true);
            Time.timeScale = 0;

            if (!calledLost)
            {
                analyticsObject.GetComponent<UGS_Analytics>().CallLostCustomEnvent();

                calledLost = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!camera.GetComponent<MoveCamera>().controllingTurret && camera.GetComponent<MoveCamera>().isPaused == false)
            {
                pauseMenu.SetActive(true);
                state = timeState.stopTime;

                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                camera.GetComponent<MoveCamera>().isPaused = true;

                SetTimeSpeed();
            }
            else
            {
                UnPause();
            }
        }
    }

    private void SetTimeSpeed(){
        if (state == timeState.stopTime){
            Time.timeScale = 0f;
            currentTimeState = timeState.normalSpeed.ToString();

            foreach (GameObject go in enemySpawner.GetComponent<EnemySpawner>().spawnedEnemies)
            {
                if (go == null)
                {

                }
                else if (go != null)
                {
                    go.GetComponent<EnemyScript>().canMove = false;
                }
            }

        }
        else if (state == timeState.halfSpeed)
        {
            Time.timeScale = 0.5f;
            currentTimeState = timeState.normalSpeed.ToString();

            foreach (GameObject go in enemySpawner.GetComponent<EnemySpawner>().spawnedEnemies)
            {
                if (go == null)
                {

                }
                else if (go != null)
                {
                    go.GetComponent<EnemyScript>().canMove = true;

                }
            }
        }
        else if (state == timeState.normalSpeed)
        {
            Time.timeScale = 1;
            currentTimeState = timeState.normalSpeed.ToString();

            foreach (GameObject go in enemySpawner.GetComponent<EnemySpawner>().spawnedEnemies)
            {
                if (go == null)
                {

                }
                else if (go != null)
                {
                    go.GetComponent<EnemyScript>().canMove = true;

                }
            }
        }
        else if (state == timeState.doubleSpeed)
        {
            Time.timeScale = 2;
            currentTimeState = timeState.normalSpeed.ToString();

            foreach (GameObject go in enemySpawner.GetComponent<EnemySpawner>().spawnedEnemies)
            {
                if (go == null)
                {

                }
                else if (go != null)
                {
                    go.GetComponent<EnemyScript>().canMove = true;

                }
            }
        }
        else if (state == timeState.tripleSpeed)
        {
            Time.timeScale = 3;
            currentTimeState = timeState.normalSpeed.ToString();

            foreach (GameObject go in enemySpawner.GetComponent<EnemySpawner>().spawnedEnemies)
            {
                if (go == null)
                {

                }
                else if (go != null)
                {
                    go.GetComponent<EnemyScript>().canMove = true;

                }
            }
        }
        else if (state == timeState.fourthSpeed)
        {
            Time.timeScale = 4;
            currentTimeState = timeState.normalSpeed.ToString();

            foreach (GameObject go in enemySpawner.GetComponent<EnemySpawner>().spawnedEnemies)
            {
                if (go == null)
                {

                }
                else if (go != null)
                {
                    go.GetComponent<EnemyScript>().canMove = true;

                }
            }
        }
        else if (state == timeState.fifthSpeed)
        {
            Time.timeScale = 5;
            currentTimeState = timeState.fifthSpeed.ToString();

            foreach (GameObject go in enemySpawner.GetComponent<EnemySpawner>().spawnedEnemies)
            {
                if (go == null)
                {

                }
                else if (go != null)
                {
                    go.GetComponent<EnemyScript>().canMove = true;

                }
            }
        }

        if (currentTimeState != lastTimeState)
        {
            foreach (GameObject go in enemySpawner.GetComponent<EnemySpawner>().spawnedEnemies)
            {
                if (go != null)
                {
                    go.GetComponent<EnemyScript>().CheckSpeed();
                }
            }

            lastTimeState = currentTimeState;
        }
    }

    public void UnPause(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        state = timeState.normalSpeed;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        camera.GetComponentInChildren<MoveCamera>().isPaused = false;
        SetTimeSpeed();
    }
}