using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponShopAssign2
{
    class Node
    {
        public int data;
        public Node left;
        public Node right;


        public Weapon[] table;
        public int tableLength;
        public int size = 5;
        public int numItems;


        public Node(int d)
        {
            data = d;
            tableLength = size;
            numItems = 0;

            table = new Weapon [tableLength]; // new obj

            for (int i = 0; i < tableLength; i++)
            {
                table[i] = null;
            }

            left = right = null;

        }
    }
}
