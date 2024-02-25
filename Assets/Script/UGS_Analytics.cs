using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Analytics;
using Unity.Services.Core;
using Unity.Services.Core.Analytics;

public class UGS_Analytics : MonoBehaviour
{
    private GameObject currentwWave;  
    
    async void Start()
    {
        DontDestroyOnLoad(this);

        try
        {
            await UnityServices.InitializeAsync();
            GiveConsent(); // Get user consent according to various legislations
        }
        catch (ConsentCheckException e)
        {
            Debug.Log(e.ToString());
        }
    }

    public void WaveCompletedCustomEvent()
    {
        currentwWave = GameObject.FindGameObjectWithTag("EnemySpawner");

        float currentLevel = currentwWave.GetComponent<EnemySpawner>().currentWave;
        Debug.Log(currentLevel);

        // Define Custom Parameters
        Dictionary<string, object> parameters = new Dictionary<string, object>()
        {
            { "waveNumber", "wave " + currentLevel.ToString()}
        };
        Debug.Log("-2");

        // The ‘levelCompleted’ event will get cached locally
        //and sent during the next scheduled upload, within 1 minute
        AnalyticsService.Instance.CustomData("waveCompleted", parameters);

        // You can call Events.Flush() to send the event immediately
        AnalyticsService.Instance.Flush();
        Debug.Log("--2");
    }

    public void LostCustomEvent()
    {
        currentwWave = GameObject.FindGameObjectWithTag("EnemySpawner");

        float currentLevel = currentwWave.GetComponent<EnemySpawner>().currentWave;
        Debug.Log("Current level" + currentLevel);

        // Define Custom Parameters
        Dictionary<string, object> parameters = new Dictionary<string, object>()
        {
            { "LostWaveNumberFixed", "wave " + currentLevel.ToString()}
        };

        // The ‘levelCompleted’ event will get cached locally
        //and sent during the next scheduled upload, within 1 minute
        AnalyticsService.Instance.CustomData("Lost", parameters);

        // You can call Events.Flush() to send the event immediately
        AnalyticsService.Instance.Flush();
    }

    public void HitEndCustomEvent(string zombieName, float endHealth)
    {
        currentwWave = GameObject.FindGameObjectWithTag("EnemySpawner");

        float currentLevel = currentwWave.GetComponent<EnemySpawner>().currentWave;

        Debug.Log(zombieName);
        Debug.Log(endHealth);
        Debug.Log(currentLevel);

        // Define Custom Parameters
        Dictionary<string, object> parameters = new Dictionary<string, object>()
        {
            { "ZombieName", "Zombie Name:" + zombieName},
            { "EndHealth", "End Health:" + endHealth},
            { "waveNumberEndHit", "Wave Enemy Hit " + currentLevel}
        };
        Debug.Log("-1");

        // The ‘levelCompleted’ event will get cached locally
        //and sent during the next scheduled upload, within 1 minute
        AnalyticsService.Instance.CustomData("EnemyHitTheEnd", parameters);

        // You can call Events.Flush() to send the event immediately
        AnalyticsService.Instance.Flush();
        Debug.Log("-");
    }

    public void GiveConsent()
    {
        // Call if consent has been given by the user
        AnalyticsService.Instance.StartDataCollection();
        Debug.Log($"Consent has been provided. The SDK is now collecting data!");
    }

    public void callWaveComplete()
    {
        try
        {
            GiveConsent(); // Get user consent according to various legislations
            WaveCompletedCustomEvent();
        }
        catch (ConsentCheckException e)
        {
            Debug.Log(e.ToString());
        }
    }

    public void callEndHit(string zombieName, float endHealth)
    {
        try
        {
            GiveConsent(); // Get user consent according to various legislations
            HitEndCustomEvent(zombieName, endHealth);
        }
        catch (ConsentCheckException e)
        {
            Debug.Log(e.ToString());
        }
    }

    public void CallLostCustomEnvent()
    {
        try
        {
            GiveConsent(); // Get user consent according to various legislations
            LostCustomEvent();
        }
        catch (ConsentCheckException e)
        {
            Debug.Log(e.ToString());
        }
    }
}