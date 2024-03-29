using System.Runtime.CompilerServices;

namespace Algorithms.LargestSum
{
    public struct MatrixPosition:IComparable<MatrixPosition>
    {
        public MatrixPosition(int line, int column, int value)
        {
            Line = line;
            Column = column;
            Value = value;
        }

        public static readonly MatrixPosition NULL = new(-1, -1, 0);
        public int Line { get; set; }
        public int Column { get; set; }
        public int Value { get; set; }

        public bool IsNull{ get => Line == -1; }

        public bool IsDiagonalTo(MatrixPosition f1)
        {
            return Line != f1.Line && Column != f1.Column;
        }


        public readonly int CompareTo(MatrixPosition other)
        {
            if (this.Value == other.Value) return 0;
            if (this.Value > other.Value) return 1;
            return -1;
        }
    }
}