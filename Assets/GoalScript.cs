using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider colision)
    {
        if(colision.gameObject.tag == "Ball")
        {
            text.SetActive(true);
        }
    }
    void Update()
    {
        
    }
}
