namespace T {

    public interface IPgm {

        IPgm Next { get; set; }
        void InvokeUpd();
        void Exe();
        void End();
    }
}
