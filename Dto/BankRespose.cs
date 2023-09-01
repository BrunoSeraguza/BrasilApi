using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegraBrasilApi.Dto
{
    public class BankRespose
    {
         
        public string Ispb;
        
        public string Nome { get; set; }
        
        public int Codigo { get; set; }
        
        public string NomeCompleto { get; set; }
    }
}