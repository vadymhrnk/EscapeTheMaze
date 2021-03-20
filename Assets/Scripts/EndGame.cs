using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : NetworkBehaviour
{
    [SerializeField] private GameObject WinnerUI = null;

    private string[] password;
    private int index = 0;

    [Server]
    private void PasswordEnter(int index)
    {
        password = new string[] { "i", "s", "o", "l", "a", "t", "e", "d" };
        index = this.index;
    }

    [ClientRpc]
    private void Winner()
    {
        WinnerUI.SetActive(true);
    }

    public override void OnStartServer() => PasswordEnter(index);

    void Start()
    {

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
            Winner();
        }
    }
}
