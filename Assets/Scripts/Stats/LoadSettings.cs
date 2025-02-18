using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadSettings : MonoBehaviour
{
    [SerializeField] private GameObject Music;
    [SerializeField] private Image RB1;
    [SerializeField] private Image RB2;
    [SerializeField] private Image LB1;
    [SerializeField] private Image LB2;
    private void Start()
    {
        if (!GlobalStats.MusicOn)
        {
            Music.SetActive(false);
        }
        if (GlobalStats.HideButtons)
        {
            RB1.color = new Color(0, 0, 0, 0);
            RB2.color = new Color(0, 0, 0, 0);
            LB1.color = new Color(0, 0, 0, 0);
            LB2.color = new Color(0, 0, 0, 0);
        }
    }
}
