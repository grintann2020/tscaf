using System;
using T;

namespace DT {

    public enum ESpc : byte {
        Squ, Hex
    }

    public class SpcPrm : ISpcPrm {
        
        public ISpc[] ISpcArr { get { return _iSpcArr; } }
        private ISpc[] _iSpcArr = new ISpc[Enum.GetNames(typeof(ESpc)).Length];

        public SpcPrm() {
            _iSpcArr[(byte)ESpc.Squ] = new SquSpc();
            _iSpcArr[(byte)ESpc.Hex] = new HexSpc(); // For Test
        }
    }
}