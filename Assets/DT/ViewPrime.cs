using System;
using T;

namespace DT {

    public enum EView : byte {
        Menu, Play
    }

    public enum ECamProj : byte {
        Menu, Play
    }

    public class ViewPrime : IViewPrime {

        public IView[] IViewArr { get { return _iViewArr; } }
        public SCamProj[] SCamProjArr { get { return _sCamProjArr; } }
        private IView[] _iViewArr = new IView[Enum.GetNames(typeof(EView)).Length];
        private SCamProj[] _sCamProjArr = new SCamProj[Enum.GetNames(typeof(ECamProj)).Length];
        // view objects
        private MenuView _menuView = new MenuView();
        private PlayView _playView = new PlayView();
        // camera projection objects
        private SCamProj _menuCamProj = new SCamProj(true, 20.0f, float.NaN, false, 0.3f, 1000.0f);
        private SCamProj _playCamProj = new SCamProj(false, float.NaN, 40, false, 0.3f, 1000.0f);

        public ViewPrime() {
            _iViewArr[(byte)EView.Menu] = _menuView;
            _iViewArr[(byte)EView.Play] = _playView;
            _sCamProjArr[(byte)ECamProj.Menu] = _menuCamProj;
            _sCamProjArr[(byte)ECamProj.Play] = _playCamProj; 
        }
    }
}