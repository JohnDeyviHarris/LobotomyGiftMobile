using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacesSpawn : MonoBehaviour
{
    [SerializeField] private GameObject FaceObject;
    [SerializeField] private Collider Radius;
    [SerializeField] private float SpawnChance;
    private float timer;
    private float cooldown = 1;
    private void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;
        if (timer > cooldown )
        {
            cooldown = Random.Range(SpawnChance -0.5f, SpawnChance + 0.5f);
            timer = 0;
            GameObject EasyFaceCLone = Instantiate(FaceObject, new Vector3(Random.Range(transform.position.x - Radius.bounds.size.x/2, transform.position.x + Radius.bounds.size.x / 2), transform.position.y, transform.position.z), transform.rotation);
        }
    }
}
