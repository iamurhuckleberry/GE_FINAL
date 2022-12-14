using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PosController : MonoBehaviour
{
    public static bool PosOn = true;

    public void PosONOFF()
    {
        PosOn = !PosOn;
    }

}
