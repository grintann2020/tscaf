using T;

namespace DT {

    public class ATut0Plc<T> : Plc<T>, IPlc {

        private SquSpc<T> _squSpc;

        public ATut0Plc(ISpc<T> iSpc) : base(iSpc) {
        // public ATut0Plc() {

        }
    }
}