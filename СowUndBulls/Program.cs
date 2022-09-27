// See https://aka.ms/new-console-template for more information
while (true)
{
    Console.WriteLine("Введите четырехзначное число");
    while (true)
    {
        int number = 0;
        int cow = 0;
        int bull = 0;
        try
            {
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 1000 || number > 9999)
            {
                Console.WriteLine("Ошибка, введите четырехзначное число");
                break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Ошибка, введите цифровое значение");
        }
        Random random = new Random();
        int randNumber = random.Next(1000,9999);
        Console.WriteLine(randNumber);
       
            List<int> listRand = new List<int>();
        List<int> listUser = new List<int>();
            while(randNumber > 0&&number>0)
            {
                listRand.Add(randNumber%10);
                listUser.Add(number%10);
                randNumber = randNumber / 10;
                number = number / 10;
            }
            listRand.Reverse();
        listUser.Reverse();

        for (int i = 0; i < listUser.Count; i++)
        {
            if (listRand[i] == listUser[i])
            {
                bull++;
            }
            for(int j = 0; j < i; ++j)
            {

            }
        }
        Console.WriteLine(bull+" Количество быков");
       
    } 
     
    
}
public class rand
{
    
}