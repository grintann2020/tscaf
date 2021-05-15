using System;
using UnityEngine;
using T;

namespace DT {

    public class MusII : II, III {

        public enum EEvt : byte {
            E0, E1
        }

        public MusII() {
            _dDtcArr = new _dDtc[Enum.GetNames(typeof(EEvt)).Length];
            _dDtcArr[(byte)EEvt.E0] = I0;
            _dDtcArr[(byte)EEvt.E1] = I1;
        }

        // public override void Enbl() {
        //     base.Enbl();
        // }

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