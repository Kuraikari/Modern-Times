using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    //Attributes Player
    public float speed;
    public float boost;

    //Physical Body Player + Stats
    public Player player;
    public Rigidbody2D r2d;
    public Animator anim;
     

    public void Start()
    {

        speed = 5f;
        boost = 7.5f;

        r2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        player = new Player();
    }

    public void Update()
    {
        playerMovement();
    }

    public void OnCollisionEnter2D(Collision2D coll2d)
    {
        
    }

    public void playerMovement()
    {

        float x, y;
        x = Input.GetAxis("Horizontal") * speed * Time.deltaTime * 15;
        y = Input.GetAxis("Vertical") * speed * Time.deltaTime * 15;

        r2d.transform.position += new Vector3(x, y);

        if (Input.GetKeyDown(KeyCode.S))
        { 
            anim.SetBool("Facing Down", true);
            anim.SetBool("Facing Up", false);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        { 
            anim.SetBool("Facing Up", true);
            anim.SetBool("Facing Down", false);
        }

    }
}