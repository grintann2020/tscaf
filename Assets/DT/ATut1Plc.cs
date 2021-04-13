using T;

namespace DT {

    public class ATut1Plc<T> : Plc<T>, IPlc {

        private SquSpc<T> _squSpc;

        public ATut1Plc(ISpc<T> iSpc) : base(iSpc) {
        // public ATut1Plc() {
            
        }
    }
}