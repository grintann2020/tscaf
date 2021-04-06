using System.Collections.Generic;
using UnityEngine;

namespace T {

    public class ViewMgr : Singleton<ViewMgr> {

        // private Camera _mainCam;
        private List<Camera> _camLis;
        private SCamProj[] _sCamProjArr;

        public void Bind(IViewPrime iViewPrime) {
            _sCamProjArr = iViewPrime.SCamProjArr;
        }

        public void Init() {
            _camLis = new List<Camera>();
            _camLis.Add(Camera.main);
            // Camera.main.nearClipPlane
            // _mainCam = Camera.main;

        }

        public void Create() {
            // new Camera();
        }

        public void Use(byte eCam) {
            // _iCamArr[eCam]
            // _mainCam
        }
    }
}