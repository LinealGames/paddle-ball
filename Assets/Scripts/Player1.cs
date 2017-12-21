using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : Player {

	// Use this for initialization
	void Start () {
        base.axis = "P1Vertical";
	}
	
	void FixedUpdate () {
        MovePlayer();
	}
}
