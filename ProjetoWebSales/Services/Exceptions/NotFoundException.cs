using System;

namespace ProjetoWebSales.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message) 
        {
        }
    }
}
