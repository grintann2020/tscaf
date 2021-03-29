using System.Collections.Generic;
using UnityEngine;

namespace T {

    public class CamMgr : Singleton<CamMgr> {

        private Camera _mainCam;
        private List<Camera> _camLis;
        private ICam[] _iCamArr;

        public void Bind(ICamPrime iCamPrime) {
            _iCamArr = iCamPrime.ICamArr;
        }

        public void Init() {
            _camLis.Clear();
            _camLis = new List<Camera>();
            _mainCam = Camera.main;
            _camLis.Add(_mainCam);
            // _iCamArr[(byte)ECam.Stg]
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