using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    public Player player;
    public Rigidbody2D r2d;
     

    public void Start()
    {
        r2d = GetComponent<Rigidbody2D>();

    }

    public void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D coll2d)
    {

    }

    public void playerMovement()
    {
        
    }
}