using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SettingScript : MonoBehaviour
{
    public bool showFps;
    public bool showFpsBackground;

    public string turret1Key;
    public string turret2Key;
    public string turret3Key;
    public string turret4Key;
    public string turret5Key;
    public string sprintKey;
    public string changeCameraKey;
    public string jumpKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadKeys()
    {
        turret1Key = GameObject.Find("Turret1Key").GetComponentInChildren<TMP_InputField>().text;
        turret2Key = GameObject.Find("Turret2Key").GetComponentInChildren<TMP_InputField>().text;
        turret3Key = GameObject.Find("Turret3Key").GetComponentInChildren<TMP_InputField>().text;
        turret4Key = GameObject.Find("Turret4Key").GetComponentInChildren<TMP_InputField>().text;
        turret5Key = GameObject.Find("Turret5Key").GetComponentInChildren<TMP_InputField>().text;

        changeCameraKey = GameObject.Find("ChangeCameraKey").GetComponentInChildren<TMP_InputField>().text;
        jumpKey = GameObject.Find("JumpKey").GetComponentInChildren<TMP_InputField>().text;
        sprintKey = GameObject.Find("SprintKey").GetComponentInChildren<TMP_InputField>().text;
    }

    public void ShowFps()
    {
        if (showFps)
        {
            showFps = false;
        }
        else
        {
            showFps = true;
        }
    }

    public void ShowFpsBackgound()
    {
         if (showFpsBackground)
         {
            showFpsBackground = false;
         }
         else
         {
            showFpsBackground = true;
         }
    }
}
