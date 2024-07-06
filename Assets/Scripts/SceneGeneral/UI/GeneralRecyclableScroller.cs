using System;
using System.Collections.Generic;
using PolyAndCode.UI;
using Unity.VisualScripting;
using UnityEngine;

namespace AssembleWords
{
    public class GeneralRecyclableScroller : MonoBehaviour, IRecyclableScrollRectDataSource
    {
        [SerializeField] private RecyclableScrollRect m_ScrollRect;
        [SerializeField] private int m_DataLength;
        
        
        private void Awake()
        {
            m_ScrollRect.DataSource = this;
        }

        public int GetItemCount()
        {
            return 0;
        }
        
        public void SetCell(ICell _cell, int _index)
        {
            // GeneralWordCell cell = _cell as GeneralWordCell;
            // cell.ConfigureCell(m_GeneralEnglish.dataArray[_index], _index);
        }
    }    
}