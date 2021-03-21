using UnityEngine;
using T;

namespace DT {

    public class PgmGrp_DT : IPgmGrp {

        public PgmMgr Mgr { get; set; }
        private InitPgm _initPgm = new InitPgm(); // Initialize Program
        private LaunchPgm _launchPgm = new LaunchPgm(); // Launch Program
        private MenuPgm _menuPgm = new MenuPgm(); // Menu Program
        private StgPgm _stgPgm = new StgPgm(); // Stage Program
        private MapPgm _mapPgm = new MapPgm(); // Map Program

        public void Init() {
            Mgr.Reg(EPgm.Init, _initPgm);
            Mgr.Reg(EPgm.Launch, _launchPgm);
            Mgr.Reg(EPgm.Menu, _menuPgm);
            Mgr.Reg(EPgm.Stg, _stgPgm);
            Mgr.Link(_initPgm, _launchPgm);
            Mgr.Link(_launchPgm, _menuPgm);
            Mgr.Link(_menuPgm, null);
            Mgr.Link(_stgPgm, _menuPgm);
            
            Mgr.Exe(EPgm.Init);
        }
    }
}