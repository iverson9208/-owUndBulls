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
    link1:
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
            for(int i=0;i<listUser.Count-1;++i)
    {
        for(int j = i+1; j < listUser.Count; ++j)
        {
            if (listUser[i] == listUser[j])
            {

                Console.WriteLine("Введите разные цифры в числе");
                goto link1;
            }
        }
    }
    listUser.Reverse();
        int cow = 0;
        int bull = 0;
    for (int i = 0; i < listUser.Count; i++)  //Проверка совпадения чисел
    {
        if (listUser.Contains(listRand[i]))
        {
            if (listUser[i] == listRand[i])
            {
                bull++;
            }
            else
            { 
                cow++;
            }
        }
    }
        if (bull == 4)
        {
            Console.WriteLine("Игра закончена");
            endGame = false;
            break;

        }
    
    Console.WriteLine("Количество быков: "+ bull+ "\n" + "Количество коров: " + cow );
}

