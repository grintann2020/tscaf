using UnityEngine.AddressableAssets;
using UnityEngine;

namespace T {

    public class ResMgr : Singleton<ResMgr> {

        private object[][] _resArr;

        public void Bind(IResPrm iResPrm) {
            _resArr = iResPrm.ResArr;
        }

        public void Init() {
            
        }

        public void Get() {
            
        }

        public void Load(ushort res) {
            var tt = _resArr[res][0];
            // var gt = GameObject.MakeGenericType(_resArr[res][0].GetType());
            Debug.Log("ResMgr Load -- " +　_resArr[res][0]);
            Addressables.LoadAssetAsync<UnityEngine.GameObject>(_resArr[res][2]);
        }
    }
}