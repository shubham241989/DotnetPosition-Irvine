using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotnetPosition_Irvine
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // TextReader tr = new StreamReader("wordlist.txt");
            var path = Server.MapPath(@"~/wordlist.txt");
            TextReader sr = new StreamReader(path);
            String line = sr.ReadToEnd();
            string[] lstArray = line.Replace(System.Environment.NewLine, " ").Split(' ');

            List<string> Defaultlist = new List<string>(lstArray);
            List<string> Mainlist = new List<string>();
            char[] smallstrchar = String.Join("", Defaultlist.Where(x => x.Length <= 4)).ToCharArray();
            char[] bigstrchar = String.Join("", Defaultlist.Where(x => x.Length > 4)).ToCharArray();
            char[] modchar = bigstrchar.Except(smallstrchar).ToArray();

            foreach (string bigstr in Defaultlist)
            {
                if (!(bigstr.IndexOfAny(modchar) != -1))
                {
                    Mainlist.Add(bigstr);
                }
            }
            Mainlist = Mainlist.OrderByDescending(x => x.Length).Take(2).ToList();
           lblWord.Text = Mainlist[1];
            lblCount.Text = Mainlist[1].Length.ToString();
            //foreach (string finalstr in Finallist)
            //{
             
            //    Console.WriteLine(finalstr);
            //}
        }

    }

  
}