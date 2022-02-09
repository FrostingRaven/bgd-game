using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsUI : MonoBehaviour
{
    public static bool SettingsActive = false;
    public GameObject[] uiElements;
    public GameObject settingsUI;

    public void OpenSettings()
    {
        if(!settingsUI.activeInHierarchy)
        {
            settingsUI.SetActive(true);
        }
        for(int i = 0; i < uiElements.Length; i++)
        {
            uiElements[i].SetActive(false);
        }
    }

    void Update()
    {
        if(settingsUI.activeInHierarchy)
        {
            OpenSettings();
        }
    }

    public void CloseSettings()
    {
        settingsUI.SetActive(false);
        for (int i = 0; i < uiElements.Length; i++)
        {
            uiElements[i].SetActive(true);
        }

        if(Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
        }
    }
}
