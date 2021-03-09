using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public void SetFPS(float fps)
    {
        Application.targetFrameRate = (int)fps;
    }
}
