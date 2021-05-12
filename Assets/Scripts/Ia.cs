namespace T {

    public class Ia {

        protected III[] _iIMArr;

        public Ia(III[] iIMArr) {
            _iIMArr = iIMArr;
        }

        public void InvkUpd() {
            for (byte i = 0; i < _iIMArr.Length; i++) {
                _iIMArr[i].InvkUpd();
            }
        }
    }
}