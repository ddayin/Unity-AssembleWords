using System;
using UnityEngine;

namespace AssembleWords
{
    public class ApplicationMain : MonoBehaviour
    {
        private void Awake()
        {
            //Screen.SetResolution(1920, 1080, false);
            UnityEngine.Application.targetFrameRate = 60;
        }
    }
}