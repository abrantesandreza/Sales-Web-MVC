using System;

namespace ProjetoWebSales.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message) : base(message) 
        {
        }
    }
}
