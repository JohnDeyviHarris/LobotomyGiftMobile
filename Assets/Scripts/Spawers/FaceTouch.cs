using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceTouch : MonoBehaviour
{
    [SerializeField] private int Points;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
        else if(collision.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("StatsEasy").GetComponent<EasyFacesStatsLevel>().Add(Points);
            Destroy(gameObject);
        }
    }
}
