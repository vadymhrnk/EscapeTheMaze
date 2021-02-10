using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGates : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != -50f)
        {
            transform.position += transform.forward * Time.deltaTime;

        }
    }
}
