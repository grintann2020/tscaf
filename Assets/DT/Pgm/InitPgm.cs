using System.Collections;
using UnityEngine;
using T;

namespace DT {

    public class TestPgm : SgltnMB<TestPgm> {

        public void TestWait(int sec) {
            StartCoroutine(TestW(sec));
        }

        IEnumerator TestW(int sec) {
            yield return new WaitForSeconds(sec);

            // GameObject go = GameObject.Find("SplhUIA1(Clone)");
            // ResMgr.Ins.Rls<GameObject>(go);
            // GameObject go2 = GameObject.Find("SplhUIA2(Clone)");
            // ResMgr.Ins.Rls<GameObject>(go2);
        }
    }

    public class InitPgm : IPgm {

        public IPgm Next { get; set; }

        public void InvkUpd() {
            // Debug.Log("InitPgm -- InvkUpd()");
        }

        public void Exe() {
            LangMgr.Ins.Init();
            ResMgr.Ins.Init();
            VwMgr.Ins.Init();
            UIMgr.Ins.Init();
            IaMgr.Ins.Init();
            StgMgr.Ins.Init();

            // System.Threading.Thread.Sleep(1000);
            // test UIMgr
            UIMgr.Ins.SetCanv((byte)EUI.Splh, GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<Canvas>());

            // UIMgr.Ins.Instl((byte)EUI.Splh);

            // TestPgm.Ins.TestWait(3);

            // ResMgr.Ins.Inst("SplhUIA1", () => {
            //     TestPgm.Ins.TestWait(3);
            // });

            // ResMgr.Ins.Inst((ushort)ERes.SplhUIA2, () => {
            // }, GameObject.FindGameObjectWithTag("MainCanvas").transform);

            // Test LangMgr
            LangMgr.Ins.Chg(ELang.ZH_CN);
            // LangMgr.Ins.Chg((byte)ELang.EN_US);
            // Debug.Log(LangMgr.Ins.Term((ushort)ETerm.Three_U));
            // Debug.Log(LangMgr.Ins.Term((ushort)ETerm.Six_U, ELang.EN));

            // LangMgr.Ins.Chg(SystemLanguage.ChineseTraditional);
            // Debug.Log(LangMgr.Ins.Term((ushort)ETerm.Six_U));

            // ResMgr.Ins.Load((byte)ERes.CubeRed);
            // ResMgr.Ins.Load((byte)ERes.Green);



            // Test VwMgr
            VwMgr.Ins.SetCam((byte)EVw.Menu, Camera.main);
            VwMgr.Ins.SetPrj((byte)EVw.Menu, (byte)ECamPrj.Menu);
            // VwMgr.Ins.Act((byte)EVw.Menu, (byte)MenuVw.EAct.Test);
            // VwMgr.Ins.Act((byte)EVw.Menu, (byte)MenuVw.EAct.GG);
            // VwMgr.Ins.Act((byte)EVw.Play, (byte)PlayVw.EAct.P1);
            // VwMgr.Ins.Act((byte)EVw.Play, (byte)PlayVw.EAct.P2);

            // Debug.Log("DT) init program --> executed");

            PgmMgr.Ins.Next();
        }

        public void End() {
            // Debug.Log("DT) init program --> end");
        }
    }
}