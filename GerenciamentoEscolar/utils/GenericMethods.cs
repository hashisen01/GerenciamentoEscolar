using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GerenciamentoEscolar.utils
{
    class GenericMethods
    {
        public bool IsValidEmail(string email)
        {
            string model = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (System.Text.RegularExpressions.Regex.IsMatch(email, model) && email != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string[] GetAddress(string zip_code)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + zip_code + "/json/");
            request.AllowAutoRedirect = false;
            try
            {
                HttpWebResponse getWebResponse = (HttpWebResponse)request.GetResponse();
                using (Stream webStream = getWebResponse.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            string response = responseReader.ReadToEnd();
                            response = Regex.Replace(response, "[{},]", string.Empty);
                            response = response.Replace("\"", "");

                            String[] adress = response.Split('\n');

                            return adress;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool RegisterStudent(string[] enrollment_data, string[] adress_data)
        {
            bool isValid = true;
            if (enrollment_data == null && adress_data == null)
            {
                return false;
            }
            else
            {
                foreach (var item in adress_data)
                {
                    if (item.Length < 2)
                        isValid = false;
                    else
                        isValid = true;
                }
                return isValid;
            }
        }
    }
}
