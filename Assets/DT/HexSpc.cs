using T;

namespace DT {

    public enum EHexDir { // don't move the enum to namespace T
        E, NE, NW, W, SW, SE,
    }

    public class HexSpc<T> : ISpc<T> where T : class/*, new ()*/  {
        
        private HexCalc _calc;
        private byte _uWd; // unit width

        public HexSpc(HexCalc calc, byte uWd) {
            _calc = calc;
            _uWd = uWd;
        }

        public T[][] Abstr(ushort[][] blkArr) {
            // float uWd = 1.0f;
            // float unitWidth = (HEXSCALE * uWd) / 2;
            // float unitHeight = (2 * uWd) / 4;
            // float rowSpacing = unitWidth * 2;
            // float colSpacing = unitHeight * 3;
            
            ushort rows = (ushort)blkArr.GetLength(0);
            ushort cols = (ushort)blkArr.GetLength(1);
            T[][] hexArr = new T[rows][];
    
            // (float colSpacing, float rowSpacing) = _calc.DistributeDist((float)_uWd);
            // SCoord3 startPos = _calc.CenterPos(cols, rows, colSpacing, rowSpacing);
            // for (ushort row = 0; row < rows; row++) {
            //     for (ushort col = 0; col < cols; col++) {
            //         if (blkArr[row][col] == 0) {
            //             hexArr[row][col] = null;
            //         } else {
            //             float x = startPos.X + col * colSpacing;
            //             float y = startPos.Y;
            //             float z = startPos.Z - row * rowSpacing;
            //             // x += this.hexCalc.UnitWidth((float)uWd) * (row & 1);
            //             if (row % 2 != 0) {
            //                 x += _calc.UnitW(_calc.HexW((float)_uWd));
            //             }
            //             // hexArr[row][col] = new T(new SGrid3(row, col, 0), new SCoord3(x, y, z));
            //             hexArr[row][col] = new T();
            //         }
            //     }
            // }

            return hexArr;
        }
    }
}