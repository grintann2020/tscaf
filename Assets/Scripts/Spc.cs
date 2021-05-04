namespace T {

    public class Spc {

        public byte[][][] DflArr { get { return _dflArr; } }
        public byte[][][] CurArr { get { return _curArr; } }
        protected delegate void _dAlt();
        protected _dAlt[] _dAltArr;
        protected string[][] _uArr;
        protected byte[][][] _dflArr;
        protected byte[][][] _curArr;
        protected IBlk[][][] _iBlkArr;
        protected ISS _iSS;


        public Spc(ISS iSS) {
            _iSS = iSS;
        }

        public void Dfl() {
            _curArr = _dflArr;
        }

        public void Alt(byte eAlt) {
            _dAltArr[eAlt].Invoke();
        }

        public void Cnstr(SCoord3 ctr) {
            _iBlkArr = _iSS.Cnstr(_curArr, ctr);
        }

        public void Estb() {
            _iSS.Estb(_iBlkArr, _uArr);
        }

        public void Elim() {

        }
    }
}