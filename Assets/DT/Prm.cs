using UnityEngine;
using T;

namespace DT {

    public class Prm : IPrm {

        public IPgmPrm IPgmPrm { get { return new PgmPrm(); } }
        public ILangPrm ILangPrm { get { return new LangPrm(); } }
        // public IResPrm IResPrm { get { return new ResPrm(); } }
        public ISSPrm ISSPrm { get { return new SSPrm(); } }
        public IVwPrm IVwPrm { get { return new VwPrm(); } }
        public IIaPrm IIaPrm { get { return new IaPrm(); } }
        public IStgPrm IStgPrm { get { return new StgPrm(); } }
        public IUIPrm IUIPrm { get { return new UIPrm(); } }

        public void Bind() {
            // Debug.Log("DT -- Prm -- Bind()");
            PgmMgr.Ins.Bind(IPgmPrm);
            LangMgr.Ins.Bind(ILangPrm);
            // ResMgr.Ins.Bind(IResPrm);
            VwMgr.Ins.Bind(IVwPrm);
            IaMgr.Ins.Bind(IIaPrm);
            SSMgr.Ins.Bind(ISSPrm);
            StgMgr.Ins.Bind(IStgPrm);
            UIMgr.Ins.Bind(IUIPrm);
        }
    } 
}