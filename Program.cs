namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //(int a, string b) z = (5, "ahmet");
            //Console.WriteLine(z.b);


            //bool a = default(bool);

            //const double pi = 3.14;

            //double pi = 156;

            //Console.WriteLine(pi);



            //string text = "68";
            //byte num = byte.Parse(text);
            //Console.WriteLine(num / 2);
            //Console.WriteLine(byte.Parse(text) / 2);


            //string text = "Elvin";

            //Console.WriteLine(text[4]);


            //double d = 3.12;

            //string d2 = d.ToString();


            //int i = 600;
            //short b = (short)i;


            //checked
            //{
            //    int num = 356489464;
            //    short num2 = (short)num;
            //    Console.WriteLine();
            //}


            //bool b = true;
            //int a = Convert.ToInt32(b);
            //Console.WriteLine(a); // output 1

            //bool r = false;
            //long g = Convert.ToInt64(r);
            //Console.WriteLine(g); // output 0


            //int a = 1;
            //bool b = Convert.ToBoolean(a);
            //Console.WriteLine(b); // output True



            // ------------------------------------------------- Polindrom Ededler -------------------------------------------------



            //Console.WriteLine("Eded daxil edin"); // 1221
            //string a = Console.ReadLine(); // "1221"

            //string b = "";

            //for (int i = a.Length-1; i >= 0; i--)
            //{
            //    b = b + a[i]; // bu string oldugu uchun yan yana yazacaq [i] ler ise indeksleridir
            //   // Console.WriteLine(i); // 3 2 1 0 bunlar indeksleridir
            //}
            //Console.WriteLine(b); // 1221

            //if (a == b) 
            //{
            //    Console.WriteLine("Polindrom ededdir");
            //}else
            //{
            //    Console.WriteLine("Piolindrom deyil");
            //}





            // ------------------------------------------------- Ulduzla Kvadrat -------------------------------------------------



            //Console.Write("Eded daxil edin : ");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= number; i++)
            //{
            //    for (int j = 1; j <= number; j++)
            //    {
            //        if (i == 1 || j == 1 || j == number || i == number)
            //            Console.Write("* ");
            //        else
            //            Console.Write("  ");
            //    }
            //    Console.WriteLine("");
            //}


            // ----------------------------------------------------- Foreach Array ---------------------------------------------------------



            //int[] arr = { 1, 2, 3, 4, 5 };
            //int num = Int32.MaxValue;

            //foreach (int i in arr)
            //{
            //    if (i < num)
            //    {
            //        num = i;
            //    }
            //}
            //Console.WriteLine(num);





            //string str = "Salam";
            //string newStr = "";
            //foreach (char ch in str)
            //{
            //    if (ch != 'S') newStr += ch;
            //}
            //Console.WriteLine(newStr);



            //int[][] jArray = new int[][]
            //{
            //    new int[] {4,8,11},
            //    new int[] {7,16},
            //};


            //for (int i = 0; i < jArray.Length; i++)
            //{
            //    Console.WriteLine(jArray[i]);
            //    for (int j = 0; j < jArray[i].Length; j++)
            //    {
            //        Console.WriteLine(jArray[i][j]);
            //    }
            //}






            //Console.Write("Eni daxil edin : ");
            //int width = int.Parse(Console.ReadLine());
            //Console.Write("Uzunlugu daxil edin : ");
            //int height = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= width; i++)
            //{
            //    for (int j = 1; j <= height; j++)
            //    {
            //        if (i == 1 || i == width || j == 1 || j == height) Console.Write("* ");
            //        else Console.Write("  ");
            //    }
            //    Console.WriteLine("");
            //}


            // Console.Write("Ededi daxil edin : ");
            //int leng = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= leng; i++)
            //{
            //    for (int j = 1; j <= leng; j++)
            //    {
            //        if (i >= j) Console.Write("*");
            //        else Console.Write(" ");
            //    }
            //    Console.WriteLine("");
            //}



            //Console.Write("Eded daxil edin : ");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= number; i++)
            //{
            //    for (int j = 1; j <= number; j++)
            //    {
            //        if (i == 1 || j == 1 || j == number || i == number)
            //            Console.Write("* ");
            //        else
            //            Console.Write("  ");
            //    }
            //    Console.WriteLine("");
            //}






            //bool medeniHal = false;
            //string result = medeniHal == true ? "Evlilere Party" : "Bekarlara Party";

            //Console.WriteLine(result);



            //int yas = 25;

            //string result = (25 > yas) ? "A" : (25 == yas) ? "B" : "C";

            //Console.WriteLine(result);


            //Console.WriteLine("Eded daxil edin");
            //int sayi = int.Parse(Console.ReadLine());

            //int result = sayi < 3 ? sayi * 5 :
            //    sayi > 3 && sayi < 9 ? sayi * 3 :
            //    sayi >= 9 && sayi % 2 == 0 ? sayi * 10 :
            //    sayi % 2 == 1 ? sayi : -1;

            //Console.WriteLine(result);






            //string hava = "Gunesli";



            //Console.WriteLine (hava == "Yagmurlu" ? "Semsiyye al" :

            //   hava == "Gunesli" ? "Bol - bol vitamin alman dilegi ile" :

            //   hava == "Kapali" ? "Yagmur yagabilir" : "Duz deyil");



            //object x = false; 

            //Console.WriteLine(x is bool); // x -in icerisindeki nedir?
            //Console.WriteLine(x is int);
            //Console.WriteLine(x is decimal);



            //string x = null;

            //Console.WriteLine(x is null);





            //string a = null;


            //Console.WriteLine(a ?? "Salam");







            //int satisQiymeti = 250;

            //switch (satisQiymeti)
            //{

            //    case 125 when (3 == 2):
            //        Console.WriteLine("Dogru deyil");
            //        break;

            //    case 150 when (3 == 3): Console.WriteLine("Dogrudur"); break;


            //}



            //int num = 20;

            //switch (num)
            //{

            //    case 15:
            //        Console.WriteLine(num * 10);
            //        break;

            //        case 20:
            //        Console.WriteLine(num * 1);
            //        break;

            //    case 25:
            //        goto case 15;
            //}



            //Console.WriteLine("Mehsullarin qiymetini qeyd edin");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Mehsullarin qiymetini qeyd edin");
            //int num2 = int.Parse(Console.ReadLine());




            //if (num1 + num2 > 200) 
            //{
            //    Console.WriteLine(num1 + num2 * 3 / 4);
            //}




            //Console.WriteLine("Kulannici adi");
            //string name = Console.ReadLine();

            //Console.WriteLine("Sifre");
            //string password = Console.ReadLine();

            //if (name == "sdfsdfsfd" && password == "65468")
            //{
            //    Console.WriteLine("Giris basarili");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiginiz kullanici adi yalnisdir"); 
            //}


            //switch (name, password) 
            //{
            //    case ("Elvin", "Elbrus"):
            //        Console.WriteLine("duzdur");
            //        break;

            //        default:
            //        Console.WriteLine("Sehvdi qaqam");
            //        break ;
            //}


            //Console.WriteLine(name == "Elbrus" && password == "123" ? "Cavab dogrudur" : "Cavab yanlisdir";)



            //Console.WriteLine("Eded daxil edin");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2-ci Eded daxil edin");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Operator daxil edin");
            //char opr = char.Parse(Console.ReadLine());


            //if (opr == '+')
            //    Console.WriteLine(num1 + num2);
            //else if (opr == '-')
            //    Console.WriteLine(num1 - num2);
            //else if (opr == '/')
            //    Console.WriteLine(num1 / num2);
            //else if (opr == '*')
            //    Console.WriteLine(num1 * num2);
            //else if (opr == '%')
            //    Console.WriteLine(num1 / num2);


            //switch (opr)
            //{
            //    case '+':
            //          Console.WriteLine(num1 + num2);
            //        break;

            //    case '-':
            //        Console.WriteLine(num1 - num2);
            //        break ;

            //    case '*':
            //        Console.WriteLine(num1 * num2);
            //        break;

            //    case '/':
            //        Console.WriteLine(num1 - num2);
            //        break;

            //    case '%':
            //        Console.WriteLine(num1 + num2);
            //        break;
            //}




            //Console.WriteLine(opr == '+' ? num1 + num2 : opr == '-' ? num1 - num2 : opr == '*' ? num1 * num2 : opr == '/' ? num1 / num2 : opr == '%' ? num1 % num2 : "Yanlis deyer");


            //int result = opr switch
            //{
            //    '+' => num1 + num2,
            //    '-' => num1 - num2,
            //    '*' => num1 * num2,
            //    '/' => num1 / num2,
            //    '%' => num1 % num2,
            //    _ => -44444444
            //};

            //Console.WriteLine(result);


            //Console.WriteLine("Eded daxil edin");
            //int num = int.Parse(Console.ReadLine());

            //if(num > 0) 
            //{
            //    Console.WriteLine("Eded musbetdir");
            //}
            //else
            //{
            //    Console.WriteLine("Eded menfidir");
            //}


            //Console.WriteLine(num > 0 ? "Eded musbetdir" : "Eded menfidir");



            //object x = "Elvin";

            //if ( x is string a) 
            //{ 
            //    Console.WriteLine(a);
            //}
            //else if (x is int b)
            //{
            //    Console.WriteLine();
            //}

            // Console.WriteLine(a); error



            //int a = 5;

            //Console.WriteLine(a is bool);
            //Console.WriteLine(a is int);
            //Console.WriteLine(a is object);


            //object a = "Elvin";

            //if (a is var b)
            //    Console.WriteLine(b);



            //Console.WriteLine("Eded daxil edin");
            //int num = int.Parse(Console.ReadLine());


            //string result = num switch
            //{
            //    > 0 and < 50 => "Eded maraqlidi"

            //};






            //try { 
            //Console.WriteLine("Eded daxil edin");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2 -ci ededi daxil edin");
            //int num2 = int.Parse(Console.ReadLine());
            //}

            //catch
            //{
            //    Console.WriteLine("Zehmet olmasa ededi duzgun qeyd edin");
            //}



            //try
            //{
            //    int a = 0; int b = 5; a = b / a;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}


            //for (int i = 0; i < 50; i+=5)
            //{
            //    Console.WriteLine("Hilmi");
            //}


            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 110; i > 100; i--)
            //{
            //    Console.WriteLine(i - 100);
            //}



            //for (int i = 1; i < 40; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}

            //int result = 0;
            //for (int i = 2; i < 40; i+=2)
            //{
            //    Console.WriteLine(result += i); 
            //}


            //Console.WriteLine("Faktorialinin gormek uchun eded daxil edin");
            //int num = int.Parse(Console.ReadLine());



            //for (int i = 1, result = 1; i <= num; i++)
            //{
            //    Console.WriteLine(result = result * i);
            //}



            //string a = "";
            //int result = 1;
            //for (int i = num; i > 1; i--)
            //{
            //    result = result * i;
            //    a = a + i;
            //    Console.WriteLine(a);
            //}



            //int num = int.Parse(Console.ReadLine());


            //while (0 < num)
            //{
            //    Console.WriteLine(num);
            //    num--;

            //}


            //int i = 0;
            //int result = 0;
            //while (i < 100)
            //{
            //    if (i % 2 == 1) 
            //    result = result + i;
            //    i++;
            //    Console.WriteLine(result);

            //}


            //int num = int.Parse(Console.ReadLine());

            //int result = 1;

            //while (1 < num) 
            //{
            //    result = result * num;
            //    num--;
            //    Console.WriteLine(result);
            //}


            while (true)
            {
                if(DateTime.Now.Second % 2 == 0)
                    Console.WriteLine(DateTime.Now);
            }












        }
    }
}

