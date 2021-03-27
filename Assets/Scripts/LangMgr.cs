namespace T {

    public class LangMgr : Singleton<LangMgr> {
        
        private string[][] _termArr;
        private ELang _eCurrLang;

        public void Bind(ILangPrime iLangPrime) {
            _termArr = iLangPrime.TermsArr;
        }

        public void Init() {
            _eCurrLang = ELang.en_US;
        }

        public void Change(ELang eLang) {
            _eCurrLang = eLang;
        }

        public string Term(ushort eTerm) {
            return _termArr[eTerm][(byte)_eCurrLang];
        }
    }
}