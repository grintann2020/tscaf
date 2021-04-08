using T;

namespace DT {

    public class Prm : IPrm {

        public IPgmPrm IPgmPrm { get { return new PgmPrm(); } }
        public ILangPrm ILangPrm { get { return new LangPrm(); } }
        public IVwPrm IVwPrm { get { return new VwPrm(); } }

        public void Bind() {
            PgmMgr.Ins.Bind(IPgmPrm);
            LangMgr.Ins.Bind(ILangPrm);
            VwMgr.Ins.Bind(IVwPrm);
        }
    } 
}