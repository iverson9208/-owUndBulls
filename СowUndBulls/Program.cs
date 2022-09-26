// See https://aka.ms/new-console-template for more information
while (true)
{
    Console.WriteLine("Введите четырехзначное число");
    while (true)
    {
        try
            {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 1000 || number > 9999)
            {
                Console.WriteLine("Ошибка, введите четырехзначное число");
                break;
            }
            int num1 = number / 1000;
            int num2 = (number % 1000) / 100;
            int num3 = (number % 100) / 10;
            int num4 = number %10;
            Console.WriteLine(num1 + " " + num2 + " " + num3+" "+num4);
        }
        catch (Exception e)
        {
            Console.WriteLine("Ошибка, введите цифровое значение");
        }
        Random random = new Random();
        int randNumber = random.Next(0,1000);
    } 
     
    
}
public class rand
{
    
}