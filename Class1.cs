using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace game_in_cons
{
    public class PlayerV
    {
        public string name { get; set; }
        public string Clas1 { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public Inventory Inventory { get; set; }
        
        public PlayerV(string clas1, string Name, int hp, int mp, int str, int dex)
        {
            name = Name;
            Clas1 = clas1;
            HP = hp;
            MP = mp;
            Str = str;
            Dex = dex;
            Inventory = new Inventory();
            

        }
    }
    public class PlayerM
    {
        public string name { get; set; }
        public string Clas2 { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public Inventory Inventory { get; set; }
      
        public PlayerM(string clas2, string Name, int hp, int mp, int str, int dex)
        {
            name = Name;
            Clas2 = clas2;
            HP = hp;
            MP = mp;
            Str = str;
            Dex = dex;
            Inventory = new Inventory();
            

        }

    }
    public class PlayerA
    {
        public string name { get; set; }
        public string Clas3 { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public Inventory Inventory { get; set; }
        
        public PlayerA(string clas3, string Name, int hp, int mp, int str, int dex)
        {
            name = Name;
            Clas3 = clas3;
            HP = hp;
            MP = mp;
            Str = str;
            Dex = dex;
            Inventory = new Inventory();
            

        }
    }
    public class Weapon
    {
        public string NeWeapon { get; set; }
        public int dmg { get; set; }
        public int MnCost { get; set; }
        public bool IsEquipped { get; set; }

        public Weapon(string neWeapon, int Dmg, int mnCost)
        {
            NeWeapon = neWeapon;
            dmg = Dmg;
            MnCost = mnCost;
            IsEquipped = false;
        }

    }
    
    
    public class Inventory
    {
        private List<Weapon> items;

        public Inventory()
        {
            items = new List<Weapon>();
        }

        public void AddItem(Weapon weapon)
        {
            items.Add(weapon);
        }

        public void ShowInventory()
        {
            Console.WriteLine("Ваш инвентарь:");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {items[i].NeWeapon}");
            }
        }

        public Weapon GetEquippedWeapon()
        {
            return items.FirstOrDefault(item => item.IsEquipped);
        }
    }
    public class Enemy
    {
        public int HP { get; set; }
        public int DMG { get; set; }
        public string Name { get; set; }

        public Enemy(string name ,int hP, int dMG)
        {
            Name = name;
            HP = hP;
            DMG = dMG;
        }
    }
    
}
