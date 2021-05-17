using System;
using UnityEngine;
using T;

namespace DT {

    public class MusII : II, III {

        public enum EInp : byte {
            I0, I1
        }

        public MusII(byte eII) : base(eII) {
            _dDtcArr = new _dDtc[Enum.GetNames(typeof(EInp)).Length];
            _dDtcArr[(byte)EInp.I0] = I0;
            _dDtcArr[(byte)EInp.I1] = I1;
        }

        private void I0(Action rct) {
            if (Input.GetMouseButtonDown(0)) {
                Debug.Log("Pressed left click.");
                rct();
            }
            if (Input.GetMouseButtonDown(1)) {
                Debug.Log("Pressed right click.");
                rct();
            }
        }

        private void I1(Action rct) {
            if (Input.GetMouseButtonDown(2)) {
                Debug.Log("Pressed middle click.");
                rct();
            }
        }
    }
}