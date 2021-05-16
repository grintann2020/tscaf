using System;

namespace T {

    public class II {

        protected delegate void _dDtc(Action rct);
        protected _dDtc[] _dDtcArr;
        protected Action[] _rctArr;

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