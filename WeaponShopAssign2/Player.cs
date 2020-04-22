using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponShopAssign2
{
    class Player
    {
        public string name;
        //public Weapon[] backpack;
        //;
        public int numItems;
        public double money;
        Backpack backpack;

        public Player(string n, double m)
        {
            name = n;
            money = m;
            numItems = 0;
            backpack = new Backpack(100, 0);
            //backpack = new Weapon[10];

        }

        public void Buy(Weapon w)
        {
            Console.WriteLine(w.weaponName+" bought...");
            //backpack[numItems] = w;
            backpack.AddLast(w);
            //numItems++;
            //Console.Write(numItems);
        }
        public void Withdraw(double amt)
        {
            money = money - amt;
        }

        public bool InventoryFull()
        {
            bool full = false;
            if (numItems == 10) full = true;
            return full;
        }


        public void PrintCharacter()
        {
            Console.WriteLine(" Name:"+name+"\n Money:"+money);
            PrintBackpack();
        }

        public void PrintBackpack()
        {
            //Console.WriteLine(" "+name+", you own "+numItems+" Weapons:");
            //for (int x = 0; x < numItems; x++)
            //{
            //    Console.WriteLine(" "+backpack[x].weaponName);
            //}
            //Console.WriteLine();
            backpack.PrintList();
        }
    }
}
