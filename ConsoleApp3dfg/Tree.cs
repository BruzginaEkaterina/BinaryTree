using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3dfg
{
    public class derevo
    {
        public long? Infa { get; set; }
        public derevo Left { get; set; }
        public derevo Right { get; set; }
        public derevo koren { get; set; }

        // Вставляет значение в дерево
        public void Insert(int inf)
        {
            if (Infa == null || Infa == inf)
            {
                Infa = inf;
                return;
            }
            if (Infa > inf)
            {
                if (Left == null) Left = new derevo();
                Insert(inf, Left, this);
            }
            else
            {
                if (Right == null) Right = new derevo();
                Insert(inf, Right, this);
            }
        }

        // Вставляет значение в определённый узел дерева
        private void Insert(int data, derevo node, derevo korn)
        {
            if (node.Infa == null || node.Infa == data)
            {
                node.Infa = data;
                node.koren = korn;
                return;
            }
            if (node.Infa > data)
            {
                if (node.Left == null) node.Left = new derevo();
                Insert(data, node.Left, node);
            }
            else
            {
                if (node.Right == null) node.Right = new derevo();
                Insert(data, node.Right, node);
            }
        }
        // Вставляет узел в определённый узел дерева
        private void Insert(derevo data, derevo node, derevo koren)
        {
            if (node.Infa == null || node.Infa == data.Infa)
            {
                node.Infa = data.Infa;
                node.Left = data.Left;
                node.Right = data.Right;
                node.koren = koren;
                return;
            }
            if (node.Infa > data.Infa)
            {
                if (node.Left == null) node.Left = new derevo();
                Insert(data, node.Left, node);
            }
            else
            {
                if (node.Right == null) node.Right = new derevo();
                Insert(data, node.Right, node);
            }
        }
    }
}
