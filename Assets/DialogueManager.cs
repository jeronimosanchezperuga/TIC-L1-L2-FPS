using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] GameObject dialogueUI;
    [SerializeField] TextMeshProUGUI textoDelDialogo;
    [SerializeField] string[] frasesDialogo;
    [SerializeField] int posicionFrase;
    [SerializeField] bool hasTalked;
    public GameObject zombie;
    public GameObject PP;
    private DialogueManager scritpA;
    //public GameObject PP;

    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);
        zombie.SetActive(false);
        PP.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && hasTalked == false)
        {
            NextFrase();
        }
        if (hasTalked == true)
        {
            zombie.SetActive(true);

            PP.SetActive(true);
        }
        //if(Input.GetKeyDown(KeyCode.E))
        //{
        //    zombie.SetActive(false);
        //}
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            frasesDialogo = other.gameObject.GetComponent<NPCBehaviour>().Data.dialogueFrases;
            dialogueUI.SetActive(true);

            if (!hasTalked)
            {
                //al entrar activa la UI de dialogo
                textoDelDialogo.text = "Pulsa F para continuar";
            }

            else
            {
                textoDelDialogo.text = "Ya hablamos. ";
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            //al entrar desactiva la UI de dialogo
            dialogueUI.SetActive(false);
        }
    }

    void NextFrase()
    {
        if (posicionFrase < frasesDialogo.Length)
        {
            textoDelDialogo.text = frasesDialogo[posicionFrase];
            posicionFrase++;
        }

        else
        {
            dialogueUI.SetActive(false);
            hasTalked = true;
        }
        
    }
    

}

