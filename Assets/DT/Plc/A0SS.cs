using T;

namespace DT {

    public class A0SS : SS, ISS {

        private const ushort DEF_ROWS = 6;
        private const ushort DEF_COLS = 6;

        // public A0SS(ISpc iSpc) : base(iSpc) {
        public A0SS() {
            // _defBoolArr = new bool[DEF_ROWS][];
            // _defBoolArr[0] = new bool[DEF_COLS] { true, true, true, true, true, true };
            // _defBoolArr[1] = new bool[DEF_COLS] { false, true, true, true, true, true };
            // _defBoolArr[2] = new bool[DEF_COLS] { false, true, true, true, true, true };
            // _defBoolArr[3] = new bool[DEF_COLS] { true, true, true, true, true, true };
            // _defBoolArr[4] = new bool[DEF_COLS] { true, true, true, true, true, true };
            // _defBoolArr[5] = new bool[DEF_COLS] { true, true, true, true, true, true };
            // _boolArr = _defBoolArr;

            _objArr = new ushort[DEF_ROWS][];
            _objArr[0] = new ushort[DEF_COLS] { 1, 1, 1, 1, 1, 1 };
            _objArr[1] = new ushort[DEF_COLS] { 1, 1, 1, 1, 1, 1 };
            _objArr[2] = new ushort[DEF_COLS] { 1, 1, 1, 1, 1, 1 };
            _objArr[3] = new ushort[DEF_COLS] { 1, 1, 1, 1, 1, 1 };
            _objArr[4] = new ushort[DEF_COLS] { 1, 1, 1, 1, 1, 1 };
            _objArr[5] = new ushort[DEF_COLS] { 1, 1, 1, 1, 1, 1 };
            // _objArr = _objArr;
        }
    }
}