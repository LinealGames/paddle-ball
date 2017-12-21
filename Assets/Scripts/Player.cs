using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    protected Rigidbody2D rb2d;
    protected string axis;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        SetControls();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();
    }

    protected void MovePlayer()
    {
        if (Input.GetAxis(axis) > 0)
        {
            rb2d.velocity = new Vector2(0,1);
        }
        else if (Input.GetAxis(axis) < 0)
        {
            rb2d.velocity = new Vector2(0,-1);
        }
        else
        {
            rb2d.velocity = Vector2.zero;
        }
    }

    protected void SetControls()
    {
        if (this.tag == "Player1")
        {
            axis = "P1Controls";
        }
        else if (this.tag == "Player2")
        {
            axis = "P2Controls";
        }
        //If neither player 1 or 2, then it's a computer and is not controlled in this way
    }

    //FIX THIS PLEASE
    /*
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            rb2d.velocity = Vector2.zero;
        }
    }
    */
}
