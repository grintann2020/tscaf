using T;

namespace Robot {

    public class PgmGrp_Robot : IPgmGrp {

        public PgmMgr Mgr { get; set; }
        private InitPgm _initPgm = new InitPgm(); // Initialize Program
        private LaunchPgm _launchPgm = new LaunchPgm(); // Launch Program

        public void Init() {
            Mgr.Reg(EPgm.Init, _initPgm);
            Mgr.Reg(EPgm.Launch, _launchPgm);
            Mgr.Link(_initPgm, _launchPgm);
            Mgr.Link(_launchPgm, null);
            
            Mgr.Exe(EPgm.Init);
        }
    }
}