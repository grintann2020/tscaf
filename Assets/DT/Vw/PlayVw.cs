using System;
using UnityEngine;
using T;

namespace DT {

    public class PlayVw : Vw, IVw {

        public enum EPrj {
            P0, P1
        }

        public enum EOrnt {
            OA, OB, O1, O2
        }

        public enum EMov {
            M1, M2
        }

        public PlayVw() {
            _prjArr = new SCamPrj[Enum.GetNames(typeof(EPrj)).Length];
            _prjArr[(byte)EPrj.P0] = new SCamPrj(true, 5.0f, float.NaN, false, 0.3f, 1000.0f);
            _prjArr[(byte)EPrj.P1] = new SCamPrj(false, float.NaN, 40, false, 0.3f, 1000.0f);

            _orntArr = new SOrnt3[Enum.GetNames(typeof(EOrnt)).Length];
            _orntArr[(byte)EOrnt.OA] = new SOrnt3(new SCoord3(30.0f, 30.0f, 30.0f), new SCoord3(0.0f, 0.0f, 0.0f));
            _orntArr[(byte)EOrnt.OB] = new SOrnt3(new SCoord3(45.0f, 45.0f, 45.0f), new SCoord3(0.0f, 0.0f, 0.0f));
            _orntArr[(byte)EOrnt.O1] = new SOrnt3(new SCoord3(4.0f, 3.0f, 0.0f), new SCoord3(0.0f, 0.0f, 0.0f));
            _orntArr[(byte)EOrnt.O2] = new SOrnt3(new SCoord3(6.0f, 8.0f, -10.0f), new SCoord3(0.0f, 0.0f, 0.0f));

            _stpArr = new ushort[Enum.GetNames(typeof(EMov)).Length];
            _stpArr[(byte)EMov.M1] = 0;
            _stpArr[(byte)EMov.M2] = 0; 

            _trkArr = new SCoord3[Enum.GetNames(typeof(EMov)).Length][][];
            _trkArr[(byte)EMov.M1] = Anm.Trk2(
                _orntArr[(byte)EOrnt.O1].A, _orntArr[(byte)EOrnt.O2].A,
                _orntArr[(byte)EOrnt.O1].B, _orntArr[(byte)EOrnt.O2].B, 1000
            );

            _trkArr[(byte)EMov.M2] = Anm.Trk2(
                new SCoord3(5.0f, 5.0f, 5.0f), new SCoord3(45.0f, 50.0f, 55.0f),
                new SCoord3(0.0f, 0.0f, 0.0f), new SCoord3(5.0f, 10.0f, 15.0f), 1000
            );

            _dflPrj = _prjArr[(byte)EPrj.P0];
            _dflOrnt = _orntArr[(byte)EOrnt.OA];
        }

        public override void Stup(Camera cam) {
            base.Stup(cam);
        }

        public override void Stdn() {
            base.Stdn();
        }

        // public void Stp1() {
            // Debug.Log("PlayVw -- P1()");
        // }

        // public void Stp2() {
            // Debug.Log("PlayVw -- P2()");
        // }

        // public void Stp3() {
            // Debug.Log("PlayVw -- P3()");
        // }
    }
}