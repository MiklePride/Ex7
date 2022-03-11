class program
{
    static void Main(string[] args)
    {
        int gold;
        int crystals;
        int crystalPrice = 15;

        Console.WriteLine("Добро пожаловать в игру! С каким количеством золота желаете начать?");
        gold = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Добро пожаловать в лавку кристаллов, у нас есть чудесные кристаллы, всего за {0} золота. Сколько желаете купить?", crystalPrice);
        crystals = Convert.ToInt32(Console.ReadLine());
        gold = gold - (crystals * crystalPrice);
        Console.WriteLine("Спасибо за покупку! Ваш балланс {0} кристаллов и {1} золота", crystals, gold);
    }   
}
