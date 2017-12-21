using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour {

    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.freezeRotation = true;
        MoveRight();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void MoveRight()
    {
        rb2d.AddForce(new Vector2(75,-75));
    }

}
