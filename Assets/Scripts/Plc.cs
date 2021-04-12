using UnityEngine;

namespace T {

    public class Plc {

        private ISpc _iSpc;

        public Plc(ISpc iSpc) {
            Debug.Log("Plc -- Contructor( ) -- " + iSpc);
            _iSpc = iSpc;
        }
    }
}