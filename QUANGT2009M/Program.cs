using System;
using System.Collections.Generic;
using QUANGT2009M.session1;

namespace QUANGT2009M
{
    internal class Program
    {
        protected static void Main(string[] args)
        {
            int a;
            string s;
            Console.WriteLine("Nhap 1 chuoi tu ban phim:");
            s = Console.ReadLine();//lay 1 dong vua nhap tu ban phim
            Console.WriteLine("nhap 1 so nguyen:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a = "+a);
            if (CheckPrime(a))
            {
                Console.WriteLine(a+"la so nguyen to");
            }

            Student st = new Student("Le van nam", 19);
            st.ShowInfo();

            Student.SayHello();
            //tao 1 mang 3 sinh vien
            Student[] stArray = new Student[3];
            stArray[0] = st;
            stArray[1] = new Student();
            stArray[2] = new Student();
            
            //list
            List<Student> listStudent = new List<Student>();
            listStudent.Add(new Student());
            //list string
            List<string> strList = new List<string>();
            //list int
            List<int> intsArr = new List<int>();
            intsArr.Add(6);

        }

        public static bool CheckPrime(int n)
        {
            if (n < 2) return false;
            if (n < 4) return true;
            for (int  i=2; i < n /2;i ++)
            {
                if (n % i == 0) return false;
                
            } 
            return true;
        }
    }
}