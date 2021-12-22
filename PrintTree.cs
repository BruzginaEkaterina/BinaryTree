using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3dfg
{
    public class countDerevo
    {
        public static void Print(derevo node)
        {
            if (node != null) // изначальная проверка не пусто ли в дереве
            {
                if (node.koren == null) // для первого вывода 
                {
                    Console.WriteLine("Корень дерева:{0}", node.Infa);
                }
                else
                {
                    if (node.koren.Left == node)
                    {
                        Console.WriteLine("Слева от {1}  - {0}", node.Infa, node.koren.Infa);
                    }

                    if (node.koren.Right == node)
                    {
                        Console.WriteLine("Справа от {1} - {0}", node.Infa, node.koren.Infa);
                    }
                }
                if (node.Left != null)
                {
                    Print(node.Left); // применяем рекурсию для того, чтобы программа не заканчивалась после вывода корня и вывелись все значения
                }
                if (node.Right != null)
                {
                    Print(node.Right); // Проверяем правое дерево и применяем рекурсию
                }
            }
        }
    }
}
