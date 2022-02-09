using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiedScript : MonoBehaviour
{
    public GameObject[] uiElements;
    public GameObject deadScreen;
    public void OnEnable()
    {
        for (int i = 0; i < uiElements.Length; i++)
        {
            uiElements[i].SetActive(false);
        }
        Time.timeScale = 0f;
        StartCoroutine(isDead());
    }

    IEnumerator isDead()
    {
        yield return new WaitForSecondsRealtime(3f);
        for (int i = 0; i < uiElements.Length; i++)
        {
            uiElements[i].SetActive(true);
        }
        Time.timeScale = 1f;
        deadScreen.SetActive(false);
    }
}
