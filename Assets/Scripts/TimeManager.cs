using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text txtTime;
    public Text txtGoles;
    public Text txtAtajados;
    public GameObject gameOver;
    public GameObject imgMadrid;
    public GameObject imgBombonera;
    public GameObject ballPoint;
    public GameObject arquero;
    public float customTime;
    public bool isCounting;
    public float timeToDoSomething;
    float timeToWait = 1;

    int goles = BallController._goles;
    // Start is called before the first frame update
    void Start()
    {
        customTime = 0;
        timeToDoSomething = timeToWait;
    }

    // Update is called once per frame
    void Update()
    {
        float elapsedTime = Time.timeSinceLevelLoad;
        //txtTime.text = elapsedTime.ToString();
        //txtTimeFloored.text = Mathf.Floor(elapsedTime).ToString();

        // txtTimeCustom.text = customTime.ToString();
      
            if (Time.timeSinceLevelLoad  > timeToDoSomething)
            {

                timeToDoSomething += timeToWait;
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                customTime = 0;
            }

            if (isCounting)
            {
                customTime += Time.deltaTime;
            }


            if (timeToDoSomething == 30)
            {
                //Time.timeScale = 0;
                //Debug.Log("Ganaste!");
                gameOver.SetActive(true);
                imgBombonera.SetActive(false);
                imgMadrid.SetActive(true);
                arquero.SetActive(false);
                ballPoint.SetActive(false);
                txtAtajados.text = (" Tiros Atajados: " + BallController._atajados + " ");
                txtGoles.text = (" Tiros Totales: " + BallController._tiros + "");
            }
    }
    
}