
using game_in_cons;
using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Добро пожаловать в игру Консольные войны!! ");
Console.WriteLine("1 - Начать игру");
Console.WriteLine("2 - Выйти");
int vybor = Convert.ToInt32(Console.ReadLine());
switch (vybor)
{
    case 1:
    break;

    case 2:
    return;
}
Console.WriteLine("Привет, путник!");
Console.WriteLine("Как тебя зовут?");
string? name = Console.ReadLine();
if (name == "Guts")
{
    Console.WriteLine("Вам нету смысла проходить эту игру , враги не достойны вашего внимания!!!!");
    return;
}
Console.WriteLine($"Привет , {name}");
Console.WriteLine("Кем ты был в ином мире?");
Console.WriteLine("Выбери класс:");
Console.WriteLine("1 - воин");
Console.WriteLine("2 - маг");
Console.WriteLine("3 - лучник");
int clas = Convert.ToInt32(Console.ReadLine());
switch (clas)
{
    case 1:
        Console.WriteLine("Теперь ты воин!");
        Console.WriteLine("Такс , теперь подкласс");
        string? clas1 = Console.ReadLine();
        switch (clas1)
        {
            case "Самурай":
                Console.WriteLine("Самурай!");
                PlayerV tom = new PlayerV(clas1, name, 110, 25, 11, 15);
                Console.WriteLine($"Имя:{tom.name}");
                Console.WriteLine($"Подкласс:{tom.Clas1}");
                Console.WriteLine($"HP:{tom.HP}");
                Console.WriteLine($"MP:{tom.MP}");
                Console.WriteLine($"Str:{tom.Str}");
                Console.WriteLine($"Dex:{tom.Dex}");
                break;
            case "Ассасин":
                Console.WriteLine("Ассасин!");
                PlayerV toy = new PlayerV(clas1, name, 90, 25, 7, 19);
                Console.WriteLine($"Имя:{toy.name}");
                Console.WriteLine($"Подкласс:{toy.Clas1}");
                Console.WriteLine($"HP:{toy.HP}");
                Console.WriteLine($"MP:{toy.MP}");
                Console.WriteLine($"Str:{toy.Str}");
                Console.WriteLine($"Dex:{toy.Dex}");
                break;
            case "Рыцарь":
                Console.WriteLine("Рыцарь!");
                PlayerV too = new PlayerV(clas1, name, 170, 10, 18, 6);
                Console.WriteLine($"Имя:{too.name}");
                Console.WriteLine($"Подкласс:{too.Clas1}");
                Console.WriteLine($"HP:{too.HP}");
                Console.WriteLine($"MP:{too.MP}");
                Console.WriteLine($"Str:{too.Str}");
                Console.WriteLine($"Dex:{too.Dex}");
                break;
            default:
                Console.WriteLine("Вы никто!");
                return;
        }
        break;

    case 2:
        Console.WriteLine("Теперь ты маг!");
        Console.WriteLine("Такс , теперь подкласс");
        string? clas2 = Console.ReadLine();
        switch (clas2)
        {
            case "Колдун":
                Console.WriteLine("Колдун!");
                PlayerM top = new PlayerM(clas2, name, 60, 150, 5, 5);
                Console.WriteLine($"Имя:{top.name}");
                Console.WriteLine($"Подкласс:{top.Clas2}");
                Console.WriteLine($"HP:{top.HP}");
                Console.WriteLine($"MP:{top.MP}");
                Console.WriteLine($"Str:{top.Str}");
                Console.WriteLine($"Dex:{top.Dex}");
                break;
            case "Пиромант":
                Console.WriteLine("Пиромант!");
                PlayerM tol = new PlayerM(clas2, name, 70, 145, 6, 6);
                Console.WriteLine($"Имя:{tol.name}");
                Console.WriteLine($"Подкласс:{tol.Clas2}");
                Console.WriteLine($"HP:{tol.HP}");
                Console.WriteLine($"MP:{tol.MP}");
                Console.WriteLine($"Str:{tol.Str}");
                Console.WriteLine($"Dex:{tol.Dex}");
                break;
            default:
                Console.WriteLine("Вы никто!");
                return;
        }
        break;

    case 3:
        Console.WriteLine("Теперь ты лучник!");
        Console.WriteLine("Такс , теперь подкласс");
        Console.WriteLine("!!HARD!!");
        string? clas3 = Console.ReadLine();
        switch (clas3)
        {
            case "Вор":
                Console.WriteLine("Вор!");
                PlayerA tol = new PlayerA(clas3, name, 30, 10, 3, 10);
                Console.WriteLine($"Имя:{tol.name}");
                Console.WriteLine($"Подкласс:{tol.Clas3}");
                Console.WriteLine($"HP:{tol.HP}");
                Console.WriteLine($"MP:{tol.MP}");
                Console.WriteLine($"Str:{tol.Str}");
                Console.WriteLine($"Dex:{tol.Dex}");
                break;
            case "Убийца":
                Console.WriteLine("Убийца!");
                PlayerA top = new PlayerA(clas3, name, 45, 15, 7, 11);
                Console.WriteLine($"Имя:{top.name}");
                Console.WriteLine($"Подкласс:{top.Clas3}");
                Console.WriteLine($"HP:{top.HP}");
                Console.WriteLine($"MP:{top.MP}");
                Console.WriteLine($"Str:{top.Str}");
                Console.WriteLine($"Dex:{top.Dex}");
                break;
            default:
                Console.WriteLine("Вы никто!");
                return;
        }
        break;
    default:
        Console.WriteLine("Вы никто!");
    return;
}
//
//
Console.WriteLine("Это твой инвентарь:");
inventory inv = new inventory("/ /" ,"/ /" , "/ /" , "/ /", "/ /");
Console.WriteLine($"{inv.size1}");
Console.WriteLine($"{inv.size2}");
Console.WriteLine($"{inv.size3}");
Console.WriteLine($"{inv.size4}");
Console.WriteLine($"{inv.size5}");
//
//
Console.WriteLine("Выбери оружие:");
Console.WriteLine("1 - меч");
Console.WriteLine("2 - посох");
Console.WriteLine("3 - лук");
Console.WriteLine("Дай имя своему оружию");
string? NeWeapon = Console.ReadLine();
int weapon = Convert.ToInt32(Console.ReadLine());
switch(weapon)
{ 
    case 1:
        Console.WriteLine("+ меч");
        Weapon Sword = new Weapon(NeWeapon, 5, 0);
        Console.WriteLine($"Имя оружия:{Sword.NeWeapon}");
        Console.WriteLine($"Урон: {Sword.dmg}");
        Console.WriteLine($"Требует маны:{Sword.MnCost}");
        break;
    case 2:
        Console.WriteLine("+ посох");
        Weapon stuff = new Weapon(NeWeapon, 10, 5);
        Console.WriteLine($"Имя оружия:{stuff.NeWeapon}");
        Console.WriteLine($"Урон: {stuff.dmg}");
        Console.WriteLine($"Требует маны:{stuff.MnCost}");     
        break;
    case 3:
        Console.WriteLine("+ лук");
        Weapon bow = new Weapon(NeWeapon, 6, 0);
        Console.WriteLine($"Имя оружия:{bow.NeWeapon}");
        Console.WriteLine($"Урон: {bow.dmg}");
        Console.WriteLine($"Требует маны:{bow.MnCost}");      
        break;
    default:
    Console.WriteLine("Вы не выбрали ничего!");
    break;
}
Weapon Sword1 = new Weapon(NeWeapon, 5, 0);

Console.WriteLine($"Оружие {NeWeapon} , было добавлено в ваш инветарь!");
Console.WriteLine("Это твой инвентарь:");
Console.WriteLine($"{inv.size1}{NeWeapon}{inv.size1}");
Console.WriteLine($"{inv.size2}");
Console.WriteLine($"{inv.size3}");
Console.WriteLine($"{inv.size4}");
Console.WriteLine($"{inv.size5}");
for (int i = 0; i < 1; i++)
{
    Console.WriteLine("Вы встретили врага!");
    Enemy ork = new Enemy(50, 10);
    Console.WriteLine($"Здоровье:{ork.HP}");
    Console.WriteLine($"Урон:{ork.edmg}");
    for (int j = 0; j < 1; j++)
    {
        Console.WriteLine("1 - ударить");
        Console.WriteLine("2 - убежать");
        int dei = Convert.ToInt32(Console.ReadLine());
        switch (dei)
        {
            case 1:
                int sum = ork.HP - Sword1.dmg; // ????????????
                for (int k = ork.HP; k < ork.HP; k++)// ???????????
                {
                    Console.WriteLine($"Осталось от врага:{sum}");// ??????????
                }
            break;
            case 2:
                Console.WriteLine("Вы убежали!");
            break;
        }
    }

    
   
}







