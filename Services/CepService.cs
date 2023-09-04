using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IntegraBrasilApi.Dto;
using IntegraBrasilApi.Interface;

namespace BrasilApi.Services
{
    public class CepService : ICep
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public CepService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGeneric<CepResponse>> BuscarEnderecoCep(string cep)
        {
           var endereco = await _brasilApi.BuscarEnderecoCep(cep);
           return _mapper.Map<ResponseGeneric<CepResponse>>(endereco);
        }
    }
}