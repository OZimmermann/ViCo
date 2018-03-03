﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyramideScript : MonoBehaviour {
    
    public int pyramideLayerMask;

    public void Awake()
    {
        pyramideLayerMask = 1 << 10; // Layer 10 = Regal (Pyramide)
    }
}
