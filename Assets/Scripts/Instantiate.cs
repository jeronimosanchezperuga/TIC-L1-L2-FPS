using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Instantiate : MonoBehaviour
{

    public GameObject objectToClone;
    public int cloneamount;

    public void CloneObject()
    {
        int i = 0;
        while (i < cloneamount)
        {
            Instantiate(objectToClone);
            i++;
        }
        //Destroy(objectToClone, 5);

    }
}
