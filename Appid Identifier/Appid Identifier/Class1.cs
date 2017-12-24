using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Appid_Identifier
{
    class Class1
    {
            public static string srccd(string url)
        {
            

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.UserAgent = "Kirbiflint";
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            
            StreamReader read = new StreamReader(resp.GetResponseStream());

            string sourcecode = read.ReadToEnd();

            resp.Close();
            read.Close();
            return sourcecode;




        }
    }
}
