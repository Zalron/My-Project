﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotates : MonoBehaviour
{

    public Vector3 RotationSpeed = new Vector3(0,90,0);

   
    void Update()  // Update is called once per frame
    {
        this.transform.Rotate(RotationSpeed * Time.deltaTime);
    }
}
