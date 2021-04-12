using System;
using T;

namespace DT {

    public enum ESpc : byte {
        Squ, Hex
    }

    public enum EPlc : byte {
        ATut00, ATut01
    }

    public class PlcPrm : IPlcPrm {
        
        public ISpc[] ISpcArr { get { return _iSpcArr; } }
        public IPlc[] IPlcArr { get { return _iPlcArr; } }
        private ISpc[] _iSpcArr = new ISpc[Enum.GetNames(typeof(ESpc)).Length];
        private IPlc[] _iPlcArr = new IPlc[Enum.GetNames(typeof(EPlc)).Length];

        public PlcPrm() {
            _iSpcArr[(byte)ESpc.Squ] = new SquSpc();
            _iSpcArr[(byte)ESpc.Hex] = new HexSpc(); // For Test
            _iPlcArr[(byte)EPlc.ATut00] = new ATut0Plc(_iSpcArr[(byte)ESpc.Squ]);
            _iPlcArr[(byte)EPlc.ATut01] = new ATut1Plc(_iSpcArr[(byte)ESpc.Squ]);
        }
    }
}