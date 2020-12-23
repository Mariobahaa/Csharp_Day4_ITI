using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    [Flags]
    public enum SecurityPriveleges : byte
    {
        //byte Flag enum, security privileges are guest, Developer, secretary and DBA.
        guest = 0b0000_0001,
        developer = 0b0000_0010,
        secretary = 0b0000_0100,
        dba = 0b0000_1000,
    }
    public enum Gender
    {
        M, F
    }

    public struct Employee
    {
        int id;
        SecurityPriveleges securityLevel;
        float salary;
        HireDate hireDate;
        Gender gender;

        public Employee(int ID, int SL, float Sal,Gender G, int d,int m, int y )
        {
            id = ID;
            securityLevel= (SecurityPriveleges)SL;
            salary = Sal;
            gender = G;
            hireDate = new HireDate(d, m, y);

        }

        public override string ToString()
        {
            StringBuilder data = new StringBuilder("", 100);
            data.Append($"Employee ID: {id} \n");
            data.Append($"Security Level: {securityLevel} \n");
            data.Append($"Salary: {salary.ToString("C")} \n");
            data.Append($"Gender: {gender} \n");
            data.Append($"Hiredate: {hireDate.Day}/{hireDate.Month}/{hireDate.Year}");

            return data.ToString();
        }

    }
}
