// See https://aka.ms/new-console-template for more information
Console.WriteLine("Игра Быки и Коровы");
bool endGame = true;
Random random = new Random();
List<int> listRand = new List<int>();     //Лист для создания случайных чисед
for (int i = 0; i < 4;)                   //Заполнение случайными числами
{
    bool Number = false;
    int noRandem = random.Next(0, 9);
    for (int j = 0; j < i; ++j)
    {
        if (listRand[j] == noRandem)
        {
            Number = true;
            break;
        }
    }
    if (!Number&&noRandem!=0)
    {
        listRand.Add(noRandem);
        i++;
    }
}
listRand.Reverse();
while (endGame)                                       
{
    int number = 0;

    Console.WriteLine("Введите четырехзначное число");
try                                                                //Блок try catch для проверки не валидного числа введеного пользователем
    { 
        number = Convert.ToInt32(Console.ReadLine());
    if (number.ToString().Length!=4 )
    {
        Console.WriteLine("Ошибка, введите четырехзначное число");
        break;     
    }
    }
catch (Exception e)
{
    Console.WriteLine("Ошибка, введите цифровое значение");
}

    List<int> listUser = new List<int>();      //Лист для создания пользовательских чисел
    while (number > 0)
    {
        listUser.Add(number % 10);
        number = number / 10;
    }
 
    listUser.Reverse();
        int cow = 0;
        int bull = 0;

    for (int i = 0; i < 4; i++)  //Проверка совпадения чисел
    {

        if (listRand[i]==listUser[i])
        {
            bull++;
        }
        
            for (int j = 0; j < 4; ++j)
            {
                if (listRand[i] == listUser[j])
                {
                    cow++;
                }
            }
        
        if (cow == 4 && bull == 4)
        {
            Console.WriteLine("Игра закончена");
            endGame = false;
            break;

        }
    }
    Console.WriteLine("Количество быков: "+ bull+ "\n" + "Количество коров: " + cow );
}

