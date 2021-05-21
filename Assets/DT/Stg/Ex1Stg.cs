using System;
using UnityEngine;
using T;

namespace DT {

    public class Ex1Stg : Stg, IStg {
        
        public enum EPrcs : byte {
            TT1, End
        }

        public enum ECond : byte {
            ABC 
        }

        private bool _isEnd = false;

        public Ex1Stg() {
            _dBgnArr = new _dBgn[Enum.GetNames(typeof(EPrcs)).Length];
            _dBgnArr[(byte)EPrcs.TT1] = Bgn1;
            _dBgnArr[(byte)EPrcs.End] = EndEnd;

            _dUpdArr = new _dUpd[Enum.GetNames(typeof(EPrcs)).Length];
            _dUpdArr[(byte)EPrcs.TT1] = null;
            _dUpdArr[(byte)EPrcs.End] = null;

            _dCondArr = new _dCond[Enum.GetNames(typeof(ECond)).Length];
            _dCondArr[(byte)ECond.ABC] = ABC;

            _prcsArr = new byte[Enum.GetNames(typeof(EPrcs)).Length][][];
            _prcsArr[(byte)EPrcs.TT1] = new byte[1][] {
                new byte [PR] {(byte)ECond.ABC, (byte)EPrcs.End},
            };
            _prcsArr[(byte)EPrcs.End] = new byte[0][];
            // Debug.Log("ATut1Stg() -- Constructor");
        }

        public override void Imp() {
            base.Imp();
        }

        private void Bgn1() {
            _isEnd = true;
            Debug.Log("---------- ATut0Stg -- Bgn1() ----------");
        }

        private void EndEnd() {
            Debug.Log("---------- ATut0Stg -- Total End ----------");
        }

        private bool ABC() {
            return _isEnd;
        }
    }
}