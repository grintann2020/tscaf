using UnityEngine;
using T;

namespace DT {

    public class StgCam : Cam, ICam {

        public SCoord3 Origin { get { return _origin; } }
        public SCoord3 _origin;
        public Vector3 tV3;

        public StgCam() {
            Debug.Log("StgCam StgCam StgCam");
            DefSetup = new SOrient3(new SCoord3(0.0f, 0.0f, 0.0f), new SCoord3(0.0f, 10.0f, 0.0f));
        }
    }
}