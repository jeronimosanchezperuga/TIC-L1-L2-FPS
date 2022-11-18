using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonScene : MonoBehaviour
{
    public GameObject agent;
    public void SalComputer(){
        SceneManager.LoadScene("Tic");
        agent.SetActive(false);
    }


}
