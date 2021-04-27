namespace T {

    public interface ISS {

        ushort Rows { get; }
        ushort Cols { get; }
        ushort[][] ObjArr { get; }
        // void SetDef();
        void Constr();
        void Estb();
        void Elim();
    }
}