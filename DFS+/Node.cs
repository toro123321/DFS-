using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DFS_
{
    class Node
    {
        private static int counter = 0;
        public Node() { id = counter++; }
        public Node(string product) { this.product = product; id = counter++; }
        public string product;
        public int id;
        public List<int> epsilon = new List<int>();
        public bool seek = false;
    }
}
