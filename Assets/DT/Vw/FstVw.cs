using System;
using UnityEngine;
using T;

namespace DT {

    public class FstVw : Vw, IVw {
        
        public enum EPrj {
            P0, P1
        }

        public enum EOrnt {                    
            O0, O1, O2
        }

        public enum EMov {
            Test, GG, ok
        }

        public FstVw() {
            _prjArr = new SCamPrj[Enum.GetNames(typeof(EPrj)).Length];
            _prjArr[(byte)EPrj.P0] = new SCamPrj(true, 10.0f, float.NaN, false, 0.3f, 1000.0f);
            _prjArr[(byte)EPrj.P1] = new SCamPrj(false, float.NaN, 40, false, 0.3f, 1000.0f);

            _orntArr = new SOrnt3[Enum.GetNames(typeof(EOrnt)).Length];
            _orntArr[(byte)EOrnt.O0] = new SOrnt3(new SCoord3(20.0f, 20.0f, 20.0f), new SCoord3(0.0f, 0.0f, 0.0f));
            _orntArr[(byte)EOrnt.O1] = new SOrnt3(new SCoord3(40.0f, 40.0f, 40.0f), new SCoord3(0.0f, 0.0f, 0.0f));
            _orntArr[(byte)EOrnt.O2] = new SOrnt3(new SCoord3(30.0f, 30.0f, 30.0f), new SCoord3(0.0f, 0.0f, 0.0f));
            
            _stpArr = new ushort[Enum.GetNames(typeof(EMov)).Length];
            
            _trkArr = new SCoord3[Enum.GetNames(typeof(EMov)).Length][][];

            _dflPrj = _prjArr[(byte)EPrj.P0];
            _dflOrnt = _orntArr[(byte)EOrnt.O0];
        }

        public override void Stup(Camera cam) {
            base.Stup(cam);
        }

        public override void Stdn() {
            base.Stdn();
        }
    }
}