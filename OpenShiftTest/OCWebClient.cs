using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace OpenShiftTest
{
    public static class OCWebClient
    {

        public static string GetGoogle()
        {
            WebClient client = new WebClient();

            // Add a user agent header in case the 
            // requested URI contains a query.

            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            try
            {
                Stream data = client.OpenRead("http://www.google.com");
                StreamReader reader = new StreamReader(data);
                string s = reader.ReadToEnd();

                data.Close();
                reader.Close();

                return s;
            }
            catch (Exception ex)
            {

                throw;
            }

        }

    }
}
