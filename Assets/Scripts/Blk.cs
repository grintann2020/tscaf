namespace T {

    public class Blk {

        public SGrid3 Grid { get { return _grid; } }
        public SCoord3 Coord { get { return _coord; } }
        public int Row { get { return _grid.Row; } }
        public int Col { get { return _grid.Col; } }
        public float X { get { return _coord.X; } }
        public float Z { get { return _coord.Z; } }
        public float Y { get { return _coord.Y; } }
        protected SGrid3 _grid;
        protected SCoord3 _coord;
    }
}