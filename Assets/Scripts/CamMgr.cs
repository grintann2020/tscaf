using UnityEngine;

namespace T {

    public class CamMgr : Singleton<CamMgr> {

        private Camera _cam;
        private ICam[] _iCamArr;

        public void Bind(ICamPrime iCamPrime) {
            _iCamArr = iCamPrime.ICamArr;
        }

        public void Init() {
            _cam = Camera.main;
            // _iCamArr[(byte)ECam.Stg]
        }
    }
}