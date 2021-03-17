using System.Collections.Generic;

namespace T {

    public class StgMgr : Singleton<StgMgr> {

        Dictionary<EStg, IStg> _stgDic = new Dictionary<EStg, IStg>();

        public void Init() {

        }

        public void Reg(EStg eStg, IStg iStg) {
            _stgDic.Add(eStg, iStg);
        }
    }
}