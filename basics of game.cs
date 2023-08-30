using game_in_cons;

Weapon equippedWeapon = null;
PlayerV playerV = null;
PlayerM playerM = null;
PlayerA playerA = null;

int deistv; 
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
        Console.WriteLine("Список подклассов (Чтобы выбрать подкласс просто введите его название):");
        Console.WriteLine("- Самурай");
        Console.WriteLine("+ Ассасин");
        Console.WriteLine("* Рыцарь");
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
        Console.WriteLine("Список подклассов (Чтобы выбрать подкласс просто введите его название):");
        Console.WriteLine("+ Колдун");
        Console.WriteLine("+ Пиромант");
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
        Console.WriteLine("Список подклассов (Чтобы выбрать подкласс просто введите его название):");
        Console.WriteLine("** Вор");
        Console.WriteLine("** Убийца");
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
Console.WriteLine("Выбери оружие:");
Console.WriteLine("1 - меч");
Console.WriteLine("2 - посох");
Console.WriteLine("3 - лук");
Console.WriteLine("Дай имя своему оружию:");
string? NeWeapon = Console.ReadLine();
int weapon = Convert.ToInt32(Console.ReadLine());

switch (weapon)
{ 
    case 1:
        Console.WriteLine("+ меч");
        Weapon sword = new Weapon(NeWeapon, 5, 0);
        equippedWeapon = sword;
        if (playerV != null)
        {
            playerV.Inventory.AddItem(sword);
        }
        else if (playerM != null)
        {
            playerM.Inventory.AddItem(sword);
        }
        else if (playerA != null)
        {
            playerA.Inventory.AddItem(sword);
        }
        Console.WriteLine($"Имя оружия: {sword.NeWeapon}");
        Console.WriteLine($"Урон: {sword.dmg}");
        Console.WriteLine($"Требует маны: {sword.MnCost}");
        break;
    case 2:
        Console.WriteLine("+ посох");
        Weapon stuff = new Weapon(NeWeapon, 10, 5);
        equippedWeapon = stuff;
        if (playerV != null)
        {
            playerV.Inventory.AddItem(stuff);
        }
        else if (playerM != null)
        {
            playerM.Inventory.AddItem(stuff);
        }
        else if (playerA != null)
        {
            playerA.Inventory.AddItem(stuff);
        }
        Console.WriteLine($"Имя оружия:{stuff.NeWeapon}");
        Console.WriteLine($"Урон: {stuff.dmg}");
        Console.WriteLine($"Требует маны:{stuff.MnCost}");     
        break;
    case 3:
        Console.WriteLine("+ лук");
        Weapon bow = new Weapon(NeWeapon, 6, 0);
        equippedWeapon = bow;
        if (playerV != null)
        {
            playerV.Inventory.AddItem(bow);
        }
        else if (playerM != null)
        {
            playerM.Inventory.AddItem(bow);
        }
        else if (playerA != null)
        {
            playerA.Inventory.AddItem(bow);
        }
        Console.WriteLine($"Имя оружия:{bow.NeWeapon}");
        Console.WriteLine($"Урон: {bow.dmg}");
        Console.WriteLine($"Требует маны:{bow.MnCost}");      
        break;
    default:
    Console.WriteLine("Вы не выбрали ничего!");
    break;
}

//if (playerV != null)
//{
//    playerV.Inventory.ShowInventory();
//}
//else if (playerM != null)
//{
//    playerM.Inventory.ShowInventory();
//}
//else if (playerA != null)
//{
//    playerA.Inventory.ShowInventory();
//}

Console.WriteLine("1 - пойти в лес ");
Console.WriteLine("2 - торговая лавка");
Console.WriteLine("3 - путешествовать");
int dei = Convert.ToInt32(Console.ReadLine());

if (dei == 1)
{
    Console.WriteLine("Вы идёте в лес");
    Console.WriteLine("...");
}
else if (dei == 2)
{
    Console.WriteLine("Торговая лавка - в разработке");
}
else if (dei == 3)
{
    List<string> availableEnemyNames = new List<string>
    {
      "Goblin", "Orc", "Troll", "Skeleton", "Zombie", "Vampire", "Werewolf", "Demon"
    };

    Random random = new Random();

    string randomEnemyName = availableEnemyNames[random.Next(availableEnemyNames.Count)];

    int enemyHP = random.Next(30, 101); // Случайное значение HP в диапазоне [30, 100]
    int enemyDamage = random.Next(5, 21); // Случайное значение урона в диапазоне [5, 20]

    Enemy enemy = new Enemy(randomEnemyName, enemyHP, enemyDamage);
    Console.WriteLine($"На вас напал {enemy.Name} хп:{enemyHP} урон:{enemyDamage}! Бой начинается!");

    do
    {
        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1 - Атаковать");
        Console.WriteLine("2 - Защита");
        Console.WriteLine("3 - Убежать");

        deistv = Convert.ToInt32(Console.ReadLine());

        if (playerV != null)
        {
            equippedWeapon = playerV.Inventory.GetEquippedWeapon();
        }
        else if (playerM != null)
        {
            equippedWeapon = playerM.Inventory.GetEquippedWeapon();
        }
        else if (playerA != null)
        {
            equippedWeapon = playerA.Inventory.GetEquippedWeapon();
        }

        if (equippedWeapon == null)
        {
            Console.WriteLine("У вас нет носимого оружия.");
            return;
        }

        switch (deistv)
        {
            case 1:

                do
                {
                    Console.WriteLine("1 - Атака обычная");
                    Console.WriteLine("2 - Атака со стойки + 5 урон (требуется мана)");
                    deistv = Convert.ToInt32(Console.ReadLine());
                    switch (deistv)
                    {
                            case 1:
                                Console.WriteLine("Вы атакуете!");
                                int damageDealt = equippedWeapon.dmg;
                                enemy.HP -= damageDealt;
                                Console.WriteLine($"Вы нанесли {damageDealt} урона. Осталось хп у врага: {enemy.HP}");
                            break;

                            case 2:
                                Console.WriteLine("Вы атакуете!");
                                if(playerV.MP > equippedWeapon.MnCost)
                                {

                                    int damageDealt1 = equippedWeapon.dmg + 5;
                                    enemy.HP -= damageDealt1;

                                    playerV.MP -= equippedWeapon.MnCost;
                                    Console.WriteLine($"Вы нанесли {damageDealt1} урона. Осталось маны у вас:{playerV.MP},Осталось хп у врага: {enemy.HP}");

                                }
                                else
                                {
                                    Console.WriteLine("Not enough mana!");
                                }
                            break;
                    }
                } while (deistv != 0 && enemy.HP > 0);
                break;
            case 2:
                Console.WriteLine("Вы выбрали защиту.");
                // Логика защиты
                break;
            case 3:
                Console.WriteLine("Вы пытаетесь убежать.");
                // Логика убегания
                break;
            default:
                Console.WriteLine("Вы выбрали некорректное действие.");
                break;
        }
    } while (deistv != 0 && enemy.HP > 0);

    if (enemy.HP <= 0)
    {
        Console.WriteLine("Вы победили!");
    }
    else
    {
        Console.WriteLine("Вы сбежали с поля боя!");
    }
}
