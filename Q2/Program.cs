Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int numberInInt;
bool IsInt = int.TryParse(number,out numberInInt);
if (IsInt)
    {
    if (numberInInt < 100)
        {
        Console.WriteLine("Третьей цифры нет");    
        }
    else
        {
        if (numberInInt < 1000)
            {
            Console.WriteLine("Третья цифра: " + numberInInt%10); // 432 = 2 
            }
        else
            {
            //Немножко читерства используя string, но это единственный нормальный способ узнать длинну int
            Console.WriteLine("Третья цифра: " + (numberInInt/intPower(10,(numberInInt.ToString().Length - 3)))%10);
            }
        }
    }
else
    {
    Console.WriteLine("Это не целое число");
    }

int intPower(int x, int y) // x - число, y - степень
    {
    int pow = 1;
    int z = x;
    while (pow < y)
        {
        pow++;
        z = z * x;            
        }
    return z;
    }