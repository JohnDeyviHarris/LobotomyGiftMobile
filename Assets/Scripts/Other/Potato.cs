using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potato : MonoBehaviour
{
    [SerializeField] private float X;
    [SerializeField] private float Y;
    [SerializeField] private float Z;
    private void FixedUpdate()
    {
        transform.Rotate(X, Y, Z);
    }
}
