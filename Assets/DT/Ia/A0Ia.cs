using UnityEngine;
using T;

namespace DT {

    public class A0Ia : Ia, IIa {

        private byte _r0, _r1 = 0;

        public A0Ia(III[] iIIArr) : base(iIIArr) {
            _iIIArr[0].Invk((byte)MusII.EEvt.E0, R0);
            _iIIArr[0].Invk((byte)MusII.EEvt.E0, R0);
            _iIIArr[0].Invk((byte)MusII.EEvt.E0, R0);
            _iIIArr[0].Invk((byte)MusII.EEvt.E1, R1);
            _iIIArr[0].Invk((byte)MusII.EEvt.E1, R0);
            _iIIArr[0].Waiv((byte)MusII.EEvt.E0, R0);
            _iIIArr[0].Waiv((byte)MusII.EEvt.E0, R0);
        }

        public void R0() {
            _r0 += 1;
            Debug.Log("A0Ia R0() -- " + _r0);
        }

        public void R1() {
            _r1 += 1;
            Debug.Log("A0Ia R1() -- " + _r1);
        }
    }
}