//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
string str = "";
int [] num;
int number = 0;
string EnteringAnArrayOfNumbersFromTheKeyboard()
    {
        Console.WriteLine("Введите через запятую попорядку коэффициенты: b1, k1, b2, k2");
        string? str= Console.ReadLine();
        return str!;
    }
int [] CcnvertingStringArrayNumbers(string str)
{
    string[] strnum = str!.Split(new char[] { ',' });
    int [] num = new int [strnum.Length];
    for(int i =0; i < strnum.Length; i++)
        {
            if(int.TryParse(strnum[i],out number) == true)
                {
                    num[i] = number;
                }
            else
                {
                    Console.WriteLine("Введено не число.Выход из программы");
                    break;
                }
    if(strnum.Length < 4)
        {
            Console.WriteLine("Введены не все коэффициенты.Выход из программы");
            break;   
        } 
    else if(strnum.Length > 4)
        {
            Console.WriteLine("Введенo коэффициентов больше чем нужно.Выход из программы");
            break;   
        }              
        }
    return num;
}

void CoordinatesIntersectionStraightLines(int [] num)
    {
        if (num[0] == num[2] && num[1] == num[3])
            {
                Console.WriteLine("Прямые совпадают");
            }
        else if (num[0] == num[2] && num[1] != num[3])
            {
                Console.WriteLine("Прямые параллельны друг другу");
            }
        else
            {
                var x = (double)(num[2] - num[0]) / (num[1] - num[3]);
                var y = (double)num[1] * (num[2] - num[0]) / (num[1] - num[3]) + num[0];
                Console.WriteLine($"Х равен: {x}, Y равен: {y}");
            }    
    }

str = EnteringAnArrayOfNumbersFromTheKeyboard();
num = CcnvertingStringArrayNumbers(str);
CoordinatesIntersectionStraightLines(num);

