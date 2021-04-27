namespace T {

    public class SSMgr : Sgltn<SSMgr> {

        private ISS[] _iSSArr;
        private ISS _iCurrSS;

        public void Bind(ISSPrm iSSPrm) {
            // _iSSArr = iSSPrm.ISSArr;
        }

        public void Init() {
            _iCurrSS = null;
        }

        // public void SetDf(byte eSS) { 
        //     if (_iCurrSS != null) {
        //         _iSSArr[eSS].SetDef();
        //     }
        // }

        public void Constr(byte eSS) { // excute specific program by Enum
            if (_iCurrSS != null) {
                if (_iSSArr[eSS] == _iCurrSS) {
                    return;
                }
                _iCurrSS.Elim();
            }
            _iCurrSS = _iSSArr[eSS];
            _iCurrSS.Constr();
        }
    }
}