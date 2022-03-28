using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks2
{
    public class Student
    {
        
        public string Fullname;
        public string GroupNo;
        public int Age;

        public Student( string fullname, string groupno, int age)
        {

            Fullname = fullname;
            GroupNo = groupno;
            Age = age;



        }
        public static bool checkGroup(string groupno)
        {
            if (groupno.Length >= 4)
            {
                bool hasDigit = false;
                bool hasUpper = false;

                foreach (char letter in groupno)
                {
                    if (char.IsDigit(letter))
                    {
                        hasDigit = true;
                        continue;
                    }
                    if (char.IsUpper(letter))
                    {
                        hasUpper = true;
                        
                    }
                       
                }
                bool result = hasDigit && hasUpper;
            }
            return false;
        }
        public static bool checkFullname(string fullname)
        {

            int count = 0;
            for (int i = 0; i < fullname.Length; i++)
            {
                if (char.IsUpper(fullname[i]) && i == 0)
                {
                    count++;
                }
                else if (char.IsWhiteSpace(fullname[i]))
                {
                    count++;
                    if (char.IsUpper(fullname[i + 1]))
                    {
                        count++;
                    }
                }
            }
            return count == 3 ? true : false;
        }
    }
}
