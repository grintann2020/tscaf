using UnityEngine;
using System.Collections.Generic;

namespace T {

    public class Cam {

        public SOrientC3 DefOrient {
            get { return _defOrient; }
            protected set { _defOrient = value; }
        }
        private SOrientC3 _defOrient;
        // private List<SOrientC3> _orientLis;

        public Cam() {
            Debug.Log("Cam Cam Cam");
            // _orientLis = new List<SOrientC3>();
        }
    }
}