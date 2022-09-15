using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    public GameObject stick;
    Vector3 hand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hand = gameObject.transform.position;
        if(Input.GetKeyDown(KeyCode.E))
        {
            hand.x += 4;
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            hand.x -= 4;
        }
        gameObject.transform.position = hand;
    }
}
