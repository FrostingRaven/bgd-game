using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadingPage : MonoBehaviour
{
    public GameObject PPG;

    private void OnEnable()
    {
        PPG.SetActive(false);
    }
}
