using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Enemy")]
    public GameObject[] enemy;
    public GameObject[] spawnedEnemies;
    public GameObject dontDestroyOnLoad;
    public float enemyReduction;
    private int type1Amount, type2Amount, type3Amount, type4Amount, type5Amount, type6Amount, type7Amount, zombieLeft;
    public bool enemyDead;

    [Header("Orbs")]
    public GameObject[] Orb;
    //private bool spawnedOrb; 
    //public int spawnedOrbs;

    [Header("Waves")]
    public int waves, currentWave;
    public float startTime, waveTime, timeBetweenWaves;
    public float waveTimeLeft;
    public float minutes, seconds;

    private int addZombies;

    public int waveBonus;

    //PRIVATE
    private GameObject canvas, analyticsObject;

    [Header("Spawn Location")]
    public Vector3 spawnLocation;

    [Header("Spawn Amount")]
    public int[] type1;
    public int[] type2;
    public int[] type3;
    public int[] type4;
    public int[] type5;
    public int[] type6;
    public int[] type7;

    [Header("Difficulty")]
    public difficultyState state;

    public enum difficultyState
    {
        Easy,
        Medium,
        Hard,
        HardCore
    }

    public waveState state1;

    public enum waveState
    {
        starting,
        betweenWave,
        onGoingWave
    }
    // Start is called before the first frame update
    void Start()
    {
        state1 = waveState.starting;
        waveTimeLeft = startTime;
        addZombies = 1;

        if (GameObject.FindGameObjectWithTag("DontDestroyOnLoad") != null)
        {
            dontDestroyOnLoad = GameObject.FindGameObjectWithTag("DontDestroyOnLoad");
            currentWave = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().startingWave;
        }
        else
        {
            currentWave = 1;

        }

        canvas = GameObject.FindGameObjectWithTag("Canvas");
        analyticsObject = GameObject.FindGameObjectWithTag("Analytics");

        spawnedEnemies = new GameObject[100];
        //spawnedOrb = false;

        if (state == difficultyState.Easy)
        {
            enemyReduction = 2;
        }
        else if (state == difficultyState.Medium)
        {
            enemyReduction = 1;
        }
        else if (state == difficultyState.Hard)
        {
            enemyReduction = 0.5f;
        }
        else if (state == difficultyState.HardCore)
        {
            enemyReduction = 0.2f;
        }


        InvokeRepeating(nameof(SpawnZombie), startTime, 0.5f);
        InvokeRepeating(nameof(checkForZombies), 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        manageWaveState();
        calculateTime();

        /*if (waveTimeLeft <= 0f && state1 == waveState.starting || state1 == waveState.betweenWave){
            manageZombies();
        }*/
    }

    private void manageWaveState()
    {
        if (state1 == waveState.starting)
        {
            waveTimeLeft -= Time.deltaTime;

            if (waveTimeLeft <= 0f)
            {
                state1 = waveState.onGoingWave;
                manageZombies();
                waveTimeLeft = waveTime;
            }
        }
        else if (state1 == waveState.onGoingWave)
        {
            waveTimeLeft -= Time.deltaTime;

            if (waveTimeLeft <= 0f || enemyDead)
            {
                enemyDead = false;
                state1 = waveState.betweenWave;
                waveTimeLeft = timeBetweenWaves;

                canvas.GetComponent<CanvasScript>().money += (waveBonus * currentWave / 2);
                //analyticsObject.GetComponent<UGS_Analytics>().callWaveComplete();
            }
        }
        else if (state1 == waveState.betweenWave)
        {
            waveTimeLeft -= Time.deltaTime;
            enemyDead = false;
            
            if (waveTimeLeft <= 0f)
            {
                currentWave += 1;
                state1 = waveState.onGoingWave;
                manageZombies();
                //spawnedOrb = false;
                waveTimeLeft = waveTime;
            }
        }
    }

    public void calculateTime()
    {
        if (waveTimeLeft > 60)
        {
            waveTimeLeft -= 60;
            minutes += 1;
        }
        else if (waveTimeLeft <= 60)
        {
            seconds = waveTimeLeft;
        }

        if (seconds < 0 && minutes > 0)
        {
            seconds = 60;
            minutes -= 1;
        }
    }

    private void  manageZombies()
    {
        if (currentWave == 1)
        {
            type1[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave1[0];
            type2[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave1[1];
            type3[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave1[2];
            type4[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave1[3];
            type5[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave1[4];
            type6[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave1[5];
        }
        else if (currentWave == 2)
        {
            type1[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave2[0];
            type2[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave2[1];
            type3[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave2[2];
            type4[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave2[3];
            type5[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave2[4];
            type6[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave2[5];
        }
        else if (currentWave == 3)
        {
            type1[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave3[0];
            type2[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave3[1];
            type3[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave3[2];
            type4[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave3[3];
            type5[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave3[4];
            type6[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave3[5];
        }
        else if (currentWave == 4)
        {
            type1[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave4[0];
            type2[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave4[1];
            type3[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave4[2];
            type4[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave4[3];
            type5[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave4[4];
            type6[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave4[5];
        }
        else if (currentWave == 5)
        {
            type1[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave5[0];
            type2[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave5[1];
            type3[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave5[2];
            type4[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave5[3];
            type5[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave5[4];
            type6[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave5[5];
        }
        else if (currentWave == 6)
        {
            type1[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave6[0];
            type2[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave6[1];
            type3[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave6[2];
            type4[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave6[3];
            type5[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave6[4];
            type6[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave6[5];
        }
        else if (currentWave == 7)
        {
            type1[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave7[0];
            type2[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave7[1];
            type3[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave7[2];
            type4[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave7[3];
            type5[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave7[4];
            type6[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave7[5];
        }
        else if (currentWave == 8)
        {
            type1[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave8[0];
            type2[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave8[1];
            type3[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave8[2];
            type4[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave8[3];
            type5[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave8[4];
            type6[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave8[5];
        }
        else if (currentWave == 9)
        {
            type1[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave9[0];
            type2[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave9[1];
            type3[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave9[2];
            type4[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave9[3];
            type5[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave9[4];
            type6[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave9[5];
        }
        else if (currentWave == 10)
        {
            type1[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave10[0];
            type2[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave10[1];
            type3[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave10[2];
            type4[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave10[3];
            type5[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave10[4];
            type6[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave10[5];
        }
        else if (currentWave == 11)
        {
            type1[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave11[0];
            type2[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave11[1];
            type3[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave11[2];
            type4[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave11[3];
            type5[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave11[4];
            type6[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave11[5];
        }
        else if (currentWave == 12)
        {
            type1[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave12[0];
            type2[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave12[1];
            type3[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave12[2];
            type4[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave12[3];
            type5[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave12[4];
            type6[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave12[5];
        }
        else if (currentWave == 13)
        {
            type1[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave13[0];
            type2[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave13[1];
            type3[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave13[2];
            type4[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave13[3];
            type5[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave13[4];
            type6[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave13[5];
        }
        else if (currentWave == 14)
        {
            type1[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave14[0];
            type2[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave14[1];
            type3[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave14[2];
            type4[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave14[3];
            type5[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave14[4];
            type6[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave14[5];
        }
        else if (currentWave == 15)
        {
            type1[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave15[0];
            type2[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave15[1];
            type3[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave15[2];
            type4[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave15[3];
            type5[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave15[4];
            type6[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave15[5];
        }
        else if (currentWave == 16)
        {
            type1[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave16[0];
            type2[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave16[1];
            type3[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave16[2];
            type4[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave16[3];
            type5[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave16[4];
            type6[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave16[5];
        }
        else if (currentWave == 17)
        {
            type1[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave17[0];
            type2[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave17[1];
            type3[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave17[2];
            type4[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave17[3];
            type5[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave17[4];
            type6[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave17[5];
        }
        else if (currentWave == 18)
        {
            type1[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave18[0];
            type2[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave18[1];
            type3[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave18[2];
            type4[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave18[3];
            type5[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave18[4];
            type6[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave18[5];
        }
        else if (currentWave == 19)
        {
            type1[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave19[0];
            type2[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave19[1];
            type3[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave19[2];
            type4[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave19[3];
            type5[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave19[4];
            type6[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave19[5];
        }
        else if (currentWave == 20)
        {
            type1[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave20[0];
            type2[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave20[1];
            type3[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave20[2];
            type4[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave20[3];
            type5[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave20[4];
            type6[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave20[5];
        }
        else if (currentWave >= 21)
        {
            type1[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave20[0] + addZombies;
            type2[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave20[1] + addZombies;
            type3[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave20[2] + addZombies;
            type4[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave20[3] + addZombies;
            type5[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave20[4] + addZombies;
            type6[currentWave] = dontDestroyOnLoad.GetComponent<DontDestroyOnLoadScript>().wave20[5] + addZombies;

            addZombies++;
        }
        /*else if (currentWave > 20 && zombieLeft <= 0)
        {
            canvas.GetComponent<CanvasScript>().Win();
        }*/

        /*else if (currentWave == 30)
        {
            type7[currentWave] = 1;
        }*/

        zombieLeft = type1[currentWave] + type2[currentWave] + type3[currentWave] + type4[currentWave] + type5[currentWave] + type6[currentWave];

        type1Amount = type1[currentWave];
        type2Amount = type2[currentWave];
        type3Amount = type3[currentWave];
        type4Amount = type4[currentWave];
        type5Amount = type5[currentWave];
        type6Amount = type6[currentWave];
    }

    public void SpawnZombie()
    {
        /*if (spawnedOrb == false){
            int SpawnNumber = UnityEngine.Random.Range(0, 500);
            int OrbNumber = UnityEngine.Random.Range(0, Orb.Length - 1);

            Debug.Log(SpawnNumber);

            if (SpawnNumber <= 10 && state1 == waveState.onGoingWave){
                Instantiate(Orb[OrbNumber], spawnLocation, Quaternion.identity);

                spawnedOrb = true;
                spawnedOrbs = spawnedOrbs + 1;
            }
        }*/
        
        if (type1Amount > 0){
            GameObject spawnedZombie = Instantiate(enemy[0], spawnLocation, Quaternion.Euler(0, 180, 0));
            spawnedZombie.GetComponent<EnemyScript>().health /= enemyReduction;
            
            int arrayPosition1 = 0;

            foreach(GameObject enemy in spawnedEnemies){
                if (enemy == null){
                    spawnedEnemies[arrayPosition1] = spawnedZombie;
                }
                else{
                    arrayPosition1 += 1;
                }
            }

            type1Amount -= 1;
        }

        if (type2Amount > 0){
            GameObject spawnedZombie = Instantiate(enemy[1], spawnLocation, Quaternion.Euler(0, 180, 0));
            spawnedZombie.GetComponent<EnemyScript>().health /= enemyReduction;

            int arrayPosition1 = 0;

            foreach(GameObject enemy in spawnedEnemies){
                if (enemy == null){
                    spawnedEnemies[arrayPosition1] = spawnedZombie;
                }
                else{
                    arrayPosition1 += 1;
                }
            }

            type2Amount -= 1;
        }

        if (type3Amount > 0){
            GameObject spawnedZombie = Instantiate(enemy[2], spawnLocation, Quaternion.Euler(0, 180, 0));
            spawnedZombie.GetComponent<EnemyScript>().health /= enemyReduction;

            int arrayPosition1 = 0;

            foreach(GameObject enemy in spawnedEnemies){
                if (enemy == null){
                    spawnedEnemies[arrayPosition1] = spawnedZombie;
                }
                else{
                    arrayPosition1 += 1;
                }
            }

            type3Amount -= 1;
        }

        if (type4Amount > 0){
            GameObject spawnedZombie = Instantiate(enemy[3], spawnLocation, Quaternion.Euler(0, 0, 0));
            spawnedZombie.GetComponent<EnemyScript>().health /= enemyReduction;

            int arrayPosition1 = 0;

            foreach(GameObject enemy in spawnedEnemies){
                if (enemy == null){
                    spawnedEnemies[arrayPosition1] = spawnedZombie;
                }
                else{
                    arrayPosition1 += 1;
                }
            }

            type4Amount -= 1;
        }

        if (type5Amount > 0){
            GameObject spawnedZombie = Instantiate(enemy[4], spawnLocation, Quaternion.Euler(0, 180, 0));
            spawnedZombie.GetComponent<EnemyScript>().health /= enemyReduction;

            int arrayPosition1 = 0;

            foreach(GameObject enemy in spawnedEnemies){
                if (enemy == null){
                    spawnedEnemies[arrayPosition1] = spawnedZombie;
                }
                else{
                    arrayPosition1 += 1;
                }
            }

            type5Amount -= 1;
        }

        if (type6Amount > 0){
            GameObject spawnedZombie = Instantiate(enemy[5], spawnLocation, Quaternion.Euler(0, 180, 0));
            spawnedZombie.GetComponent<EnemyScript>().health /= enemyReduction;

            int arrayPosition1 = 0;

            foreach(GameObject enemy in spawnedEnemies){
                if (enemy == null){
                    spawnedEnemies[arrayPosition1] = spawnedZombie;
                }
                else{
                    arrayPosition1 += 1;
                }
            }

            type6Amount -= 1;
        }

        if (type7Amount > 0)
        {
            GameObject spawnedZombie = Instantiate(enemy[6], spawnLocation, Quaternion.Euler(0, 180, 0));
            spawnedZombie.GetComponent<EnemyScript>().health /= enemyReduction;

            int arrayPosition1 = 0;

            foreach (GameObject enemy in spawnedEnemies)
            {
                if (enemy == null)
                {
                    spawnedEnemies[arrayPosition1] = spawnedZombie;
                }
                else
                {
                    arrayPosition1 += 1;
                }
            }

            type7Amount -= 1;
        }

    }

    public void checkForZombies(){
        if (state1 == waveState.onGoingWave){
            int spawnedEnemiesAmount = 0;
            enemyDead = false;

            foreach(GameObject enemy in spawnedEnemies){
                if (enemy != null){
                    spawnedEnemiesAmount += 1;
                }
            }

            if (spawnedEnemiesAmount == 0){
                enemyDead = true;
            }
            else{
                enemyDead = false;
            }
        }
    }
}