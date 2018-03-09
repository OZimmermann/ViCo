using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteinePosition : MonoBehaviour
{
    private int CountAirTapSteine = 0;
    private int AirTapEvenOdd;
    
    private PyramideScript pyramideClass;

    void Start()
    {
        pyramideClass = GameObject.Find("Pyramide4").GetComponent<PyramideScript>();
    }

    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
        // On each Select gesture, count up
        CountAirTapSteine++;
        AirTapEvenOdd = CountAirTapSteine / 8; // OnSelect triggers too often
        //Debug.Log("CountAirTapSteine: " + CountAirTapSteine);

        // If the user is in placing mode, display the spatial mapping mesh.
        if (AirTapEvenOdd % 2 != 0) // even number
        {
            SpatialMapping.Instance.DrawVisualMeshes = true;
        }
        // If the user is not in placing mode, hide the spatial mapping mesh.
        else
        {
            SpatialMapping.Instance.DrawVisualMeshes = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Do a raycast into the world that will only hit the Spatial Mapping mesh.
        var headPosition = Camera.main.transform.position;
        var gazeDirection = Camera.main.transform.forward;

        RaycastHit hitInfo;

        if (AirTapEvenOdd == 0)
        {
            //Do nothing
        }
        else if (Physics.Raycast(headPosition, gazeDirection, out hitInfo,
        30.0f, pyramideClass.pyramideLayerMask) && AirTapEvenOdd % 2 != 0)
        {
            // Move this object to where the raycast hit the Spatial Mapping mesh.
            this.transform.position = hitInfo.point;

            // Rotate this object to face the user.
            Quaternion toQuat = Camera.main.transform.localRotation;
            toQuat.x = 0;
            toQuat.z = 0;
            this.transform.rotation = toQuat;
        }
    }
}