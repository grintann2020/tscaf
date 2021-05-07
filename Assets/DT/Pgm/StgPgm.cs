using System.Collections;
using UnityEngine;
using T; 

namespace DT {

    public class Test2 : SgltnMB<Test2> {

        public void TestWait(int sec, GameObject[] goArr = null) {
            if (goArr == null) {
                StartCoroutine(TestW(sec));
            } else {
                StartCoroutine(TestW(sec, goArr));
            }
        }

        IEnumerator TestW(int sec, GameObject[] goArr = null) {
            yield return new WaitForSeconds(sec);
            // StgMgr.Ins.Act((byte)EStg.ATut0);
            VwMgr.Ins.Mov((byte)EVw.Play, (byte)PlayVw.EMov.M1);
            yield return new WaitForSeconds(sec * 3);
            VwMgr.Ins.Mov((byte)EVw.Play, (byte)PlayVw.EMov.M1);
        }
    }

    public class StgPgm : IPgm {

        public IPgm Next { get; set; }

        public void InvkUpd() {
            StgMgr.Ins.InvkUpd();
            VwMgr.Ins.InvkUpd();
        }

        public void Exe() {
            // IaMgr.Ins.Sw();
            StgMgr.Ins.Imp((byte)EStg.Ex0);
            VwMgr.Ins.Stup((byte)EVw.Play, Camera.main);
            Test2.Ins.TestWait(2);
        }

        public void End() {

        }
    }
}