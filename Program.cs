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
int k =1;
int x = 0;
int y = 0;
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
    switch (input[k])
    {
        case "*":
            znak[y] = k;
            y++;
            break;
        case "/":
            znak[y] = k;
            y++;
            break;
        case "+":
            znak[y] = k;
            y++;
            break;
        case "-":
            znak[y] = k;
            y++;
            break;
    }
    k += 2;
}

Stack<int> output = new Stack<int>();
for(int i = 0; i < znak.Length  ; i++)
{

    if (i != znak.Length-1)
    {
        if ((input[znak[i]] == "*" || input[znak[i]] == "/") && (input[znak[i + 1]] != "*" && input[znak[i + 1]] != "/"))
        {
            switch (input[znak[i]])
            {
                case "*":
                    output.Push(ymn(Convert.ToInt32(input[znak[i] - 1]), Convert.ToInt32(input[znak[i] + 1])));
                    break;
                case "/":
                    output.Push(del(Convert.ToInt32(input[znak[i] - 1]), Convert.ToInt32(input[znak[i] + 1])));
                    break;
            }
            
            
        }
        else if ((input[znak[i]] == "*" || input[znak[i]] == "/") && (input[znak[i + 1]] == "*" || input[znak[i + 1]] == "/"))
        {
            switch (input[znak[i]])
            {
                case "*":
                    output.Push(ymn(Convert.ToInt32(input[znak[i] - 1]), Convert.ToInt32(input[znak[i] + 1])));
                    break;
                case "/":
                    output.Push(del(Convert.ToInt32(input[znak[i] - 1]), Convert.ToInt32(input[znak[i] + 1])));
                    break;
            }
            switch (input[znak[i + 1]])
            {

                case "*":
                    x = output.Pop();
                    output.Push(ymn(x, Convert.ToInt32(input[znak[i + 1] + 1])));
                    break;
                case "/":
                    x = output.Pop();
                    output.Push(del(x, Convert.ToInt32(input[znak[i + 1] + 1])));
                    break;
            }
            i++;
        }
        else if ((input[znak[i]] == "-" || input[znak[i]] == "+") && (input[znak[i + 1]] != "*" && input[znak[i + 1]] != "/") && i != 0)
        {
            output.Push(Convert.ToInt32(input[znak[i] + 1]));
        }
        else if ((input[znak[i]] == "-" || input[znak[i]] == "+") && (input[znak[i + 1]] != "*" || input[znak[i + 1]] != "/") && i == 0)
        {
            output.Push(Convert.ToInt32(input[znak[i] - 1]));
            output.Push(Convert.ToInt32(input[znak[i] + 1]));
            
        }
        else if ((input[znak[i]] == "-" || input[znak[i]] == "+") && (input[znak[i + 1]] == "*" || input[znak[i + 1]] == "/"))
        {

        }
    }
    else
    {
        if (input[znak[i]] == "*" || input[znak[i]] == "/")
        {
            switch (input[znak[i]])
            {
                case "*":
                    output.Push(ymn(Convert.ToInt32(input[znak[i] - 1]), Convert.ToInt32(input[znak[i] + 1])));
                    break;
                case "/":
                    output.Push(del(Convert.ToInt32(input[znak[i] - 1]), Convert.ToInt32(input[znak[i] + 1])));
                    break;
            }
            
        }
        else if (input[znak[i]] == "+" || input[znak[i]] == "-")
        {
            output.Push(Convert.ToInt32(input[znak[i] + 1]));
            
        }
    }
}
for (int i = 0; i < znak.Length; i++)
{

    if (i != znak.Length - 1)
    {
        if ((input[znak[i]] == "*" || input[znak[i]] == "/") && (input[znak[i + 1]] != "*" && input[znak[i + 1]] != "/"))
        {
            List<int> list = new List<int>(znak);
            list.Remove(znak[i]);
            znak = list.ToArray();

        }
        else if ((input[znak[i]] == "*" || input[znak[i]] == "/") && (input[znak[i + 1]] == "*" || input[znak[i + 1]] == "/"))
        {
            
            List<int> list = new List<int>(znak);
            list.Remove(znak[i]);
            znak = list.ToArray();
            i++;
            List<int> list1 = new List<int>(znak);
            list1.Remove(znak[i]);
            znak = list1.ToArray();
        }
        else if ((input[znak[i]] == "-" || input[znak[i]] == "+") && (input[znak[i + 1]] != "*" || input[znak[i + 1]] != "/") && i == 0)
        {
            List<int> list = new List<int>(znak);
            list.Remove(znak[i]);
            znak = list.ToArray();
        }
    }
    else
    {
        if (input[znak[i]] == "*" || input[znak[i]] == "/")
        {
            List<int> list = new List<int>(znak);
            list.Remove(znak[i]);
            znak = list.ToArray();
        }
        else if (input[znak[i]] == "+" || input[znak[i]] == "-")
        {
            List<int> list = new List<int>(znak);
            list.Remove(znak[i]);
            znak = list.ToArray();
        }
    }
}
foreach(int n in output)
{
    Console.WriteLine(n);
}
foreach (int n  in znak)
{
    Console.WriteLine(n);
}
while (output.Count != 1)
{
    for (int i = 0; i < znak.Length; i++)
    {
        switch (input[znak[i]])
        {
            case "+":
                output.Push(output.Pop() + output.Pop());
                break;
            case "-":
                int sec = output.Pop();
                int fir = output.Pop();
                output.Push(sec + fir);
                break;
            case "/":
                int sec1 = output.Pop();
                int fir2 = output.Pop();
                output.Push(sec1 / fir2);
                break;
            case "*":
                output.Push(output.Pop() * output.Pop());
                break;

        }
    }
}
Console.WriteLine(output.Pop());
    sw.Close();
    sr.Close();
//}
//catch (Exception e)
//{
//    Console.WriteLine("Exception: " + e.Message);
//}