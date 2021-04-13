using T;

namespace DT {

    public class Hex : Blk {

        public Hex[] AdjArr { get { return _adjArr; } }
        public Hex E { get { return this._adjArr[0]; } set { this._adjArr[0] = value; } }
        public Hex NE { get { return this._adjArr[1]; } set { this._adjArr[1] = value; } }
        public Hex NW { get { return this._adjArr[2]; } set { this._adjArr[2] = value; } }
        public Hex W { get { return this._adjArr[3]; } set { this._adjArr[3] = value; } }
        public Hex SW { get { return this._adjArr[4]; } set { this._adjArr[4] = value; } }
        public Hex SE { get { return this._adjArr[5]; } set { this._adjArr[5] = value; } }
        private Hex[] _adjArr;

        public Hex(SGrid3 grid, SCoord3 coord) {
            _grid = grid;
            _coord = coord;
            _adjArr = new Hex[] {
                null, null, null, null, null, null, null, null,
            };
        }
    }
}