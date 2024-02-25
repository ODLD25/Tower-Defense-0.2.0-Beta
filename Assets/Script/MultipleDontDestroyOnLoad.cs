using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleDontDestroyOnLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CheckForMultipleDontDestroyOnLoad();
        CheckForMultipleAnalytics();
    }

    public void CheckForMultipleDontDestroyOnLoad()
    {
        GameObject[] dontDestroyOnLoadArray;

        dontDestroyOnLoadArray = GameObject.FindGameObjectsWithTag("DontDestroyOnLoad");

        int arrayPos = 0;
        if (dontDestroyOnLoadArray.Length > 1)
        {
            dontDestroyOnLoadArray[1].GetComponent<DontDestroyOnLoadScript>().number++;
            dontDestroyOnLoadArray[1].GetComponent<DontDestroyOnLoadScript>().splitCode = dontDestroyOnLoadArray[0].GetComponent<DontDestroyOnLoadScript>().splitCode;

            foreach (GameObject go in dontDestroyOnLoadArray)
            {
                if (arrayPos == 0)
                {
                    Destroy(go);
                }

                arrayPos++;
            }
        }
    }

    public void CheckForMultipleAnalytics()
    {
        GameObject[] AnalyticsArray;

        AnalyticsArray = GameObject.FindGameObjectsWithTag("Analytics");

        int arrayPos = 0;
        if (AnalyticsArray.Length > 0)
        {
            foreach (GameObject go in AnalyticsArray)
            {
                if (arrayPos >= 1)
                {
                    Destroy(go);
                }

                arrayPos++;
            }
        }
    }
}
