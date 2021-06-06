﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterUI : MonoBehaviour
{
    public GameObject JieShao;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            JieShao.SetActive(true);
        }  
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            JieShao.SetActive(false);
        }
    }
}
