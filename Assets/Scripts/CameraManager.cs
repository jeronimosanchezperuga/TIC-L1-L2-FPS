using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject camIntro;
    public GameObject camPlayer;

    // Start is called before the first frame update
    void Start()
    {
        camPlayer.SetActive(false);
        camIntro.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CameraActivation()
    {
        camPlayer.SetActive(true);
        camIntro.SetActive(false);
    }

}
