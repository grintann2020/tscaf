using System;
using UnityEngine;

namespace T {

    public class II {

        protected delegate void _dDtc(Action rct);
        protected _dDtc[] _dDtcArr;
        protected Action[] _rctArr;

        public II() {
            // _isEnbl = false;
            // Debug.Log("II() -- ");
        }

        public virtual void Enbl() {
            _rctArr = new Action[_dDtcArr.Length];
            for (byte e = 0; e < _rctArr.Length; e++) {
                _rctArr[e] = () => { };
            }
            // Debug.Log("MusII() -- " + _rctArr.Length);
            // _isEnbl = true;
        }

        public virtual void Dsbl() {
            for (byte e = 0; e < _rctArr.Length; e++) {
                _rctArr[e] = null;
            }
            _rctArr = new Action[0];
            // _isEnbl = false;
        }

        public void Invk(byte eEvt, Action rct) {
            _rctArr[eEvt] += rct;
        }

        public void Waiv(byte eEvt, Action rct) {
            _rctArr[eEvt] -= rct;
        }

        public void InvkUpd() {
            // if (_isEnbl == false) {
            //     return;
            // }
            for (byte d = 0; d < _dDtcArr.Length; d++) {
                if (_dDtcArr[d] != null) {
                    _dDtcArr[d].Invoke(_rctArr[d]);
                }
            }
        }
    }
}