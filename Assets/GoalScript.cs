using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public Score Score1;
    public Score Score2;
    public GameObject wintext;
    public GameObject losetext;
    public Vector3 pos;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z);
    }
    void Start()
    {

    }
    
    /*
    // Update is called once per frame
    private void OnTriggerEnter(Collider colision)
    {
        if(colision.gameObject.tag == "Ball")
        {
            if(Score1.Score1 == 3)
            {
                wintext.SetActive(true);
            }
            else if(Score2.Score2 == 3)
            {
                losetext.SetActive(true);
            }
            
        }
    }*/
        
    void Update()
    {
        
    }
}
