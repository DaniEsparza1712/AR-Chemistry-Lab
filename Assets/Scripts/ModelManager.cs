using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelManager : MonoBehaviour {

	public GameObject[] Models;
    void Start()
    {
            //Disable All models at start
            DisableAll();
    }

    void DisableAll()
    {
        foreach (var item in Models)
        {
            item.SetActive(false);
        }
    }

    void SetModel(int index)
    {
        //Disable All other models before setting
        DisableAll();
        Models[index].SetActive(true);
    }

}