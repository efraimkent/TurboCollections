namespace TurboCollections {
    public class TurboList<T> {
        public int Count => items.Length;
        T[] items = Array.Empty<T>();

        void EnsureSize(int size) {
            if (items.Length >= size)
                return;
            int newSize = Math.Max(size, items.Length * 2);
            T[] newArray = new T[newSize];
            for (int i = 0; i < Count; i++) {
                newArray[i] = items[i];
            }
            items = newArray;
        }

        public void Add(T item) {

            //resize the Array
            T[] newArray = new T[Count + 1];
            for (int i = 0; i < Count; i++) {
                newArray[i] = items[i];
            }

            //assign the new Element
            newArray[Count] = item;

            //assign the result to our field
            items = newArray;
        }

        public T Get(int index) {
            return items[index];
        }

        public void Clear() {
            items = Array.Empty<T>();
        }

        public void RemoveAt(int index) {
            T[] newArray = new T[Count - 1];
            for (int i = 0; i < Count - 1; i++) {
                if (i >= index) {
                    newArray[i] = items[i + 1];
                } else {
                    newArray[i] = items[i];
                }
            }
            items = newArray;
            Console.WriteLine(string.Join(",", newArray));
        }

        public bool Contains(T item) {
            foreach (var elements in items) {
                if (elements.Equals(item)) {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(T item) {
            int i = 0;
            foreach (var elements in items) {
                if (elements.Equals(item)) {
                    return i;
                }
                i++;
            }
            return -1;
        }

        public void Remove(T item) {
            T[] newArray = new T[Count];
            foreach (var elements in items) {
                if (elements.Equals(item)) {
                    newArray[Count] = item;
                }
            }
            Console.WriteLine(string.Join(",", newArray));
        }
    }
}
