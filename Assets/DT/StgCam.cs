using UnityEngine;
using T;

namespace DT {

    public class StgCam : Cam, ICam {

        public StgCam() {
            Debug.Log("StgCam StgCam StgCam");
            DefOrient = new SOrientC3(new SCoord3(0.0f, 0.0f, 0.0f), new SCoord3(0.0f, 10.0f, 0.0f));
        }
    }
}