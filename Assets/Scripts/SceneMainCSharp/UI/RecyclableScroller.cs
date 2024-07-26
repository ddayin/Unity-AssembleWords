using System;
using System.Collections.Generic;
using PolyAndCode.UI;
using TMPro;
using UnityEngine;

namespace AssembleWords
{
    public class RecyclableScroller : MonoBehaviour, IRecyclableScrollRectDataSource
    {
        [SerializeField] private RecyclableScrollRect m_ScrollRect;
        [SerializeField] private int m_DataLength;
        
        // public CSharp m_CSharp;
        
        private void Awake()
        {
            TestInitData();
            m_ScrollRect.DataSource = this;
        }

        private void TestInitData()
        {
            // m_DataLength = m_CSharp.dataArray.Length;
        }

        public int GetItemCount()
        {
            // return m_CSharp.dataArray.Length;
            return 0;
        }
        
        public void SetCell(ICell _cell, int _index)
        {
            // WordCell cell = _cell as WordCell;
            // cell.ConfigureCell(m_CSharp.dataArray[_index], _index);
        }
    }    
}