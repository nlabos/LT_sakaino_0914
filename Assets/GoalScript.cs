using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public Score score;
    public GameObject text;
    public Vector3 pos;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
       
    }
    void Start()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            collision.gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z);
            collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            if (score.score == 2)
            {
                text.SetActive(true);
            }
            
        }
    }
        
    void Update()
    {
        
    }
}
