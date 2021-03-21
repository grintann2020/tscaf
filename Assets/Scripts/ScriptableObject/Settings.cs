using UnityEngine;
using DT;
using Robot;

namespace T {
    
    [CreateAssetMenu(fileName = "Settings", menuName = "ScriptableObject/Settings", order = 0)]
    public class Settings : ScriptableObject {

        public EGame EGame;
        public ScrRez ScrRez;

        public IPgmGrp IPgmGrp {
            get {
                switch (EGame) {
                    case EGame.DoubleTrap:
                        return new PgmGrp_DT();
                    case EGame.Robot:
                        return new PgmGrp_Robot();
                    default:
                        return new PgmGrp_DT();
                }
            }
        }
    }
}