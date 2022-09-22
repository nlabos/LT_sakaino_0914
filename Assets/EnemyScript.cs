using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform player;
    public float speed;
    bool TF;
    public Rigidbody rigidbody;
    public GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider colision)
    {
        if (colision.gameObject.tag == "Ball")
        {
            TF = true;
        }
    }
    void OnTriggerExit(Collider colision)
    {
        if (colision.gameObject.tag == "Ball")
        {
            TF = false;
        }
    }
    void Update()
    {
        if (TF)
        {
            if (player.position.z - Ball.transform.position.z < 0)
            {
                rigidbody.MovePosition(rigidbody.position + new Vector3(0, 0, speed));
            }
            if (player.position.z - Ball.transform.position.z > 0)
            {
                rigidbody.MovePosition(rigidbody.position + new Vector3(0, 0, -speed));
            }
            if (player.position.z - Ball.transform.position.z > 0)
            {
                rigidbody.MoveRotation(rigidbody.rotation * Quaternion.Euler(new Vector3(0, 10f, 0)));
            }
            if (player.position.z - Ball.transform.position.z < 0)
            {
                rigidbody.MoveRotation(rigidbody.rotation * Quaternion.Euler(new Vector3(0, -10f, 0)));
            }
        }
    }
}
