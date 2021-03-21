using UnityEngine;

namespace T {

    public struct STerm {
        
        private ETerm _eTerm;
        private SystemLanguage _eLang;
        private string _txt;

        public STerm(ETerm eTerm, SystemLanguage eLang, string txt) {
            _eTerm = eTerm;
            _eLang = eLang;
            _txt = txt;
        }
    }
}