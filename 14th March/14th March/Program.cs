using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Collections;//(used to compare)
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;//generic delecates(action)



namespace _14th_March
{

    /*
    [DataContract]
    class Product
    {
        [DataMember]
        public int pid;
        [DataMember]
        public string pname;
        [DataMember]
        public Double price;
        public Product()
        {
            pid = 1;
            pname = "Computer";
            price = 45000;
        }
    }
    class Program
    { 

        static void Main(string[] args)
        {
            //FileStream fs = new FileStream("E:\\14th marrch.txt", FileMode.Create);
            //Product Pobj = new Product();
            //DataContractJsonSerializer sr = new DataContractJsonSerializer(typeof(Product));
            //sr.WriteObject(fs, Pobj);
            //fs.Close();

            FileStream fs = new FileStream("E:\\14th marrch.txt", FileMode.Create);
            DataContractJsonSerializer sr = new DataContractJsonSerializer(typeof(Product));
            Product Pobj = (Product)sr.ReadObject(fs);
            Console.WriteLine(Pobj.pid+","+Pobj.pname+","+Pobj.price);
            fs.Close();


        }
    }*/

    /*````````````````````````````````````````````````````Array list``````````````````````````````````````````

    class program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[3] { 400, 500, 600 };
            ArrayList List1 = new ArrayList();
            List1.Add(1008);
            List1.Add(2003);
            List1.Add(300);
            List1.Add(400);

            List1.AddRange(array1);
            //List1.Sort();
            //List1.Reverse();
            //List1.Remove(2003);
            //List1.RemoveRange(2, 4);
            //List1.RemoveAt(3);

            foreach (var i in List1)
            {
                Console.WriteLine(i);
            }
        }
    }*/

    /*````````````````````````````````````````````Hashtable class````````````````````````````````````````````````````

    class program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("XML", "Extensible markup language");
            ht.Add("JSON", "javascript object notation");
            ht.Add("SOAP", "Simple object acess protocal");
            ht.Add("XAML", "Extensible Application markup lang");
            ht.Add("AJAX", "Asynchronous javascript and Xml");


            ICollection ckeys = ht.Keys;

            //foreach (string i in ckeys)
            //{
            //    Console.WriteLine(i);
            //}
            //ICollection cvalues = ht.Values;

            //foreach (string i in cvalues)
            //{
            //    Console.WriteLine(i);
            //}



            // by using "ENUMERATOR" we can get key and value at a same time. No use of two for loop here.
            IDictionaryEnumerator IDE = ht.GetEnumerator();
            while (IDE.MoveNext())
            {
                Console.WriteLine(IDE.Key + "--." + IDE.Value);

            }
            Console.WriteLine("-----------------------------");
            foreach (DictionaryEntry DE in ht)
            {
                Console.WriteLine(DE.Key + "--" + DE.Value);
            }

        }




    }
    */
    /*``````````````````````````` Sorted list class````````````````````````````````````````````````
    // it is similar to hashtable just here we can sort the keys.

    class program
    {
        static void Main(string[] args)
        {
            SortedList ht = new SortedList();
            ht.Add("XML", "Extensible markup language");
            ht.Add("JSON", "javascript object notation");
            ht.Add("SOAP", "Simple object acess protocal");
            ht.Add("XAML", "Extensible Application markup lang");
            ht.Add("AJAX", "Asynchronous javascript and Xml");
            
            IDictionaryEnumerator IDE = ht.GetEnumerator();
            while (IDE.MoveNext())
            {
                Console.WriteLine(IDE.Key + "--." + IDE.Value);

            }
            Console.WriteLine("-----------------------------");
            foreach (DictionaryEntry DE in ht)
            {
                Console.WriteLine(DE.Key + "--" + DE.Value);
            }

        }


    }
    */

    /*`````````````````````````````````````````STACK`````````````````````````````````````

    class program
    {
        static void Main(string[]args)
        {
            Stack obj = new Stack();     //LIFO
            obj.Push(100);
            obj.Push(200);
            obj.Push(300);
            obj.Push("Yamini");
            obj.Push(400);

            obj.Pop();

            foreach (var i in obj)
            {
                Console.WriteLine(i);
            }

        }
    }*/

    /*`````````````````````````````````````````QUEUE`````````````````````````````````````
    // ENQUEUE - FOR STORE
    // DEQUEU- FOR REMOVE
    class program
    {
        static void Main(string[]args)
        {
            Queue obj = new Queue();  //FIFO
            obj.Enqueue("Hello");
            obj.Enqueue("Hii");
            obj.Enqueue("Welcome");
            obj.Enqueue(600.45);
            obj.Enqueue(300);

            obj.Dequeue();
            foreach (var i in obj) 
            {
                Console.WriteLine(i);
            }

        }
    }*/

    /*```````````````````````````````````````List method``````````````````````````````````````````

    class program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>();
            list1.Add("C#.NET");
            list1.Add("J#.NET");
            list1.Add("F#.NET");
            list1.Add("VB.NET");

            list1.AddRange(new string[3] { "AJAX", "JQUERY", "HTML" });
            //list1.Remove("HTML");
            //list1.RemoveAt(0);
            //list1.RemoveRange(0, 4);
            //list1.Reverse();
            list1.Sort();

            foreach(string i in list1)
            {
                Console.WriteLine(i);
            }

        }
    }*/


    /*```````````````````````````````````````Dictrionary class``````````````````````````````````````````
    // keys caanot be duplicated.

    class Program
    {
        static void Main(string[] args)
        {/*
            Dictionary<int, string> di = new Dictionary<int, string>();
            di.Add(3, "ASP.NET"); ;
            di.Add(2, "MVC");
            di.Add(1, "WPF");
            di.Add(4,"");

            ICollection<int> keys = di.Keys;
            foreach (int i in keys)
            {
                Console.WriteLine(i);

            }
            ICollection<string> values= di.Values;
            foreach (string i in values)
            {
                Console.WriteLine(i);

            }// using enumetor


            IDictionaryEnumerator IDE = di.GetEnumerator();
            while(IDE.MoveNext())
            {
                Console.WriteLine(IDE.Key + "," + IDE.Value);
            }
            foreach (KeyValuePair<int,string>kvp in di)
            {
                Console.WriteLine(kvp.Key + "," + kvp.Value);
            }

            // sorted Dictionary

            SortedDictionary<int, string> di = new SortedDictionary<int, string>();
            di.Add(3, "ASP.NET"); ;
            di.Add(2, "MVC");
            di.Add(1, "WPF");
            di.Add(4, "");

            ICollection<int> keys = di.Keys;
            foreach (int i in keys)
            {
                Console.WriteLine(i);

            }
            ICollection<string> values = di.Values;
            foreach (string i in values)
            {
                Console.WriteLine(i);

            }
            IDictionaryEnumerator IDE = di.GetEnumerator();
            while (IDE.MoveNext())
            {
                Console.WriteLine(IDE.Key + "," + IDE.Value);
            }
            foreach (KeyValuePair<int, string> kvp in di)
            {
                Console.WriteLine(kvp.Key + "," + kvp.Value);
            }
        }

        */

    /*````````````````````````````````HashSet Method````````````````````````````````````````````````

     class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> hs = new HashSet<string>();
            hs.Add("HTML");
            hs.Add("DHTML");
            hs.Add("JAVASCRIPT");
            hs.Add("JQUERY");

            HashSet<string> hs1 = new HashSet<string>();
            hs1.Add("JAVA");
            hs1.Add("PHP");
            hs1.Add("HTML");
            hs1.Add("DHTML");

            //hs.UnionWith(hs1);
            //hs.IntersectWith(hs1);
            hs.ExceptWith(hs1);


            foreach (string i in hs)
            {
                Console.WriteLine(i);
            }
        }
     }*/

    /*`````````````````````````````````````STACK````````````````````````````````````````````````
    
    class program
    {
        static void Main(string[] args)
        {
            Stack<string> obj = new Stack<string>();  //LIFO
            obj.Push("Hello");
            obj.Push("Yamini");
            obj.Push("Welcome");
            obj.Push("500");
            obj.Push("12.45");

            obj.Pop();
            foreach( string D in obj)
            {
                Console.WriteLine(D);
            }
        }
    }
    */


    /*````````````````````````````````````QUEUE````````````````````````````````````````````````

    class program
    {
        static void Main(string[] args)
        {
            Queue<string> obj = new Queue<string>();  //FILO
            obj.Enqueue("Hello");
            obj.Enqueue("Yamini");
            obj.Enqueue("Welcome");
            obj.Enqueue("500");
            obj.Enqueue("12.45");

            obj.Dequeue();
            foreach (string D in obj)
            {
                Console.WriteLine(D);
            }
        }
    }
    */

    /*````````````````````````````````````````User Defined Generic Class``````````````````````````````````````
    class Book< T1,T2,T3>
    {
        T1 bid;
        T2 bname;
        T3 bprice;
        public Book (T1 bid,T2 bname, T3 bprice)
        {
            this.bid = bid;
            this.bname = bname;
            this.bprice = bprice;

        }
        public void print()
        {
            Console.WriteLine($"Book Id:{this.bid}");
            Console.WriteLine($"Book Name: {this.bname}");
            Console.WriteLine($"Book Price:{this.bprice}");
        }
    }
    class program
    {
        static void Main (string[]args)
        {
            Book<int, string, double> Bobj1 = new Book<int, string, double>(1, "C#_Pro", 4.4);
            Bobj1.print();
            Book<int, string, string> Bobj2 = new Book<int, string, string>(1, "C#_Pro", "$303");
            Bobj2.print();
            Book<string, string, double> Bobj3 = new Book<string, string, double>("VB001", "C#_Pro", 4.4);
            Bobj3.print();
        }
    }*/

    /*```````````````````````````````````````EXCEPTION HANDLING`````````````````````````````
    class program
    {
        static void Main(string[] agrs)
        {
            Stack obj = new Stack();
            obj.Push("hello");
            obj.Push("hii");
            obj.Push("Yamini");
            obj.Push(45.6);
            obj.Push(600);

            try
            {
                foreach (string i in obj)
                {
                    Console.WriteLine(i);

                }
                
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }/*

    class program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 100;
            //b = 0;
            b = 10;
            try
            {
                Console.WriteLine("Result= " + (a / b));
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("End of Program");
            }
        }
    }*/
    /* ``````````` Exception with arrays``````````
    class program
    {
        static void Main(string[]args)
        {
            int[] a = new int [ 11, 12, 13, 14, 15 ];
            int[] b = new int[3];

            try
            {
                a.CopyTo(b, 0);
                foreach (int i in b)
                {
                    Console.WriteLine(i);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Destination is small");

            }
            finally
            {
                Console.WriteLine("End");
            }
        }
    }


    class Demo
    {
        public void validate(string username)
        {
            if (username.Length >= 3 && username != "null")
                Console.WriteLine("Welcome..." + username);
            else
                throw new ArgumentNullException();
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            string username;
            Console.WriteLine("Enter your name:");
            username= Console.ReadLine();
            try
            {
                Demo obj = new Demo();
                obj.validate(username);

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Invalid Username");
            }
            finally
            {
                Console.WriteLine("End");
            }

        }
    }*/


    /*````````````````````````````````user defined exception handling class```````````````
    class InvalidAgeException:Exception
    {
        public InvalidAgeException():base()
        {

        }
    }
    class Demo
    {
        public void validate(int age)
        {
            if (age >= 18 && age <= 65)
                Console.WriteLine("Valid user");
            else
                throw new InvalidAgeException();
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter Your age:");
            age = Convert.ToInt32(Console.ReadLine());
            try
            {
                Demo obj = new Demo();
                obj.validate(age);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine("Invalid age " + "," + ex.Source + ex.StackTrace);

            }
            finally
            {
                Console.WriteLine("End");
            }
        }
    }
    */

    /*````````````````````Inner Exception``````````````````
    class program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 10, 20, 30 };
            try
            {
                try
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(a[i]);
                    }
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    if (File.Exists("E:\\File12.txt") == false)
                    {
                        throw new FileNotFoundException();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (ex.InnerException != null) ;
                {
                    Console.WriteLine("Inner Exception");
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }*/


    /*````````````````````"Try-Finally" and "Using"`````````````````````````
    class program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            StreamReader sr = null;


            try
            {
                fs = new FileStream("E:\\file.txt", FileMode.Open);
                sr = new StreamReader(fs);
                Console.WriteLine(sr.ReadLine());
            }
            finally
            {
                fs.Close();
                sr.Close();
            }
            using (FileStream fs= new FileStream("D:\\file.txt", FileMode.Open))
            {
                StreamReader sr = new StreamReader(fs);
        Console.WriteLine(sr.ReadLine());
                sr.Close();
            }
        }


    }*/

    /*```````````Dynamic Keyword```````````````
    class program
    {
        static void Main(string[] args)
        {
            int x = 100;
            string y = x;  //Compile time checking


            string str = "Hello";
            int result = str;

            dynamic x;
            x = 45;
            string y = x;
            Console.WriteLine(y);   // Runtime error

            var x = 100;
            string y = x;
            Console.WriteLine(y);   //Compile time error
        }
    }
    */


    /*
    class Demo
    {
        public void method1(dynamic x, dynamic y)
        {
            Console.WriteLine(x + y);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            dynamic v1 = 1.2;
            dynamic v2 = "Hello";
            dynamic v3 = true;

            Console.WriteLine(v1.GetType().ToString());
            Console.WriteLine(v2.GetType().ToString());
            Console.WriteLine(v3.GetType().ToString());

            Demo obj = new Demo();
            obj.method1(10, 20);
            obj.method1("C#_pro",6.0);
            obj.method1(1.22, 6.0);
            obj.method1("MVC", "_core");
        }
    }*/

    /*```````````````````````Anonymus method with nested anonymus```````````````````````````````
    
    class demo
    {
        public static void display(dynamic det)
        {
            Console.WriteLine(det);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            var studentdet= new {
                                  Regno=1,
                                  Name= "Yamiee",       
                                  Course="_.Net FULLSTACK",
                                  Coursedet= new {
                                                    Cdesc="C#.Net,SQL,LINQ,EF_CORE,WEBAPI",
                                                    Cduration = "2month",
                                                    Cfees = 85000
                                                 }

                               };
            Console.WriteLine(studentdet.Regno + "," + studentdet.Name);
            Console.WriteLine(studentdet.Course);
            Console.WriteLine(studentdet.Coursedet.Cdesc);
            Console.WriteLine(studentdet.Coursedet.Cduration + "," + studentdet.Coursedet.Cfees);

            demo.display(studentdet);
           
        } 
    }*/

    /*```````````````````Delegate keyword(Anonymus method)`````````````

    delegate void method1();
    delegate void method2(int n);
    class program
    {
        static void Main(string[]args)
        {
            method1 obj = delegate {
                                    Console.WriteLine("Anonymus Method");

                                   };
            obj();
            method2 obj1= delegate(int n) {
                                   for (int i=1; i<=n;i++)
                                         {
                                            Console.WriteLine(i);
                                          
                                         }
                                    };
            obj1(5);
          


        }
    }*/

    /*
    //Anonymus function with return type 

    delegate void method1();
    delegate void method2(int n);
    delegate int method3(int a, int b);
    delegate int method4(int n);
    class program
    {
        static void Main(string[] args)
        {
            method3 obj2 = delegate (int a, int b)
                                      {
                                          return (a + b);
                                      };
            Console.WriteLine("Sum : " + obj2(10, 20));
            method4 obj3 = delegate (int n){
                                                int sum = 0;
                                                for (int i = 1; i <= n; i++)
                                                {
                                                    sum = sum + 1;
                                                }
                                                return sum;
                                            };
            Console.WriteLine("Sum of numbers: " + obj3(10));

        }
    }*/



    //```````````````````````````````Extension Method```````````````````````````````````````````````````````
    /*
    static class Demo
    {
        public static int ToNumber(this string value)
        {
            return int.Parse(value);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            string str = x.ToString();
            
            //string str1 = "1234";
            //int result = str1.ToNumber();
            Console.WriteLine(str);
        }
    }


    static class example
    {
        public static void method3(this Demo obj,string uname)
        {
            Console.WriteLine("Welcome " + uname);
        }
        public static void method4(this Demo obj,string fname,string lname)
        {
            Console.WriteLine($"{fname} {lname}@gmail.com");
        }
    }
    class Demo
    {
        public void method1()
        {
            Console.WriteLine("First Method");
        }
        public void method2()
        {
            Console.WriteLine("Second method");

        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            obj.method1();
            obj.method2();
            obj.method3("John");
            obj.method4("Ajay", "Rao");

        }
    }*/


    //`````````````````````````````````````````````MULTI-THREADING```````````````````````````````````````
    /*(using Namespace= using sytem.threading;)

    class Demo
    {
        public void function1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            Thread th1 = new Thread(new ThreadStart(obj.function1));
            th1.Start();
     
        
        }
    }*/


    /* ******Parallel threads with sleep method********
    /(sleep is for timing that is 2mS)


    class Demo
    {
        public void function1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            Thread th1 = new Thread(new ThreadStart(obj.function1));
            th1.Start();

            Thread th2 = new Thread(new ThreadStart(obj.function1));
            th2.Start();
            Thread th3 = new Thread(new ThreadStart(obj.function1));
            th3.Start();


        }
    }*/

    /************Lock in thread(Thread synchronization)**********
    class Demo
    {
        public void function1()
        {
            lock (this)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(2000);
                }
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            Thread th1 = new Thread(new ThreadStart(obj.function1));
            th1.Start();

            Thread th2 = new Thread(new ThreadStart(obj.function1));
            th2.Start();
            Thread th3 = new Thread(new ThreadStart(obj.function1));
            th3.Start();

        }
    }*/


    /************Threadpool Class****************
    //It is collection or group of preconfigured threads which handles the n number of request which are coming in.
    class Demo
    {
        public void function1(object Threadno)
        {
            string tname = "Threads=" + Threadno.ToString();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
    }
     class program
    {
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            for (int task=1; task < 5; task++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(obj.function1), task);
                Thread.Sleep(2000);// if we dont write sleep here we will not get the output.

            }
        }
    }*/


    //``````````````````````````````TIGHT COUPLING AND LOOSE COUPLING```````````````````````````
    /* ******tight coupling****************
    class Demo
    {
        public void add()
        {
            Console.WriteLine("Add Method");
        }
        public void Sub()
        {
            Console.WriteLine("Subtract Method");
        }
        public void square()
        {
            Console.WriteLine("Square Method");
        }
        public void Area()
        {
            Console.WriteLine("Area Method");
        }
    }
    class DependeancyInj
    {
        Demo obj = new Demo();
        public void Compute()
        {
            obj.add();
            obj.Sub();
            obj.square();
            obj.Area();
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            DependeancyInj d1 = new DependeancyInj();
            d1.Compute();
        }
    }*/


    /***************Loose coupling*******************
    interface Icalculator
    {
        void calculate();

    }
    class Add : Icalculator
    {
        public void calculate()
        {
            Console.WriteLine("Sum");
        }
    }
    class sub : Icalculator
    {
        public void calculate()
        {
            Console.WriteLine("Difference");
        }
    }
    class square: Icalculator
    {
        public void calculate()
        {
            Console.WriteLine("Square");
        }
    }
    class cube : Icalculator
    {
        public void calculate()
        {
            Console.WriteLine("cube");
        }
    }
    class DependencyInj
    {
        Icalculator objCal = null;
        public DependencyInj(Icalculator obj)
        {
            objCal = obj;
        }
        public void compute()
        {
            objCal.calculate();
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            DependencyInj d1 = new DependencyInj(new Add());
            d1.compute();

            DependencyInj d2 = new DependencyInj(new sub());
            d2.compute();

            DependencyInj d3 = new DependencyInj(new square());
            d3.compute();

            DependencyInj d4 = new DependencyInj(new cube());
            d4.compute();
        }
    }*/


    //`````````````````````````````````````GENERIC DELEGATE``````````````````````````````

    /************function delegate*********
    class sample
    {
        public static int addition(int a,int b)
        {
            return (a + b);
        }
        public static string function1(string x,string y,string z)
        {
            return string.Concat(x, y, z);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> res1 = new Func<int, int, int>(sample.addition);
            Console.WriteLine("Sum=" + res1(10, 20));
            Func<string,string,string,string> res2 = new Func<string,string,string,string>(sample.function1);
            Console.WriteLine("New String is="+res2("Model","VIew","Controller"));
        }
    }*/
    /*
    class sample
    {
        public static int method1(string str)
        {
            return (str.Length);
        }
        public static double method2(int m1, int m2, int m3, int m4)
        {
            return ((m1 + m2 + m3 + m4) / 4);
        }
        public static double method3( int h, int b)
        {
            return (0.5 * b * h);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Func<string,int> res1 = new Func<string,int>(sample.method1);
            Console.WriteLine("String Length= " + res1("Yamini"));
            Func<int,int,int,int,double> res2 = new Func<int,int,int,int,double>(sample.method2);
            Console.WriteLine("Average= " + res2(20,60,80,50));
            Func<int,int,double> res3 = new Func<int,int,double>(sample.method3);
            Console.WriteLine("Area =" + res3(2,7));
        }
    }*/

    /**************************Action delegate************
    class sample
    {
        public static void print1()
        {
            Console.WriteLine("Welcome");
        }
        public static void print2(string x, string y)
        {
            Console.WriteLine("New string is= " + string.Concat(x, y));
        }
        public static void print3(int svalue,int evalue)
        {
            for (int i = svalue; i <= evalue; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
    class program
    {
        static void Main(string[]agrs)
        {
            Action a1 = new Action(sample.print1);
            a1();
            Action<string, string> a2 = new Action<string, string>(sample.print2);
            a2("New", "York");
            Action<int, int> a3 = new Action<int, int>(sample.print3);
            a3(1, 10);
        }
    } */

    //predict delegate





    /*
    //Synchronous Programming
    class sample
    {
        public void print()
        {
            Console.WriteLine("Full");
            
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            sample obj = new sample();
            obj.print();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("End");
        }
    }*/




    /*``````````````````````Asynchronous Programming```````````````````````````````
    class sample
    {
        public void print()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            sample obj = new sample();

            Task task1 = new Task(obj.print);
            task1.Start();

           
            Console.WriteLine("End");
            Console.ReadKey();
        }
    }*/

    /*``````````````````````Asynchronous Programming```````````````````````````````
    //```````Lambda expression```````````
    class sample
    {
        public void print()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            sample obj = new sample();

            //Task task1 = new Task(obj.print);
            //task1.Start();
            //Task Task1 = Task.Factory.StartNew(obj.print);
            //Task Task1 = Task.Run(()=>{ obj.print(); });//***********lambda Expression*********
            Task Task1 = Task.Run(new Action(obj.print));
            //Task1.Wait();


            Console.WriteLine("End");
            Console.ReadKey();//this is to complete the execution program and return back the value.
        }
    }
    */




    /*****Envoking a method using Task library i.e returning a value using Task.
    class demo
   {
       public int print(int n)
       {
           int sum = 0;
           for (int i = 0; i < n; i++)
           {
               sum=sum+i;
           }
           return sum;
       }

   }
   class program
   {
       static void Main(string[] args)
       {
           Console.WriteLine("Start");
           demo obj = new demo();
           Task<int> task1 = Task.Run(() =>
             {
                 return obj.print(10);
             });
           Console.WriteLine("Result: "+task1.Result);
           Console.WriteLine("End");
           Console.ReadKey();
       }
   }*/




    /***********Same program only difference is, function is taken inside the Task function.****
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            Task<int> task1 = Task.Run(() =>
             { 
                  int sum = 0;
                  for (int i = 0; i < 5; i++)
                  {
                      sum = sum + i;
                  }
                  return sum;
             });
            Console.WriteLine("Result = " + task1.Result);
            Console.WriteLine("End");
            Console.ReadKey();

        }
    }*/



    /***********Task with Action Delegate***************(used in API)
    class program
    {
        static void Main(string[] args)
        {
            var x = new Action(() =>{
                                        Console.WriteLine("Action Delegate");
                                    });
            Task task1 = new Task(() => x());
            task1.Start();
            task1.Wait();
        }
    }*/
    /*
    class program
    {
        static void Main(string[] args)
        {
            var x = new Action<int>((n) =>
            {
                for (int i = 0; i <= n; i++)
                {
                    Console.WriteLine(i);
                }

            });
            Task task1 = new Task(() => x(10));
            task1.Start();
            task1.Wait();
        }
    }*/







    class TechDet : IComparable
    {
        public int tid { get; set; }
        public string tname { get; set; }
        public double tduration { get; set; }
        public int CompareTo(object obj)
        {
            TechDet tobj = obj as TechDet;
            if (tobj != null)
            {
                return this.tname.CompareTo(obj)
            }
        }

    }
    class Duration: IComparer<TechDet>
    {
        public int Compare(TechDet x,TechDet y)
        {
            return x.tduration.CompareTo(y.tduration);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            TechDet[] techarrayobj = new TechDet[]{
                new TechDet{tid=1,tname="WPF",tduration=4 };
            new TechDet { tid = 1, tname = "WCF", tduration = 3 };
            new TechDet { tid = 1, tname = "MVC", tduration = 1 };
            new TechDet { tid = 1, tname = "WPASP.net", tduration = 2 };
        }

        }
    }
}

       


    





