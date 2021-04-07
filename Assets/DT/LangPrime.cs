using System;
using UnityEngine;
using T;

namespace DT {

    public enum ETerm : ushort {
        Zero_U, One_U, Two_U, Three_U, Four_U, Five_U, Six_U, Seven_U, Eight_U, Nine_U, Ten_U,
        Zero_L, One_L, Two_L, Three_L, Four_L, Five_L, Six_L, Seven_L, Eight_L, Nine_L, Ten_L,
        A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S,
        GrinBit,
        DoubleTrap,
        Test,
    }

    public class LangPrime : ILangPrime {

        public ELang[] LangArr { get {return _langArr; } }
        public string[][] TermArr { get { return _termArr; } }
        private ELang[] _langArr = new ELang[] {
            ELang.EN_US,
            ELang.ZH_CN,
            ELang.ZH_TW,
            ELang.KO,
        };
        private string[][] _termArr = new string[Enum.GetNames(typeof(ETerm)).Length][];

        public LangPrime() {
            float stampA = UnityEngine.Time.realtimeSinceStartup;
            // {EN_US, ZH_CN, ZH_TW, KO}
            _termArr[(ushort)ETerm.Zero_U] = new string[] { "ZERO", "零", "零" };
            _termArr[(ushort)ETerm.One_U] = new string[] { "ONE", "壹", "壹" };
            _termArr[(ushort)ETerm.Two_U] = new string[] { "TWO", "贰", "貳" };
            _termArr[(ushort)ETerm.Three_U] = new string[] { "THREE", "叁", "參" };
            _termArr[(ushort)ETerm.Four_U] = new string[] { "FOUR", "肆", "肆" };
            _termArr[(ushort)ETerm.Five_U] = new string[] { "FIVE", "伍", "伍" };
            _termArr[(ushort)ETerm.Six_U] = new string[] { "SIX", "陆", "陸" };
            _termArr[(ushort)ETerm.Seven_U] = new string[] { "SEVEN", "柒", "柒" };
            _termArr[(ushort)ETerm.Eight_U] = new string[] { "EIGHT", "捌", "捌" };
            _termArr[(ushort)ETerm.Nine_U] = new string[] { "NINE", "玖", "玖" };
            _termArr[(ushort)ETerm.Ten_U] = new string[] { "TEN", "拾", "拾" };

            _termArr[(ushort)ETerm.Zero_L] = new string[] { "zero", "〇", "〇" };
            _termArr[(ushort)ETerm.One_L] = new string[] { "one", "一", "一" };
            _termArr[(ushort)ETerm.Two_L] = new string[] { "two", "二", "二" };
            _termArr[(ushort)ETerm.Three_L] = new string[] { "three", "三", "三" };
            _termArr[(ushort)ETerm.Four_L] = new string[] { "four", "四", "四" };
            _termArr[(ushort)ETerm.Five_L] = new string[] { "five", "五", "五" };
            _termArr[(ushort)ETerm.Six_L] = new string[] { "six", "六", "六" };
            _termArr[(ushort)ETerm.Seven_L] = new string[] { "seven", "七", "七" };
            _termArr[(ushort)ETerm.Eight_L] = new string[] { "eight", "八", "八" };
            _termArr[(ushort)ETerm.Nine_L] = new string[] { "nine", "九", "九" };
            _termArr[(ushort)ETerm.Ten_L] = new string[] { "ten", "十", "十" };

            // _termArr = new string[Enum.GetNames(typeof(ETerm)).Length][];
            // _termArr[(ushort)ETerm.GrinBit] = new string[] { "Grin Bit", "Grin Bit" };
            // _termArr[(ushort)ETerm.DoubleTrap] = new string[] { "DoubleTrap", "雙重陷阱", "雙重陷阱" };
            // _termArr[(ushort)ETerm.Test] = new string[] { "Test", "測試", "測測" };

            // _termArr[10] = new string[] { 
            //     "TenTenTenTenTenTenTenTenTenTenTen",
            //     "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
            //     "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            // };
            // _termArr[11] = new string[] { 
            //     "TenTenTenTenTenTenTenTenTenTenTen",
            //     "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
            //     "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            // };
            // _termArr[12] = new string[] { 
            //     "TenTenTenTenTenTenTenTenTenTenTen",
            //     "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
            //     "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            // };
            // _termArr[13] = new string[] { 
            //     "TenTenTenTenTenTenTenTenTenTenTen",
            //     "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
            //     "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            // };
            // _termArr[14] = new string[] { 
            //     "TenTenTenTenTenTenTenTenTenTenTen",
            //     "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
            //     "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            // };
            // _termArr[15] = new string[] { 
            //     "TenTenTenTenTenTenTenTenTenTenTen",
            //     "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
            //     "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            // };
            // _termArr[16] = new string[] { 
            //     "TenTenTenTenTenTenTenTenTenTenTen",
            //     "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
            //     "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            // };
            // _termArr[17] = new string[] { 
            //     "TenTenTenTenTenTenTenTenTenTenTen",
            //     "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
            //     "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            // };
            // _termArr[18] = new string[] { 
            //     "TenTenTenTenTenTenTenTenTenTenTen",
            //     "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
            //     "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            // };
            // _termArr[19] = new string[] { 
            //     "TenTenTenTenTenTenTenTenTenTenTen",
            //     "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
            //     "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            // };
            // _termArr[20] = new string[] { 
            //     "TenTenTenTenTenTenTenTenTenTenTen",
            //     "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
            //     "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            // };

            float stampB = UnityEngine.Time.realtimeSinceStartup;
            // Debug.Log("time a -- " + stampA + " --> time b -- " + stampB + ", dur -- " + (double)(stampB - stampA));
        }
    }
}