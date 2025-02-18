using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EasyFacesStatsLevel : MonoBehaviour
{
    private int Count;
    [SerializeField] private TextMeshProUGUI text;
    public void Add(int howmany)
    {
        Count += howmany;
        text.text = Count.ToString();
        GameObject.FindGameObjectWithTag("Finish").GetComponent<LevelSettings>().CheckWin(Count);
    }
    public void DisAdd(int howmany)
    {
        Count -= howmany;
        text.text = Count.ToString();
    }
}
