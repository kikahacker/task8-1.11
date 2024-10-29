//try
//{
using System.Runtime.CompilerServices;

StreamWriter sw1 = new StreamWriter("C:\\Users/prdb/Desktop/JDJD/task8-1.11/Ввод.txt");
Console.WriteLine("Введите пример '+','-','/','*'");
Console.WriteLine("Пример x + y");
string str = Console.ReadLine();
sw1.WriteLine(str);
sw1.Close();
StreamWriter sw = new StreamWriter("C:\\Users/prdb/Desktop/JDJD/task8-1.11/Вывод.txt");
StreamReader sr = new StreamReader("C:\\Users/prdb/Desktop/JDJD/task8-1.11/Ввод.txt");
string[] input = sr.ReadLine().Split(" ");
string[] answmas = new string[input.Length-1];
int[] znak = new int[input.Length / 2 ];
int answ = 0;
string a = "";
int x = 0;
int k =1;
int y = 0;
int l = 0;
int len = answmas.Length - 1;
int j = answmas.Length - 1;
static int plus(int x,int y)
{
    return x + y;
}
static int min(int x,int y)
{
    return x - y;
}
static int ymn(int x,int y)
{
    return x * y;
}
static int del(int x,int y)
{
    return x / y;
}
while (k < input.Length)
{

    if (input[k] == "/" || input[k] == "*")
    {
        if (input[k - 1] == input[k + 1])
        {
            answmas[x] = input[k - 1];
            x++;
        }
        else
        {
            answmas[x] = input[k - 1];
            answmas[x + 1] = input[k + 1];
            x += 2;
        }


        switch (input[k])
        {
            case "/":
                znak[y] = k;
                y++;
                break;
            case "*":
                znak[y] = k;
                y++;
                break;
        }
    }
    k +=2 ;

}
k = answmas.Length - 1;
while (k  > 0)
{ 
    if (input[k] == "-" || input[k] == "+")
    {
        if (input[k - 1] == input[k + 1])
        {
            answmas[j-1] = input[k - 1];
            j--;
        }
        else
        {
            answmas[j-1] = input[k - 1];
            answmas[j] = input[k + 1];
            j -= 2;
        }
        
    }
    k -=2;
}
k = 1;
while (k < input.Length)
{

    if (input[k] == "+" || input[k] == "-")
    {
        switch (input[k])
        {
            case "+":
                znak[y] = k;
                y++;
                break;
            case "-":
                znak[y] = k;
                y++;
                break;
        }
    }
    k += 2;
}
    foreach (string n in answmas)
{
    Console.WriteLine(n);
}
foreach (int n in znak)
{
    Console.WriteLine(n);
}
Stack<string> output = new Stack<string>(answmas.Reverse());
int i = 0;
while (answmas.Length > 1)
{
    string first = answmas[i];
    string second = answmas[i+1];
    switch (input[znak[l]])
    {
        case "+":
            answ += plus(Convert.ToInt32(first), Convert.ToInt32(second));
            output.Pop();
            output.Pop();
            answmas = output.ToArray();
            Console.WriteLine("ANSW    ");
     
            Console.WriteLine(plus(Convert.ToInt32(first), Convert.ToInt32(second)));
            l++;
            break;
        case "-":
            answ += min(Convert.ToInt32(first), Convert.ToInt32(second));
            output.Pop();
            output.Pop();
            answmas = output.ToArray();
            Console.WriteLine("ANSW    ");
            Console.WriteLine(min(Convert.ToInt32(first), Convert.ToInt32(second)));
            l++;
            break;
        case "*":
            answ += ymn(Convert.ToInt32(first), Convert.ToInt32(second));
            output.Pop();
            output.Pop();
            answmas = output.ToArray();
            Console.WriteLine("ANSW    ");
            Console.WriteLine(ymn(Convert.ToInt32(first), Convert.ToInt32(second)));
            l++;
            break;
        case "/":
            answ += del(Convert.ToInt32(first), Convert.ToInt32(second));
            output.Pop();
            output.Pop();
            answmas = output.ToArray();
            Console.WriteLine("ANSW    ");
            Console.WriteLine(del(Convert.ToInt32(first), Convert.ToInt32(second)));
            l++;
            break;
    }

}

Console.WriteLine(answ);

    sw.Close();
    sr.Close();
//}
//catch (Exception e)
//{
//    Console.WriteLine("Exception: " + e.Message);
//}