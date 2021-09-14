using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class FileHandling
    {
        public string WriteFile()
        {
            FileStream obj = new FileStream(@"E:\EuroTraining\demo\file2.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(obj);
            sw.WriteLine("Course Details");
            sw.WriteLine("***************");
            Console.WriteLine("Enter number of courses: ");
            int num = Convert.ToInt32(Console.ReadLine());
            sw.WriteLine("Number of Courses: " + num);
            for (int i = 0; i < num ; i++)
            {
                Console.WriteLine(" Enter RegNo: ");
                int reg = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Course : ");
                string course = Console.ReadLine();
                Console.WriteLine("Enter Course title: ");
                string course_title = Console.ReadLine();

                sw.WriteLine("RegNo :" + reg);
                sw.WriteLine("Course :" + course);
                sw.WriteLine("Title :" + course_title);
            }
            sw.Close();
            obj.Close();
            return "File Created";
        }

    }
}
