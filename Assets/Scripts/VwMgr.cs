using System;
using UnityEngine;

namespace T {

    public class VwMgr : Singleton<VwMgr> {

        private SCamProj[] _sCamProjArr;
        private IVw[] _iVwArr;
        // private IVw _iCurrVw;

        public void Bind(IVwPrm iVwPrm) {
            _sCamProjArr = iVwPrm.SCamProjArr;
            _iVwArr = iVwPrm.IVwArr;
        }

        public void Init() {
            // _iCurrVw = null;
        }

        public void SetCam(byte eVw, Camera cam) {
            if (Array.IndexOf(_iVwArr, eVw) == -1) {
                Debug.LogError("VwMgr SetCam( ) -- (byte)eVw = " + eVw + " is not included");
                return;
            }
            _iVwArr[eVw].SetCam(cam);
        }

        public void SetCam(IVw iVw, Camera cam) {
            iVw.SetCam(cam);
        }

        public void SetCamProj(byte eVw, byte eCamProj) {
            if (Array.IndexOf(_iVwArr, eVw) == -1) {
                Debug.LogError("VwMgr SetCamProj( ) -- (byte)eCamProj = " + eCamProj + " is not included");
                return;
            }
            _iVwArr[eVw].SetCamProj(_sCamProjArr[eCamProj]);
        }

        public void SetCamProj(IVw iVw, byte eCamProj) {
            iVw.SetCamProj(_sCamProjArr[eCamProj]);
        }

        public IVw GetVw(byte eVw) {
            if (Array.IndexOf(_iVwArr, eVw) == -1) {
                Debug.LogError("VwMgr GetVw( ) -- (byte)eVw = " + eVw + " is not included");
                return null;
            }
            return _iVwArr[eVw];
        }

        public void Close() {

        }

        // public void Use(byte eVw) {
        //     if (_iVwArr[eVw] == _iCurrVw) {
        //         return;
        //     }
        //     _iCurrVw = _iVwArr[eVw];
        //     _iCurrVw.Set();
        // }

        // public void Use(IVw iVw) {
        //     if (iVw == _iCurrVw) {
        //         return;
        //     }
        //     _iCurrVw = iVw;
        //     _iCurrVw.Set();
        // }

        public void Mv(byte eVw, byte eMv) {
            if (Array.IndexOf(_iVwArr, eVw) == -1) {
                Debug.LogError("VwMgr Mv( ) -- (byte)eVw = " + eVw + " is not included");
            }
        }

        public void Mv(IVw iVw, byte eMv) {
            // if (Array.IndexOf(_iVwArr, eVw) == -1) {
            //     Debug.LogError("VwMgr Mv( ) -- (byte)" + eVw + " is not included");
            // }
        }
    }
}