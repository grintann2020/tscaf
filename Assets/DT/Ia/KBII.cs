using System;
using T;

namespace DT {

    public class KBII : II, III {

        public enum EEvt : byte {
            A0, A1, A2
        }

        public KBII(byte eII) : base(eII) {
            _dDtcArr = new _dDtc[Enum.GetNames(typeof(EEvt)).Length];
            _dDtcArr[(byte)EEvt.A0] = A0;
            _dDtcArr[(byte)EEvt.A1] = A1;
            _dDtcArr[(byte)EEvt.A2] = A2;
        }

        private void A0(Action dRct) {
        }

        private void A1(Action dRct) {
        }

        private void A2(Action dRct) {
        }
    }
}