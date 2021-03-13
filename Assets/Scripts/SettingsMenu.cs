using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public void SetFPS(float fps)
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = (int)fps;
    }

    public void SetSensitivity(float sensitivity)
    {
        GameObject.Find("CameraMountPoint").GetComponent<MouseLook>().mouseSensitivity = sensitivity;
    }
}
