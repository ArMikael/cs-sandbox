using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Sandbox
{
    class GradesBook
    {
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        List<float> grades = new List<float>();
    }
}
