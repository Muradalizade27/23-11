using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Home_Work
{
    internal class admin
    {
        public bool Admin;
        public string Section;

        public admin(bool issuperAdmin, string section)
        {
            Admin = issuperAdmin;
            Section = section;

        }

        public string Return()
        {
            return $"{Admin} , {Section}";
        }
    }
}
