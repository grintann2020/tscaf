using UnityEngine;
using T;

namespace DT {

    public class InitPgm : IPgm {

        public IPgm Next { get; set; }

        public void InvkUpd() {

        }

        public void Exe() {
            LangMgr.Ins.Init();
            VwMgr.Ins.Init();
            UIMgr.Ins.Init();
            InteractMgr.Ins.Init();
            StgMgr.Ins.Init();

            // Test LangMgr
            // Debug.Log("DT) init program --> executed");
            // LangMgr.Ins.Chg(ELang.ZH_CN);
            // Debug.Log(LangMgr.Ins.Term((ushort)ETerm.Six_U));

            // LangMgr.Ins.Chg((byte)ELang.EN_US);
            // Debug.Log(LangMgr.Ins.Term((ushort)ETerm.Six_U));

            // LangMgr.Ins.Chg(SystemLanguage.ChineseTraditional);
            // Debug.Log(LangMgr.Ins.Term((ushort)ETerm.Six_U));

            // VwMgr.Ins.Set((byte)EVw.Menu);

            // Test VwMgr
            VwMgr.Ins.SetCam((byte)EVw.Menu, Camera.main);
            VwMgr.Ins.Act((byte)EVw.Menu, (byte)MenuVw.EAct.Test);
            VwMgr.Ins.Act((byte)EVw.Menu, (byte)MenuVw.EAct.GG);
            VwMgr.Ins.Act((byte)EVw.Play, (byte)PlayVw.EAct.P1);
            VwMgr.Ins.Act((byte)EVw.Play, (byte)PlayVw.EAct.P2);

            PgmMgr.Ins.Next();
        }

        public void End() {
            // Debug.Log("DT) init program --> end");
        }
    }
}