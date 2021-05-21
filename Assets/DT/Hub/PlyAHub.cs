using System;
using UnityEngine;
using T;

namespace DT {

    public class PlyAHub : Hub, IHub {

        public enum EAct {
            AAct0, AAct1, AAct2,
        }

        public enum EGO {
            A1, A2, A3
        }

        public enum EVal {
            VA1, VA2, VA3, VA4, VA5,
        }

        public PlyAHub() {
            _goArr = new GameObject[Enum.GetNames(typeof(EGO)).Length];
            _valArr = new object[Enum.GetNames(typeof(EVal)).Length];
            _actArr = new _dAct[Enum.GetNames(typeof(EAct)).Length];
            _actArr[(byte)EAct.AAct0] = AAct0;
            _actArr[(byte)EAct.AAct1] = AAct1;
            _actArr[(byte)EAct.AAct2] = AAct2;
        }

        public void AAct0() {

        }

        public void AAct1() {

        }

        public void AAct2() {

        }
    }
}