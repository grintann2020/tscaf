using System;
using UnityEngine;
using T;

namespace DT {

    public enum EIa : byte {
        A0, A1
    }

    public class IaPrm : IIaPrm {

        public IIa[] IIaArr { get { return _iIaArr; } }
        private IIa[] _iIaArr = new IIa[Enum.GetNames(typeof(EIa)).Length];
        private III _iMusII;
        private III _iKBII;

        public IaPrm() {
            _iMusII = new MusII();
            _iKBII = new KBII();
            _iIaArr[(byte)EIa.A0] = new A0Ia(new III[] { _iMusII, _iKBII });
            _iIaArr[(byte)EIa.A1] = new A1Ia(new III[] { _iKBII });
        }
    }
}