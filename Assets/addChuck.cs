﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addChuck : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

        GetComponent<ChuckSubInstance>().RunCode(@"
        SinOsc foo => dac;
        while( true )
        {
            Math.random2f( 300, 1000 ) => foo.freq;
            100::ms => now;
        }
    ");
    }
}
