using System;
using UnityEngine;
using T;

namespace DT {

    public class FstVw : Vw, IVw {

        public enum EAct {
            Test, GG, ok
        }

        public FstVw(SCamPrj defProj, SOrnt3 defOrnt) : base(defProj, defOrnt) {
            _dActArr = new _dAct[Enum.GetNames(typeof(EAct)).Length];
            _dActArr[(byte)EAct.Test] = Test;
            _dActArr[(byte)EAct.GG] = GG;
        }

        public void InvkUpd() {

        }

        

        public void Test() {
            Debug.Log("FstVw -- Test()");
        }

        public void GG() {
            Debug.Log("FstVw -- GG()");
        }
    }
}