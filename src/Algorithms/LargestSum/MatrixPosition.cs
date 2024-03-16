namespace Algorithms.LargestSum
{
    public struct MatrixPosition
    {
        public MatrixPosition(int line, int column, int value)
        {
            Line = line;
            Column = column;
            Value = value;
        }

        public int Line { get; set; }
        public int Column { get; set; }
        public int Value { get; set; }
    }
}
