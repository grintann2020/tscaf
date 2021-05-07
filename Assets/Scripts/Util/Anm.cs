namespace T {

    public static class Anm {

        public static SCoord3[] Trk(SCoord3 a, SCoord3 b, ushort s) {
            SCoord3[] arr = new SCoord3[s];
            float x = (b.X - a.X) / s;
            float y = (b.Y - a.Y) / s;
            float z = (b.Z - a.Z) / s;
            for (ushort c = 0; c < s; c++) {
                arr[c] = new SCoord3((x * c) + a.X, (y * c) + a.Y, (z * c) + a.Z);
            }
            return arr;
        }

        public static SCoord3[][] Trk2(SCoord3 a1, SCoord3 b1, SCoord3 a2, SCoord3 b2, ushort s) {
            SCoord3[][] arr = new SCoord3[s][];
            float x1 = (b1.X - a1.X) / s;
            float y1 = (b1.Y - a1.Y) / s;
            float z1 = (b1.Z - a1.Z) / s;
            float x2 = (b2.X - a2.X) / s;
            float y2 = (b2.Y - a2.Y) / s;
            float z2 = (b2.Z - a2.Z) / s;
            for (ushort c = 0; c < s; c++) {
                arr[c] = new SCoord3[2] {
                    new SCoord3((x1 * c) + a1.X, (y1 * c) + a1.Y, (z1 * c) + a1.Z),
                    new SCoord3((x2 * c) + a2.X, (y2 * c) + a2.Y, (z2 * c) + a2.Z)
                };
            }
            return arr;
        }
    }
}