using System;
using System.Collections.Generic;
using System.Text;

namespace RestclientBasic
{
    
    public class User
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }

        internal object Select(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        internal static object Where(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        internal static object Any(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
