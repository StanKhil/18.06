namespace _18._06
{
    internal class Program
    {


        static void Task1()
        {
            List<string> a = new List<string>();
            a.Add("1");
            a.Add("11");
            a.Add("21");
            a.Add("1211");
            a.Add("111221");
            a.Add("312211");
            a.Add("13112221");
            //Console.WriteLine(a.Count);
            //Console.WriteLine(a[a.Count - 1]);
            Console.WriteLine("Введите номер числа в последовательности");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x <= a.Count) Console.WriteLine(a[x - 1]);
            else
            {
                while (a.Count < x)
                {
                    string temp = "";
                    string s = a[a.Count - 1];
                    //Console.WriteLine(s);
                    char t = s[0];
                    int count = 0;
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] == t) count++;
                        else
                        {
                            temp += count;
                            temp += t;
                            t = s[i];
                            count = 1;
                        }
                        //Console.WriteLine(temp);
                    }
                    temp += count;
                    temp += t;
                    a.Add(temp);
                    //Console.WriteLine("ok  " + temp);
                }
                Console.WriteLine(a[x - 1]);
            }
            /*foreach (var item in a)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();*/
            
        }


        static void Task2()
        {
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите m");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, m];

            int x = 1;
            int minRow = 0;
            int maxRow = n - 1;
            int minCol = 0;
            int maxCol = m - 1;

            while (x <= n * m)
            {
                for (int i = minCol; i <= maxCol && x <= n * m; i++) a[minRow, i] = x++;
                minRow++;
                for (int i = minRow; i <= maxRow && x <= n * m; i++) a[i, maxCol] = x++;
                maxCol--;
                for (int i = maxCol; i >= minCol && x <= n * m; i--) a[maxRow, i] = x++;
                maxRow--;
                for (int i = maxRow; i >= minRow && x <= n * m; i--) a[i, minCol] = x++;
                minCol++;
            }
            for (int i = 0; i < n; i++){ 
                for (int j = 0; j < m; j++)Console.Write(a[i,j] + " ");
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            //Одномерные массивы, задача 3
            Task1();
            //Двумерные массивы, задача 1
            Task2();
        }
    }
}
