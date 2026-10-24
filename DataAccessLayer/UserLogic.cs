using System;
using System.Collections.Generic;
using System.Text;
using Shop.Model;

namespace Shop.DL
{
    public class UserLogic
    {
        public int RegisterUser(Student stud)
        {
            string sql = $"Update Students5 set Name ='{stud.Name}', Age = {stud.Age}, MobileNo = {stud.MobileNo} where MobileNo = {stud.MobileNo}";
            int value = Helper.Register(sql);
            return value;
        }
    }
}
