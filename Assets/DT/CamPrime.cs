using System;
using T;

namespace DT {

    public enum ECam : byte {
        Menu, Stg
    }

    public class CamPrime : ICamPrime {

        public ICam[] ICamArr { get { return _iCamArr; } }
        private ICam[] _iCamArr = new ICam[Enum.GetNames(typeof(ECam)).Length];
        // camera objects
        private MenuCam _menuCam = new MenuCam(); // Menu Camera
        private StgCam _stgCam = new StgCam(); // Stage Camera

        public CamPrime() {
            _iCamArr[(byte)ECam.Menu] = _menuCam;
            _iCamArr[(byte)ECam.Stg] = _stgCam;
        }
    }
}