namespace Graph
{
    public class Graph<T> : IGraph<T>
    {
        private class Node<N>
        {
            public Node(N name)
            {
                this.name = name;
            }
            public N name { get; }
        }
        
        private T[] values;
        public Graph()
        {
            values = new T[0];
        }

        public T Add(T name)
        {
            return name;
        }

        public bool AddEdge(T dest, T src)
        {
            return true;
        }

        public bool Clear()
        {
            return true;   
        }

        public T Remove(T name)
        {
            return name;
        }

        public bool RemoveEdge(T dest, T src)
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
