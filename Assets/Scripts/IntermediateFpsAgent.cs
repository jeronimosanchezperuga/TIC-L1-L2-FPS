using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntermediateFpsAgent : MonoBehaviour
{
    public Transform FPS;

    public Transform baseguardia;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            //FindObjectOfType<AgentScript>().agent.destination = FPS.position;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<AgentScript>().agent.destination = baseguardia.position;
        }
    }
}
