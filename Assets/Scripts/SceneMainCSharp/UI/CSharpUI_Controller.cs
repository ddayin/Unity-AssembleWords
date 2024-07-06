using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace AssembleWords
{
    public class CSharpUI_Controller : MonoBehaviour
    {
        public Button m_ButtonBack;

        private void Awake()
        {
            m_ButtonBack.onClick.AddListener(OnClickBackButton);
        }
        
        private void OnClickBackButton()
        {
            Debug.Log("Back");
            SceneManager.LoadScene(SceneName.Title.ToString());
        }
    }
}