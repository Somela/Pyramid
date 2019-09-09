using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    class CustomAttribute
    {
        private string str1;
        private string str2;
        [MyAttribute("Modifier", "Assigns the Student Details")]
        public void setDetails(string str_1,string str_2)
        {
            str1 = str_1;
            str2 = str_2;
        }
        [MyAttribute("Accessor", "Returns Value of getStringOne")]
        public string getStringOne()
        {
            return str1;
        }
        [MyAttribute("Accessor", "Returns Value of Combine String")]
        public string CombineString()
        {
            return str1 +" "+str2;
        }

        [MyAttribute("Accessor", "Returns Value of getStringTwo")]
        public string getStringTwo()
        {
            return str2;
        }
    }
    [AttributeUsage(AttributeTargets.All)]
    public class MyAttribute : Attribute
    {
        private string name;
        private string action;
        public MyAttribute(string name, string action)
        {
            this.name = name;
            this.action = action;
        }
        public string Name
        {
            get { return name; }
        }
        public string Action
        {
            get { return action; }
        }
    }
}
