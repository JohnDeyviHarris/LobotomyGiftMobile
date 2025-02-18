using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject PauseObj;
    public void OnPause()
    {
        PauseObj.SetActive(true);
        Time.timeScale = 0;
    }
    public void OffPause()
    {
        PauseObj.SetActive(false);
        Time.timeScale = 1;
    }
}
