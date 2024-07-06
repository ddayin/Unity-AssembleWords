using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace AssembleWords
{
    [System.Serializable]
    public class Word
    {
        public char[] letters;
    }
 
    [System.Serializable]
    public class Sentence
    {
        public string SentenceAnswer;
        public List<Word> listWords = new List<Word>();
        
        public Sentence(string sentenceAnswer)
        {
            if (string.IsNullOrEmpty(sentenceAnswer) == true)
            {
                this.SentenceAnswer = "Don't kill the goose that lays the golden eggs.";    
            }
            else
            {
                this.SentenceAnswer = sentenceAnswer;
            }
            
            string[] words = this.SentenceAnswer.Split(' ');
            this.listWords = new List<Word>();
            foreach (string word in words)
            {
                Word newWord = new Word();
                newWord.letters = word.ToCharArray();
                this.listWords.Add(newWord);
            }
        }
    }
    public class GameModel : MonoBehaviour
    {
        public string completeSentence;

        public Sentence m_Sentences;

        private void Awake()
        {
            
        }

        public void Init()
        {
            m_Sentences = new Sentence(completeSentence);
        }

        public void CleanUp()
        {
            
        }
    }    
}