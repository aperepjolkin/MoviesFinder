using data;
using data.DAL;
using data.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace business.Service
{
    public static class DataAPIService 
    {
        
     
        public static async Task<string> FetchDataFromPublicAPIAsync(string title)
        {
            string API_KEY = "&apikey=7878efa8";
            string url = "?t=" + title + API_KEY;
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("http://www.omdbapi.com");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                        return response.Content.ReadAsStringAsync().Result;
                    else
                        return response.StatusCode.ToString();
                  
                } 
                catch(Exception ex)
                {
                    return ex.ToString();
                }

            }

        

        }
    }
       
    }

