using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace AssembleWords
{
    public class GeneralUI_Controller : MonoBehaviour
    {
        public Button m_ButtonBack;

        private void Awake()
        {
            m_ButtonBack.onClick.AddListener(() => OnClickBackButton());
        }
        
        private void OnClickBackButton()
        {
            Debug.Log("Back");
            SceneManager.LoadScene(SceneName.Title.ToString());
        }
    }    
}