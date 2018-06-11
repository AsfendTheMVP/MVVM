using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;
using QuotesApplication.Interfaces;
using QuotesApplication.Models;
using QuotesApplication.Services;

namespace QuotesApplication.ViewModels
{
    public class QuotesViewModel : BaseViewModel
    {
        public ObservableCollection<Quote> Quotes { get; set; }
        private IQuotes _quotes;
        public QuotesViewModel(IQuotes quotes)
        {
            Quotes = new ObservableCollection<Quote>();
            _quotes = quotes;
            LoadQuotes();
        }
        public async void LoadQuotes()
        {
            var quotes = await _quotes.GetQuotes();
            foreach (var quote in quotes)
            {
                Quotes.Add(quote);
            }
        }
    }
}
