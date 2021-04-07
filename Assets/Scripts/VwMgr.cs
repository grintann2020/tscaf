using System.Collections.Generic;
using UnityEngine;

namespace T {

    public class VwMgr : Singleton<VwMgr> {

        // private Camera _mainCam;
        private List<Camera> _camLis;
        private IVw[] _iVwArr;
        private SCamProj[] _sCamProjArr;
        private IVw _iCurrVw;

        public void Bind(IVwPrime iVwPrime) {
            _iVwArr = iVwPrime.IVwArr;
            _sCamProjArr = iVwPrime.SCamProjArr;
        }

        public void Init() {
            _camLis = new List<Camera>();
            _camLis.Add(Camera.main);
            _iCurrVw = null;
            // Camera.main.nearClipPlane
            // _mainCam = Camera.main;
        }

        public void Create() {
            // new Camera();
        }

        public void Set(byte eVw) {
            if (_iVwArr[eVw] == _iCurrVw) {
                return;
            }
            _iCurrVw = _iVwArr[eVw];
            _iCurrVw.Set();
        }

        public void Set(IVw iVw) {
            if (iVw == _iCurrVw) {
                return;
            }
            _iCurrVw = iVw;
            _iCurrVw.Set();
        }
    }
}