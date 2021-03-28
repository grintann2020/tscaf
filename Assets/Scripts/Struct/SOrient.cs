using System;

namespace T {

    public struct SOrient2 {

        public SCoord2 A;
        public SCoord2 B;
        public float DistX { get { return B.X - A.X; } }
        public float DistY { get { return B.Y - A.Y; } }
        public float Dist {
            get { return (float)Math.Sqrt(Math.Pow(DistX, 2) + Math.Pow(DistY, 2)); }
        }

        public SOrient2(SCoord2 a, SCoord2 b) {
            A = a;
            B = b;
        }

        public SOrient2(SGrid2 a, SGrid2 b) {
            A = new SCoord2(a.Row, a.Col);
            B = new SCoord2(b.Row, b.Col);
        }
    }

    public struct SOrient3 {

        public SCoord3 A;
        public SCoord3 B;
        public float DistX { get { return B.X - A.X; } }
        public float DistY { get { return B.Y - A.Y; } }
        public float DistZ { get { return B.Z - A.Z; } }
        public float Dist {
            get { return (float)Math.Sqrt(Math.Pow(DistX, 2) + Math.Pow(DistY, 2) + Math.Pow(DistZ, 2)); }
        }

        public SOrient3(SCoord3 a, SCoord3 b) {
            A = a;
            B = b;
        }

        public SOrient3(SGrid3 a, SGrid3 b) {
            A = new SCoord3(a.Row, a.Col, a.Lay);
            B = new SCoord3(b.Row, b.Col, b.Lay);
        }
    }
}