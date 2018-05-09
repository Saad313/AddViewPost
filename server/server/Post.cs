using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace server
{
    [DataContract]
    public class Post
    {
        private bool approval = false;
        private string id;


        [DataMember]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public bool Approval
        {
            get { return approval; }
            set { approval = value; }
        }

        private string title;

        [DataMember]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string category;
        [DataMember]
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        private string description;
        [DataMember]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}