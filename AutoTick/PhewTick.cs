using System;
using System.Web;
using System.IO;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTick
{
    public class PhewTick
    {
        public static string[] getData(string userToken)
        {
            Uri refUri = new Uri(Properties.Settings.Default.phewtick_server + Properties.Settings.Default.refresh_tail + "?token=" + userToken);
            HttpWebRequest getQRT = HttpWebRequest.CreateHttp(refUri);

            getQRT.UserAgent = Properties.Settings.Default.user_agent;
            getQRT.Accept = Properties.Settings.Default.header_accept;
            getQRT.Headers.Add("Accept-Language", Properties.Settings.Default.header_alang);
            getQRT.KeepAlive = Properties.Settings.Default.header_keepalive;
            getQRT.Headers.Add("Accept-Encoding", Properties.Settings.Default.header_aencoding);
            getQRT.ContentType = Properties.Settings.Default.header_ctype;
            getQRT.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            try
            {

                HttpWebResponse webResp = (HttpWebResponse)getQRT.GetResponse();


                Stream respStr = webResp.GetResponseStream();

                StreamReader strRead = new StreamReader(respStr);
                String feed = strRead.ReadToEnd();

                String[] data = new String[2];

                try
                {
                    JObject phewInfo = JObject.Parse(feed);
                    data[0] = phewInfo["qr_key"].ToString();
                    data[1] = phewInfo["ticket"].ToString();
                    Console.WriteLine(data[0] + " " + data[1]);
                    return data;

                }
                catch (Exception parseError)
                {
                    System.Windows.Forms.MessageBox.Show("The following error has occured: " + parseError.ToString(), "Uh-oh", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return null;
                }

                respStr.Flush();
                strRead.Close();
            }

            catch (Exception reallyBad)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + reallyBad.ToString(), "An error has occured", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                //getData(userToken);
                return null;
            }
        }

        public static string[] doScan(string yourtoken, string friendToken)
        {

            string[] friendData = getData(friendToken);
            string postData = "lat=" + Properties.Settings.Default.latitude + "&lng=" + Properties.Settings.Default.longitude + "&qr_key=" + friendData[0] + "&token=" + yourtoken;

            byte[] postArray = Encoding.ASCII.GetBytes(postData);

            Uri refUri = new Uri(Properties.Settings.Default.phewtick_server + Properties.Settings.Default.scan_tail);
            HttpWebRequest getQRT = HttpWebRequest.CreateHttp(refUri);

            Console.WriteLine(refUri.ToString());

            getQRT.Method = "POST";

            getQRT.UserAgent = Properties.Settings.Default.user_agent;
            getQRT.Accept = Properties.Settings.Default.header_accept;
            getQRT.Headers.Add("Accept-Language", Properties.Settings.Default.header_alang);
            getQRT.KeepAlive = Properties.Settings.Default.header_keepalive;
            getQRT.Headers.Add("Accept-Encoding", Properties.Settings.Default.header_aencoding);
            getQRT.ContentType = Properties.Settings.Default.header_ctype;
            getQRT.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            Stream reqStream = getQRT.GetRequestStream();

            reqStream.Write(postArray, 0, postArray.Length);

            reqStream.Close();

            try
            {
                HttpWebResponse webResp1 = (HttpWebResponse)getQRT.GetResponse();


                Stream respStr1 = webResp1.GetResponseStream();

                StreamReader strRead1 = new StreamReader(respStr1);
                String feed = strRead1.ReadToEnd();

                String[] data = new String[3];

                try
                {
                    JObject phewInfo = JObject.Parse(feed);
                    data[0] = phewInfo["user"]["name"].ToString();
                    data[1] = phewInfo["user"]["met"].ToString();
                    data[2] = phewInfo["user"]["ticket"].ToString();

                    Console.WriteLine(data[0] + data[1] + data[2]);

                    return data;

                }
                catch (Exception parseError)
                {
                    System.Windows.Forms.MessageBox.Show("The following error has occured: " + parseError.ToString(), "Uh-oh", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return null;
                }

                Console.WriteLine(feed);

                respStr1.Flush();
                strRead1.Close();
            }

            catch (Exception badIdea)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + badIdea.ToString(), "An error has occured", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                //doScan(yourtoken, friendToken);
                return null;
            }

        }

        public static void updateLoc(string token)
        {
            string postData = "lat=" + Properties.Settings.Default.latitude + "&lng=" + Properties.Settings.Default.longitude + "&tz_offset=" + Properties.Settings.Default.gmt_offset + "&tz_id=" + Properties.Settings.Default.timezone_id + "&post_bg=" + Properties.Settings.Default.post_bg + "&token=" + token + "&locale=en_US";

            byte[] postArray = Encoding.ASCII.GetBytes(postData);

            Uri refUri = new Uri(Properties.Settings.Default.phewtick_server + Properties.Settings.Default.location_tail);
            HttpWebRequest getQRT = HttpWebRequest.CreateHttp(refUri);

            Console.WriteLine(refUri.ToString());

            getQRT.Method = "POST";

            getQRT.UserAgent = Properties.Settings.Default.user_agent;
            getQRT.Accept = Properties.Settings.Default.header_accept;
            getQRT.Headers.Add("Accept-Language", Properties.Settings.Default.header_alang);
            getQRT.KeepAlive = Properties.Settings.Default.header_keepalive;
            getQRT.Headers.Add("Accept-Encoding", Properties.Settings.Default.header_aencoding);
            getQRT.ContentType = Properties.Settings.Default.header_ctype;
            getQRT.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            Stream reqStream = getQRT.GetRequestStream();

            reqStream.Write(postArray, 0, postArray.Length);

            reqStream.Close();

            try
            {
                HttpWebResponse webResp1 = (HttpWebResponse)getQRT.GetResponse();


                Stream respStr1 = webResp1.GetResponseStream();

                StreamReader strRead1 = new StreamReader(respStr1);
                String feed = strRead1.ReadToEnd();
                Console.WriteLine(feed);

                respStr1.Flush();
                strRead1.Close();
            }

            catch (Exception badIdea)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + badIdea.ToString(), "An error has occured", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

    }
}
