using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {
    public float currentSpeed = 10.0f;
    private Rigidbody body;
	// Use this for initialization
	void Start () {
        body = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        body.AddTorque(Input.GetAxis("Vertical") * transform.right);
        body.AddTorque(Input.GetAxis("Horizontal") * transform.forward * -1f);
        if (Input.GetKey(KeyCode.Space)) { transform.Translate(Vector3.forward * Time.deltaTime * currentSpeed); }
        

    }
}
