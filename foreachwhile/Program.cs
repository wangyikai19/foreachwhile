using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachwhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////3-1
            //int i,min,temp;
            //Console.WriteLine("請輸入10個整數");
            //Console.WriteLine("請輸入第1個整數");
            //min = Convert.ToInt32(Console.ReadLine());
            //for (i = 2; i <= 10; i++)
            //{
            //    Console.WriteLine($"請輸入第{i}個整數");
            //    temp = Convert.ToInt32(Console.ReadLine());
            //    if (temp < min)
            //    {
            //        min = temp;
            //    }
            //}
            //Console.WriteLine($"最小值為{min}");
            //Console.ReadKey();

            ////3-1 while
            //int i, min, temp;
            //Console.WriteLine("請輸入10個整數");
            //Console.WriteLine("請輸入第1個整數");
            //min = Convert.ToInt32(Console.ReadLine());
            //for (i = 2; i <= 10; i++)
            //{
            //    Console.WriteLine($"請輸入第{i}個整數");
            //    temp = Convert.ToInt32(Console.ReadLine());
            //    while (temp < min)
            //    {
            //        min = temp;
            //    }
            //}
            //Console.WriteLine($"最小值為{min}");
            //Console.ReadKey();

            ////3-2
            //int i,n, min, temp;
            //Console.WriteLine("請輸入n個整數,n=:");
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入第1個整數");
            //min = Convert.ToInt32(Console.ReadLine());
            //for (i = 2; i <= n; i++)
            //{
            //    Console.WriteLine($"請輸入第{i}個整數");
            //    temp = Convert.ToInt32(Console.ReadLine());
            //    if (temp < min)
            //    {
            //        min = temp;
            //    }
            //}
            //Console.WriteLine($"最小值為{min}");
            //Console.ReadKey();

            ////3-2 while
            //int i, n, min, temp;
            //Console.WriteLine("請輸入n個整數,n=:");
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入第1個整數");
            //min = Convert.ToInt32(Console.ReadLine());
            //for (i = 2; i <= n; i++)
            //{
            //    Console.WriteLine($"請輸入第{i}個整數");
            //    temp = Convert.ToInt32(Console.ReadLine());
            //    while (temp < min)
            //    {
            //        min = temp;
            //    }
            //}
            //Console.WriteLine($"最小值為{min}");
            //Console.ReadKey();

            ////3-3
            //int i, min;
            //string temp="";
            //Console.WriteLine("請輸入10個整數");

            //for (i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"請輸入第{i}個整數");
            //    min = Convert.ToInt32(Console.ReadLine());
            //    if (min > 12)
            //    {
            //        temp += min.ToString() + ",";
            //    }
            //}
            //temp = temp.Substring(0, temp.Length - 1);
            //Console.WriteLine($"大於12的值有{temp}");
            //Console.ReadKey();

            ////3-3 while
            //int i, min;
            //string temp = "";
            //Console.WriteLine("請輸入10個整數");

            //for (i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"請輸入第{i}個整數");
            //    min = Convert.ToInt32(Console.ReadLine());
            //    while(min > 12)
            //    {
            //        temp += min.ToString() + ",";
            //    }
            //}
            //temp = temp.Substring(0, temp.Length - 1);
            //Console.WriteLine($"大於12的值有{temp}");
            //Console.ReadKey();

            ////3-4
            //int i, min, temp=0;
            //Console.WriteLine("請輸入10個整數");

            //for (i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"請輸入第{i}個整數");
            //    min = Convert.ToInt32(Console.ReadLine());
            //    if (min > 12)
            //    {
            //        temp += min;
            //    }
            //}
            //Console.WriteLine($"大於12的值總和為:{temp}");
            //Console.ReadKey();

            ////3-4 while
            //int i, min, temp = 0;
            //Console.WriteLine("請輸入10個整數");

            //for (i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"請輸入第{i}個整數");
            //    min = Convert.ToInt32(Console.ReadLine());
            //    if (min > 12)
            //    {
            //        temp += min;
            //    }
            //}
            //Console.WriteLine($"大於12的值總和為:{temp}");
            //Console.ReadKey();

            ////3-5
            //int i, n, max, temp,count=0;
            //Console.WriteLine("請輸入n個整數,n=:");
            //n = Convert.ToInt32(Console.ReadLine());
            //max = 1;
            //for (i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"請輸入第{i}個整數");
            //    temp = Convert.ToInt32(Console.ReadLine());
            //    if (temp%2==1)
            //    {
            //        count++;

            //        if (temp > max)
            //        {
            //            max = temp;
            //        }
            //    }
            //}
            //if (count > 0)
            //{
            //    Console.WriteLine($"最大奇數為{max}");
            //}
            //else
            //{
            //    Console.WriteLine($"您輸入的無奇數!");
            //}
            //Console.ReadKey();

            ////3-5 while
            //int i, n, max, temp, count = 0;
            //Console.WriteLine("請輸入n個整數,n=:");
            //n = Convert.ToInt32(Console.ReadLine());
            //max = 1;
            //for (i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"請輸入第{i}個整數");
            //    temp = Convert.ToInt32(Console.ReadLine());
            //    while (temp % 2 == 1)
            //    {
            //        count++;

            //        if (temp > max)
            //        {
            //            max = temp;
            //        }
            //    }
            //}
            //if (count > 0)
            //{
            //    Console.WriteLine($"最大奇數為{max}");
            //}
            //else
            //{
            //    Console.WriteLine($"您輸入的無奇數!");
            //}
            //Console.ReadKey();

            ////3-6
            //int i, n;
            //double max = 0, temp;
            //Console.WriteLine("請輸入n個整數,n=:");
            //n = Convert.ToInt32(Console.ReadLine());
            //for (i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"請輸入第{i}個整數");
            //    temp = Convert.ToDouble(Console.ReadLine());
            //    if (temp > 0)
            //    {
            //        max += Math.Pow(temp, 2);
            //    }
            //}
            //Console.WriteLine($"所有正數之平方的加總{max}");
            //Console.ReadKey();

            ////3-6 while
            //int i, n;
            //double max = 0, temp;
            //Console.WriteLine("請輸入n個整數,n=:");
            //n = Convert.ToInt32(Console.ReadLine());
            //for (i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"請輸入第{i}個整數");
            //    temp = Convert.ToDouble(Console.ReadLine());
            //    while (temp > 0)
            //    {
            //        max += Math.Pow(temp, 2);
            //    }
            //}
            //Console.WriteLine($"所有正數之平方的加總{max}");
            //Console.ReadKey();

            ////3-7
            //int i, n, temp;
            //string total="";
            //Console.WriteLine("請輸入n個整數,n=:");
            //n = Convert.ToInt32(Console.ReadLine());
            //for (i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"請輸入第{i}個整數");
            //    temp = Convert.ToInt32(Console.ReadLine());
            //    if (temp < 0)
            //    {
            //        total += temp.ToString() + "會被轉為:";
            //        temp = -temp;
            //        total += temp.ToString() + ";";
            //    }
            //}
            //Console.WriteLine($"{total}");
            //Console.ReadKey();

            ////3-7 while
            //int i, n, temp;
            //string total = "";
            //Console.WriteLine("請輸入n個整數,n=:");
            //n = Convert.ToInt32(Console.ReadLine());
            //for (i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"請輸入第{i}個整數");
            //    temp = Convert.ToInt32(Console.ReadLine());
            //    while (temp < 0)
            //    {
            //        total += temp.ToString() + "會被轉為:";
            //        temp = -temp;
            //        total += temp.ToString() + ";";
            //    }
            //}
            //Console.WriteLine($"{total}");
            //Console.ReadKey();

            ////補充習題1
            //string answer = "質數有";

            //for(int i = 101; i < 201; i++)
            //{
            //    bool isnumber = true;
            //    for (int j =2; j < i-1; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isnumber = false;
            //            break;
            //        }

            //    }
            //    if (isnumber)
            //    {
            //        answer += i.ToString() + ",";
            //    }

            //}
            //answer = answer.Substring(0, answer.Length - 1);
            //Console.WriteLine($"{answer}");
            //Console.ReadKey();

            ////補充習題1 while
            //string answer = "質數有";

            //for (int i = 101; i < 201; i++)
            //{
            //    bool isnumber = true;
            //    for (int j = 2; j < i - 1; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isnumber = false;
            //            break;
            //        }

            //    }
            //    if (isnumber)
            //    {
            //        answer += i.ToString() + ",";
            //    }

            //}
            //answer = answer.Substring(0, answer.Length - 1);
            //Console.WriteLine($"{answer}");
            //Console.ReadKey();

            ////補充習題2
            //int x;
            //string answer = "質因數有";
            //Console.WriteLine("請輸入1個整數:");
            //x = Convert.ToInt32(Console.ReadLine());

            //for (int i = 2; i < x; i++)
            //{
            //    bool isnumber = true;
            //    for (int j = 2; j < i - 1; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isnumber = false;
            //            break;
            //        }

            //    }
            //    if (isnumber)
            //    {
            //        if (x % i == 0)
            //        {
            //            answer += i.ToString() + ",";
            //        }

            //    }

            //}
            //answer = answer.Substring(0, answer.Length - 1);
            //Console.WriteLine($"{answer}");
            //Console.ReadKey();

            ////補充習題2 while
            //int x;
            //string answer = "質因數有";
            //Console.WriteLine("請輸入1個整數:");
            //x = Convert.ToInt32(Console.ReadLine());

            //for (int i = 2; i < x; i++)
            //{
            //    bool isnumber = true;
            //    for (int j = 2; j < i - 1; j++)
            //    {
            //        while (i % j == 0)
            //        {
            //            isnumber = false;
            //            break;
            //        }

            //    }
            //    while (isnumber)
            //    {
            //        if (x % i == 0)
            //        {
            //            answer += i.ToString() + ",";
            //        }

            //    }

            //}
            //answer = answer.Substring(0, answer.Length - 1);
            //Console.WriteLine($"{answer}");
            //Console.ReadKey();

            ////補充習題3
            //int count = 0;
            //for(int i = 100; i <= 300; i++)
            //{
            //    if (i % 21 == 0)
            //    {
            //        count ++;
            //    }
            //}
            //Console.WriteLine($"{count}");
            //Console.ReadKey();

            ////補充習題3 while
            //int count = 0;
            //for (int i = 100; i <= 300; i++)
            //{
            //    while (i % 21 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine($"{count}");
            //Console.ReadKey();

            ////4-1
            //int i, n, max, temp, count = 0;
            //Console.WriteLine("請輸入n個整數,n=:");
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入1個整數");
            //max = Convert.ToInt32(Console.ReadLine());
            //for (i = 2; i <= n; i++)
            //{
            //    Console.WriteLine($"請輸入第{i}個整數");
            //    temp = Convert.ToInt32(Console.ReadLine());
            //    while (temp > max)
            //    {
            //        max = temp;
            //    }
            //}

            //Console.WriteLine($"最大數為{max}");
            //Console.ReadKey();

            ////4-2
            //int start,i,n,end;
            //double answer;
            //Console.WriteLine("請輸入起始值:");
            //start = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入間格差:");
            //i = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入共有N個數字:");
            //n = Convert.ToInt32(Console.ReadLine());
            //end = start + i * (n - 1);
            //answer = (start + end) * n / 2.0;

            //Console.WriteLine($"總合為:{answer}");
            //Console.ReadKey();

            ////4-3
            //int i, n, temp,total=0;
            //string answer = "小於13的數有:";
            //Console.WriteLine("請輸入n個整數,n=:");
            //n = Convert.ToInt32(Console.ReadLine());
            //for (i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"請輸入第{i}個整數");
            //    temp = Convert.ToInt32(Console.ReadLine());
            //    while (temp < 13)
            //    {
            //        answer += temp.ToString() + ",";
            //        total += temp;
            //        break;
            //    }
            //}
            //Console.WriteLine($"{answer}總合為{total}");
            //Console.ReadKey();

            ////4-4
            //int i, n, temp;
            //string answer = "";
            //Console.WriteLine("請輸入n個整數,n=:");
            //n = Convert.ToInt32(Console.ReadLine());
            //for (i = 1; i < n+1; i++)
            //{
            //    Console.WriteLine($"請輸入第{i}個整數");
            //    temp = Convert.ToInt32(Console.ReadLine());
            //    while (temp>7 && temp < 13)
            //    {
            //        answer += temp.ToString() + "大於7而小於13";
            //        i = n;
            //        break;
            //    }
            //}
            //Console.WriteLine($"{answer}");
            //Console.ReadKey();
            ////4-5
            //int a, b;
            //for (int i = 1; i < 6; i++)
            //{
            //    Console.WriteLine($"請輸入a{i}");
            //    a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"請輸入b{i}");
            //    b = Convert.ToInt32(Console.ReadLine());
            //    if (a > b)
            //    {
            //        Console.WriteLine($"a{i}:{a},b{i}:{b}");
            //        break;
            //    }
            //}
            //Console.ReadKey();

            ////補充1
            //DateTime start;
            //DateTime end;
            //int count = 0;
            //Console.WriteLine($"請輸入開始時間");
            //start = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine($"請輸入結束時間");
            //end = Convert.ToDateTime(Console.ReadLine());
            //while (start < end)
            //{
            //    count++;
            //    start = start.AddMinutes(5);
            //}
            //Console.WriteLine($"吃了{count}個漢堡");
            //Console.ReadKey();

            ////補充2
            int money = 560;
            int month = 0;
            while (money > 0)
            {
                money = money - 4;
                month++;
                while (month % 12 == 0)
                {
                    money = money - 1;
                    break;
                }

            }
            Console.WriteLine($"{month}");
            Console.ReadKey();

            ////補充3
            //Random random = new Random();
            //int randomNumber = random.Next(100);
            //int temp;
            //do
            //{
            //    Console.WriteLine("猜猜看:");
            //    temp = Convert.ToInt32(Console.ReadLine());
            //} while (temp != randomNumber);
            //Console.WriteLine("答對啦~");
            //Console.ReadKey();

        }
    }
}
