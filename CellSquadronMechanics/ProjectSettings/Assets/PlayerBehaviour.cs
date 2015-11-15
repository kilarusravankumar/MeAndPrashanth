﻿using UnityEngine;
using System.Collections;
using CnControls;

public class PlayerBehaviour : MonoBehaviour {
    public float currentSpeed = 10.0f;
    private Rigidbody body;
    private Vector3 movement;
    public float sentivity = 20.0f;
	// Use this for initialization
	void Start () {
        body = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //body.AddTorque(CnInputManager.GetAxis("Vertical") * transform.right);
        //body.AddTorque(CnInputManager.GetAxis("Horizontal") * transform.forward * -1f);
         transform.Translate(Vector3.forward * Time.deltaTime * currentSpeed);
        movement = new Vector3(CnInputManager.GetAxis("Horizontal")*sentivity*-1.0f, CnInputManager.GetAxis("Vertical")*sentivity, 0.0f);
        body.velocity = movement;

    }
   

}
