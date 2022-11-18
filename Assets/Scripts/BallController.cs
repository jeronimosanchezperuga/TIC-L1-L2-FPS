using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    public Text txtAtajados;
    public Text txtGoles;
    float camara;
    

    Vector3 ballPosition;

    public GameObject ballPoint;
    public GameObject ball;
    public GameObject gameOver;
    float customTime;
  

    public float ballSpeed;
    float ballPositionz;
    float ballPositiony;
    Rigidbody rbBall;
    Transform position;
    Transform rotation;
    GameObject clon;
    GameObject clonPoint;
    public GameObject arquero;
    public static GameObject _arquero;
    public static int _tiros=0;
    public static int _atajados = 0;
    public static int _goles= 0;


    // Start is called before the first frame update
    void Start()
    {
        



    }

    // Update is called once per frame
    void Update()
    {
        //Posicion es la posicion donde va la pelota luego del random.range. Es la posicion Final. 
        //ballPosition es el Vector3 que tiene la posicion donde incicia y donde termina (No esta bien hecho hasta ahora)

        //Destroy(ballPoint, 3);


        //for(int i = 0; i>1; i++)
        //{
        //  Debug.Log("Bokita papa");
        //}

       

        /*if (Time.time > timeToDoSomething)
        {
           
            //ball.transform.position = new Vector3(4, ballPositiony, ballPositionz) - transform.position;
            ballPosition = new Vector3(4, ballPositiony, ballPositionz) - transform.position;
            ballPoint.transform.position = new Vector3(3, ballPositiony, ballPositionz);
            timeToDoSomething += timeToWait;
        }
        //transform.position += ball.transform.position * Time.deltaTime * ballSpeed;
        transform.position += ballPosition * Time.deltaTime * ballSpeed;
        */

        

        //if(Time.time > 5)
        if (Input.GetMouseButtonDown(0))
        {
            ballPositionz = Random.Range(1.5f, -1.5f);
            ballPositiony = Random.Range(1.5f, 0.3f);
            ballPoint.transform.position = new Vector3(2, ballPositiony, ballPositionz);
            Vector3 tempV3 = new Vector3(3.429749f, ballPositiony, ballPositionz);
            Vector3 direction = tempV3 - transform.position;
            clon = Instantiate(ball, transform.position, transform.rotation);
            rbBall = clon.GetComponent<Rigidbody>();
            if (rbBall) {
                rbBall.AddForce(direction* ballSpeed, ForceMode.Impulse);
            }
            Destroy(clon, 5);
            _tiros++;
          
        }
        
    }



    //private void OnTriggerEnter(Collider col)
    //{
     //   Destroy(clon);
   // }




}


    
