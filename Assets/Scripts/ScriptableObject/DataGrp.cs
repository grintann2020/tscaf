using UnityEngine;
using DT;
using Robot;

namespace T {
    
    [CreateAssetMenu(fileName = "DataGrp", menuName = "ScriptableObject/DataGroup", order = 0)]
    public class DataGrp : ScriptableObject {

        public EGame EGame;

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