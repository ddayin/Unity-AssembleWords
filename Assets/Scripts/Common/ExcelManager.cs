using System;
using System.IO;
using System.Linq;
using Cathei.BakingSheet;
using Cathei.BakingSheet.Examples.Google;
using Cathei.BakingSheet.Unity;
using UnityEditor;
using UnityEngine;
using WanzyeeStudio;

namespace AssembleWords
{
    public class ExcelManager : BaseSingleton<ExcelManager>
    {
        protected override void Awake()
        {
            base.Awake();

            Init();
        }

        public void Init()
        {
            
            // "Assets/Levels/Excel/dev-english.xlsx"
            Load("dev-english.xlsx" );
        }
        
        static async void Load(string importedAsset)
        {
            // automatically run postprocessor if any excel file is imported
            //string excelAsset = importedAssets.FirstOrDefault(x => x.EndsWith(".xlsx"));
            string excelAsset = importedAsset;

            if (excelAsset != null)
            {
                var excelPath = Path.GetDirectoryName(excelAsset);
                var jsonPath = Path.Combine(Application.streamingAssetsPath, "Excel");

                var sheetContainer = new Cathei.BakingSheet.Examples.Google.SheetContainer(UnityLogger.Default);

                // create excel converter from path
                var excelConverter = new ExcelSheetConverter(excelPath, TimeZoneInfo.Utc);

                // bake sheets from excel converter
                await sheetContainer.Bake(excelConverter);

                // (optional) verify that data is correct
                sheetContainer.Verify(
#if BAKINGSHEET_ADDRESSABLES
                    new AddressablePathVerifier(),
#endif
                    new ResourcePathVerifier()
                );

                // create json converter to path
                var jsonConverter = new JsonSheetConverter(jsonPath);

                // save datasheet to streaming assets
                await sheetContainer.Store(jsonConverter);

                AssetDatabase.Refresh();

                Debug.Log("Excel sheet converted.");
            }
        }
    }
}