namespace Graph
{
    public interface IGraph<T>
    {
        public int Size();
        public T Add(T name);
        public bool IsNodeExist(T name);
        public T Remove(T name);
        public bool AddEdge(T dest, T src);
        public bool IsEdgeExist(T dest, T src);
        public bool RemoveEdge(T dest, T src);
        public string ToString();
        public bool Clear();
    }
}
