using System;
using UnityEngine;
using T;

namespace DT {

    public enum ETerm : ushort {
        GrinBit,
        DoubleTrap,
        Test,
        One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
        A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S
    }

    public class LangPrime : ILangPrime {

        public string[][] TermsArr { get { return _termsArr; } }
        private string[][] _termsArr = new string[Enum.GetNames(typeof(ETerm)).Length][];

        public LangPrime() {
            float stampA = UnityEngine.Time.realtimeSinceStartup;

            _termsArr[(ushort)ETerm.One] = new string[] { "One", "壹", "一" };
            _termsArr[(ushort)ETerm.Two] = new string[] { "Two", "貳", "二" };
            _termsArr[(ushort)ETerm.Three] = new string[] { "Three", "參", "三" };
            _termsArr[(ushort)ETerm.Four] = new string[] { "Four", "肆", "四" };
            _termsArr[(ushort)ETerm.Five] = new string[] { "Five", "伍", "五" };
            _termsArr[(ushort)ETerm.Six] = new string[] { "Six", "陸", "六" };
            _termsArr[(ushort)ETerm.Seven] = new string[] { "Seven", "柒", "七" };
            _termsArr[(ushort)ETerm.Eight] = new string[] { "Eight", "捌", "八" };
            _termsArr[(ushort)ETerm.Nine] = new string[] { "Nine", "玖", "九" };
            _termsArr[(ushort)ETerm.Ten] = new string[] { "Ten", "拾", "十" };

            // _termsArr = new string[Enum.GetNames(typeof(ETerm)).Length][];
            // _termsArr[(ushort)ETerm.GrinBit] = new string[] { "Grin Bit", "Grin Bit" };
            // _termsArr[(ushort)ETerm.DoubleTrap] = new string[] { "DoubleTrap", "雙重陷阱", "雙重陷阱" };
            // _termsArr[(ushort)ETerm.Test] = new string[] { "Test", "測試", "測測" };

            _termsArr[10] = new string[] { 
                "TenTenTenTenTenTenTenTenTenTenTen",
                "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
                "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            };
            _termsArr[11] = new string[] { 
                "TenTenTenTenTenTenTenTenTenTenTen",
                "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
                "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            };
            _termsArr[12] = new string[] { 
                "TenTenTenTenTenTenTenTenTenTenTen",
                "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
                "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            };
            _termsArr[13] = new string[] { 
                "TenTenTenTenTenTenTenTenTenTenTen",
                "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
                "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            };
            _termsArr[14] = new string[] { 
                "TenTenTenTenTenTenTenTenTenTenTen",
                "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
                "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            };
            _termsArr[15] = new string[] { 
                "TenTenTenTenTenTenTenTenTenTenTen",
                "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
                "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            };
            _termsArr[16] = new string[] { 
                "TenTenTenTenTenTenTenTenTenTenTen",
                "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
                "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            };
            _termsArr[17] = new string[] { 
                "TenTenTenTenTenTenTenTenTenTenTen",
                "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
                "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            };
            _termsArr[18] = new string[] { 
                "TenTenTenTenTenTenTenTenTenTenTen",
                "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
                "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            };
            _termsArr[19] = new string[] { 
                "TenTenTenTenTenTenTenTenTenTenTen",
                "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
                "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            };
            _termsArr[20] = new string[] { 
                "TenTenTenTenTenTenTenTenTenTenTen",
                "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
                "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            };

            float stampB = UnityEngine.Time.realtimeSinceStartup;
            // Debug.Log("time a -- " + stampA + " --> time b -- " + stampB + ", dur -- " + (double)(stampB - stampA));
        }
    }
}