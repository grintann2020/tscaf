using System;
using UnityEngine;

namespace T {

    public class LangMgr : Singleton<LangMgr> {

        private ELang[] _langArr;
        private string[][] _termArr;
        private ELang _eCurrLang;
        private static ELang[] _sysLangArr = new ELang[] { // contrast system language
            ELang.AF, // Afrikaans = 0
            ELang.AR, // Arabic = 1
            ELang.EU, // Basque = 2
            ELang.BE, // Belarusian = 3
            ELang.BG, // Bulgarian = 4
            ELang.CA, // Catalan = 5
            ELang.ZH_CN, // Chinese = 6
            ELang.CS, // Czech = 7
            ELang.DA, // Danish = 8
            ELang.NL, // Dutch = 9
            ELang.EN_US, // English = 10
            ELang.ET, // Estonian = 11
            ELang.FO, // Faroese = 12
            ELang.FI, // Finnish = 13
            ELang.FR, // French = 14
            ELang.DE, // German = 15
            ELang.EL, // Greek = 16
            ELang.HE, // Hebrew = 17
            ELang.HU, // Hungarian = 18
            ELang.IS, // Icelandic = 19
            ELang.ID, // Indonesian = 20
            ELang.IT, // Italian = 21
            ELang.JA, // Japanese = 22
            ELang.KO, // Korean = 23
            ELang.LV, // Latvian = 24
            ELang.LT, // Lithuanian = 25
            ELang.NO, // Norwegian = 26
            ELang.PL, // Polish = 27
            ELang.PT, // Portuguese = 28
            ELang.RO, // Romanian = 29
            ELang.RU, // Russian = 30
            ELang.SH, // SerboCroatian = 31
            ELang.SK, // Slovak = 32
            ELang.SL, // Slovenian = 33
            ELang.ES, // Spanish = 34
            ELang.SV, // Swedish = 35
            ELang.TH, // Thai = 36
            ELang.TR, // Turkish = 37
            ELang.UK, // Ukrainian = 38
            ELang.VI, // Vietnamese = 39
            ELang.ZH_CN, // ChineseSimplified = 40
            ELang.ZH_TW, // ChineseTraditional = 41
            ELang.EN_US, // Unknow = 42
        };

        public void Bind(ILangPrime iLangPrime) {
            _langArr = iLangPrime.LangArr;
            _termArr = iLangPrime.TermArr;
        }

        public void Init() {
            _eCurrLang = ELang.EN_US;
        }

        public void Change(byte eLang) {
            if ((ELang)eLang == _eCurrLang) {
                return;
            }
            if (Array.IndexOf(_langArr, (ELang)eLang) == -1) {
                Debug.LogError("LangMgr Change( ) -- " + (ELang)eLang + " is not included");
                return;
            }
            _eCurrLang = (ELang)eLang;
        }

        public void Change(ELang eLang) {
            if (eLang == _eCurrLang) {
                return;
            }
            if (Array.IndexOf(_langArr, eLang) == -1) {
                Debug.LogError("LangMgr Change( ) -- " + eLang + " is not included");
                return;
            }
            _eCurrLang = eLang;
        }

        public void Change(SystemLanguage sysLang) {
            if (_sysLangArr[(byte)sysLang] == _eCurrLang) {
                return;
            }
            if (Array.IndexOf(_langArr, _sysLangArr[(byte)sysLang]) == -1) {
                Debug.LogError("LangMgr Change( ) -- " + _sysLangArr[(byte)sysLang] + " is not included");
                return;
            }
            _eCurrLang = _sysLangArr[(byte)sysLang];
        }

        public string Term(ushort eTerm) {
            return _termArr[eTerm][Array.IndexOf(_langArr, _eCurrLang)];
        }
    }
}