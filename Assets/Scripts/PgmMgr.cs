using System;
using UnityEngine;

namespace T {

    public class PgmMgr : Singleton<PgmMgr> {

        private IPgm[] _iPgmArr;
        private IPgm _iCurrPgm;

        public void Bind(IPgmPrm iPgmPrm) {
            _iPgmArr = iPgmPrm.IPgmArr;
        }

        public void Init() {
            _iCurrPgm = null;
        }

        public void InvokeUpd() {
            if (_iCurrPgm != null) {
                _iCurrPgm.InvokeUpd();
            }
        }

        public void Exe(byte ePgm) { // excute specific program by Enum
            if (Array.IndexOf(_iPgmArr, ePgm) == -1) {
                Debug.LogError("PgmMgr Exe( ) -- (byte)ePgm = " + ePgm + " is not included");
                return;
            }
            if (_iCurrPgm != null) {
                if (_iPgmArr[ePgm] == _iCurrPgm) {
                    return;
                }
                _iCurrPgm.End();
            }
            _iCurrPgm = _iPgmArr[ePgm];
            _iCurrPgm.Exe();
        }

        public void Exe(IPgm iPgm) { // excute specific program by interface
            if (_iCurrPgm != null) {
                if (iPgm == _iCurrPgm) {
                    return;
                }
                _iCurrPgm.End();
            }
            _iCurrPgm = iPgm;
            _iCurrPgm.Exe();
        }

        public void Next() { // end current program and excute next program
            if (_iCurrPgm != null && _iCurrPgm.Next != null) {
                _iCurrPgm.End();
                _iCurrPgm = _iCurrPgm.Next;
                _iCurrPgm.Exe();
            }
        }
    }
}