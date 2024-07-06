using System;
using PolyAndCode.UI;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

namespace AssembleWords
{
    public class GeneralWordCell : MonoBehaviour, ICell
    {
        public TextMeshProUGUI m_IdText;
        public TextMeshProUGUI m_WordText;
        private Button m_Button;

        private int m_CellIndex;
        
        private void Awake()
        {
            m_Button = GetComponent<Button>();
            m_Button.onClick.AddListener(() => OnClickCell());
        }
        
        // public void ConfigureCell(GeneralEnglishData _model, int _index)
        // {
        //     m_CellIndex = _index;
        //     m_WordModel = _model;
        //
        //     m_IdText.text = _model.Id;
        //     m_WordText.text = _model.Word;
        // }
        
        private void OnClickCell()
        {
            // Debug.Log(m_WordModel.Word);
            // AllTypeOfDictionary.instance.m_CurrentType = TypeOfDictionary.General;
            // AllTypeOfDictionary.instance.SetCurrentId(m_WordModel.Id);
            // AllTypeOfDictionary.instance.SetPreviousScene(SceneName.MainGeneral);
            // SceneManager.LoadScene(SceneName.Description.ToString());
        }
    }    
}