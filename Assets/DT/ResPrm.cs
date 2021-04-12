using System;
using UnityEngine;
using T;

namespace DT {

    public enum ERes : byte {
        // Squ, Hex
    }

    public class ResPrm : IResPrm {
        
        // public IRes[] IResArr { get { return _iResArr; } }
        // private IRes[] _iResArr = new IRes[Enum.GetNames(typeof(ERes)).Length];

        private Sprite[] _sprArr;

        public ResPrm() {

        }
    }
}