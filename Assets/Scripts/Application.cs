using System;
using UnityEngine;

namespace AssembleWordsApp
{
    public class Application : MonoBehaviour
    {
        private void Awake()
        {
            Screen.SetResolution(1080, 1920, true);
            UnityEngine.Application.targetFrameRate = 30;
        }
    }
}