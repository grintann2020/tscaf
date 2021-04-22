using UnityEngine;

namespace T {

    public interface IUI {

        void SetCanv(Canvas canv);
        void Instl(); // install
        void Unstl(); // uninstall
        // void Rst(); // reset
        // void InvkUpd();
    }
}