using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitcher : MonoBehaviour
{
    public GameObject PPG;

    private void OnEnable()
    {
        PPG.SetActive(true);
    }

    public void JapanLoad()
    {
        SceneManager.LoadScene("Japan");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
