using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] public TMP_Text timeText;
    public float timeStart;

    private void Start()
    {
        timeText.text = timeStart.ToString("F2");
    }

    private void Update()
    {
        timeStart += Time.deltaTime;
        timeText.text = timeStart.ToString("F2");
    }

}
