
using System;
namespace assignment04
{
    public struct Student
    {
        private string _name;
        private string _gender;
        private int _age;
        private int _std;
        private char _div;
        private double _marks;

        string n1, n2;
        int n3, n4;
        char n5;
        double n6;
        public Student(string _name, string _gender, int _age, int _std, char _div, double _marks)
        {
            this._name = _name;
            this._gender = _gender;
            this._age = _age;
            this._std = _std;
            this._div = _div;
            this._marks = _marks;

        }

        public void setname(String _name)
        {
            this._name = _name;
        }
        string getname()
        {
            return _name;
        }
        public void setgender(string _gender)
        {
            this.setgender(_gender);
        }
        string getgender()
        {
            return _gender;
        }
        public void setage(int _age)
        {
            this._age = _age;
        }
        int getage()
        {
            return _age;
        }

        public void setstd(int _std)
        {
            this._std = _std;
        }
        int getstd()
        {
            return _std;
        }
        public void setchar(char _div)
        {
            this._div = _div;
        }
        char getchar()
        {
            return _div;
        }
        public void setmarks(double _marks)
        {
            this._marks = _marks;
        }
        double getmarks()
        {
            return _marks;
        }
        public void accept()
        {
            Console.WriteLine("Enter the name");
            n1 = Console.ReadLine();

            Console.WriteLine("Enter the gender");
            n2 = Console.ReadLine();

            Console.WriteLine("Enter the age");
            n3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the std");
            n4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the div");
            n5 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the marks");
            n6 = Convert.ToDouble(Console.ReadLine());

        }
        public void display()
        {
            Console.WriteLine("Name :" + n1);
            Console.WriteLine("gender :" + n2);
            Console.WriteLine("age :" + n3);
            Console.WriteLine("std :" + n4);
            Console.WriteLine("div :" + n5);
            Console.WriteLine("marks :" + n6);
            Console.ReadLine();

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student p = new Student();
            p.accept();
            p.display();
        }
    }
}
