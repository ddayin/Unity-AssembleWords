using System;
using UnityEngine;

namespace AssembleWordsApp
{
    public class Application : MonoBehaviour
    {
        private void Awake()
        {
            Screen.SetResolution(1920, 1080, false);
            UnityEngine.Application.targetFrameRate = 60;
        }
    }
}