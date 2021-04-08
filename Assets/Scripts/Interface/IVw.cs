using System.Collections.Generic;
using UnityEngine;

namespace T {

    public interface IVw {

        void SetCam(Camera cam);
        void SetCamProj(SCamProj sCamProj);
    }
}