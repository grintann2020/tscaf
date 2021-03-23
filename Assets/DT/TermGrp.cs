using System.Collections.Generic;
using UnityEngine;
using T;

namespace DT {

    public class TermGrp : ITermGrp {

        public LangMgr Mgr { private get; set; }

        public static string[,] Arr = new string[,] {
            {"Grin Bit", "Grin Bit"},
            {"Double Trap", "雙重陷阱"},
            {"Test", "測試"}
        };

        public void Init() {

        }
    }
}