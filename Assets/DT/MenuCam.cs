using T;

namespace DT {

    public class MenuCam : ICam {

        public SCoord3 Origin { get { return _origin; } }
        public SCoord3 _origin;
    }
}