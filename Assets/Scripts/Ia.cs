namespace T {

    public class Ia {

        public bool IsInstl { get { return _isInstl; } }
        protected III[] _iIIArr;
        private bool _isInstl;

        public Ia(III[] iIIArr) {
            _iIIArr = iIIArr;
        }

        public virtual void Instl() {
            _isInstl = true;
        }

        public virtual void Unstl() {
            _isInstl = false;
        }

        public void InvkUpd() {
            if (_isInstl == false) {
                return;
            }
            for (byte i = 0; i < _iIIArr.Length; i++) {
                _iIIArr[i].InvkUpd();
            }
        }
    }
}