
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class EnterComputer : MonoBehaviour
{   
    
    [SerializeField] GameObject dialogueUI;
    [SerializeField]TextMeshProUGUI textoDelDialogo;
    [SerializeField] bool hasTalked;
    [SerializeField] bool ScreenOn;

    void Start()
    {
        dialogueUI.SetActive(false);
    }

     void Update() {

        if(hasTalked == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("GameScene");
               
                Cursor.visible = true;
                ScreenOn = true;
            }
        }
        if(ScreenOn == true){
           
            if (Input.GetKeyDown(KeyCode.W))
            {

                SceneManager.LoadScene("Tic");
                Debug.Log("GANASTE!");
            }
        }
    
    }
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
      
        //al entrar activa la UI de diálogo
        if (other.gameObject.CompareTag("Computadora"))
        {
            hasTalked = true;
            textoDelDialogo.text = "Usar PC (E)";
            dialogueUI.SetActive(true);
            

            if (!hasTalked)
            {
                textoDelDialogo.text = "Usar PC (E)";
                dialogueUI.SetActive(true);
            }
           

       
        }
        
    }

     void OnTriggerExit(Collider other)
    {
        dialogueUI.SetActive(false);
    }
 }
