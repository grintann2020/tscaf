using System;
using T;

namespace DT {

    // public enum ESquSpc : byte {
    //     SquA
    // }

    // public enum EHexSpc : byte {
    //     HexA
    // }

    public enum EPlc : byte {
        ATut0, ATut1, XHex1
    }

    public class PlcPrm : IPlcPrm { // place prime
        
        // public ISpc<Squ>[] ISquSpcArr { get { return _iSquSpcArr; } }
        // public ISpc<Hex>[] IHexSpcArr { get { return _iHexSpcArr; } }
        public IPlc[] IPlcArr { get { return _iPlcArr; } }
        // private ISpc<Squ>[] _iSquSpcArr = new ISpc<Squ>[Enum.GetNames(typeof(ESquSpc)).Length];
        // private ISpc<Hex>[] _iHexSpcArr = new ISpc<Hex>[Enum.GetNames(typeof(EHexSpc)).Length];
        private IPlc[] _iPlcArr = new IPlc[Enum.GetNames(typeof(EPlc)).Length];

        public PlcPrm() {
            // _iSquSpcArr[(byte)ESquSpc.SquA] = new SquSpc<Squ>(new SquCalc(), 1);
            // _iHexSpcArr[(byte)EHexSpc.HexA] = new HexSpc<Hex>(new HexCalc(), 1); // For Test
            ISpc<Squ> iSquSpc = new SquSpc<Squ>(new SquCalc(), 1);
            ISpc<Hex> iHexSpc = new HexSpc<Hex>(new HexCalc(), 1); // For Test
            _iPlcArr[(byte)EPlc.ATut0] = new ATut0Plc<Squ>(iSquSpc);
            _iPlcArr[(byte)EPlc.ATut1] = new ATut0Plc<Squ>(iSquSpc);
            _iPlcArr[(byte)EPlc.XHex1] = new ATut0Plc<Hex>(iHexSpc);
        }
    }
}