using T;

namespace Robot {

    public class Prm : IPrm {

        public IPgmPrm IPgmPrm { get { return new PgmPrm(); } }
        public ILangPrm ILangPrm { get { return new LangPrm(); } }

        public void Bind() {
            PgmMgr.Ins.Bind(IPgmPrm);
            LangMgr.Ins.Bind(ILangPrm);
        }
    }
}