using System.Collections.Generic;
using UnityEngine;

namespace T {

    public class LangMgr : Singleton<LangMgr> {

        // public static SLang ChineseTraditional = new SLang(SystemLanguage.ChineseTraditional, "ChineseTraditional", "zh-TW");
        // public static SLang ChineseSimplified = new SLang(SystemLanguage.ChineseSimplified, "ChineseSimplified", "zh-CH");
        // public static SLang English = new SLang(SystemLanguage.English, "English", "en");

        // private Dictionary<ETerm, STerm> _termDic = new Dictionary<ETerm, STerm>();

        public void Init() {

        }

        public static string[,] TermArr = new string[,] {
            {"Grin Bit", "Grin Bit"},
            {"Double Trap", "雙重陷阱"},
            {"Test", "測試"}
        };
    }
}