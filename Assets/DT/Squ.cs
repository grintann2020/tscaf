using T;

namespace DT {

    public class Squ : Blk {

        public Squ[] AdjArr { get { return _adjArr; } }
        public Squ N { get { return _adjArr[0]; } set { _adjArr[0] = value; } }
        public Squ S { get { return _adjArr[1]; } set { _adjArr[1] = value; } }
        public Squ W { get { return _adjArr[2]; } set { _adjArr[2] = value; } }
        public Squ E { get { return _adjArr[3]; } set { _adjArr[3] = value; } }
        public Squ NW { get { return _adjArr[4]; } set { _adjArr[4] = value; } }
        public Squ NE { get { return _adjArr[5]; } set { _adjArr[5] = value; } }
        public Squ SW { get { return _adjArr[6]; } set { _adjArr[6] = value; } }
        public Squ SE { get { return _adjArr[7]; } set { _adjArr[7] = value; } }
        private Squ[] _adjArr;

        public Squ(SGrid3 grid, SCoord3 coord) {
            _grid = grid;
            _coord = coord;
            _adjArr = new Squ[] {
                null, null, null, null, null, null, null, null,
            };
        }
    }
}