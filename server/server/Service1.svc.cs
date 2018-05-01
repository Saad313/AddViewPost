using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public void registeruser(string username, string password)

        {
            User u = new User();
            u.Username = username;
            u.Password = password;
            Userdl.user.Add(u);
            
        }
        public void registeradmin(string username, string password)

        {
            admin a = new admin();
            a.Adminname = username;
            a.Adminpassword = password;
            admindl.admin.Add(a);


        }

        public bool Login_user(string username, string password)
        {
            foreach (User u in Userdl.user)
            {
                if (u.Username == username && u.Password == password)
                {
                    return true;
                    MyUtill.log = u;
                }
            }
            return false;
        }

        public bool isadmin(string usernmae, string password)
        {
            foreach (admin a in admindl.admin)
            {
                if (a.Adminname == usernmae && a.Adminpassword == password)
                {
                    return true;
                }

            }
            return false;
        }

    }
}
