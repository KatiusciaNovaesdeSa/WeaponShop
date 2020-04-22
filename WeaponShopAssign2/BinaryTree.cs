using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponShopAssign2
{
    class BinaryTree
    {
        public Node root; // tree root
        public int numItems;
        public int index;
        public int tableSize;

        public BinaryTree()
        {
            root = null;
            numItems = 0;
        }


        // MY INSERTION FUNCTION 
        public void Push(int x, Weapon item)
        {
            index = 0;
            tableSize = 5;

            Node newNode = new Node(x); // new obj
            newNode.table[index] = item;

            if (root == null)
            {
                root = newNode;
                return;
            }

            Node parent = root;     
            Node current = root;

            while (current != null)
            {
                parent = current;

                if (current.data < x)
                {
                    current = current.right;
                }

                else
                    current = current.left;
            }


            if (parent.data < x)  { parent.right = newNode; }

            else {  parent.left = newNode; }
        }

        //public int Search(int number)
        //{
        //    return SearchWorker(root, number);
        //}

        //public int SearchWorker(Node curr, int number)
        //{
        //    if (curr == null)
        //    {
        //        return -1;
        //    }

        //    if (curr.data == number)
        //    {
        //        return number;
        //    }
        //    if (number < curr.data)
        //    {
        //        return SearchWorker(curr.left, number);
        //    }
        //    return SearchWorker(curr.right, number);

        //}

        //MY SEARCH FUNCTION
        public Weapon Search(int x)
        {
            Node searchNode = new Node(x); // new obj

            searchNode.data = x;
            Weapon ptr;

            Node parent = root;
            Node current = root;

            while (current.data != searchNode.data)
            {
                parent = current;

                if (current.data < x)
                {
                    current = current.right;
                }

                if (current.data > x)
                    current = current.left;
            }

            return ptr = current.table[0];

        }


        //  In-order Traversal

        public void DisplayInOrder()
        {
            Console.WriteLine("Weapon List: ");
            InOrder(root);
        }

        public void InOrder(Node n)
        {
            if (n != null)
            {
                InOrder(n.left); // moving left

                Console.WriteLine("Item Number: {0}, Name: {1}, Damage: {1}, Cost: {2}", n.data, n.table[0].weaponName, n.table[0].damage, n.table[0].cost);

                InOrder(n.right); // moving right
            }
        }



        // Pre-order Traversal


        public void DisplayPreorder()
        {
            Console.WriteLine(" Preorder: ");
            PreOrder(root);
        }

        public void PreOrder(Node n)
        {
            if (n != null)
            {
                Console.WriteLine("Item Number: {0}, Name: {1}, Damage: {1}, Cost: {2}", n.data, n.table[0].weaponName, n.table[0].damage, n.table[0].cost);

                PreOrder(n.left);  // moving left
                PreOrder(n.right);  // moving right
            }
        }



        //Post-order Traversal

        public void DisplayPostOrder()
        {
            Console.WriteLine("Postorder: ");
            PostOrder(root);
        }

        public void PostOrder(Node n)
        {
            if (n != null)
            {
                PostOrder(n.left);
                PostOrder(n.right);

                Console.WriteLine("Item Number: {0}, Name: {1}, Damage: {1}, Cost: {2}", n.data, n.table[0].weaponName, n.table[0].damage, n.table[0].cost);
            }
        }

    }
}
