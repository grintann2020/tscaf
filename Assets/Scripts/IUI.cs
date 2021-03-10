namespace T {

    public interface IUI : IUI {

        void Bind(UIMgr mgr);
        void Init();
        void Clear();
        void InvokeUpd();
    }
}