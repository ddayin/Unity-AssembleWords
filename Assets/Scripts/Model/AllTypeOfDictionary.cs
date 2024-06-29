using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;
using WanzyeeStudio;

namespace AssembleWordsApp
{
    public enum TypeOfDictionary
    {
        General = 0,
        CPlusPlus,
        CSharp,
        Unity,
        Unreal,
        Network
    }
    
    public class AllTypeOfDictionary : BaseSingleton<AllTypeOfDictionary>
    {
        public TypeOfDictionary m_CurrentType = TypeOfDictionary.General;
        
        public string m_CurrentId;

        private SceneName m_PreviousScene = SceneName.Title;
        
        protected override void Awake()
        {
            base.Awake();
            
            Init(TypeOfDictionary.General);
            Init(TypeOfDictionary.CSharp);
        }

        private void Init(TypeOfDictionary _type)
        {
            m_CurrentType = _type;

            switch (m_CurrentType)
            {
                case TypeOfDictionary.General:
                    SetGeneralType();
                    break;
                case TypeOfDictionary.CPlusPlus:
                    break;
                case TypeOfDictionary.CSharp:
                    SetCSharpType();
                    break;
                case TypeOfDictionary.Unity:
                    break;
                case TypeOfDictionary.Unreal:
                    break;
                case TypeOfDictionary.Network:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void SetGeneralType()
        {
            
        }
        
        private void SetCSharpType()
        {
            
        }
        
        public string GetDescription()
        {
            switch (m_CurrentType)
            {
                case TypeOfDictionary.General:
                    return "";
                case TypeOfDictionary.CSharp:
                    return "";
                case TypeOfDictionary.CPlusPlus:
                    return "";
                case TypeOfDictionary.Unity:
                    return "";
                case TypeOfDictionary.Unreal:
                    return "";
                case TypeOfDictionary.Network:
                    return "";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        
        public string GetWord()
        {
            switch (m_CurrentType)
            {
                case TypeOfDictionary.General:
                    return "";
                case TypeOfDictionary.CSharp:
                    return "";
                case TypeOfDictionary.CPlusPlus:
                    return "";
                case TypeOfDictionary.Unity:
                    return "";
                case TypeOfDictionary.Unreal:
                    return "";
                case TypeOfDictionary.Network:
                    return "";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        
        public void SetCurrentId(string _id)
        {
            m_CurrentId = _id;
        }
        
        public void SetPreviousScene(SceneName _scene)
        {
            m_PreviousScene = _scene;
        }
        
        public SceneName GetPreviousScene()
        {
            return m_PreviousScene;
        }
    }
}