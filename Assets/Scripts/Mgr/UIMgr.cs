using UnityEngine;

namespace T {

    public class UIMgr : Sgltn<UIMgr> {

        private IUI[] _iUIArr;

        public void Bind(IUIPrm iUIPrm) {
            _iUIArr = iUIPrm.IUIArr;
        }

        public void Init() {

        }

        public void SetCanv(byte eUI, Canvas canv) {
            _iUIArr[eUI].SetCanv(canv);
        }

        public IUI GetUI(byte eUI) {
            return _iUIArr[eUI];
        }

        public void Instl(byte eUI) {
            _iUIArr[eUI].Instl();
        }

        public void Unstl(byte eUI) {
            _iUIArr[eUI].Unstl();
        }
    }
}