using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace game_in_cons
{
    class PlayerV
    {
        public string name { get; set; }
        public string Clas1 { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public PlayerV(string clas1, string Name, int hp, int mp, int str, int dex)
        {
            name = Name;
            Clas1 = clas1;
            HP = hp;
            MP = mp;
            Str = str;
            Dex = dex;

        }
    }
    class PlayerM
    {
        public string name { get; set; }
        public string Clas2 { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public PlayerM(string clas2, string Name, int hp, int mp, int str, int dex)
        {
            name = Name;
            Clas2 = clas2;
            HP = hp;
            MP = mp;
            Str = str;
            Dex = dex;

        }

    }
    class PlayerA
    {
        public string name { get; set; }
        public string Clas3 { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public PlayerA(string clas3, string Name, int hp, int mp, int str, int dex)
        {
            name = Name;
            Clas3 = clas3;
            HP = hp;
            MP = mp;
            Str = str;
            Dex = dex;

        }
    }
    class Weapon
    {
        public string NeWeapon { get; set; }
        public int dmg { get; set; }
        public int MnCost { get; set; }


        public Weapon(string neWeapon, int Dmg, int mnCost)
        {
            NeWeapon = neWeapon;
            dmg = Dmg;
            MnCost = mnCost;
        }

    }
    class inventory
    {
        private static string[] _inventory = new string[] { };

        public string size1 { get; set; }
        public string size2 { get; set; }
        public string size3 { get; set; }
        public string size4 { get; set; }
        public string size5 { get; set; }

        public inventory(string Size1, string Size2, string Size3, string Size4 , string Size5)
        {
            size1 = Size1;
            size2 = Size2;
            size3 = Size3;
            size4 = Size4;
            size5 = Size5;
        }
    }
    class Enemy
    {
        public int HP { get; set; }
        public int edmg { get; set; }
        public Enemy(int hp, int Edmg)
        {
            HP = hp;
            edmg = Edmg;
        }
    }
}
