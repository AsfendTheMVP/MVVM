using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using QuotesApplication.Models;

namespace QuotesApplication.Interfaces
{
    public interface IQuotes
    {
       Task<List<Quote>> GetQuotes();
    }
}
