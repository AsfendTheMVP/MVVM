using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using QuotesApplication.Interfaces;
using QuotesApplication.Models;

namespace QuotesApplication.Services
{
   public class QuotesApi : IQuotes
    {
       
        public async Task<List<Quote>> GetQuotes()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("http://www.quotes.somee.com/api/Quotes");
            return JsonConvert.DeserializeObject<List<Quote>>(response);
        }
    }
}
