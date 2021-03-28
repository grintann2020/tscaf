using UnityEngine;
using System.Collections.Generic;

namespace T {

    public class Cam {

        public SOrient3 DefSetup {
            get {
                if (_setupLis.Count == 0) {
                    _setupLis.Add(new SOrient3());
                } 
                return _setupLis[0]; }
            protected set {
                if (_setupLis.Count == 0) {
                    _setupLis.Add(new SOrient3());
                } 
                _setupLis[0] = value; }
        }
        private SOrient3 _defSetup;
        private List<SOrient3> _setupLis;

        public Cam() {
            Debug.Log("Cam Cam Cam");
            _setupLis = new List<SOrient3>();
        }
    }
}