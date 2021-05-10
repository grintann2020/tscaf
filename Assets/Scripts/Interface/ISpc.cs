namespace T {

    public interface ISpc {

        bool IsCnstr { get; }
        bool IsEstb { get; }
        byte[][][] DflArr { get; }
        byte[][][] CurArr { get; }
        void Cnstr(SCoord3 ctr); // construct
        void Dcstr(); // deconstruct
        void Estb(); // establish
        void Elim(); // eliminate
        void Dfl(); // default
        void Alt(byte eAlt); // alter
    }
}