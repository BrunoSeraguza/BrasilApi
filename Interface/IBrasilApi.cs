using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegraBrasilApi.Dto;
using IntegraBrasilApi.Model;

namespace IntegraBrasilApi.Interface
{
    public interface IBrasilApi
    {
           Task<ResponseGeneric<CepModel>> BuscarEnderecoCep(string cep);
           Task<ResponseGeneric<List<BanksModel>>> BuscarTodosBancos();
           Task<ResponseGeneric<BanksModel>> BuscarBanco(string ispb);

    }
}