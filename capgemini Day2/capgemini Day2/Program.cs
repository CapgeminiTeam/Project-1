using System;

namespace capgemini_Day2
{
    ////class Program
    //{
    ////    static void Main(string[] args)
    //      {
    //        //int[] array1 = new int[5] { 10, 20, 30, 40, 50 };
    //        //for (int i=0; i<array1.Length;i++)
    //        //{
    //        //    Console.WriteLine("array1["+i+"]="+array1[i]);

    //        //}


    //        //int[] array1 = new int[5];
    //        //int[] array2 = new int[5];
    //        //int[] array3 = new int[5];

    //        //Console.WriteLine("Enter the array 1 elemement: ");
    //        //for (int i = 0; i < array1.Length; i++)
    //        //{
    //        //    array1[i]=int.Parse(Console.ReadLine());

    //        //}
    //        //Console.WriteLine("Enter the array 2 elemement: ");
    //        //for (int i = 0; i < array1.Length; i++)
    //        //{
    //        //    array2[i] = int.Parse(Console.ReadLine());

    //        //}
    //        //Console.WriteLine("sum = ");
    //        //for (int i = 0; i < array1.Length; i++)
    //        //{
    //        //    array3[i] = array1[i] + array2[i];
    //        //    Console.WriteLine("array3[" + i + "]=" + array3[i]);

    //        //}

    //        //To store heterogeneous element use Object````````````

    //        //object[] product = new object[] { 1, "ABC", 3.45 };
    //        //for (int i = 0; i < product.Length; i++)
    //        //{
    //        //    Console.WriteLine(product[i]);

    //        //}
    //        //Console.WriteLine("------");

    //        //foreach(object i in product)
    //        //{
    //        //    Console.WriteLine(i);
    //        //}

    //        //object[] product = new object[] { 1, "ABC", 3.45 };
    //        //for (int i = 0; i < product.Length; i=+2)
    //        //{
    //        //    Console.WriteLine(product[i]);

    //        //}
    //        //Console.WriteLine("------");

    //        //foreach (var i in product)///////foreach is used to fetch the data directly without giving the address
    //        //{
    //        //    Console.WriteLine(i);
    //        //}






    //        //int[,] array1 = new int[2, 2] { { 10, 20 }, { 30, 40 } };
    //        //for (int i=0; i<2; i++)
    //        //{
    //        //    for (int j = 0; j < 2; j++) 
    //        //    {
    //        //        Console.WriteLine("["+i+"," +j+"]="+array1[i,j]+"\t");
    //        //    }

    //        //}




    //        //int[,] array1 = new int[2, 2] ;
    //        //Console.WriteLine("Enter the array elements: ");
    //        //for (int i = 0; i < 2; i++)
    //        //{
    //        //    for (int j = 0; j < 2; j++)
    //        //    {
    //        //        array1[i,j]=int.Parse(Console.ReadLine());
    //        //    }

    //        //}


    //        //for (int i = 0; i < 2; i++)
    //        //{
    //        //    for (int j = 0; j < 2; j++)
    //        //    {
    //        //        Console.Write("[" + i + "," + j + "]=" +array1[i, j] + "\t");
    //        //    }
    //        //    Console.WriteLine("/n");
    //        //}







    //        //int[][] Jarray = new int[4][];
    //        //Jarray[0] = new int[] { 10, 20, 30 };
    //        //Jarray[1] = new int[] { 10, 20, };
    //        //Jarray[2] = new int[] { 102, 204, 306,409,506 };
    //        //Jarray[3] = new int[] {10};


    //        //for (int i=0; i<Jarray.Length; i++)
    //        //{
    //        //    for (int j=0; j<Jarray[i].Length;j++)
    //        //    {
    //        //        Console.Write(Jarray[i][j] + "\t");

    //        //    }
    //        //    Console.WriteLine("\n");
    //        //}


    //        //int[][] Jarray = new int[4][];
    //        //Jarray[0] = new int[] { 10, 20, 30 };
    //        //Jarray[1] = new int[] { 10, 20, };
    //        //Jarray[2] = new int[] { 102, 204, 306,409,506 };
    //        //Jarray[3] = new int[] {10};


    //        //for (int i=0; i<Jarray.Length; i++)
    //        //{
    //        //    for (int j=0; j<Jarray[i].Length;j++)
    //        //    {
    //        //        Console.Write(Jarray[i][j] + "\t");

    //        //    }
    //        //    Console.WriteLine("\n");
    //        //}


    //        //object[][] course = new object[3][];
    //        //course[0] = new object[] { 1, 2, 3, 4 };
    //        //course[1] = new object[] { "C#","PHP",".net" };
    //        //course[2] = new object[] { "1 month", "15 days", "45 days" };


    //        //for (int i = 0; i < course.Length; i++)
    //        //{
    //        //    for (int j = 0; j < course[i].Length; j++)
    //        //    {
    //        //        Console.Write(course[i][j] + "\t");

    //        //    }
    //        //    Console.WriteLine("\n");
    //        //}


    //        ///Tryparse method
    //        //int result;
    //        //Console.WriteLine("Input a numner");
    //        //bool b = int.TryParse(Console.ReadLine(), out result);
    //        //Console.WriteLine(b + "," + result);

    //        //Parse method
    //        //int b;
    //        //Console.WriteLine("Input a number: ");
    //        //b = int.Parse(Console.ReadLine());
    //        //Console.WriteLine(b);


    //        //char ch;
    //        //Console.WriteLine("Input a char:");
    //        //ch = char.Parse(Console.ReadLine());
    //        //if (ch>='0' && ch<='9')
    //        //    Console.WriteLine("It is a Number");
    //        //else if (ch >= 'a' && ch <= 'z') 
    //        //    Console.WriteLine("It alpha");
    //        //else
    //        //    Console.WriteLine("It's a special character");

    //        //bool var1 = true;
    //        //int res;
    //        //res = Convert.ToInt32(var1);
    //        //Console.WriteLine(res);



    //        //``````````STRING````````````
    //        //string str = "My name is Yamini";
    //        //string str3 = " hii";
    //        //String str1 = "My name is Yamini";
    //        //Console.WriteLine(str.Length);
    //        //Console.WriteLine(str.IndexOf('m'));
    //        //Console.WriteLine(str.LastIndexOf('m'));
    //        //Console.WriteLine(str.StartsWith('M'));
    //        //Console.WriteLine(str.EndsWith('u'));
    //        //Console.WriteLine(str.Contains('a'));
    //        //Console.WriteLine(str.Equals(str1));
    //        //Console.WriteLine(string.Compare(str, str1));// Results are 0,1,-1
    //        //Console.WriteLine(string.Concat(str, str1));
    //        //Console.WriteLine(str.Remove(5));
    //        //Console.WriteLine(str.Substring(5));
    //        //Console.WriteLine(str.Replace('a', 'k'));
    //        //Console.WriteLine(str.Replace("Yamini", "Yamiee"));
    //        //Console.WriteLine(str.Insert(10,"@@"));
    //        //Console.WriteLine(str.Equals(str1));
    //        //Console.WriteLine(str == str1);


    //        //String str2 = string.Copy(str); //copy
    //        //Console.WriteLine(str2);

    //        //String str3 = (String)str.Clone(); //reference
    //        //Console.WriteLine(str3);

    //        //We can concenate 3 strings
    //        //Console.WriteLine(string.Concat(str, str3, str1));

    //        //CharEnumerator ch = str.GetEnumerator();
    //        //while(ch.MoveNext())
    //        //{
    //        //    Console.WriteLine(ch.Current);
    //        //}

    //        //Char[] charray = str.ToCharArray();
    //        //foreach (char i in charray)
    //        //{
    //        //    Console.WriteLine(i);
    //        //}


    //        //string[] strarray = str.Split(' ');
    //        //foreach(string i in strarray)
    //        //{
    //        //    Console.WriteLine(i);
    //        //}


    //        //string newstring = string.Join(" ", strarray);
    //        //Console.WriteLine(newstring);

    //        //char[] charray = new char[35];
    //        //str.CopyTo(0, charray, 0, str.Length);
    //        ////str.CopyTo(4, charray, 0, 12);
    //        //Console.WriteLine(charray);


    //        //object str1 = "Welcome";
    //        //char[] chaarray = { 'W', 'e', 'l', 'c', 'o', 'm', 'e' };
    //        //object str2 = new string(chaarray);
    //        //Console.WriteLine(str1.Equals(str2));
    //        //Console.WriteLine(str1 == str2);


    //    }

    //}

    //enum product { Printer= 345, Projector= 234, Dekstop, Laptop};
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine((int)product.Projector);
    //        Console.WriteLine(Convert.ToInt32(product.Laptop));
    //    }
    //}

    //struct accdet
    //{
    //    public int accno;
    //    public string accname;
    //    public double depamt;

    //    public void print()
    //    {
    //        Console.WriteLine(accno + "," + accname + "," + depamt);

    //    }
    //    class program
    //    {
    //        static void Main(string[] args)
    //        {
    //            accdet firstdet;
    //            firstdet.accno = 1;
    //            firstdet.accname = "Yamiee";
    //            firstdet.depamt = 350000;
    //            Console.WriteLine(firstdet.accno + "," + firstdet.accname + "," + firstdet.depamt);
    //            //firstdet.print();
    //            accdet secdet;
    //            secdet.accno = 2;
    //            secdet.accname = "bhushan";
    //            secdet.depamt = 200000;
    //            secdet.print();


    //        }

    //    }

    //}


    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        Nullable<int> empid = 12;
    //        Console.WriteLine(empid);

    //        Nullable<double> proprice = null;
    //        Console.WriteLine(proprice);

    //        int? custage = null;
    //        Console.WriteLine(custage.GetValueOrDefault());
    //        Console.WriteLine(custage.HasValue);


    //    }
    //}
    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        int x = 100;
    //        object y = x;
    //        Console.WriteLine(y);
    //        int result = (int)y;
    //        Console.WriteLine(result);
    //    }
    //}
    struct productdetail
    {
        public int pcode;
        public string pname;
        public double unitprice;

        //public void print()
        //{
        //    Console.WriteLine(pcode + ","  + pname + "," + unitprice);
        //}
    }
    //class program
    //{
    //    static void Main(String[] agrs)
    //    {
    //        productdetail first;
    //        first.pcode = 122;
    //        first.pname = "Green tea";
    //        first.unitprice = 23;
    //        Console.WriteLine(first.pcode + "\n" + first.pname + "\n" + first.unitprice+"\n");
    //        //first.print();

    //        productdetail sec;
    //        sec.pcode = 124;
    //        sec.pname = "Tea";
    //        sec.unitprice = 44;
    //        Console.WriteLine(sec.pcode + "\n" + sec.pname + "\n" + sec.unitprice+"\n");
    //        //sec.print();
            
    //        productdetail third;
    //        third.pcode = 126;
    //        third.pname = "Cofee";
    //        third.unitprice = 50;
    //        Console.WriteLine(third.pcode + "\n" + third.pname + "\n" + third.unitprice+"\n");
    //        //third.print();

    // }
        class Program
        {
            static void Main(string[] args)
            {
                int[] array = new int[10];
                Console.WriteLine("Enter the array elemements: ");
                for (int i = 0; i < array.Length; i++)
                {
                   array[i] = int.Parse(Console.ReadLine());
                }
            

            }
            int sum = 0;
            foreach (int j in array);
            {
                sum+=j;
            }
            Console
        }   


}



