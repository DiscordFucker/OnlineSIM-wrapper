using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSIM
{
    public class OnlineSimClient
    {


        


        private static string apiKey;
        public OnlineSimClient(string API_Key)
        {
            apiKey = API_Key;
        }

        public string GetBalance()
        {

            WebClient client = new WebClient();
            string myc = client.DownloadString($"http://onlinesim.ru/api/getBalance.php?apikey={apiKey}");
            dynamic dont_ask_me_why = JObject.Parse(myc);
            string gg = dont_ask_me_why.balance;
            return gg;

        }
        public string GetZBalance()
        {
            WebClient client = new WebClient();
            string myc = client.DownloadString($"http://onlinesim.ru/api/getBalance.php?apikey={apiKey}");
            dynamic dont_ask_me_why = JObject.Parse(myc);
            string gg = dont_ask_me_why.zbalance;
            return gg;


        }


        public string GetReceivedCode(string tzid)
        {

            WebClient client = new WebClient();
            string mynum = client.DownloadString($"http://onlinesim.ru/api/getState.php?apikey={apiKey}&tzid={tzid}");
            dynamic phonefuture = JObject.Parse(mynum.Replace("[", "").Replace("]", ""));
            string phonenumber = phonefuture.msg;

            return phonenumber;

        }
        public string GetNumber(string tzid)
        {

            WebClient client = new WebClient();
            string mynum = client.DownloadString($"http://onlinesim.ru/api/getState.php?apikey={apiKey}&tzid={tzid}");
            dynamic phonefuture = JObject.Parse(mynum.Replace("[", "").Replace("]", ""));
            string phonenumber = phonefuture.number;
            return phonenumber;
            
        }

        public string CreateTZID(string service, int country = 7, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            try
            {
                string responseString  = new WebClient().DownloadString($"https://onlinesim.ru/api/getNum.php?apikey={apiKey}&service={service}&country={country}");

                dynamic jsonDe = JObject.Parse(responseString);
                string tzid = jsonDe.tzid;

                return tzid;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }







    }
}
