using System;
using UnityEngine;

namespace T {

    [CreateAssetMenu(fileName = "ScrRezSO", menuName = "ScriptableObject/ScrRezSO", order = 0)]
    public class ScrRezSO : ScriptableObject {

        [HideInInspector] public float ScrWd { get { return Screen.width; } }
        [HideInInspector] public float ScrHt { get { return Screen.height; } }
        [HideInInspector]
        public float AR { // aspect ratio
            get {
                if (ScrWd > ScrHt) {
                    _isPortrait = false;
                    return (float)Math.Round((ScrHt / ScrWd), 6);
                } else {
                    _isPortrait = true;
                    return (float)Math.Round((ScrWd / ScrHt), 6);
                }
            }
        }
        public int Long { set { _long = (ushort)Math.Abs(value); } }
        public int Short { set { _short = (ushort)Math.Abs(value); } }
        public int Wd {
            get { return (int)Math.Round((_isPortrait ? _long : _short) * AR); }
        }
        public int Ht {
            get { return (int)Math.Round((_isPortrait ? _short : _long) * AR); }
        }
        private ushort _long = 0;
        private ushort _short = 0;
        private bool _isPortrait = false;
    }
}