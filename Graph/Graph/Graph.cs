using System.CodeDom;

namespace Graph
{
    public class Graph<T> : IGraph<T>
    {
        private class Node<N>
        {
            public Node(N name)
            {
                this.name = name;
                edges = new List<Node<N>>();
            }
            public readonly N name;
            public List<Node<N>> edges;
        }        
        private List<Node<T>> values;
        public Graph()
        {
            values = new List<Node<T>>();
        }
        public int Size()
        {
            return values.Count;
        }
        public T Add(T name)
        {
            if (IsNodeExist(name))
            {
                throw new Exception($"Node with {name} exist!");
            }
            values.Add(new Node<T>(name));
            return name;
        }
        private Node<T> getItem(T name) { 
            if (!IsNodeExist(name))
            {
                throw new Exception($"Node {name} doesn't exist!");
            }
            foreach (var value in values)
            {
                if (string.Equals(value?.name?.ToString(), name?.ToString()))
                {
                    return value ?? new Node<T>(name);
                }
            }
            throw new Exception($"Node {name} doesn't exist!");
        }
        public T Remove(T name)
        {
            if (!IsNodeExist(name))
            {
                throw new Exception($"Node {name} doesn't exist!");
            }
            var value = getItem(name);
            values.Remove(value);
            return name;
        }
        public bool IsNodeExist(T name)
        {
            foreach (var value in values)
            {
                if (string.Equals(value?.name?.ToString(), name?.ToString()))
                {
                    return true;
                }
            }
            return false;
        }
        public bool AddEdge(T dest, T src)
        {
            if (!IsNodeExist(dest))
            {
                throw new Exception("Node {dest} doesn't exist!");
            }
            if (!IsNodeExist(src))
            {
                throw new Exception("Node {src} doesn't exist!");
            }
            var destanetion = getItem(dest);
            var source = getItem(src);
            destanetion.edges.Add(source);
            return true;
        }
        public bool IsEdgeExist(T dest, T src)
        {
            if (!IsNodeExist(dest))
            {
                throw new Exception("Node {dest} doesn't exist!");
            }
            if (!IsNodeExist(src))
            {
                throw new Exception("Node {src} doesn't exist!");
            }
            var destanetion = getItem(dest);
            var source = getItem(src);
            return destanetion.edges.Contains(source);
        }
        public bool Clear()
        {
            values.Clear();
            return true;
        }
        public bool RemoveEdge(T dest, T src)
        {
            if (!IsNodeExist(dest))
            {
                throw new Exception("Node {dest} doesn't exist!");
            }
            if (!IsNodeExist(src))
            {
                throw new Exception("Node {src} doesn't exist!");
            }
            var destanetion = getItem(dest);
            var source = getItem(src);
            destanetion.edges.Remove(source);
            return true;
        }

        public override string ToString()
        {
            return values.ToArray().ToString() ?? "";
        }
    }
}
