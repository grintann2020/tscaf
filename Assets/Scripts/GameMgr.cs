using UnityEngine;

namespace T {

    public class GameMgr : Singleton<GameMgr> {

        private SettingsSO _settings;
        private ScrRezSO[] _scrRezArr;
        private PgmMgr _pgmMgr;

        public void Bind(SettingsSO settings) {
            _settings = settings;
        }

        public void Init() {
            _scrRezArr = _settings.ScrRezArr;
            ScrRez(_scrRezArr[0]);
            PgmMgr.Ins.Init();
            PgmMgr.Ins.ExePgm(EPgm.Init);
            // Debug.Log("AR --> " + _scrRezArr[4].Ratio + ", Wd --> " + _scrRezArr[4].Wd + ", Ht --> " + _scrRezArr[4].Ht);
        }

        public void InvokeUpd() {
            PgmMgr.Ins.InvokeUpd();
        }

        public void ScrRez(ScrRezSO scrRez) {
            Screen.SetResolution(scrRez.Wd, scrRez.Ht, true);
        }

        public void ScrRez(int wd, int ht) {
            Screen.SetResolution(wd, ht, true);
        }
    }
}