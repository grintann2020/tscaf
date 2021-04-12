namespace T {

    public struct SGrid2 {

        public ushort Row, Col;

        public SGrid2(ushort row, ushort col) {
            Row = row;
            Col = col;
        }
    }

    public struct SGrid3 {

        public ushort Row, Col, Lay;

        public SGrid3(ushort row, ushort col, ushort lay) {
            Row = row;
            Col = col;
            Lay = lay;
        }
    }
}