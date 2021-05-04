namespace T {

    public class Stg {

        protected delegate void _dBgn();
        protected delegate void _dUpd();
        protected delegate bool _dCond();
        protected _dBgn[] _dBgnArr;
        protected _dUpd[] _dUpdArr;
        protected _dCond[] _dCondArr;
        protected byte[][][] _actArr;
        protected byte _eAct;
        protected bool _isImp;
        protected bool _isAct;
        protected const byte PR = 2;

        public Stg() {
            _eAct = 0;
            _isImp = false;
            _isAct = false;
        }

        public virtual void Imp() {
            _isImp = true;
        }

        public virtual void Clr() {
            _eAct = 0;
            _isImp = false;
            _isAct = false;
        }

        public void Act() {
            if (_isImp == false) {
                return;
            }
            _eAct = 0;
            _dBgnArr[_eAct].Invoke();
            _isAct = true;
        }

        public void Act(byte eAct) {
            if (_isImp == false) {
                return;
            }
            _eAct = eAct;
            _dBgnArr[_eAct].Invoke();
            _isAct = true;
        }

        public void InvkUpd() {
            if (_isImp == false || _isAct == false) {
                return;
            }
            for (byte c = 0; c < _actArr[_eAct].Length; c++) {
                if (_dCondArr[_actArr[_eAct][c][0]].Invoke()) {
                    Act(_actArr[_eAct][c][1]);
                }
            }
            if (_dUpdArr[_eAct] != null) {
                _dUpdArr[_eAct].Invoke();
            }
        }
    }
}