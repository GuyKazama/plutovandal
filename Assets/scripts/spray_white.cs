﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spray_white : MonoBehaviour
{
    public GameObject spray;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("e"))
        {
            spray.SetActive(true);
        }
        if (Input.GetKeyUp("e"))
        {
            spray.SetActive(false);
        }
    }
}
