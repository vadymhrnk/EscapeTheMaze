using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : NetworkBehaviour
{
    [SerializeField] private GameObject WinnerUI = null;

    private string[] password;
    private int index;


    void Start()
    {
        password = new string[] { "i", "s", "o", "l", "a","t","e","d" };
        index = 0;
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(password[index]))
            {
                index++;
            }
            else
            {
                index = 0;
            }
        }

        if (index == password.Length)
        {
            WinnerUI.SetActive(true);
        }
    }
}
