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
                        return new DT.PgmGrp();
                    case EGame.Robot:
                        return new Robot.PgmGrp();
                    default:
                        return new DT.PgmGrp();
                }
            }
        }
    }
}