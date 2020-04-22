using System;

namespace WeaponShopAssign2
{
    class Program
    {


        public static void addWeapons(BinaryTree bt)
        {
            int index = 1;
            Console.WriteLine("***********WELCOME TO THE WEAPON ADDING MENU*********");




            //string weaponName; int weaponRange; int weaponDamage; double weaponWeight; double weaponCost;
            //Console.WriteLine("Please enter the NAME of the Weapon ('end' to quit):");
            //weaponName = Console.ReadLine();
            //while (weaponName.CompareTo("end") != 0)
            //{
            //    Console.WriteLine("Please enter the Range of the Weapon (0-10):");
            //    weaponRange = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Please enter the Damage of the Weapon:");
            //    weaponDamage = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Please enter the Weight of the Weapon (in pounds):");
            //    weaponWeight = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Please enter the Cost of the Weapon:");
            //    weaponCost = Convert.ToDouble(Console.ReadLine());
            //    Weapon w = new Weapon(weaponName, weaponRange, weaponDamage, weaponWeight, weaponCost);
            //    bt.Push(index, w);
            //    index++;
            //    Console.WriteLine("Please enter the NAME of another Weapon ('end' to quit):");
            //    weaponName = Console.ReadLine();
            //}



            //just for testing
            Weapon wp = new Weapon("ak47", 8, 8, 8, 80);
            Weapon wp1 = new Weapon("usp", 1, 1, 8, 10);
            Weapon wp2 = new Weapon("mp4", 3, 3, 8, 50);
            Weapon wp3 = new Weapon("desert Eagle", 10, 10, 8, 30);
            bt.Push(1, wp);
            bt.Push(2, wp1);
            bt.Push(3, wp2);
            bt.Push(4, wp3);
        }

        public static void showRoom(BinaryTree bt, Player p)
        {
            string choice;
            Console.WriteLine("WELCOME TO THE SHOWROOM!!!!");
            bt.DisplayInOrder();
            Console.WriteLine(" You have " + p.money + " money.");
            Console.WriteLine("Please select a weapon to buy('end' to quit):");
            choice = Console.ReadLine();
            while (choice.CompareTo("end") != 0 && !p.InventoryFull())
            {
                Weapon w = bt.Search(Convert.ToInt32(choice));
                if (w != null)
                {
                    if (w.cost > p.money)
                    {
                        Console.WriteLine("Insufficient funds to buy " + w.weaponName);
                    }
                    else
                    {
                        p.Buy(w);
                        p.Withdraw(w.cost);
                    }
                }
                else
                {
                    Console.WriteLine(" ** " + choice + " not found!! **");
                }
                Console.WriteLine("Please select another weapon to buy('end' to quit):");
                choice = Console.ReadLine();
            }
            Console.WriteLine();
        }

        public static Player CreatePlayer()
        {
            string name;
            Console.WriteLine("Please enter the player name: ");
            name = Console.ReadLine();
            Player p = new Player(name, 100);
            Console.WriteLine("{0}, You have $100 to spend.", name);
            Console.ReadKey();
            return p;
        }

        static void Main(string[] args)
        {
            
            runProgram();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }

        public static void showMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Please select a choice from the menu below:\n");
            Console.WriteLine("1:Add Items to the shop");
            Console.WriteLine("2:Delete Items from the shop");
            Console.WriteLine("3:Buy from the shop");
            Console.WriteLine("4:View backpack");
            Console.WriteLine("5:View Player");
            Console.WriteLine("6:Exit");
        }

        public static int getValidChoice()
        {
            int choice;

            while (!int.TryParse(Console.ReadLine(), out choice) || (choice < 1 || choice > 6))
            {

                showMainMenu();
                Console.WriteLine("Please enter a valid choice:");
            }
            return choice;
        }


        public static void runProgram()
        {

            //HashTable ht = new HashTable(100);
            BinaryTree bt = new BinaryTree();
            Player player;
            int choice;
            player = CreatePlayer();

            showMainMenu();
            choice = getValidChoice();
            while (choice != 6)
            {
                if (choice == 1) { addWeapons(bt); }
                if (choice == 2) { addWeapons(bt); }
                if (choice == 3) { showRoom(bt, player); }
                if (choice == 4) { player.PrintBackpack(); }
                if (choice == 5) { player.PrintCharacter(); }
                choice = getValidChoice();
            }
            Console.Clear();
            Console.WriteLine("Thank you.");
            Console.ReadKey();
        }


    }
}
