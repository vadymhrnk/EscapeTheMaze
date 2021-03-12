using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapCameraMount : NetworkBehaviour
{
        public GameObject MinimapCameraMountPoint;

    // Start is called before the first frame update
    void Start()
    {
        if (hasAuthority)
        {
            Transform cameraTransform = GameObject.Find("MinimapCamera").GetComponent<Camera>().transform;
            cameraTransform.SetParent(MinimapCameraMountPoint.transform);
            cameraTransform.position = MinimapCameraMountPoint.transform.position;
            cameraTransform.rotation = MinimapCameraMountPoint.transform.rotation;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
