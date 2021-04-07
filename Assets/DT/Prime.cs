using T;

namespace DT {

    public class Prime : IPrime {

        public IPgmPrime IPgmPrime { get { return new PgmPrime(); } }
        public ILangPrime ILangPrime { get { return new LangPrime(); } }
        public IVwPrime IVwPrime { get { return new VwPrime(); } }

        public void Bind() {
            PgmMgr.Ins.Bind(IPgmPrime);
            LangMgr.Ins.Bind(ILangPrime);
            VwMgr.Ins.Bind(IVwPrime);
        }
    } 
}