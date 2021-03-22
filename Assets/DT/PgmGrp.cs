using System.Collections.Generic;
using UnityEngine;
using T;

namespace DT {

    public class PgmGrp : IPgmGrp {

        public enum EPgm : byte {
            Init, Launch, Menu, Stg, Map
        }

        // public Dictionary<EPgm, IPgm> PgmDic { get; set; }
        public PgmMgr Mgr { private get; set; }
        Dictionary<IPgmGrp.EPgm, IPgm> IPgmGrp.PgmDic { get; set; }

        private InitPgm _initPgm = new InitPgm(); // Initialize Program
        private LaunchPgm _launchPgm = new LaunchPgm(); // Launch Program
        private MenuPgm _menuPgm = new MenuPgm(); // Menu Program
        private StgPgm _stgPgm = new StgPgm(); // Stage Program
        private MapPgm _mapPgm = new MapPgm(); // Map Program

        public PgmGrp() {
        }

        public void Init() {
            // Mgr.Reg(EPgm.Init, _initPgm);
            // Mgr.Reg(EPgm.Launch, _launchPgm);
            // Mgr.Reg(EPgm.Menu, _menuPgm);
            // Mgr.Reg(EPgm.Stg, _stgPgm);

            PgmDic.Add(EPgm.Init, _initPgm);
            PgmDic.Add(EPgm.Launch, _launchPgm);
            PgmDic.Add(EPgm.Menu, _menuPgm);
            PgmDic.Add(EPgm.Stg, _stgPgm);
            Mgr.Link(_initPgm, _launchPgm);
            Mgr.Link(_launchPgm, _menuPgm);
            Mgr.Link(_menuPgm, null);
            Mgr.Link(_stgPgm, _menuPgm);
            
            // Mgr.Exe(EPgm.Init);
        }
    }
}