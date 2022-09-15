using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickContoroller : MonoBehaviour
{
    public Transform player;
    public float speed;
    bool TF;
    public Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider colision)
    {
        if(colision.gameObject.tag == "hand")
        {
            TF = true;
        }
    }
    void OnTriggerExit(Collider colision)
    {
        if(colision.gameObject.tag == "hand")
        {
            TF = false;
        }
    }
    void Update()
    {
        if (TF)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rigidbody.MovePosition(rigidbody.position + new Vector3(0,0,speed));
            }
            if (Input.GetKey(KeyCode.S))
            {
                rigidbody.MovePosition(rigidbody.position + new Vector3(0, 0, -speed));
            }
            if (Input.GetKey(KeyCode.J))
            {
                rigidbody.MoveRotation(rigidbody.rotation * Quaternion.Euler(new Vector3(0, 10f, 0)));
            }
            if (Input.GetKey(KeyCode.L))
            {
                rigidbody.MoveRotation(rigidbody.rotation * Quaternion.Euler(new Vector3(0, -10f, 0)));
            }
        }
    }
}
