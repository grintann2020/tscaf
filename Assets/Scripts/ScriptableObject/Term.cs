using System;
using UnityEngine;

namespace T {

    [CreateAssetMenu(fileName = "Term", menuName = "ScriptableObject/Term", order = 0)]
    public class Term : ScriptableObject {

        public ETerm ETerm;
        public string Txt;

    }
}