using System.CodeDom;
using System.Collections;
using System.Diagnostics.Metrics;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace Graph
{
    public class Graph<T> : IGraph<T>
    {
        private class Edge<N>
        {
            public Edge(Node<N> Dest, int weight)
            {
                this.Dest = Dest;
                this.weight = weight;
            }
            public readonly Node<N> Dest;
            public readonly int weight;
        }
        private class Node<N>
        {
            public Node(N name)
            {
                this.name = name;
                edges = new List<Edge<N>>();
            }
            public readonly N name;
            public List<Edge<N>> edges;
        }        
        private List<Node<T>> values;
        public T? MainSrc { get; private set; }
        public T? MainDest { get; private set; }
        public Graph()
        {
            values = new List<Node<T>>();
            MainSrc = default;
            MainDest = default;
        }
        public bool SetDest(T dest)
        {
            MainDest = dest;
            return true;
        }
        public bool SetSrc(T src)
        {
            MainSrc = src;
            return true;
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
        public bool AddEdge(T src, int weight, T dest)
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
            source.edges.Add(new Edge<T>(destanetion, weight));
            return true;
        }
        public bool IsEdgeExist(T src, T dest)
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
            foreach (var edge in source.edges) 
            {
                if (edge?.Dest?.name?.ToString() == destanetion?.name?.ToString()) 
                {
                    return true;
                }
            }
            return false;
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
            var edge = GetEdge(source, destanetion);
            if (edge == null) return false;
            source.edges.Remove(edge);
            return true;
        }
        private Edge<T>? GetEdge(Node<T> src, Node<T>? dest)
        {
            foreach (var edge in src.edges) 
            {
                if (edge?.Dest?.name?.ToString() == dest?.name?.ToString())
                {
                    return edge;
                }
            }
            return null;
        }
        public override string ToString()
        {
            return values.ToArray().ToString() ?? "";
        }

        // DRAW PART
        const int BASE_RADIUS = 30;
        const int DEGREE_IN_CIRCLE = 360;
        const int START_DEGREE_POS = 90;
        const int NODE_RADIUS = 20;
        const int ARROW_LENGTH = 15;
        Brush NODE_BACKGROUND_COLOR = Brushes.LightGray;
        Brush NODE_TEXT_COLOR = Brushes.Black;
        Brush WEIGHT_FONT_COLOR = Brushes.LightSteelBlue;
        Pen NODE_BORDER_COLOR = Pens.Black;
        Pen NODE_LINE_COLOR = Pens.Black;
        Pen WEIGHT_BORDER_COLOR = Pens.Black;
        public void DrawGraph(Graphics g, int width, int height)
        {
            int counter = values.Count;
            if (counter == 0) return;
            int radius = (counter - 1) * BASE_RADIUS;
            int radiusDegStep = DEGREE_IN_CIRCLE / counter;
            
            // 0 - x; 1 - y
            int[][] circlesPosition = new int[counter][];
            int[] center = { width / 2, height / 2};
            int currentDegree = START_DEGREE_POS;

            for (int i = 0; i < counter; i++)
            {
                int xSign = currentDegree >= 90 && currentDegree <= 270 ? -1 : 1;
                int ySign = currentDegree >= 0 && currentDegree <= 180 ? -1 : 1;
                double radianDegree = currentDegree * Math.PI / 180;
                double xCos = Math.Abs(Math.Cos(radianDegree));
                double ySin = Math.Abs(Math.Sin(radianDegree));
                int xOffset = (int)(xCos * radius * xSign);
                int yOffset = (int)(ySin * radius * ySign);
                circlesPosition[i] = new int[2]; 
                circlesPosition[i][0] = center[0] + xOffset;
                circlesPosition[i][1] = center[1] + yOffset;
                int newRadius = currentDegree + radiusDegStep;
                currentDegree = newRadius > 360 ? newRadius - 360 : newRadius;
            }

            // drawing
            Node<T>[] nodes = values.ToArray();
            DrawLines(g, circlesPosition, nodes);
            DrawNodes(g, circlesPosition, nodes);
        }

        private void DrawLines(Graphics g, int[][] centers, Node<T>[] nodes)
        {
            for (int i = 0; i < centers.Length; i++)
            {
                int startX = centers[i][0];
                int startY = centers[i][1];
                foreach (var edge in nodes[i].edges)
                {
                    int stopIndex = Convert.ToInt32(edge.Dest.name) - 1;
                    int endX = centers[stopIndex][0];
                    int endY = centers[stopIndex][1];
                    g.DrawLine(NODE_LINE_COLOR, startX, startY, endX, endY);
                    DrawEndArrow(g, startX, startY, endX, endY);
                    DrawWeight(g, startX, startY, endX, endY, edge.weight);
                }
            }
        }
        double[] coefs = { 0.5, 0.5, 0.45, 0.4, 0.35, 0.30, 0.3, 0.3, 0.80 };
        private void DrawWeight(Graphics g, int startX, int startY, int endX, int endY, int weight)
        {
            int x = Math.Abs(endX - startX);
            int y = Math.Abs(endY - startY);
            int length = (int)(Math.Sqrt(x * x + y * y) * coefs[values.Count - 1]);
            double degree = Math.Atan((double)y / x);
            double cos = Math.Cos(degree);
            double sin = Math.Sin(degree);
            int xSign = startX > endX ? 1 : -1;
            int ySign = startY > endY ? 1 : -1;
            int xOffset = (int)(cos * length * xSign);
            int yOffset = (int)(sin * length * ySign);
            endX += xOffset;
            endY += yOffset;
            int digitsCount = weight.ToString().Length;
            g.FillRectangle(WEIGHT_FONT_COLOR, endX - (4+ digitsCount*5), endY - 7, 8+(digitsCount * 5), 14);
            g.DrawRectangle(WEIGHT_BORDER_COLOR, endX - (4+ digitsCount*5), endY - 7, 8+(digitsCount * 5), 14);
            g.DrawString(weight.ToString(), new Font("Arial", 9), NODE_TEXT_COLOR, endX-(3+digitsCount*5), endY-7);
        }
        private void DrawEndArrow(Graphics g, int startX, int startY, int endX, int endY)
        {
            int x = Math.Abs(endX - startX);
            int y = Math.Abs(endY - startY);
            double degree = Math.Atan((double)y / x);
            double cos = Math.Cos(degree);
            double sin = Math.Sin(degree);
            int xSign = startX > endX ? 1 : -1;
            int ySign = startY > endY ? 1 : -1;
            int xOffset = (int)(cos * NODE_RADIUS * xSign);
            int yOffset = (int)(sin * NODE_RADIUS * ySign);
            endX += xOffset;
            endY += yOffset;
            double arrow1Deg = degree - (30 * Math.PI / 180);
            double cosA1 = Math.Abs(Math.Cos(arrow1Deg));
            double sinA1 = Math.Abs(Math.Sin(arrow1Deg));
            int xA1 = endX + (int)(cosA1 * ARROW_LENGTH * xSign);
            int yA1 = endY + (int)(sinA1 * ARROW_LENGTH * ySign);
            g.DrawLine(NODE_LINE_COLOR, endX, endY, xA1, yA1);
            if (startX == endX) xSign = -xSign;
            if (startY == endY) ySign = -ySign;
            double arrow2Deg = degree + (30 * Math.PI / 180);
            double cosA2 = Math.Abs(Math.Cos(arrow2Deg));
            double sinA2 = Math.Abs(Math.Sin(arrow2Deg));
            int xA2 = endX + (int)(cosA2 * ARROW_LENGTH * xSign);
            int yA2 = endY + (int)(sinA2 * ARROW_LENGTH * ySign);
            g.DrawLine(NODE_LINE_COLOR, endX, endY, xA2, yA2);
        }

        private void DrawNodes(Graphics g, int[][] centers, Node<T>[] nodes)
        {
            for (int i = 0; i < centers.Length; i++)
            {
                int x = centers[i][0] - NODE_RADIUS;
                int y = centers[i][1] - NODE_RADIUS;
                g.FillEllipse(NODE_BACKGROUND_COLOR, x, y, NODE_RADIUS * 2, NODE_RADIUS * 2);
                g.DrawEllipse(NODE_BORDER_COLOR, x, y, NODE_RADIUS * 2, NODE_RADIUS * 2);
                g.DrawString(nodes[i]?.name?.ToString(), new Font("Arial", 15), NODE_TEXT_COLOR, x + 11, y + 9);
            }
        }

        // main alghoritms
        public int DijkstraAlgo(T source, T destanation)
        {
            HashSet<T> viseted = new HashSet<T>();
            T w = source; // start symbol
            int[,] D = new int[values.Count, values.Count]; // lengths
            for (int k = 0; k < values.Count; k++)
            {
                for (int j = 0; j < values.Count; j++)
                {
                    D[k, j] = int.MaxValue;
                }
            }

            int i = 0;
            while (viseted.Count < values.Count)
            {
                Node<T> CurrentObject = getItem(w);
                int currentIndex = Convert.ToInt32(CurrentObject?.name?.ToString()) - 1;
                int prevValue = i != 0
                    ? D[i - 1, currentIndex] == int.MaxValue
                        ? 0
                        : D[i - 1, currentIndex]
                    : 0;
                for (int j = 0; j < values.Count; j++)
                {
                    if (viseted.Contains(values[j].name))
                    {
                        D[i, j] = D[i - 1, j];
                        continue;
                    }
                    Edge<T> currentEdge = GetEdge(CurrentObject, values[j]);
                    if (currentEdge != null)
                        D[i, j] = i != 0 
                            ? Math.Min(
                                prevValue + currentEdge.weight, 
                                D[i - 1, j]) 
                            : currentEdge.weight;
                    else
                        D[i, j] = i != 0
                            ? D[i - 1, j]
                            : int.MaxValue;
                }
                viseted.Add(w);
                int minVal = D[i,0], minIndex = 0;
                for (int j = 0; j < values.Count; j++)
                {
                    if (D[i, j] < minVal && !viseted.Contains(values[j].name))
                    {
                        minVal = D[i, j];
                        minIndex = j;
                    }
                }
                w = values[minIndex].name;
                i++;
            }
            return 0;
        }
    }
}
