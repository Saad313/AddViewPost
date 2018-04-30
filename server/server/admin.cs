using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace server
{
    [DataContract]
    public class admin
    {
        private string adminname;
        private string adminpassword;

        [DataMember]
        public string Adminname
        {
            get
            {
                return adminname;
            }

            set
            {
                adminname = value;
            }
        }

        [DataMember]
        public string Adminpassword
        {
            get
            {
                return adminpassword;
            }

            set
            {
                adminpassword = value;
            }
        }
    }
}