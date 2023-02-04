//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

string str = "";
int [] num;
int count = 0;
string EnteringAnArrayOfNumbersFromTheKeyboard()
    {
        Console.WriteLine("Введите любые целые числа через запятую");
        string? str= Console.ReadLine();
        return str!;
    }
int [] CcnvertingStringArrayNumbers(string str)
{
    string[] strnum = str!.Split(new char[] { ',' });
    int [] num = new int [strnum.Length];
    for(int i =0; i < strnum.Length; i++)
        {
            num[i] = Convert.ToInt32(strnum[i]);
        }
    return num;
}
int NumbersLessThanZero(int [] num)
{
    for(int i = 0; i < num.Length; i++)
        {
            if(num[i] > 0) count++;
        }
    return count;
}
str = EnteringAnArrayOfNumbersFromTheKeyboard();

num = CcnvertingStringArrayNumbers(str);
count = NumbersLessThanZero(num);
Console.WriteLine($"В массиве столько чисел больше 0: {count}");