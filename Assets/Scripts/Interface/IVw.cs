using UnityEngine;

namespace T {

    public interface IVw {

        void SetCam(Camera cam);
        void SetDef();
        void SetPrj(SCamPrj sCamPrj);
        void SetOrnt(SOrnt3 ornt);
        void Act(byte act);

        // extends
        void InvkUpd();
    }
}