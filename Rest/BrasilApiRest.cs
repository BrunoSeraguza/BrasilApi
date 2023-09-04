using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using IntegraBrasilApi.Dto;
using IntegraBrasilApi.Interface;
using IntegraBrasilApi.Model;
using Microsoft.VisualBasic;

namespace BrasilApi.Rest
{
    public class BrasilApiRest : IBrasilApi
    {
      
        public Task<ResponseGeneric<BanksModel>> BuscarBanco(string ispb)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseGeneric<CepModel>> BuscarEnderecoCep(string cep)
        {
            
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");

            var response = new ResponseGeneric<CepModel>();

            using(var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentApiResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<CepModel>(contentApiResp);

                if(responseBrasilApi.IsSuccessStatusCode)
                {
                    response.HttpStatusCode = responseBrasilApi.StatusCode;
                    response.Response = objResponse;
                    return response;
                }else{
                    response.HttpStatusCode = responseBrasilApi.StatusCode;
                    response.ReturnError = JsonSerializer.Deserialize<ExpandoObject>(contentApiResp);
                }
            }
            return response;
        }

        public Task<ResponseGeneric<List<BanksModel>>> BuscarTodosBancos()
        {
            throw new NotImplementedException();
        }
    }
}