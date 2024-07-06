using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


namespace AssembleWords
{
    public class DescriptionUI_Controller : MonoBehaviour
    {
        public Button m_ButtonBack;
        public GameObject m_SceneRoot;
        public TextMeshProUGUI m_TextWord;
        public TextMeshProUGUI m_TextDescription;
        
        private void Awake()
        {
            m_ButtonBack.onClick.AddListener(() => OnClickBackButton());
        }

        private void OnEnable()
        {
            // m_TextWord.text = AllTypeOfDictionary.instance.GetWord();
            // m_TextDescription.text = AllTypeOfDictionary.instance.GetDescription();
        }

        private void OnClickBackButton()
        {
            Debug.Log("Back");

            /*
            SceneName sceneName = AllTypeOfDictionary.instance.GetPreviousScene();
            switch (sceneName)
            {
                case SceneName.MainCSharp:
                    SceneManager.LoadScene(SceneName.MainCSharp.ToString());
                    break;
                case SceneName.MainGeneral:
                    SceneManager.LoadScene(SceneName.MainGeneral.ToString());
                    break;
                default:
                    break;
            }
            */
        }
    }    
}