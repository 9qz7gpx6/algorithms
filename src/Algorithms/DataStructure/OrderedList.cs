using Algorithms.LargestSum;

namespace Algorithms.DataStructure
{
    public class OrderedList : List<MatrixPosition> 
    {
        public new void Add(MatrixPosition matrixPosition)
        {
            int i = FindPosition(matrixPosition.Value);
            Insert(i, matrixPosition);
        }

        internal MatrixPosition? NextAfter(MatrixPosition f1, int position = 0)
        {
            int next = position;
            do next++; while (next < Count && !this[next].IsDiagonalTo(f1));
            return this[next];
        }

        public int FindPosition(int value) {
            return FindPosition(value, this);
        }

        protected static int FindPosition(int newElement, IList<MatrixPosition> list)
        {
            int pointer = 0;
            int last = list.Count - 1;
            int first = 0;
            if (last < 0 || newElement > list[0].Value) return pointer;

            if (newElement < list[last].Value) return ++last;

            var getPointer = () =>
            {
                var range = (double)(last - first);
                var mid = (int)Math.Ceiling(range / 2);
                return first + mid;
            };

            pointer = getPointer();

            bool stop = false;
            int currentElement;
            int iterations = 0;
            while (!stop)
            {
                iterations++;
                currentElement = list[pointer].Value;
                if (newElement == currentElement) return pointer;
                if (newElement > currentElement)
                {
                    last = pointer - 1;
                    if (newElement < list[last].Value)
                    {
                        return pointer;
                    }
                }

                if (newElement < currentElement)
                {
                    first = pointer;
                    pointer++;
                    if (newElement > list[pointer].Value) return pointer;
                }

                pointer = getPointer();

                stop = pointer < 0 || pointer > list.Count;
            }
            return pointer < 0 ? 0 : list.Count - 1;
        }
    }
}