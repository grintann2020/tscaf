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

    public class LangPrm : ILangPrm {

        public object[][][] TermArr { get { return _termArr; } }
        private object[][][] _termArr = new object[Enum.GetNames(typeof(ETerm)).Length][][];

        public LangPrm() {
            float stampA = UnityEngine.Time.realtimeSinceStartup;
            _termArr[(ushort)ETerm.Zero_U] = new object[][] { new object[] { ELang.EN, "ZERO" }, new object[] { ELang.ZH_CN, "零" }, new object[] { ELang.ZH_TW, "零" } };
            _termArr[(ushort)ETerm.One_U] = new object[][] { new object[] { ELang.EN, "ONE" }, new object[] { ELang.ZH_CN, "壹" }, new object[] { ELang.ZH_TW, "壹" } };
            _termArr[(ushort)ETerm.Two_U] = new object[][] { new object[] { ELang.EN, "TWO" }, new object[] { ELang.ZH_CN, "贰" }, new object[] { ELang.ZH_TW, "貳" } };
            _termArr[(ushort)ETerm.Three_U] = new object[][] { new object[] { ELang.EN, "THREE" }, new object[] { ELang.ZH_CN, "叁" }, new object[] { ELang.ZH_TW, "參" } };
            _termArr[(ushort)ETerm.Zero_U] = new object[][] { new object[] { ELang.EN, "FOUR" }, new object[] { ELang.ZH_CN, "肆" }, new object[] { ELang.ZH_TW, "肆" } };
            _termArr[(ushort)ETerm.One_U] = new object[][] { new object[] { ELang.EN, "FIVE" }, new object[] { ELang.ZH_CN, "伍" }, new object[] { ELang.ZH_TW, "伍" } };
            _termArr[(ushort)ETerm.Two_U] = new object[][] { new object[] { ELang.EN, "SIX" }, new object[] { ELang.ZH_CN, "陆" }, new object[] { ELang.ZH_TW, "陸" } };
            _termArr[(ushort)ETerm.Three_U] = new object[][] { new object[] { ELang.EN, "SEVEN" }, new object[] { ELang.ZH_CN, "柒" }, new object[] { ELang.ZH_TW, "柒" } };
            _termArr[(ushort)ETerm.Three_U] = new object[][] { new object[] { ELang.EN, "EIGHT" }, new object[] { ELang.ZH_CN, "捌" }, new object[] { ELang.ZH_TW, "捌" } };
            _termArr[(ushort)ETerm.Three_U] = new object[][] { new object[] { ELang.EN, "NINE" }, new object[] { ELang.ZH_CN, "玖" }, new object[] { ELang.ZH_TW, "玖" } };
            _termArr[(ushort)ETerm.Three_U] = new object[][] { new object[] { ELang.EN, "TEN" }, new object[] { ELang.ZH_CN, "拾" }, new object[] { ELang.ZH_TW, "拾" } };

            // _termArr[(ushort)ETerm.Zero_L] = new string[] { "zero", "〇", "〇" };
            // _termArr[(ushort)ETerm.One_L] = new string[] { "one", "一", "一" };
            // _termArr[(ushort)ETerm.Two_L] = new string[] { "two", "二", "二" };
            // _termArr[(ushort)ETerm.Three_L] = new string[] { "three", "三", "三" };
            // _termArr[(ushort)ETerm.Four_L] = new string[] { "four", "四", "四" };
            // _termArr[(ushort)ETerm.Five_L] = new string[] { "five", "五", "五" };
            // _termArr[(ushort)ETerm.Six_L] = new string[] { "six", "六", "六" };
            // _termArr[(ushort)ETerm.Seven_L] = new string[] { "seven", "七", "七" };
            // _termArr[(ushort)ETerm.Eight_L] = new string[] { "eight", "八", "八" };
            // _termArr[(ushort)ETerm.Nine_L] = new string[] { "nine", "九", "九" };
            // _termArr[(ushort)ETerm.Ten_L] = new string[] { "ten", "十", "十" };

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