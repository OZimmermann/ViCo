using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyramideScript : MonoBehaviour {

    //private MeshCollider pyramideCollider;
    
    private int pyramideLayer = 31;
    public int pyramideLayerMask;

    public void Awake()
    {
        //pyramideCollider = gameObject.GetComponent<MeshCollider>();
        gameObject.layer = pyramideLayerMask;
        pyramideLayerMask = 1 << pyramideLayer;
        Debug.Log("pyramideLayerMask: " + pyramideLayerMask);
    }
}
