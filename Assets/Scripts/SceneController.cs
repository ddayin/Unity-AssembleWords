using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using WanzyeeStudio;

namespace AssembleWords
{
    public enum SceneName
    {
        Title = 0,
        MainGeneral,
        MainCSharp,
        Description,
        PuzzleGame,
        Setting
    }
    
    public class SceneController : BaseSingleton<SceneController>
    {
        public SceneName m_CurrentSceneName = SceneName.Title;
        
        protected override void Awake()
        {
            base.Awake();
        }
        
        public void LoadScene(SceneName _sceneName)
        {
            m_CurrentSceneName = _sceneName;
            
            string number = ((int)_sceneName).ToString(); 
            string sceneName = number + _sceneName.ToString();
            
            
            SceneManager.LoadScene(sceneName);
        }
    }
}