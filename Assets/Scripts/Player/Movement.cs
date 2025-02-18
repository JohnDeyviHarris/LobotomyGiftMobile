using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float Speed;
    private float velocityX;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3 (velocityX * Speed, 0, 0);
        transform.Rotate(0, velocityX * Speed, 0);
    }
    public void Right()
    {
        velocityX = 1;
    }
    public void Left()
    {
        velocityX = -1;
    }
    public void Nothing()
    {
        velocityX = 0;
    }
}
