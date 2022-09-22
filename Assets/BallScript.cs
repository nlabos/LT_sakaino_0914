using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Score Score1;
    public Score Score2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Goal1"))
        {
            Score1.score++;

        }
        else if(other.CompareTag("Goal2"))
        {
            Score2.score++;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Goal1"))
        {
            //Destroy(gameObject);

        }
        else if (other.CompareTag("Goal2"))
        {
            //Destroy(gameObject);

        }
    }

    void Update()
    {
        
    }
}
