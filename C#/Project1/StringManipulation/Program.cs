using System;
using System.Text;

namespace StringManipulation
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("String Manipulation");
            

           

            DateTime alku = DateTime.Now;

            string html = "<table>";
            for(int i=0; i<10000; i++ )
            {
                html += "<tr> <td>" + i + "</tr> </td>";
            }
            html += ">/table>";

            Console.WriteLine("HTML koodin pittus: " + html.Length);
            DateTime loppu = DateTime.Now;
            TimeSpan kesto = loppu - alku;
            Console.WriteLine("HTML koodin muodotus kesi {0}", kesto.TotalSeconds);

            Console.WriteLine("With String Builder ");
            DateTime alku2 = DateTime.Now;
            StringBuilder sb = new StringBuilder();
            sb.Append("<table>");

            for(int i=0; i<10000; i++)
            {
                sb.AppendLine($"<tr> <td>{i}</td></tr>");

            }
            sb.AppendLine("</table>");
            string valistella = sb.ToString();
            DateTime loppu2 = DateTime.Now;
            TimeSpan kesto2 = loppu2 - alku2;
            Console.WriteLine("HTML koodin pittus: " + sb.Length);
            Console.WriteLine("HTML koodin muodotus StringBuilder kesto {0}", kesto2.TotalSeconds);
        }
    }
}
