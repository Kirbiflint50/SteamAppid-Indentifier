using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using System.Threading;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Xml;
using System.Drawing.Printing;
using html = HtmlAgilityPack;


//using System.Threading.Tasks;

//using Fizzler.Systems.HtmlAgilityPack;

namespace Appid_Identifier
{



    public partial class Form1 : Form




    {
        string url;
        int endid;
        int nm;
        html.HtmlDocument dc;

        HtmlWeb appidwb = new HtmlWeb();
        public Form1()
        {
            InitializeComponent();
        }

        string idhtml;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;

            }
            if (e.KeyChar == '.')
            {

                if (textBox1.Text.Contains("."))
                    e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //  Thread app;

            ////WebClient n;


            //   WebClient lnkstmdb;
            // string Finder;
            /// XmlDocument xmlDoc = new XmlDocument();
            /// 
            int removechr;
            //char[] chrs = { '<', '>', ':', ';', '=' }; 
            /// 
            // HttpClient Id;
            //  WebBrowser id;
            //WebClient client;
            ///   string Appid;
            ////  string Nmgame;
            //string xml;
            ///string s;
            ////string htmlstrg;
            
            ///////HtmlAgilityPack.HtmlDocument htmlDoc;
            ///PrintDocument html = new PrintDocument();
            ///HtmlAgilityPack.HtmlDocument document2; ///= new HtmlAgilityPack.HtmlDocument();

            /// HtmlAgilityPack.HtmlDocument appid; 

            ///   HttpWebRequest req;
            ////   HttpWebResponse resp;
            ////  StreamReader r;
            ////String hmdonwl;
            //XDocument doc;
            ///  string url; ///= "http://store.steampowered.com" + "/" + Appid;

            /////HtmlDocument Appid;
            ////  string htmlappid;
            if (String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(textBox2.Text))

            {

                MessageBox.Show("Enter your game name! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;


            }

            //else if (textBox1.Text.Contains



            // app / 225540 /
            try
            {

                url = "http://store.steampowered.com/search/?term=" + textBox1.Text;
                string sourcecode = Class1.srccd(url);

                nm = sourcecode.IndexOf("appid=\"");
                // int nmgm = sourcecode.IndexOf("")
                sourcecode = sourcecode.Substring(nm, sourcecode.Length - nm);
                nm = sourcecode.IndexOf("\"");
                endid = sourcecode.IndexOf(" onm", nm);
                string appidfinal = sourcecode.Substring(nm, endid - nm) + " onm";
                textBox2.Text = appidfinal;
                string myString = textBox2.Text;
                textBox2.Text = myString.Replace("onm", "");


            }
            catch (Exception ex)
            {




                MessageBox.Show("Sorry something went wrong. Maybe you are not connected to internet or the appid is not listed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }






            /* else if (textBox1.Text.Contains(""))
              {


                  try
                  {

                      url = "http://store.steampowered.com/search/?term=" + textBox2.Text;
                      string sourcecode = Class1.srccd(url);

                      nm = sourcecode.IndexOf("<span class=\"title\">");
                      // int nmgm = sourcecode.IndexOf("")
                      sourcecode = sourcecode.Substring(nm, sourcecode.Length - nm);
                      nm = sourcecode.IndexOf("title\" > ");
                      endid = sourcecode.IndexOf(" </span>", nm);
                      string appidfinal = sourcecode.Substring(nm, endid - nm) + " </span>";
                      textBox1.Text = appidfinal;
                      string myString = textBox2.Text;
                      textBox1.Text = myString.Replace("onm", "");
                      return;

                  }
                  catch (Exception ex)
                  {




                      MessageBox.Show("Sorry something went wrong, maybe you are not connected to internet or the appid is not listed.");
                  }*/







            // string test = "data-appid=";
            //int index = test.IndexOf(appidfinal);
            /// int l = test.Length;
            //// test.Substring(t) 
            ///  test = test.Substring(index + 4);
            //textBox2.Text = test;

            /// string dff = appidfinal;
            ///string[] edd = File.ReadAllLines(@"data-appid=");
            ////  string edd = string.Join(appidfinal);//File.ReadAllLines(appidfinal);

            //for (int i = edd.Count - 1; i >=0; i-- )


            // string appid =  " data-appid=";
            ///int apid = Convert.ToInt32("-data-appid=");

            ////  appidfinal.Select.
            ///if (apid != -1)
            ///{


            ///// appidfinal = appidfinal.Remove(apid);
            /// textBox2.Text = appidfinal;


            /////}



            //textBox2.Text = appidfinal;

            //// if (




            //  appid = appid.Substring(0, appid.Length - 1);





            ///while ((removechr = textBox2.Text.IndexOfAny(chrs)) >= 0)
            ///{



            /// appid = textBox2.Text.Remove(removechr, 1);


            ///}


            // textBox2.Text = Convert.ToString(endid); 

            /// textBox2.Text = sourcecode;

            // StreamWriter rw = new StreamWriter("code.txt");

            //rw.Write(sourcecode);
            ///rw.Close();








            /*    else


                    url = "https://steamdb.info/search/?a=app&q=" + textBox1.Text;

                /* var config = new HttpSelfHostConfiguration("http://localhost:8080");

                 config.Routes.MapHttpRoute(
                     "API Default", "api/{controller}/{id}",
                     new { id = RouteParameter.Optional });*/


            /*      HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                  ((System.Net.HttpWebRequest)request).UserAgent = ".NET Framework";
                  //Create response-object
                  HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                  //Take response stream
                  StreamReader sr = new StreamReader(response.GetResponseStream());

                  //Read response stream (html code)
                  string html = sr.ReadToEnd();

                  //Close streamreader and response
                  sr.Close();
                  response.Close();




              htmlDoc = new html.HtmlDocument();

              htmlDoc.LoadHtml(html);
              var appid = htmlDoc.DocumentNode.SelectNodes("//*[@id=\"table - sortable\"]/tbody/tr[1]");


              for(int i = 0; i<= appid.Count; i++ )

              {


                  string u = appid.InnerText;

                  textBox2.Text = u;




              }*/



            //return source
            //// return html;

            /// WebRequest objRequest = WebRequest.Create(url);
            // ((System.Net.HttpWebRequest)objRequest).UserAgent = ".NET Framework";
            ///  objRequest.UserAgent = "";
            /// objRequest.UserAgent = ".NET Framework Test Client";
            ////HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();


            ///Stream objDataStream = objResponse.GetResponseStream();

            // StreamReader TextReader = new StreamReader(objDataStream);



            //string htmlval = TextReader.ReadToEnd();








            /* if (htmlval == null)

             {


                 MessageBox.Show("html null");



             }
             else
                 dc = new html.HtmlDocument();

                 dc.LoadHtml(htmlval);


                 HtmlNodeCollection nodes = dc.DocumentNode.SelectNodes("//*[@id=\"table - sortable\"]/tbody/tr[1]/td[1]/a");





                 foreach (HtmlNode n in nodes)

                {

                     HtmlNode a = nodes.SelectSingleNode("a");



                     string sTitel = a.InnerText;

                     string appid = a.GetAttributeValue("href", "");

                     textBox2.Text = appid;

                    /// sys_Add_Result(sTitel);

                 }*/






            ///  s = "https://steamdb.info/search/?a=app&q=" + textBox1.Text;

            //            WebClient appid = new WebClient();
            ///          s = appid.DownloadString( s );
            ///          

            // client = new WebClient();
            //  appid =  new HtmlAgilityPack.HtmlDocument();

            // Directory.CreateDirectory("C:/Users/Simone Inches/Desktop/html/");
            ///System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls;
            /* try
             {
                 HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                 request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Trident/7.0; rv:11.0) like Gecko";
                 //request.Timeout = 10;
                 HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                 StreamReader read = new StreamReader(response.GetResponseStream());
                 string data = read.ReadToEnd();


                 htmlDoc = new HtmlAgilityPack.HtmlDocument();

                 // There are various options, set as needed
                 htmlDoc.OptionFixNestedTags = true;

                 // filePath is a path to a file containing the html
                 htmlDoc.Load(data);

                 // Use:  htmlDoc.LoadHtml(xmlString);  to load from a string (was htmlDoc.LoadXML(xmlString)

                 // ParseErrors is an ArrayList containing any errors from the Load statement
                 if (htmlDoc.ParseErrors != null && htmlDoc.ParseErrors.Count() > 0)
                 {
                     // Handle any parse errors as required

                 }
                 else
                 {

                     if (htmlDoc.DocumentNode != null)
                     {
                         HtmlAgilityPack.HtmlNode bodyNode = htmlDoc.DocumentNode.SelectSingleNode("//*[@id=\"table - sortable\"]/tbody/tr[1]/td[1]/a");

                         if (bodyNode != null)
                         {

                             MessageBox.Show("Error!");
                             // Do something with bodyNode
                         }
                         else
                             textBox2.Text = Convert.ToString(bodyNode);
                     }


                 }

             }
             catch(Exception Ex)
             {


                 MessageBox.Show("Sorry, something went wrong! ");
             }


             /*HttpWebResponse response = (HttpWebResponse)request.GetResponse();
             string data = "";
             if (response.StatusCode == HttpStatusCode.OK)
             {
                 Stream receiveStream = response.GetResponseStream();
                 StreamReader readStream = null;

                 if (response.CharacterSet == null)
                 {
                     readStream = new StreamReader(receiveStream);
                 }
                 else
                 {
                     readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                 }

                 data = readStream.ReadToEnd();


                 response.Close();
                 readStream.Close();
             }*/

            ///  document2 = new HtmlAgilityPack.HtmlDocument();
            ///document2.LoadHtml(data);
            //textBox2.Text = data;*/


            /// client.DownloadFile(url, "C:/Users/Simone Inches/Desktop/html/Saved.html");

            ///File.WriteAllText(@"c:\YourLocalFolder\somefile.txt", s);

            // Add an event handler that prints the document after it loads.


            /* url = "https://steamdb.info/search/?a=app&q=" + textBox1.Text;
             id = new WebBrowser();
             id.Url = new Uri(url, @"\\myshare\help.html");
             id.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(PrintDocument);*/

            // Set the Url property to load the document.


            /// client.DownloadFile(url, "C:/Users/Simone Inches/Desktop/Saved.html");
            /*  var Webget = new HtmlWeb();
              var doc = Webget.Load(url);
            //  foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//h2//a"))
              {
                  node.Add(node.ChildNodes[0].InnerHtml);
              }
              foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//li[@class='tel']//a"))
              {
                  phones.Add(node.ChildNodes[0].InnerHtml);
              }*/
            ////  client.DownloadFile(url, @"C:\Users\Simone Inches\Desktop\Saved.html");



            ///  HtmlAgilityPack.HtmlDocument app = new HtmlAgilityPack.HtmlDocument();
            /*  HtmlWeb ds = new HtmlWeb();
              appid = ds.Load(s);
              HtmlNodeCollection nodes =  appid.DocumentNode.SelectNodes("//*[@id=\"table - sortable\"]/tbody/tr[1]");
              htmlstrg = "";


              var item = nodes;



              htmlstrg = item.ToString();



              textBox2.Text = htmlstrg;*/




            /*using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(s).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        MatchCollection m = Regex.Matches( "//*[@id=\"table - sortable\"]//tr[1]/td[1]/a");

                        string result = content.ReadAsStringAsync().Result;
                        textBox2.Text = result;




                    }


                }
            }*/



            /* var code =  await Task.Factory.StartNew(() => appidwb.Load(s));

             var doc = code.DocumentNode.SelectNodes("//*[@id=\"table - sortable\"]//tr[1]/td[1]/a");

             var text = doc.Select(node => node.InnerText);

             textBox2.Text = Convert.ToString(text);*/

            /*var url = "https://steamdb.info/search/?a=app&q=" + s;

            var httpclnt = new HttpClient();



            var html = await httpclnt.GetStringAsync(url);
            var dwnld = new HtmlAgilityPack.HtmlDocument();

            dwnld.LoadHtml(html);


            var Appid = dwnld.DocumentNode.Descendants("a")

            .Where(node => node.GetAttributeValue("href", "")
            .Equals("/app/.+?/")).ToList();

            string nmb = Convert.ToString(Appid);*/


            /// textBox2.Text = Appid.ToString();
















            //  MatchCollection id = Regex.Matches(s, @"<a href= s*(.+?)>s*(.+?)</a>", RegexOptions.Singleline);

            ///textBox2.Text = Convert.ToString(id);





            //get the page
            /// var o = new HtmlWeb();
            /*var document = n.DownloadString("http://example.com/page.html");


            //loop through all div tags with item css class
            foreach (var item in document.QuerySelectorAll("div.item"))
            {
                var title = item.QuerySelector("h3:not(.share)").InnerText;
                var date = DateTime.Parse(item.QuerySelector("span:eq(2)").InnerText);
                var description = item.QuerySelector("span:has(b)").InnerHtml;
            }*/


            /*    Nmgame = "https://steamdb.info/search/?a=app&q=" + textBox1.Text;

                string htmlTagPattern = "<.*?>";
                var regexCss = new Regex("(\\<script(.+?)\\</script\\>)|(\\<style(.+?)\\</style\\>)", RegexOptions.Singleline | RegexOptions.IgnoreCase);
                htmlstrg = regexCss.Replace(htmlstrg, string.Empty);
                htmlstrg = Regex.Replace(htmlstrg, htmlTagPattern, string.Empty);
                htmlstrg = Regex.Replace(htmlstrg, @"^\s+$[\r\n]*", "", RegexOptions.Multiline);
                htmlstrg = htmlstrg.Replace("&nbsp;", string.Empty);*/

            /// return htmlstrg;
            /// req = (HttpWebRequest)WebRequest.Create(Nmgame);
            ///resp = (HttpWebResponse)req.GetResponse();
            ///r = new StreamReader(resp.GetResponseStream());
            ///richTextBox1.Text = r.ReadToEnd();
            ///r.Close();
            /////  lnkstmdb  = new WebClient();
            ///string s = lnkstmdb.DownloadString("http://en.wikipedia.org/wiki/Main_Page");

            // 2.
            ///foreach ( i in LinkFinder.Find(s))
            ///{
            //  Debug.WriteLine(i);
            ////}

            /* s = textBox1.Text;
         List<string> dd = new List<string>();
         List<string> tt = new List<string>();
         WebClient idapp = new WebClient();
         hmdonwl = idapp.DownloadString("https://steamdb.info/search/?a=app&q= " + s); // download the html doc to htmdownl variable.
         MatchCollection appid = Regex.Matches(hmdonwl, @"<a href = s*(.+?)\ s* </a>", RegexOptions.Singleline);

         foreach (Match pp in appid)
         {


             if (pp.Groups[1].Value != s)
             {

                 string app = pp.Groups[1].Value;
                 dd.Add(app);




             }*/







            ////  textBox2.Text = Convert.ToString(dd);
            // obtain some arbitrary html....
            /* using (var client = new WebClient())
             {
                 htmlappid = client.DownloadString("http://stackoverflow.com/questions/2038104" + );
             }
             // use the html agility pack: http://www.codeplex.com/htmlagilitypack
             HtmlDocument doc = new HtmlDocument();
             doc.LoadHtml(html);
             StringBuilder sb = new StringBuilder();
             foreach (HtmlTextNode node in doc.DocumentNode.SelectNodes("//text()"))
             {
                 sb.AppendLine(node.Text);
             }
             string final = sb.ToString();*/


            //   s = textBox1.Text;
            //Appid = new HtmlDocument;
            ////Appid.Load("https://steamdb.info/search/?a=app&q=" + s);
            //////Xmdonwl = Appid.OuterXml;

            //////    xml = new WebClient().DownloadString("https://steamdb.info/search/?a=app&q=" + textBox1.Text);

            ///doc = XmlDocument.Parse(xml);

            //  Nmgame = textBox1.Text;
            //   url = "http://store.steampowered.com" + "/" + textBox1.Text;


            /*xmlDoc.Load("https://steamdb.info/search/?a=app&q=" + textBox1.Text); // https://steamdb.info/search/?a=app&q= Just Cause 3
            s = client.DownloadString("https://steamdb.info/search/?a=app&q=");
            textBox2.Text = s;*/
            /// n = 

            //  url = "http://store.steampowered.com/"  + textBox2.Text; //http://store.steampowered.com/ 4444

            ///n = 

            /// Appid = textBox2.Text;
            /// Nmgame = textBox1.Text;

            //url = ("http://store.steampowered.com" + "/" + Appid)  //// + "&steamid=" + "&format=json&include_appinfo=1";    


            //// SteamUser.GetSteamID().ToString()
            // textBox2.Text = Appid;




            /// else

            /*query = HttpContext.Current.Request.ServerVariables["URL"] +
            HttpContext.Current.Request.ServerVariables["PATH_INFO"] +
            HttpContext.Current.Request.ServerVariables["QUERY_STRING"];
    }*/


        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(""))
            {



                textBox2.Text = "";



            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.')
            {
                e.Handled = true;

            }
            if (e.KeyChar == '.')
            {

                if (textBox1.Text.Contains("."))
                    e.Handled = true;
            }*/
        }

        






        }

       
    }





 
         




       
    





