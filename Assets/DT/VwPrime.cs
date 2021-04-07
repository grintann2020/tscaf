using System;
using T;

namespace DT {

    public enum EVw : byte {
        Menu, Play
    }

    public enum ECamProj : byte {
        Menu, Play
    }

    public class VwPrime : IVwPrime {

        public IVw[] IVwArr { get { return _iVwArr; } }
        public SCamProj[] SCamProjArr { get { return _sCamProjArr; } }
        private IVw[] _iVwArr = new IVw[Enum.GetNames(typeof(EVw)).Length];
        private SCamProj[] _sCamProjArr = new SCamProj[Enum.GetNames(typeof(ECamProj)).Length];
        // vieww objects
        private MenuVw _menuVw = new MenuVw();
        private PlayVw _playVw = new PlayVw();
        // camera projection objects
        private SCamProj _menuCamProj = new SCamProj(true, 20.0f, float.NaN, false, 0.3f, 1000.0f);
        private SCamProj _playCamProj = new SCamProj(false, float.NaN, 40, false, 0.3f, 1000.0f);

        public VwPrime() {
            _iVwArr[(byte)EVw.Menu] = _menuVw;
            _iVwArr[(byte)EVw.Play] = _playVw;
            _sCamProjArr[(byte)ECamProj.Menu] = _menuCamProj;
            _sCamProjArr[(byte)ECamProj.Play] = _playCamProj; 
        }
    }
}