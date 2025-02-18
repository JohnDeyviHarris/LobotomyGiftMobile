using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public void TurnMusic()
    {
        if (GlobalStats.MusicOn)
        {
            gameObject.GetComponent<Image>().color = Color.red;
            GlobalStats.MusicOn = false;
            print(GlobalStats.MusicOn);
            GameObject.FindAnyObjectByType<AudioSource>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<Image>().color = Color.green;
            GlobalStats.MusicOn = true;
            print(GlobalStats.MusicOn);
            GameObject.FindAnyObjectByType<AudioSource>().enabled = true;
        }
    }
    public void ToggleButtons()
    {
        if (GlobalStats.HideButtons)
        {
            gameObject.GetComponent<Image>().color = Color.red;
            GlobalStats.HideButtons = false;
            print(GlobalStats.HideButtons);
        }
        else
        {
            gameObject.GetComponent<Image>().color = Color.green;
            GlobalStats.HideButtons = true;
            print(GlobalStats.HideButtons);
        }
    }
}
