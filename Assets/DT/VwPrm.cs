using System;
using UnityEngine;
using T;

namespace DT {

    public enum ECamPrj : byte {
        Menu, Play
    }

    public enum EVw : byte {
        Menu, Play
    }

    // public enum EVwAct {
    //     MenuTest, MenuGG, MenuOK,
    //     PlayP1, PlayP2, PlayP3,
    // }

    public class VwPrm : IVwPrm {
        
        public SCamPrj[] SCamPrjArr { get { return _sCamPrjArr; } }
        public IVw[] IVwArr { get { return _iVwArr; } }

        // private delegate void _dAct();
        
        private SCamPrj[] _sCamPrjArr = new SCamPrj[Enum.GetNames(typeof(ECamPrj)).Length];
        private IVw[] _iVwArr = new IVw[Enum.GetNames(typeof(EVw)).Length];
        // private _dAct[] _dActArr = new _dAct[Enum.GetNames(typeof(EVwAct)).Length];

        private SCamPrj _menuCamPrj = new SCamPrj(true, 20.0f, float.NaN, false, 0.3f, 1000.0f);
        private SCamPrj _playCamPrj = new SCamPrj(false, float.NaN, 40, false, 0.3f, 1000.0f);

        private MenuVw _menuVw = new MenuVw();
        private PlayVw _playVw = new PlayVw();

        public VwPrm() {
            _sCamPrjArr[(byte)ECamPrj.Menu] = _menuCamPrj;
            _sCamPrjArr[(byte)ECamPrj.Play] = _playCamPrj;

            _iVwArr[(byte)EVw.Menu] = _menuVw;
            _iVwArr[(byte)EVw.Play] = _playVw;

            // _dActArr[(byte)EVwAct.MenuTest] = _menuVw.Test;
            // _dActArr[(byte)EVwAct.MenuGG] = _menuVw.Test;
            // _dActArr[(byte)EVwAct.PlayP1] = _playVw.P1;
            // _dActArr[(byte)EVwAct.PlayP2] = _playVw.P2;
        }
    }
}