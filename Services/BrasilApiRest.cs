using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegraBrasilApi.Dto;
using IntegraBrasilApi.Interface;
using IntegraBrasilApi.Model;

namespace IntegraBrasilApi.Services
{
    public class BrasilApiRest : IBrasilApi
    {
        public Task<ResponseGeneric<CepModel>> BuscarBanco(string ispb)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseGeneric<CepModel>> BuscarEnderecoCep(string cep)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseGeneric<List<CepModel>>> BuscarTodosBancos()
        {
            throw new NotImplementedException();
        }
    }
}