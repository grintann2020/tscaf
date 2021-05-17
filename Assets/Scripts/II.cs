using System;

namespace T {

    public class II {

        public byte EII { get; }
        protected delegate void _dDtc(Action rct);
        protected _dDtc[] _dDtcArr;
        protected Action[] _rctArr;
        private byte _eII;

        public II(byte eII) {
            _eII = eII;
        }

        public void Instl() {
            _rctArr = new Action[_dDtcArr.Length];
            for (byte e = 0; e < _rctArr.Length; e++) {
                _rctArr[e] = () => {};
            }
        }

        public void Invk(byte eEvt, Action rct) {
            _rctArr[eEvt] += rct;
        }

        public void Waiv(byte eEvt, Action rct) {
            _rctArr[eEvt] -= rct;
        }

        public void InvkUpd() {
            for (byte d = 0; d < _dDtcArr.Length; d++) {
                if (_dDtcArr[d] != null) {
                    _dDtcArr[d].Invoke(_rctArr[d]);
                }
            }
        }
    }
}