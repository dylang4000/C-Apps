using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class book
    {
    public string Title { get; set; }
        public bookauthor author { get; set; }
        public List<bookauthor> Authors { get; set; }
        public float Price { get; set; } = 0.0f;
        public uint PageCount { get; set; } = 0;



        public book()
        {
            Title = "";
            Authors = new List<bookauthor>();
        }
        public override string ToString()
        {
            string text = "";
            text += Title + " Pages:" + PageCount + " Price:" + Price + " Authors:" + Authors;
            return text;
        }
    }
    public class bookauthor
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        public override string ToString()
        {
            string text = "";
            text += "the author is " + FirstName +" " + LastName; 
            return text;
            
        }
    }
}
