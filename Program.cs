using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week15_3
{
    class Student
    {
        private string _iD, _name;
        private int _chi, _math, _eng;
        public string ID
        {
            set { _iD = value; }
            get { return _iD; }
        }
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        
        public int Chi
        {
            set
            {
                if (value > 100)
                    value = 100;
                else if (value < 0)
                    value = 0;
                _chi = value;
            }
            get{ return _chi;}
        }
        public int Math
        {
            set
            {
                if (value > 100)
                    value = 100;
                else if (value < 0)
                    value = 0;
                _math = value;
            }
            get { return _math; }
        }
        public int Eng
        {
            set
            {
                if (value > 100)
                    value = 100;
                else if (value < 0)
                    value = 0;
                _eng = value;
            }
            get { return _eng; }
        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR_week15_3");
            
            Student 段昱如_3_1 = new Student();
            段昱如_3_1.ID="B0226497_1";
            段昱如_3_1.Name="段昱如_3_1";
            段昱如_3_1.Chi=63;
            段昱如_3_1.Math=57;
            段昱如_3_1.Eng=-8;
            Console.WriteLine("同學1:");
            Console.WriteLine($"學號: {段昱如_3_1.ID},姓名: {段昱如_3_1.Name}," +
                $"國文:{段昱如_3_1.Chi},數學:{段昱如_3_1.Math}," +
                $"英文:{段昱如_3_1.Eng}");
            Student 段昱如_3_2 = new Student();
            段昱如_3_2.ID = "B0226497_2";
            段昱如_3_2.Name = "段昱如_3_2";
            段昱如_3_2.Chi = 828;
            段昱如_3_2.Math = 322;
            段昱如_3_2.Eng = 72;
            Console.WriteLine("同學2:");
            Console.WriteLine($"學號: {段昱如_3_2.ID},姓名: {段昱如_3_2.Name}," +
                $"國文:{段昱如_3_2.Chi},數學:{段昱如_3_2.Math}," +
                $"英文:{段昱如_3_2.Eng}");
            Student 段昱如_3_3 = new Student();
            段昱如_3_3.ID = "B0226497_3";
            段昱如_3_3.Name = "段昱如_3_3";
            段昱如_3_3.Chi = 52;
            段昱如_3_3.Math =35;
            段昱如_3_3.Eng = -9;
            Console.WriteLine("同學3:");
            Console.WriteLine($"學號: {段昱如_3_3.ID},姓名: {段昱如_3_3.Name}," +
                $"國文:{段昱如_3_3.Chi},數學:{段昱如_3_3.Math}," +
                $"英文:{段昱如_3_3.Eng}");
            Console.ReadLine();
        }
    }
}
