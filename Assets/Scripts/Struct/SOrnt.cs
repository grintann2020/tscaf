using System;

namespace T {

    public struct SOrnt2 {

        public SCoord2 A, B;
        public float DistX { get { return B.X - A.X; } }
        public float DistY { get { return B.Y - A.Y; } }
        public float Dist {
            get { return (float)Math.Sqrt(Math.Pow(DistX, 2) + Math.Pow(DistY, 2)); }
        }

        public SOrnt2(SCoord2 a, SCoord2 b) {
            A = a;
            B = b;
        }
    }

    public struct SOrnt3 {

        public SCoord3 A, B;
        public float DistX { get { return B.X - A.X; } }
        public float DistY { get { return B.Y - A.Y; } }
        public float DistZ { get { return B.Z - A.Z; } }
        public float Dist {
            get { return (float)Math.Sqrt(Math.Pow(DistX, 2) + Math.Pow(DistY, 2) + Math.Pow(DistZ, 2)); }
        }

        public SOrnt3(SCoord3 a, SCoord3 b) {
            A = a;
            B = b;
        }
    }
}