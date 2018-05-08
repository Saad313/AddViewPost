using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace server
{
    [DataContract]
    public class User
    {
        private string username;
        private string password;
        private List<Post> posts = new List<Post>();

        [DataMember]
        public List<Post> Posts
        {
            get
            { 
                return posts;
            }
            set
            { 
                posts = value; 
            }
        }


        [DataMember]
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        [DataMember]
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
    }
}