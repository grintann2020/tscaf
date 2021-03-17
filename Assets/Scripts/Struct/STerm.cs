using UnityEngine;

namespace T {

    public struct STerm {
        // public SystemLanguage Num;
        public ETerm Num;
        public string Txt;

        public STerm(ETerm num, string txt) {
            Num = num;
            Txt = txt;
        }
    }
}