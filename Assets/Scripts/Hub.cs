using System;
using UnityEngine;

namespace T {

    public class Hub {

        public bool IsConn { get { return _isConn; } }
        protected delegate void _dAct();
        protected _dAct[] _actArr;
        protected GameObject[] _goArr;
        protected object[] _valArr;
        private bool _isConn;

        public virtual void Conn() {
            _isConn = true;
            RstArr();
        }

        public virtual void Dscn() {
            _isConn = false;
            RstArr();
        }

        public void InvkUpd() {
            if (_isConn == false) {
                return;
            }
        }

        public void Act(byte eAct) {
            _actArr[eAct]();
        }

        public void StGO(byte eGO, GameObject go) {
            _goArr[eGO] = go;
        }

        public GameObject GtGO(byte eGO) {
            return _goArr[eGO];
        }

        public void StVal<T>(byte eVal, T val) {
            _valArr[eVal] = val;
        }

        public T GtVal<T>(byte eVal) {
            return (T)_valArr[eVal];
        }

        private void RstArr() {
            for (byte g = 0; g < _goArr.Length; g++) {
                _goArr[g] = null;
            }
            for (byte v = 0; v < _valArr.Length; v++) {
                _valArr[v] = null;
            }
        }
    }
}