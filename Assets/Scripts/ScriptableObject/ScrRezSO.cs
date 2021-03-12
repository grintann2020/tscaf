using System;
using UnityEngine;

namespace T {

    [CreateAssetMenu(fileName = "ScreenResolution", menuName = "ScriptableObject/ScreenResolution", order = 0)]
    public class ScrRezSO : ScriptableObject {

        public ushort Long = 0; // long side length
        public ushort Short = 0; // short side length

        public bool IsPortrait { // is portrait or landscape
            get { return Screen.height > Screen.width; }
        }

        public float Ratio { // aspect ratio
            get { return (float)Screen.height / (float)Screen.width; } // e.g. 9:16 = 0.5625
        }

        public int Wd { // width
            get { return IsPortrait ? Short : Long; }
        }

        public int Ht { // height
            get { return (int)Math.Floor(Wd * Ratio) - ((int)Math.Floor(Wd * Ratio) % 2 == 0 ? 0 : 1); }
        }
    }
}