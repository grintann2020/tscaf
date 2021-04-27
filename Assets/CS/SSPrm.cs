using System;
using T;

namespace CS {

    public enum ESS : byte {
        CS01, CS02
    }

    public class SSPrm : ISSPrm { // place prime

        public ISS[] ISSArr { get { return _iSSArr; } }
        private ISS[] _iSSArr = new ISS[Enum.GetNames(typeof(ESS)).Length];


        public SSPrm() {

        }
    }
}