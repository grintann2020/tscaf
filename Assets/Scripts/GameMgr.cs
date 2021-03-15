using UnityEngine;

namespace T {

    public class GameMgr : Singleton<GameMgr> {

        private Settings _settings;

        public void Bind(Settings settings) {
            _settings = settings;
        }

        public void Init() {
            SetRez(_settings.ScrRez, 2);
            PgmMgr.Ins.Init();
            PgmMgr.Ins.ExePgm(EPgm.Init);
        }

        public void InvokeUpd() {
            PgmMgr.Ins.InvokeUpd();
        }

        public void SetRez(ScrRez scrRez) {
            Screen.SetResolution(scrRez.Wd, scrRez.Ht, true);
            Debug.Log("Screen Resolution --> Width: " + scrRez.Wd + ", Height: " + scrRez.Ht + ", aspect ratio: " + scrRez.AR);
        }

        public void SetRez(ScrRez scrRez, byte lv) {
            scrRez.Lv = lv;
            Screen.SetResolution(scrRez.Wd, scrRez.Ht, true);
            Debug.Log("Screen Resolution --> Width: " + scrRez.Wd + ", Height: " + scrRez.Ht + ", aspect ratio: " + scrRez.AR);
        }
    }
}