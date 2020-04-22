using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponShopAssign2
{   // This class implements a backpack as a linked list
    // The backpack can hold any number of weapons as long as maxWeight is not crossed.
    // If an attempt to add a weapon to backpack is rejected due to weight
    class Backpack
    {
        double maxWeight;
        double presentWeight;
        NodeBackpack head;

        public Backpack(double maxWeight, double presentWeight)
        {
            this.maxWeight = maxWeight;
            this.presentWeight = presentWeight;
            head = null;
        }

        public void AddLast(Weapon sWeapon)
        {
            //create a new node
            NodeBackpack newNode = new NodeBackpack(sWeapon);

            //head is null
            if (head == null)
            {
                head = newNode;
                return;
            }

            NodeBackpack curr = head;
            while (curr.next != null) // find the last item
            {
                curr = curr.next;
            }

            curr.next = newNode;
        }

        public void PrintList()
        {

            Console.WriteLine("List: ");
            NodeBackpack curr = head;

            while (curr != null)
            {
                Console.WriteLine("{0}-{1}-{2}", curr.data.weaponName, curr.data.cost, curr.data.damage);
                curr = curr.next;
            }
        }
    }



}
