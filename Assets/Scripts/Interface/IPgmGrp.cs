using System.Collections.Generic;

namespace T {

    public interface IPgmGrp {

        enum EPgm {}
        PgmMgr Mgr { set; }
        Dictionary<EPgm, IPgm> PgmDic { get; set; }
        void Init();
    }
}
