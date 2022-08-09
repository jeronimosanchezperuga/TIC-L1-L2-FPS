using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsIterator : MonoBehaviour
{
    //así se define un array
    GameObject[] mesas;

    // Start is called before the first frame update
    void Start()
    {
        //el método FindGameObjectsWithTag devuelve un array, por eso no es necesario
        //inicializarlo explícitamente
        mesas = GameObject.FindGameObjectsWithTag("mesa");
        Debug.Log(mesas.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            DestroyObjectsInArray(mesas);
        }
    }

    public void DestroyObjectsInArray(GameObject[] array)
    {
        for (int i = 0;i<array.Length;i++)
        {
            Destroy(array[i]);
        }
    }


}
