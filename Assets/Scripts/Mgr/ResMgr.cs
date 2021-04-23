using System.Threading.Tasks;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine;

namespace T {

    public class ResMgr : Sgltn<ResMgr> {
        public delegate void DCb();
        public delegate void DCb<T>(T obj);
        public delegate void DCbArr<T>(T[] objArr);

        public void Init() {

        }

        public void Load<TObj>(string key, DCb<TObj> dLoaded) {
            Addressables.LoadAssetAsync<TObj>(key).Completed += (AsyncOperationHandle<TObj> hdl) => {
                dLoaded(hdl.Result);
            };
        }

        public async void Load<TObj>(string[] keyArr, DCbArr<TObj> dLoaded) {
            TObj[] objArr = new TObj[keyArr.Length];
            Task[] taskArr = new Task[keyArr.Length];
            AsyncOperationHandle<TObj>[] hdlArr = new AsyncOperationHandle<TObj>[keyArr.Length];
            for (byte k = 0; k < keyArr.Length; k++) {
                hdlArr[k] = Addressables.LoadAssetAsync<TObj>(keyArr[k]);
                taskArr[k] = hdlArr[k].Task;
            }
            await Task.WhenAll(taskArr);
            for (byte k = 0; k < keyArr.Length; k++) {
                objArr[k] = hdlArr[k].Result;
            }
            dLoaded(objArr);
        }

        public void Inst(string key, DCb<GameObject> dInsted, Transform parent = null) { // Addressables.InstantiateAsync will clone asset directlty
            Addressables.InstantiateAsync(key, parent).Completed += (AsyncOperationHandle<GameObject> hdl) => {
                dInsted(hdl.Result);
            };
        }

        public void Inst(string key, DCb<GameObject> dInsted, Vector3 pos, Quaternion rot, Transform parent = null) { // Addressables.InstantiateAsync will clone asset directlty
            Addressables.InstantiateAsync(key, pos, rot, parent).Completed += (AsyncOperationHandle<GameObject> hdl) => {
                dInsted(hdl.Result);
            };
        }

        public async void Inst(string[] keyArr, DCbArr<GameObject> dInsted, Transform parent = null) { // Addressables.InstantiateAsync will clone asset directlty
            GameObject[] objArr = new GameObject[keyArr.Length];
            Task[] taskArr = new Task[keyArr.Length];
            AsyncOperationHandle<GameObject>[] hdlArr = new AsyncOperationHandle<GameObject>[keyArr.Length];
            for (byte k = 0; k < keyArr.Length; k++) {
                hdlArr[k] = Addressables.InstantiateAsync(keyArr[k], parent);
                taskArr[k] = hdlArr[k].Task;
            }
            await Task.WhenAll(taskArr);
            for (byte k = 0; k < keyArr.Length; k++) {
                objArr[k] = hdlArr[k].Result;
            }
            dInsted(objArr);
        }

        public void Rls<TObj>(TObj obj, DCb dRlsed = null) {
            Addressables.Release<TObj>(obj);
            if (dRlsed != null) {
                dRlsed();
            }
        }

        public void Rls<TObj>(TObj[] objArr, DCb dRlsed = null) {
            for (ushort o = 0; o < objArr.Length; o++) {
                Addressables.Release<TObj>(objArr[o]);
            }
            if (dRlsed != null) {
                dRlsed();
            }
        }
    }
}