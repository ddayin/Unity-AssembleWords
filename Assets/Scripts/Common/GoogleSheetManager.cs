using System;
using System.IO;
using Cathei.BakingSheet;
using Cathei.BakingSheet.Examples;
using Cathei.BakingSheet.Unity;
using UnityEditor;
using UnityEngine;
using WanzyeeStudio;
using Newtonsoft.Json;

namespace AssembleWords
{
    public class GoogleSheetManager : BaseSingleton<GoogleSheetManager>
    {
        protected override void Awake()
        {
            base.Awake();
        }

        public static async void Load()
        {
            var jsonPath = Path.Combine(Application.streamingAssetsPath, "Google");

            var googleConverter = new GoogleSheetConverter("1iWMZVI4FgtGbig4EgPIun_BRbzp4ulqRIzINZQl-AFI", GoogleCredential, TimeZoneInfo.Utc);

            var sheetContainer = new Cathei.BakingSheet.Examples.Google.SheetContainer(UnityLogger.Default);

            await sheetContainer.Bake(googleConverter);

            // create json converter to path
            var jsonConverter = new GoogleSheetTools.PrettyJsonConverter(jsonPath);

            // save datasheet to streaming assets
            await sheetContainer.Store(jsonConverter);

            AssetDatabase.Refresh();

            Debug.Log("Google sheet converted.");
        }

        public void CleanUp()
        {
            
        }
    }
}