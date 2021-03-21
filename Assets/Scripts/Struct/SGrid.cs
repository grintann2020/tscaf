namespace T {

    public struct SGrid2 {

        public int Row;
        public int Col;

        public SGrid2(int row, int col) {
            Row = row;
            Col = col;
        }
    }

    public struct SGrid3 {

        public int Row;
        public int Col;
        public int Lay;

        public SGrid3(int row, int col, int lay) {
            Row = row;
            Col = col;
            Lay = lay;
        }
    }
}