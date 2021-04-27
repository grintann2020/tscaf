using System;
using T;

namespace DT {

    public enum ESS : byte {
        A0, A1, B0, B1
    }

    public class SSPrm : ISSPrm { // the prime of spatial structure

        public ISS[] ISSArr { get { return _iSSArr; } }
        private ISS[] _iSSArr = new ISS[Enum.GetNames(typeof(ESS)).Length];

        public SSPrm() {
            _iSSArr[(byte)ESS.A0] = new A0SS();
            _iSSArr[(byte)ESS.A1] = new A1SS();
        }
    }
}