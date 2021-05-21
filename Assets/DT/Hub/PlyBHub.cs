using System;
using UnityEngine;
using T;

namespace DT {

    public class PlyBHub : Hub, IHub {

        public enum EAct {
            BAct0, BAct1, BAct2,
        }

        public enum EGO {
            B1, B2, B3
        }

        public enum EVal {
            VB1, VB2, VB3, VB4, VB5,
        }

        public PlyBHub() {
            _goArr = new GameObject[Enum.GetNames(typeof(EGO)).Length];
            _valArr = new object[Enum.GetNames(typeof(EVal)).Length];
            _actArr = new _dAct[Enum.GetNames(typeof(EAct)).Length];
            _actArr[(byte)EAct.BAct0] = BAct0;
            _actArr[(byte)EAct.BAct1] = BAct1;
            _actArr[(byte)EAct.BAct2] = BAct2;
        }

        public void BAct0() {

        }

        public void BAct1() {

        }

        public void BAct2() {

        }
    }
}