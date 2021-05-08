namespace MyLinkedList
{
    public class List<T>
    {
        class Node<V>
        {
            public V val;
            public Node<V> prev = null;
            public Node<V> next = null;
            public Node(V val)=>this.val = val;
        }
        public int Size { get; private set; } = 0;
        Node<T> head = null;
        Node<T> last = null;
        public void Add(T val)
        {
            if (Size == 0)
            {
                AddFirst(val);
                return;
            }
            last.next = new(val);
            last.next.prev = last;
            Size++;
        }
        void AddFirst(T val)
        {
            head = new(val);
            last = head;
            Size++;
        }
        public T this[int index]
        {
            get
            {
                Node<T> temp = head;
                for (int i = 1; i < index; i++)
                    temp = temp.next;
                return temp.val;
            }
            set
            {
                this[index] = value;
            }
        }
        public static explicit operator T[](List<T> l)
        {
            var res = new T[l.Size];
            for (int i = 0; i < l.Size; i++)
                res[i] = l[i];
            return res;
        }
    }
    public class Queue
    {
        int size = 0;
        El last = null;
        class El
        {
            public int val;
            public El next = null;
            public El(int val) => this.val = val;
        }
        public void Add(int val)
        {
            El temp = new(val);
            if (size != 0)
                temp.next = last;
            last = temp;
            size++;
        }
        public void Remove(int val)
        {
            if (last is null)
                return;
            El temp = last;
            while (temp.next is not null)
                if (temp.next.val == val)
                    temp.next = temp.next.next;
                else
                    temp = temp.next;
        }
        public override string ToString()
        {
            if (size == 0)
                return string.Empty;
            var res = string.Empty;
            El temp = last;
            while (temp != null)
            {
                res += $"{temp.val} ";
                temp = temp.next;
            }
            return res/*.Reverse()*/;
        }
    }
    public class Stack<T>// where T: Human
    {
        Node<T> bot = null;
        public class Node<V>
        {
            public V val;
            public Node<V> bot = null;
            public Node(V val) => this.val = val;
        }
        public void PushBack(T val)
        {
            Node<T> temp = new(val);
            if (bot != null)
                temp.bot = bot;
            bot = temp;
        }
        public override string ToString()
        {
            var res = string.Empty;
            for (Node<T> temp = bot; temp != null; temp = temp.bot)
                res += $"{temp.val} ";
            return res;
        }
    }
}
