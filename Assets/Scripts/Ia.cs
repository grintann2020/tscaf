namespace T {

    public class Ia {

        public bool IsEnbl { get { return _isEnbl; } }
        protected III[] _iIIArr;
        private bool _isEnbl;

        public Ia(III[] iIIArr) {
            _iIIArr = iIIArr;
        }

        public virtual void Enbl() {
            for (byte i = 0; i < _iIIArr.Length; i++) {
                _iIIArr[i].Enbl();
            }
        }

        public virtual void Dsbl() {
            for (byte i = 0; i < _iIIArr.Length; i++) {
                _iIIArr[i].Dsbl();
            }
        }

        public void InvkUpd() {
            if (_isEnbl == false) {
                return;
            }
            for (byte i = 0; i < _iIIArr.Length; i++) {
                _iIIArr[i].InvkUpd();
            }
        }
    }
}