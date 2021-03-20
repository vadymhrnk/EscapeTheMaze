using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] public GameObject pauseMenuUI;
    [SerializeField] public GameObject settingsMenuUI;

    public static bool IsPaused = false;


    public void Resume()
    {
        GameObject mouseLookScript = GameObject.Find("CameraMountPoint");
        mouseLookScript.GetComponent<MouseLook>().enabled = true;
        pauseMenuUI.SetActive(false);
        IsPaused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    public void Pause()
    {
        GameObject mouseLookScript = GameObject.Find("CameraMountPoint");
        mouseLookScript.GetComponent<MouseLook>().enabled = false;
        pauseMenuUI.SetActive(true);
        IsPaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                Resume();

            }
            else
            {
                Pause();
            }
        }
    }
}
