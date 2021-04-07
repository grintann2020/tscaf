using UnityEngine;
using T;

namespace DT {

    public class InitPgm : IPgm {

        public IPgm Next { get; set; }

        public void InvokeUpd() {

        }

        public void Exe() {
            LangMgr.Ins.Init();
            VwMgr.Ins.Init();
            UIMgr.Ins.Init();
            InteractMgr.Ins.Init();
            StgMgr.Ins.Init();

            // VwMgr.Ins.Create();

            // Debug.Log("DT) init program --> executed");
            LangMgr.Ins.Change(ELang.ZH_CN);
            Debug.Log(LangMgr.Ins.Term((ushort)ETerm.Six_U));

            // LangMgr.Ins.Change((byte)ELang.EN_US);
            // Debug.Log(LangMgr.Ins.Term((ushort)ETerm.Six_U));

            // LangMgr.Ins.Change(SystemLanguage.ChineseTraditional);
            // Debug.Log(LangMgr.Ins.Term((ushort)ETerm.Six_U));

            PgmMgr.Ins.Next();
        }

        public void End() {
            // Debug.Log("DT) init program --> end");
        }
    }
}