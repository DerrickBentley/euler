using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemClassLibrary
{
    /// <summary>
    /// based on dev.getEthos.com
    /// get "cool numbers"
    /// </summary>
    public class getEthosCoolNumbers
    {


        public string getAllWebRequests()
        {
            StringBuilder result = new StringBuilder();
            const string WEBSERVICE_URL = "http://dev.getethos.com/code";
            for (int i = 1; i <= 100; i++)
            {
                result.Append(getWebRequestFromUrl(WEBSERVICE_URL + i.ToString()));
            }
            return result.ToString();
        }

        public string submitAnswer(string answer)
        {
            string URLAuth = "http://dev.getethos.com/";
            WebClient webClient = new WebClient();
            webClient.Headers.Add("X-COOL-SUM", "70601040511");
            webClient.Headers.Add(HttpRequestHeader.Cookie, "authorized=true");
            NameValueCollection formData = new NameValueCollection();
            formData["code"] = answer;

            byte[] responseBytes = webClient.UploadValues(URLAuth, "POST", formData);
            string resultAuthTicket = Encoding.UTF8.GetString(responseBytes);
            webClient.Dispose();
            return resultAuthTicket;
        }

        /// <summary>
        /// makes a post request with the proper header to the url and returns the string
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public string getWebRequestFromUrl(string url)
        {
            var webRequest = System.Net.WebRequest.Create(url);
            string result = "";
            try
            {
                if (webRequest != null)
                {
                    webRequest.Method = "POST";
                    webRequest.Timeout = 12000;
                    webRequest.Headers.Add("X-COOL-SUM", "70601040511");
                    using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                        {
                            var jsonResponse = sr.ReadToEnd();
                            result = jsonResponse;
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                //return ex.ToString();
                return "";
            }
        }

        /// <summary>
        /// for an integer, square each individual digit and return the sum
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public int getSquareOfDigits(int i)
        {
            var digits = i.ToString().ToCharArray().Select(x => int.Parse(x.ToString()));
            int result = 0;
            foreach (var digit in digits)
            {
                result += digit * digit;
            }
            return result;
        }

        /// <summary>
        /// returns true if a number is "cool"
        /// a number is cool if the sum of its squared digits, twindled down, eventually gets to 1.
        /// Uncool numbers repeat infinitely :(
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Boolean isCoolNumber(int i)
        {
            if (i <= 1)
                return true;
            if (i == 4)
                return false;
            return isCoolNumber(getSquareOfDigits(i));
        }

        /// <summary>
        /// For a range, return the sum of cool numbers.
        /// </summary>
        /// <param name="from">inclusive</param>
        /// <param name="upTo">inclusive</param>
        /// <returns></returns>
        public Int64 sumOfCoolNumbers(int from, int upTo)
        {
            Int64 result = 0;
            for (int i = from; i <= upTo; i++)
            {
                if (isCoolNumber(i))
                    result += i;
            }
            return result;
        }

    }
}
