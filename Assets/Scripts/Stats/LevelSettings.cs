using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngineInternal;

public class LevelSettings : MonoBehaviour
{
    [SerializeField] private int PointsNeed;
    [SerializeField] private Color BGColor;
    [SerializeField] private Color GColor;
    [Space]
    [Header("Objects")]
    [SerializeField] private Material BG;
    [SerializeField] private Material G;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject WinGameOBJ;
    [SerializeField] private GameObject LoseGameOBJ;
    [SerializeField] private List<FacesSpawn> FaceSpawners;
    [SerializeField] private GameObject WinSFX;
    [SerializeField] private GameObject LoseSFX;
    [SerializeField] private TextMeshProUGUI PointsNeedTxt;
    private void Start()
    {
        BG.color = BGColor;
        G.color = GColor;
        PointsNeedTxt.text = ("Points need:" + PointsNeed.ToString());
    }
    private void Win()
    {
        Player.SetActive(false);
        WinGameOBJ.SetActive(true);
        WinSFX.SetActive(true);
        foreach (var face in FaceSpawners)
        {
            face.enabled = false;
        }
    }
    private void Lose()
    {
        Player?.SetActive(false);
        LoseGameOBJ?.SetActive(true);
        LoseSFX?.SetActive(true);
        foreach(var face in FaceSpawners)
        {
            face.enabled = false;
        }
    }
    public void CheckWin(int Score)
    {
        if (Score == PointsNeed || Score > PointsNeed)
        {
            Win();
        }
        else if (Score < 1)
        {
            Lose();
        }
    }
}
