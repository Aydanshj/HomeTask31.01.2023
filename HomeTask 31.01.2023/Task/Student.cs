using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask
{
    internal class Student
    {

        private static int TotalCount;

        public Student()
        {
            TotalCount++;
            No = TotalCount;
        }

        public int No;
        public string Name;

        public string GroupNo;
        public Student(string groupno)
        {
            if (CheckGroupNo(groupno))
                GroupNo = groupno;
        }

        public bool CheckGroupNo(string str)
        {
            if (str.Length == 4 && char.IsUpper(str[0]))
            {
                for (int i = 1; i < str.Length; i++)
                {
                    if (!char.IsNumber(str[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;

        }
    }
}
