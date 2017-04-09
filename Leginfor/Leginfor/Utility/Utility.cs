using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Leginfor.Utility
{
    public class Utility
    {
        public static string _blogURL = "https://news.google.com.mx/news?cf=all&hl=es&pz=1&ned=es_mx&topic=b&output=rss";
        public static IEnumerable<Rss> getRssFeed()
        {
            XDocument feedXml = XDocument.Load(_blogURL);
            var feeds = from feed in feedXml.Descendants("item")
                        select new Rss
                        {
                            Titulo = feed.Element("title").Value,
                            Link = feed.Element("link").Value,
                            Descripcion = Regex.Match(feed.Element("description").Value, @"^.{1,180}\b(?<!\s)").Value,
                            Image = GetImagesInGoogleNewsString(feed.Element("description").Value)
                        };
            return feeds;
        }
        private static string GetImagesInGoogleNewsString(string htmlString)
        {
            string imgSrcs = string.Empty;
       
            var imgSrcMatches = System.Text.RegularExpressions.Regex.Matches(htmlString, string.Format(@"<\s*img\s*src\s*=\s*{0}\s*([^{0}]+)\s*{0}", "\""),
               RegexOptions.CultureInvariant | RegexOptions.IgnoreCase |
               RegexOptions.Multiline);
            
            try
            {
                Screen screen = Screen.PrimaryScreen;
                int heigth = screen.Bounds.Height;
                int width = screen.Bounds.Width;
                imgSrcs = imgSrcMatches[0].Value + ">";
                imgSrcs = imgSrcs.Replace(">", "style='max-width: 100%; max-height:100%' class='img-responsive img-rss'>");

            }
            catch
            {
                
            }

            return imgSrcs;
        }

        public static string Code(string sValue, bool bHide = true, bool bUpper = false)
        {
            string str = string.Empty;
            string str1 = string.Empty;
            int num = sValue.Length;
            int num1 = 1;
           // sValue = sValue.ToUpper();

            do
            {
                if (bHide)
                {
                    str = sValue.Substring(num1 - 1, 1);
                    str = (String.Compare(str, "¤") != 0) ? (Strings.Chr((int)str[0] - sValue.Length)).ToString() : Strings.Chr(39 - sValue.Length).ToString();
                    str1 += str;
                }
                else
                {
                    str = Strings.Chr((int)(sValue.Substring(num1 - 1, 1))[0] + num).ToString();
                    var tmp = (String.Compare(str, "'") == 0) ? "¤" : str;
                    str1 += HttpContext.Current.Server.HtmlDecode(tmp);
                }
                num1 += 1;
            } while (num1 <= num);

            return str1;
        }
    }
}