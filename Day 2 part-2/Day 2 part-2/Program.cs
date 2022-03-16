using System;

namespace Day_2_part_2
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] array = new int[10];
    //        Console.WriteLine("Enter the array elemements: ");
    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            array[i] = int.Parse(Console.ReadLine());
    //        }
    //        int sum = 0;
    //        foreach (int j in array)
    //        {
    //            sum += j;
    //        }
    //        Console.WriteLine(sum);
    //    }

    //}
    //class Employees
    //{
    //    int eid;
    //    string ename;
    //    string dept;
    //    public double salary;

    //    public void getemdetail()
    //    {
    //        Console.WriteLine("Enter Employees Details(id,name.dept,salary)");
    //        eid = Convert.ToInt32(Console.ReadLine());
    //        ename = Console.ReadLine();
    //        dept = Console.ReadLine();
    //        salary = Convert.ToDouble(Console.ReadLine());
    //    }

    //    public void printemdetail()
    //    {
    //        Console.WriteLine("id={0},ename={1},dept={2},salary={3}", eid, ename, dept,salary);
    //        //Console.WriteLine("id=" + eid + "ename=" + ename + "dept=" + dept);
    //        //Console.WriteLine($"Id={eid},Empname={ename},Dept={dept}");

    //    }

    //}
    //class program
    //{
    //    static void Main(string[]args)
    //    {
    //        Employees e1 = new Employees();
    //        e1.getemdetail();
    //        e1.printemdetail();
    //        Employees e2 = new Employees();
    //        e2.getemdetail();
    //        e2.printemdetail();
    //        Employees e3 = new Employees();
    //        e3.getemdetail();
    //        e3.printemdetail();



    //        double total_sal = e1.salary + e2.salary+e3.salary;
    //        Console.WriteLine("Total salary: " + total_sal);

    //    }
    //}

    //class Employees
    //{
    //    int eid;
    //    string ename;
    //    string dept;
    //    public double salary;

    //    public void getemdetail(int eid, string ename,string dept,double salary)
    //    {
    //        this.eid=eid;
    //        this.ename= ename;
    //        this. dept = dept;
    //        this.salary = salary;
    //    }

    //    public void printemdetail()
    //    {
    //        Console.WriteLine("id={0},ename={1},dept={2},salary={3}", eid, ename, dept, salary);
    //        //Console.WriteLine("id=" + eid + "ename=" + ename + "dept=" + dept);
    //        //Console.WriteLine($"Id={eid},Empname={ename},Dept={dept}");

    //    }

    //}
    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        Employees e1 = new Employees();
    //        e1.getemdetail(10,"yamini","Testing",30000);
    //        e1.printemdetail();
    //        Employees e2 = new Employees();
    //        e2.getemdetail(11, "Bhushan","HR",40000);
    //        e2.printemdetail();

    //        double total_sal = e1.salary + e2.salary ;
    //        Console.WriteLine("Total salary: " + total_sal);

    //    }
    //}
    //class Employees
    //{
    //    int accno;
    //    string accname;

    //    public double deptamt;

    //    public void getemdetail()
    //    {
    //        Console.WriteLine("Enter Employees Details(accno,accname.deptamt)");
    //        accno = Convert.ToInt32(Console.ReadLine());
    //        accname = Console.ReadLine();
    //        deptamt = Convert.ToDouble(Console.ReadLine());
    //    }

    //    public void printemdetail()
    //    {
    //        Console.WriteLine("id={0},ename={1},dept={2}", accno, accname, deptamt);
    //        //Console.WriteLine("id=" + eid + "ename=" + ename + "dept=" + dept);
    //        //Console.WriteLine($"Id={eid},Empname={ename},Dept={dept}");

    //    }

    //}
    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        Employees e1 = new Employees();
    //        e1.getemdetail();
    //        e1.printemdetail();
    //        Employees e2 = new Employees();
    //        e2.getemdetail();
    //        e2.printemdetail();
    //        Employees e3 = new Employees();
    //        e3.getemdetail();
    //        e3.printemdetail();



    //        double total_sal = e1.deptamt + e2.deptamt + e3.deptamt;
    //        Console.WriteLine("Total salary: " + total_sal);

    //    }
    //}
    //class sample
    //{
    //    int no1, no2;
    //    public void getnumbers(int no1, int no2)
    //    {
    //        this.no1 = no1;
    //        this.no2 = no2;
    //    }
    //    public int addnumbers()
    //    {
    //        return (this.no1 + this.no2);
    //    }
    //    public int subnumbers()
    //    {
    //        return (this.no1 - this.no2);
    //    }
    //    public int checkgreater() // Ternary operator
    //    {
    //        return  no1 > no2 ? no1 : no2;   
    //    }

    //}
    //class program
    //{
    //    static void Main(string[]args)
    //    {
    //        sample obj = new sample();
    //        obj.getnumbers(10, 20);

    //        Console.WriteLine("Sum: " + obj.addnumbers());
    //        Console.WriteLine("Diff: " + obj.subnumbers());
    //        Console.WriteLine("Greater number is: " + obj.checkgreater());
    //    }
    //}


    //````````````````constructor``````````````
    //class Book
    //{
    //    int bid;
    //    string bname;
    //    double price;

    //    public Book() {}
    //    public void show()
    //    {
    //        Console.WriteLine($"bookid={bid},bookname={bname},price={price}");

    //    }

    //}
    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        Book obj1 = new Book();
    //        obj1.show();
    //    }
    //}

    /*
    class Book
    {
        int bid;
        string bname;
        double price;

        public Book()
        {
            bid = 1;
            bname = "C# pro";
            price = 5600;
        }   //default

        public Book(int bid, string bname, double price)
        {
            this.bid = bid;
            this.bname = bname;
            this.price = price;
            // parameterized constructor
        }

        public Book (Book obj) 
        {
            this.bid = obj.bid;
            this.bname = obj.bname;
            this.price = obj.price;
            // Copy constructor
        }
        public void show()
        {
            Console.WriteLine($"bookid={bid},bookname={bname},price={price}");

        }

    }
    class program
    {
        static void Main(string[] args)
        {
            Book obj1 = new Book();
            obj1.show();

            Book obj2 = new Book(2,"SQL",3400);
            obj2.show();

            Book obj3 = new Book(obj1);
            obj3.show();
        }
    }
    */
    //````````````````````````Destructor`````````````````````````````````````````
    //class Book
    //{
    //    int bid;
    //    string bname;
    //    double price;

    //    public Book()
    //    {
    //        bid = 1;
    //        bname = "C# pro";
    //        price = 5600;
    //    }   //default

    //    public Book(int bid, string bname, double price)
    //    {
    //        this.bid = bid;
    //        this.bname = bname;
    //        this.price = price;
    //        // parameterized constructor
    //    }

    //    public Book(Book data)
    //    {
    //        this.bid = data.bid;
    //        this.bname = data.bname;
    //        this.price = data.price;
    //        // Copy constructor
    //    }
    //    public void show()
    //    {
    //        Console.WriteLine($"bookid={bid},bookname={bname},price={price}");

    //    }
    //    ~Book()
    //    {
    //    }

    //}
    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        Book obj1 = new Book();
    //        obj1.show();

    //        Book obj2 = new Book(2, "SQL", 3400);
    //        obj2.show();

    //        Book obj3 = new Book(obj1);
    //        obj3.show();
    //    }
    //}



    /*
    class product
    {
        int noofitems;
        string pname;
        double unitprice;
        int total;

        public product()
        {
            noofitems= 10;
            pname = "TELEVISION";
            unitprice = 56000;
        }   //default

        public product(int noofitems, string pname, double unitprice)
        {
            this.noofitems = noofitems;
            this.pname = pname;
            this.unitprice = unitprice;
            // parameterized constructor
        }

        public product(product data)
        {
            this.noofitems = data.noofitems;
            this.pname = data.pname;
            this.unitprice = data.unitprice;
            // Copy constructor
        }
        public void show()
        {
            Console.WriteLine($"bookid={noofitems},bookname={pname},price={unitprice}");
            Console.WriteLine($"Total price: {unitprice * noofitems}");

        }
       
    }
    class program
    {
        static void Main(string[] args)
        {
            product obj1 = new product();
            obj1.show();

            product obj2 = new product(24, "AIR CONDITIONER", 34000);
            obj2.show();

            product obj3 = new product(obj2);
            obj3.show();

          
        }
    }

    */

    /*````````````````````````````` SINGLE INHERITANCE``````````````````````````````````````
    class Data
    {
        protected int coordinate1, coordinate2;
        public void getdata()
        {
            Console.WriteLine("enter 2 coordinate: ");
            coordinate1 = Convert.ToInt32(Console.ReadLine());
            coordinate2 = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Data1 : Data
    {
        public void compute()
        {
            double res = Math.Sqrt(coordinate1 * coordinate2);
            Console.WriteLine("Result= " + res);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Data1 obj = new Data1();
            obj.getdata();      
            obj.compute();

                    
        }
    }

    
    class Data
    {
        protected int Regno, m1, m2, m3, m4;
        protected string name;
        public void getdata()
        {
            Console.WriteLine("Enter Registration number: ");
            Regno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter marks of 4 subjects: ");
            m1 = Convert.ToInt32(Console.ReadLine());
            m2 = Convert.ToInt32(Console.ReadLine());
            m3 = Convert.ToInt32(Console.ReadLine());
            m4 = Convert.ToInt32(Console.ReadLine());

        }

    }
    class result: Data
    {
        public void calculate()
        {
            double res = m1 + m2 + m3 + m4;
            Console.WriteLine("Result: " + res);
            double avg = res / 4;
            Console.WriteLine("Avg: " + avg);
        }
    }
    class student
    {
        static void Main(string[] args)
        {
            result obj = new result();
            obj.getdata();
            obj.calculate();


        }

    }
    */

    /*``````````````````````````````MULTIPLE INHERITANCE````````````````````````````````````````
    class Employee
    {
        protected int emid;
        protected string ename;
        public void getdata()
        {
            Console.WriteLine("Enter emplloyees Details: id ,name ");
            emid = Convert.ToInt32(Console.ReadLine());
            ename=Console.ReadLine();

        }
    }
    class Dept : Employee
    {
        protected string deptname;
        protected string deptloc;
        public void getdeptdata()
        {
            Console.WriteLine("Enter emplloyees Details: deptname ,deptloc ");
            deptname = (Console.ReadLine());
            deptloc = Console.ReadLine();
        }
    }
    class final : Dept
    {
        public void display()
        {
            Console.WriteLine("EmpID:"+emid+"," +"Empname= "+ename);
            Console.WriteLine("Dept name: " + deptname + "," + "Dept location= " + deptloc);

        }
    }
    class program
    {
        static void Main(string[]args)
        {
            final obj = new final();
            obj.getdata();
            obj.getdeptdata();
            obj.display();
        }
    }





    class student
    {
        protected int stid;
        protected string name;
        public void getpersonal()
        {
            Console.WriteLine("Enter student id and name: ");
            stid = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
        }

    }
    class course: student
    {
        protected string coursename;
        protected int duration;
        protected int fees;
        public void getcdata()
        {
            Console.WriteLine("Enter Course name,course duration and course fees: ");
            coursename = Console.ReadLine();
            duration = Convert.ToInt32(Console.ReadLine());
            fees = Convert.ToInt32(Console.ReadLine());

        }

    }
    class final : course
    {
        public void display()
        {
            Console.WriteLine("StudentID:" + stid + "," + "Student name= " + name);
            Console.WriteLine("course name: " + coursename + "," + "course duration= " +duration + ","+"Course fees: "+fees);
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            final obj = new final();
            obj.getpersonal();
            obj.getcdata();
            obj.display();
        }
    }
    */

    /*```````````````````````````````````HEIRARCHICAL INHERITANCE``````````````````````````````
    class data
    {
        protected int a, b;
        public void getdeta()
        {
            Console.WriteLine("Enter two numbers: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
        }

    }
    class Demo1 : data
    {
        public void add()
        {
            Console.WriteLine("Sum of two numbers: "+(a + b));

        }

    }
    class Demo2 : data
    {
        public void sub()
        {
            Console.WriteLine("Diff of two numbers: "+(a - b));

        }

    }
    class Demo3 : data
    {
        public void pro()
        {
            Console.WriteLine("pro of two numbers: "+(a * b));

        }

    }
    class program
    {
        static void Main(string[]args)
        {
            Demo1 obj1 = new Demo1();
            obj1.getdeta();
            obj1.add();

            Demo2 obj2 = new Demo2();
            obj2.getdeta();
            obj2.sub();


            Demo3 obj3 = new Demo3();
            obj3.getdeta();
            obj3.pro();
        }
    }
    


    class comp_name
    {
        protected string Compname;
        protected int Id;
        public void Getdeta()
        {
            Console.WriteLine("Enter name of the company and ID: ");
            Compname =Console.ReadLine();
            Id = Convert.ToInt32(Console.ReadLine());


        }
    }
    class Data1 : comp_name
    {
        protected int noofemployee;
        protected string location;
        public void b1()
        {
            Console.WriteLine("Enter number of employees and location: ");
            noofemployee = Convert.ToInt32(Console.ReadLine());
            location = Console.ReadLine();
        }

    }
    class Data2 :Data1
    {
        protected int noofemployee;
        protected string location;
        public void b2()
        {
            Console.WriteLine("Enter number of employees and location: ");
            noofemployee = Convert.ToInt32(Console.ReadLine());
            location = Console.ReadLine();
        }

    }
    class Data3 : Data2
    {
        protected int noofemployee;
        protected string location;
        public void b3()
        {
            Console.WriteLine("Enter number of employees and location: ");
            noofemployee = Convert.ToInt32(Console.ReadLine());
            location = Console.ReadLine();
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            Data1 obj1 = new Data1();
            obj1.Getdeta();
            obj1.b1();

            Data2 obj2 = new Data2();
            obj1.Getdeta();
            obj1.b1();

            Data3 obj3 = new Data3();
            obj1.Getdeta();
            obj1.b1();


        }
    }
    */

    /*`````````````````````````````````````Constructor inheritance in derived class````````````````````````````````
    class category
    {
        protected string cname, cdesc;
        public category(string cname, string cdesc)
        {

            this.cname = cname;
            this.cdesc = cdesc;

        }
    }
    class product: category
    {
        string pname;
        double price;
        public product(string cname, string cdesc,string pname,double price):base(cname, cdesc)
        {
            this.pname = pname;
            this.price = price;

        }
        public void displaydet()
        {
            Console.WriteLine("Category name: " + cname + "," + "cdess= " + cdesc);
            Console.WriteLine("Product_name: " + pname + "," + "price= " + price);

        }

    }
    class program
    {
        static void Main(string[] args)
        {
            product p1 = new product("Stationary", "All engg and Medical books", "C#_pro", 6800);
            p1.displaydet();

        }
    }*/



    /*`````````````````````````````````````INTERFACE````````````````````````````````````
    interface InterFace
    {
        void dispaly();
        void print(string str);

    }
    class Demo
    {
        public void display()
        {
            Console.WriteLine("This is interface method");
        }
        public void print(string str)
        {
            Console.WriteLine(string.Concat("Hello ", str));

        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            obj.display();
            obj.print("World");
        }
    }
    

    interface InterFaceOne
    {
        void method1(int a,int b);
        double method2(int a);
        void method3(string s1, string s2, string s3);
    }
    class demo : InterFaceOne
    {
        public void method1(int a, int b)
        {
            Console.WriteLine("Product= " + (a * b));
        }
        public double method2(int a)
        {
            return (Math.Sqrt(a * a));
        }
        public void method3(string s1,string s2,string s3)
        {
            Console.WriteLine(string.Concat(s1, s2, s3));
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            demo obj = new demo();
            obj.method1(10, 20);
            Console.WriteLine("Result: " + obj.method2(25));
            obj.method3("Hii", "My", "Name is yamini");

        }
    }
    




    interface InterFaceOne
    {
        int method1(int l, int b);
        double method2(int b, int h);
    }
    class demo : InterFaceOne
    {
        public int method1(int l, int b)
        {
            return (2 * (l * b));
        }
        public double method2(int b, int h)
        {
            return (h * b);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            demo obj = new demo();
            Console.WriteLine("perimeter: " + obj.method1(2, 5));
            Console.WriteLine("Area: " + obj.method2(3, 6));
        }

    }*/


    /*```````````````````````````````multiple inheritance```````````````````````````````````
    interface InterFaceOne
    {
        int method1(int a, int b);
        double method(int r);


    }
    interface InterFaceTwo
    {
        int calculate(int a, int b);
        double compute(int r);

    }
    class Demo : InterFaceOne, InterFaceTwo
    {
        public int calculate(int a, int b)
        {
            return (a + b);

        }
        public double calculate(int r)
        {
            return (3.14 * r * r);

        }

        public double compute(int r)
        {
            throw new NotImplementedException();
        }

        public double method(int r)
        {
            throw new NotImplementedException();
        }

        public void method1(int a, int b)
        {
            Console.WriteLine("Product= " + (a + b));
        }

        int InterFaceOne.method1(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
    class program
    {
        static void Main(string[] args)
        {

        }
    }


    

    interface InterFaceOne
    {
        void Display();
    }
    interface InterFaceTwo
    {
        void Display();
    }
    class Demo : InterFaceOne,InterFaceTwo
    {
        void InterFaceOne.Display()
        {
            Console.WriteLine("Method From InterfaceOne");
        }
        void InterFaceTwo.Display()
        {
            Console.WriteLine("Method From InterfaceTwo");
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            Demo obj = new Demo();
            ((InterFaceOne)obj).Display();
            ((InterFaceTwo)obj).Display();


        }





    }
    ``````````````````````````````````````STATIC KEYWORD``````````````````````````````````````````

    class Demo
    {
        public void print()
        {
            Console.WriteLine("It is Non-static method");
        }
        public static void display()
        {
            Console.WriteLine("It is static method");
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            Demo obj1 = new Demo();
            obj1.print();

            Demo.display();

        }
    }


    class demo
    {
        int radius;
        public static double pi;
        public demo(int radius)
        {
            this.radius = radius;
        }
        static demo()
        {
            demo.pi = Math.PI;
        }
        public void print()
        {
            Console.WriteLine("Area of Circle: " + pi * radius * radius);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            demo obj1 = new demo(10);
            obj1.print();

            demo obj2 = new demo(20);
            obj2.print();

        }
    }



    class employees
    {
        string ename;
        string designation;
        static string dept;
        

        public employees(string ename, string designation)
        {
            this.ename = ename;
            this.designation = designation;
        }
        static employees()
        {
            employees.dept = "computer science";
        }
        public void print()
        {
            Console.WriteLine($"The name of employee= " + ename + "," + " and the designation : " + designation+","+"  Department: "+dept);
        }
        class program
        {
            static void Main(string[] args)
            {
                employees obj1 = new employees("yamiee","HR");
                obj1.print();

                employees obj2 = new employees("sakshi","tester");
               obj2.print();

              

            }
        }
    }


    class Demo
    { 
        public Demo()
        {
            Console.WriteLine("Non-static");
        }
        static Demo()
        {
            Console.WriteLine("Static");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Demo obj1 = new Demo();
            Demo obj2 = new Demo();
        }
    }


    class Demo
    {
        public Demo()
        {
            Console.WriteLine("A");
        }
        static Demo()
        {
            Console.WriteLine("B");
        }

    }
    class Demo1: Demo
    {
        public Demo1():base()
        {
            Console.WriteLine("C");
        }
        static Demo1()
        {
            Console.WriteLine("D");
        }

    }
    class program
    {
        static void Main(string[]args)
        {
            Demo1 obj1 = new Demo1();
        }
    }*/

    interface I1
    {
        void function1(int x);
        void function2(string r);

    }
    interface I2
    {
        double area(int r);

        double volume(int r, int h);

    }
    class Demo : I1, I2
    {
        public void function1 (int x)
        {
            Console.WriteLine("Product= " + (x * x));
        }
        public void function2(string r)
        {
            Console.WriteLine(string.Concat("hii", r));
        }

        public double area(int r)
        {
            return (3.14 * r * r);

        }
        public double volume(int r, int h)
        {
            return (1/3* 3.14* r *r *h );
        }
        class program
        {
            static void Main(string[] args)
            {

            }

        }


    }







