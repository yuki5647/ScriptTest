﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Test : MonoBehaviour {

   

    

    // Use this for initialization
    void Start() {

        int[] array = { 10, 20, 30, 40, 50 };

        for (int a = 0; a < array.Length; a++) {

            Debug.Log(array[a]);

        }

        

        for (int a = 4; a >=0 ; a--)
        {

            Debug.Log(array[a]);
        }
       

        }
        

        











    // Update is called once per frame
    void Update () {
		
	}
 }
