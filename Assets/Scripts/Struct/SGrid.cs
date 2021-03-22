namespace T {

    public struct SGrid2 {

        public ushort Row;
        public ushort Col;

        public SGrid2(ushort row, ushort col) {
            Row = row;
            Col = col;
        }
    }

    public struct SGrid3 {

        public ushort Row;
        public ushort Col;
        public ushort Lay;

        public SGrid3(ushort row, ushort col, ushort lay) {
            Row = row;
            Col = col;
            Lay = lay;
        }
    }
}