using UnityEngine;

namespace T {

    public interface IVw {

        void SetCam(Camera cam);
        void SetPrj(SCamPrj sCamPrj);
        void Act(byte act);

        // extends
        void InvkUpd();
    }
}