using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3dfg
{
    public class Travers
    {
        public static void Traversal(derevo node) // Обратный обход
        {
            var stack = new Stack<derevo>(); // создание стэка для обхода
            derevo lastNodeVisited = null;

            while (stack.Count > 0 || node != null)
            {
                if (node != null)
                {
                    stack.Push(node); // Сначала обходим левое поддерево
                    node = node.Left;
                }
                else
                {
                    var peekNode = stack.Peek();
                    if (peekNode.Right != null && lastNodeVisited != peekNode.Right)
                    {
                        node = peekNode.Right; // обходим правое поддерево
                    }
                    else
                    {
                        Console.Write(" ");
                        Console.Write(string.Join(Environment.NewLine, peekNode.Infa));
                        lastNodeVisited = stack.Pop(); // Достаём из стэка и выводим
                    }
                }
            }
        }
    }
}
