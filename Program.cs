//try
//{
StreamWriter sw1 = new StreamWriter("C:\\Users/Максим/Desktop/1.11/task8-1.11/Ввод.txt");
Console.WriteLine("Введите пример '+','-','/','*'");
Console.WriteLine("Пример x + y");
string str = Console.ReadLine();
sw1.WriteLine(str);
sw1.Close();
StreamWriter sw = new StreamWriter("C:\\Users/Максим/Desktop/1.11/task8-1.11/Вывод.txt");
StreamReader sr = new StreamReader("C:\\Users/Максим/Desktop/1.11/task8-1.11/Ввод.txt");
string[] input = sr.ReadLine().Split(" ");
string[] answmas = new string[input.Length-1];
int answ = 0;
string a = "";
int x = 0;
int k =1;
int j = answmas.Length - 1;
while (k<input.Length)
{
    if (input[k] == "/" || input[k] == "*")
    {
        answmas[x] = input[k - 1];
        answmas[x + 1] = input[k + 1];
        x += 2;  
    }
    k += 2;
    
}
k = 1;
while (k < input.Length)
{
    if (input[k] == "-" || input[k] == "+")
    {
        answmas[j - 1] = input[k - 1];
        answmas[j] = input[k + 1];
        j -= 2;
    }
    k += 2;
}

foreach (string n in answmas)
{
    Console.WriteLine(n);
}

    sw.Close();
    sr.Close();
//}
//catch (Exception e)
//{
//    Console.WriteLine("Exception: " + e.Message);
//}