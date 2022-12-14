using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PostProcessing : MonoBehaviour
{
    public void Start()
    {
        if(PosController.PosOn)
        {
            Camera.main.GetComponent<Volume>().enabled = true;
        }
        else
        {
            Camera.main.GetComponent<Volume>().enabled = false;
        }
    }


}
