namespace T {

    public class InitPgm : IPgm {

        public IPgm Next { get; set; }

        public void InvokeUpd() {

        }

        public void Exe() {
            GameMgr.Ins.Init();
            UIMgr.Ins.Init();
            InteractMgr.Ins.Init();
            PgmMgr.Ins.Next();
        }

        public void End() {

        }
    }
}