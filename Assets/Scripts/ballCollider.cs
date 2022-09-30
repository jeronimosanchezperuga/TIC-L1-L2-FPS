using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballCollider : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
       // Destroy(gameObject, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        Destroy(gameObject);
        BallController._atajados++;
       
        //BallController._goles = ;
    }
}
