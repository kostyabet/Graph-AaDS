namespace Graph
{
    public interface IGraph<T>
    {
        public int Size();
        public T Add(T name);
        public bool IsNodeExist(T name);
        public T Remove(T name);
        public bool AddEdge(T dest, int weight, T src);
        public bool IsEdgeExist(T dest, T src);
        public bool RemoveEdge(T dest, T src);
        public string ToString();
        public bool Empty();
        public bool Clear();
        public bool SetDest(T dest);
        public bool SetSrc(T src);
        public void DrawGraph(Graphics g, int width, int height);
        public (int[,], int[]) DijkstraAlgoShort(T source);
        public (int[,], int[]) DijkstraAlgoLong(T source);
        public int[,] FloydAlgorithm();
        public List<List<int>> FindAllPaths(T src, T dest);
    }
}
