using System;

namespace Day_3
{
    /*static class Demo
    {
        static int id;
        static string name;
        static Demo()
        {
            id = 1;
            name = "sam";
        }
        public static void display()
        {
            Console.WriteLine(id + "," + name);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Demo.display();

        }
    }*/

    /*`````````````````````````````````POLYMORPHISM````````````````````````````````````````````````
    class demo
    {
        public void display()
        {
            Console.WriteLine("Let it be");
        }
        public void display(string s1)
        {
            Console.WriteLine("Hello= " + s1);
        }
        public string display (string s1,string s2)
        {
            return (string.Concat(s1, s2));
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            demo obj1 = new demo();
            obj1.display();
            obj1.display("Yamini");
            obj1.display("Hii", "Yamiee");
        }
    }


    class sides
    {
        public int compute(int a)
        {
            return (a * a * a);
        }
        public int compute(int l, int b)
        {
            return (l * b);


        }
    }
    class program
    {
        static void Main(string[] args)
        {
            sides obj1 = new sides();
            obj1.compute(10);
            obj1.compute(12, 2);


        }
    }

    class demo
    {
        public virtual void print()
        {
            Console.WriteLine("Base class");
        }
    }
    class Demo2 : demo
    {
        public override void print()
        {
            Console.WriteLine("Derived class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo2 obj1 = new Demo2();
            
            obj1.print();
         

        }
    }
    

    class Vehicle
    {
        protected string vname;
        protected double price;

        public Vehicle(string vname,double price)
        {
            this.vname = vname;
            this.price = price;

        }
        public virtual void print() { }
    }
    class TWOWH : Vehicle
    {
        string desc;
        public TWOWH(string vname, double price, string desc) : base(vname, price)
        {
            this.desc = desc;
        }
        public void print()
        {
            Console.WriteLine("Two wheeler details");
            Console.WriteLine(vname + " , " + price +" , "+ desc);
        }

    }
    class FOURWH : Vehicle
    { 
        string desc;
        public FOURWH(string vname, double price, string desc) : base(vname, price)
        {
            this.desc = desc;
        }
        public override void print()
        {
            Console.WriteLine("Two wheeler details");
            Console.WriteLine(vname + " , " + price+  " , " + desc);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            TWOWH obj1 = new TWOWH("HONDA",50000, "BLACK");
            obj1.print();
            FOURWH obj2 = new FOURWH("BALENO", 500000, "BLACK");
            obj2.print();

        }

    }

    //````````````````````````````````````````ABSTRACTION````````````````````````````````````````
    abstract class sample1
    {
        protected double d1, d2;
        public void print()
        {
            Console.WriteLine("Enter 2 Dimension");
            d1 = double.Parse(Console.ReadLine());
            d2 = double.Parse(Console.ReadLine());

        }
        public abstract double calculate();
    }
    class sample2: sample1
    {
        public override double calculate()
        {
            return (0.5 * d1 * d2);
        }


    }
    class program
    {
        static void Main(string[] args)
        {
            sample2 obj1 = new sample2();
            obj1.print();
            Console.WriteLine("Area of triangle= " + obj1.calculate());
        }
    }

    //``````````````````````````sealed class```````````````````````````````````````````


    sealed class sample
    {
        protected double d1, d2;
        public void print()
        {
            Console.WriteLine("Enter the dimension: ");
            d1 = double.Parse(Console.ReadLine());
            d2 = double.Parse(Console.ReadLine());

        }
        public double areaRT()
        {
            return (d1 * d2);
        }
        public double areaTR()
        {
            return (0.5 * d1 * d2);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            sample obj = new sample();
            obj.print();
            Console.WriteLine("Area of rectangle= " + obj.areaRT());
            Console.WriteLine("Area of rectangle= " + obj.areaTR());


        }
    }*/

    /*```````````````````````````````````````````Partial class````````````````````````````````
    partial class sample
    {
        protected double d1, d2;
    }
    partial class sample
    {
        public void print()
        {
            Console.WriteLine("Enter two dimension: ");
            d1 = double.Parse(Console.ReadLine());
            d2 = double.Parse(Console.ReadLine());

        }

    }
    partial class sample
    {
        public double areaRT()
        {
            return (d1 * d2);
        }
    }
    partial class sample
    {
        public double areaTR()
        {
            return (0.5 * d1 * d2);
        }
    }
    class profgram
    {
        static void Main(string[] args)
        {
            sample obj = new sample();
            obj.print();
            Console.WriteLine("Area of rectangle= " + obj.areaRT());
            Console.WriteLine("Area of rectangle= " + obj.areaTR());


        }
    }


     partial class sample
    {
        partial void method1();
        partial void method2();
    }
    partial class sample
    {
        int len, bh;
        public void getdetails()
        {
            Console.WriteLine("Input data: ");
            len = Convert.ToInt32(Console.ReadLine());
            bh = Convert.ToInt32(Console.ReadLine());
            method1();
        }
        partial void method1()
        {
            Console.WriteLine("Area= " + (len * bh));
            method2();
        }
        partial void method2()
        {
            Console.WriteLine("Area= " + (Math.Sqrt(len*bh)));
            
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            sample obj = new sample();
            obj.getdetails();
        }
    }*/

    /*`````````````````````````````````Operator overloading(Uniary)````````````````````````````````````````````
   
    class sample
    {
        int a, b;
        public sample(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static sample operator -(sample obj)
        {
            obj.a = -obj.a;
            obj.b = -obj.b;
            return obj;

        }
        public void print()
        {
            Console.WriteLine(a + "," + b);
        }


    }
    class program
    {
        static void Main(string[] args)
        {
            sample obj = new sample(100,200);
            obj = -obj;
            obj.print();
        }
    }*/



    /*``````````````````````````````````Operator overloading(binary)`````````````````````````````````````````

    class sample
    {
        int a;
        double b;
        public sample(int a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public sample()
        {
        }

        public static sample operator -(sample obj1, sample obj2)
        {
            sample temp = new sample();
            temp.a = obj1.a - obj2.a;
            temp.b = obj1.b - obj2.b;
            return temp;

        }
        public static sample operator +(sample obj1, sample obj2)
        {
            sample temp = new sample();
            temp.a = obj1.a + obj2.a;
            temp.b = obj1.b + obj2.b;

            return temp;

        }
        public void print()
        {
            Console.WriteLine(a + "," + b);
        }


    }
    class program
    {
        static void Main(string[] args)
        {
            sample s1 = new sample(100, 200.45);
            sample s2 = new sample(12, 20.3);
            sample s3 = new sample();
            s3 = s1 - s2;
            sample s4 = new sample();
            s4 = s1 + s2;
            s3.print();
            s4.print();

        }
    }*/



    /*``````````````````````````````````````is operator```````````````````````````````````````````````

    class sample1
    {

    }
    class sample2
    {

    }
    class program
    {
        static void Main(string[]args)
        {
            sample1 s1 = new sample1();
            sample2 s2 = new sample2();
            Console.WriteLine(s1 is sample1);
            Console.WriteLine(s2 is sample1);

            Console.WriteLine(s1 is sample2);
            Console.WriteLine(s2 is sample2);
            Console.WriteLine(s1 is object);
            Console.WriteLine(s2 is object);



        }
    }*/

    /*``````````````````````````````````````as operator- use to convertion```````````````````````````````````````````````
    class sample1
    {

    }
    class sample2
    {
    }
    class program
    {
        static void Main(string[] args)
        {
            object[] objarray = new object[7];
            objarray[0] = new sample1();
            objarray[1] = new sample2();
            objarray[2] = "Hello";
            objarray[3] = 1234;
            objarray[4] = 345.6;
            objarray[5] = true;
            objarray[6] = null;


            for (int i = 0; i < objarray.Length; i++)
            {
                string result = objarray[i] as string;
                if (result != null)
                    Console.WriteLine(result);
                else
                    Console.WriteLine("Not a string" + result);
            }

        }
    }*/


    /*````````````````````````````````````(Nested Namespaces)````Ambiguity can be handled using  different namespaces``````````````````````````````
    namespace n1
    {
        class sample
        {
            public void print()
            {
                Console.WriteLine("Me and only me");
            }

        }
    }
    namespace n2
    {
        class sample
        {
            public void print()
            {
                Console.WriteLine("Let it be");
            }
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            n1.sample obj = new n1.sample();
            obj.print();
            n2.sample obj1 = new n2.sample();
            obj1.print();


        }
    }
    */

    //````````````````````````````````````````````swap method``````````````````````````````````````````````````
    /* with ref keyword
     
  
    class sample
    {
        public void swap( ref int  a,ref int b )
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a= " + a + ",b= " + b);
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            sample obj = new sample();
            int a = 100, b = 200;
            obj.swap(ref a,ref b);
        }
    }*/



    /*   without ref keyword

    class sample
    {
        public void swap(int a, int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a= " + a + ",b= " + b);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            sample obj = new sample();
            int a = 100, b = 200;
            obj.swap(a,b);
        }
    }
    */

    /*``````````````````````````````````````````out parameter```````````````````````````````````````````````

    class sample
    {
        public void method (int a,int b, out int r1,out int r2, out int r3)
        {
            r1 = a + b;
            r2 = a - b;
            r3 = a * b;
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            sample obj = new sample();
            int a = 20, b = 20, Result1, Result2, Result3;
            obj.method(a, b, out Result1, out Result2, out Result3);

            Console.WriteLine("Sum : " + Result1);
            Console.WriteLine("Diff : " + Result2);
            Console.WriteLine("Product : " + Result3);

        }
    }*/

    /*``````````````````````````````````````````params keyword```````````````````````````````````````````````

    class sample
    {
        public void method1(params int[] a)
        {
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------------");

        }
        public void method2(params object[]a)
        {
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------------");

        }
    }
    class program
    {
        static void Main(string[] args)
        {
            sample obj = new sample();
            obj.method1(10, 20, 30);
            obj.method1(10, 20, 30, 23, 34, 56);
            obj.method2(1, "Yamini", 2, "Yamiee", 3.34, "opp");
        }
    }*/



    /*````````````````````````````````````````````````````optional parameter`````````````````````````````````````````````````````````````````````
    class sample
    {
        public void studentDetails(int regno, string sname, string smailid, string course)
        {
            Console.WriteLine(regno + "," + sname + "," + smailid + "," + course);
            Console.WriteLine("----------------------------");

        }
        public void BookDetails(string bname, double price, string auname = "Robert")
        {
            Console.WriteLine(bname + "," + auname + "," + price);
            Console.WriteLine("----------------------------");
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            sample obj = new sample();
            obj.studentDetails(1, "Ajay", "ajay123@gmail.com", ".Net");
            obj.studentDetails(smailid: "jay123@gmail.com", course: "Java", sname: "Jay", regno: 7);
            obj.BookDetails("C++", 2400);
            obj.BookDetails("C pro", 5400, "Andrew");

        }
    }
    */


    /*``````````````````````````````````````property & Indexes````````````````````````````````````````````````````````
    class book
    {
        int bid;
        string bname;
        string anuname;

    }
    public int _bid
    {
        get { return bid;}
        set { bid = value;}
    }
    public int _bid
    {
        get { return bid; }
        set { bid = value; }
    }



    */

    /*=================read only property====================
    class book
    {
        int bid;
        string bname;
        string auname;
    
        public book()
        {
            bid = 1;
            bname = "JAVA";
            auname = "XXXXX";

        }
        public interface _bid
        {
            get {return _bid;}
        }
        public interface _bid
        {
            get {return _bid;}
        }
        public interface _bid
        {
            get {return _bid;}
        }*/



    class book
    {
        in
    }

    
    




    
}




