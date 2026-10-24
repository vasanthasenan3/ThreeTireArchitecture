namespace Shop.BL;

using Shop.DL;
using Shop.Model;

public class Userdata
{
    public void RegisterUser(Student stud)
    {
        UserLogic ouser = new UserLogic();
        ouser.RegisterUser(stud);
    }
}
