using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMount : NetworkBehaviour
{
    public GameObject CameraMountPoint;

    void Start()
    {
        if (isLocalPlayer)
        {
            Transform cameraTransform = Camera.main.gameObject.transform;
            cameraTransform.SetParent(CameraMountPoint.transform);
            cameraTransform.position = CameraMountPoint.transform.position;
            cameraTransform.rotation = CameraMountPoint.transform.rotation;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
