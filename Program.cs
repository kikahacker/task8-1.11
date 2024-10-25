//try
//{
    StreamWriter sw1 = new StreamWriter("C:\\Users/prdb/Desktop/JDJD/task8/Ввод.txt");
    Console.WriteLine("Введите пример '+','-','/','*'");
    Console.WriteLine("Пример x + y");
    string str = Console.ReadLine();
    sw1.WriteLine(str);
    sw1.Close();
    StreamWriter sw = new StreamWriter("C:\\Users/prdb/Desktop/JDJD/task8/Вывод.txt");
    StreamReader sr = new StreamReader("C:\\Users/prdb/Desktop/JDJD/task8/Ввод.txt");
    string[] input = sr.ReadLine().Split(" ");
    int[] znak = new int[input.Length/2];
    string[] answmas = new string[input.Length];
    int answ = 0;
    int del = 0;
    int umn = 0;
    int x = 0;
        for (int i = 0;i < input.Length; i++)
        {
        switch (input[i])
        {
            case "+":
                znak[x] = i ;
                x++;
                break;
            case "-":
                znak[x] = i ;
                x++;
                break;
            case "/":
                znak[x] = i ;
                x++;
                break;
            case "*":
                znak[x] = i ;
                x++;
                break;
        }
    }  

    
    
    for (int k = znak.Length; k > 0; k--)
    {
   for (int j = 0; j < znak.Length; j++)
    {
        for (int i = 0; i < znak.Length; i++)
        {
            if (input[znak[i]] == "/" || input[znak[i]] == "*")
            {
                answmas[j] = input[znak[i]-1];
                answmas[j+1] = input[znak[i]+1];
            }
            if (input[znak[i]] == "+" || input[znak[i]] == "-")
            {
                answmas[k] = input[znak[i]-1];
                answmas[k + 1] = input[znak[i]+1];
            }
        }
    }     
}

   foreach (string i in answmas)
{
    Console.WriteLine(i);
}
    
   // Console.WriteLine(answ);
   // sw.WriteLine(answ);
    
    sw.Close();
    sr.Close();
//}
//catch (Exception e)
//{
//    Console.WriteLine("Exception: " + e.Message);
//}