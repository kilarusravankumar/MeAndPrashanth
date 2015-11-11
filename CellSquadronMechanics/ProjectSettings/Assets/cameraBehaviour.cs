using UnityEngine;
using System.Collections;

public class cameraBehaviour : MonoBehaviour {

    public Ray ray;
    public Vector2 mousePos;

    private Transform target;
    private GameObject player;
    private Vector3 wantedPosition;

    public float distance = 50.0f;
    public float height = 3.0f;
    public float damping = 5.0f;
    public float rotationDamping = 0.5f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        target = player.transform;
    }

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(mousePos);
    }

    void LateUpdate()
    {
        SmoothFollow();
    }

    void SmoothFollow()
    {
        //Follow player smoothly
        wantedPosition = target.TransformPoint(0, height, -distance);
        transform.position = Vector3.Lerp(transform.position, wantedPosition, Time.deltaTime * damping);

        Quaternion wantedRotation = Quaternion.LookRotation(target.position - transform.position, target.up);

        transform.rotation = Quaternion.Slerp(transform.rotation, wantedRotation, Time.deltaTime * rotationDamping);

        transform.LookAt(target, target.up);




    }
   

}
