namespace T {

    public interface IPlc {

        ushort Rows { get; }
        ushort Cols { get; }
        bool[][] BoolArr { get; }
        ushort[][] ObjArr { get; }
        void SetDef();
        void Constr();
        void Estb();
        void Elim();
    }
}