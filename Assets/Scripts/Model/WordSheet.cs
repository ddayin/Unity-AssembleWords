using Cathei.BakingSheet;
using UnityEngine;

namespace AssembleWordsApp
{
    public class WordSheet : Sheet<WordSheet.Row>
    {
        public class Row : SheetRow
        {
            public string id { get; private set; }
            public string category { get; private set; }
            public string word { get; private set; }
            public string description { get; private set; }
        }
    }
}