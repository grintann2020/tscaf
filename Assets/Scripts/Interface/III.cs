using System;

namespace T {

    public interface III { // interactive input

        byte EII { get; }
        void Instl();
        void Invk(byte eEvt, Action rct);
        void Waiv(byte eEvt, Action rct);
        void InvkUpd();
    }
}