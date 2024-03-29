using Algorithms.LargestSum;

namespace Algorithms.DataStructure
{
    public class OrderedList<T> : List<T> where T : IComparable<T>
    {
        public new void Add(T item)
        {
            int i = FindPosition(item);
            Insert(i, item);
        }

       

        public int FindPosition(T value) {
            return FindPosition(value, this);
        }

        protected static int FindPosition(T newElement, IList<T> list)
        {
            int pointer = 0;
            int last = list.Count - 1;
            int first = 0;
            if (last < 0 || newElement.CompareTo(list[0]) == 1) return pointer;

            if (newElement.CompareTo(list[last])==-1) return ++last;

            var getPointer = () =>
            {
                var range = (double)(last - first);
                var mid = (int)Math.Ceiling(range / 2);
                return first + mid;
            };

            pointer = getPointer();

            T currentElement;
            int iterations = 0;
            while (!(pointer < 0 || pointer > list.Count))
            {
                iterations++;
                currentElement = list[pointer];
                if (newElement.CompareTo( currentElement)==0) return pointer;
                if (newElement.CompareTo(currentElement)==1)
                {
                    last = pointer - 1;
                    if (newElement.CompareTo(list[last]) == -1)
                    {
                        return pointer;
                    }
                }

                if (newElement.CompareTo(currentElement)==-1)
                {
                    first = pointer;
                    pointer++;
                    if (newElement.CompareTo(list[pointer])==1) return pointer;
                }

                pointer = getPointer();

            }
            return pointer < 0 ? 0 : list.Count - 1;
        }
    }
}