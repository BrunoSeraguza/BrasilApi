using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IntegraBrasilApi.Dto;
using IntegraBrasilApi.Model;
using Microsoft.AspNetCore.Http.HttpResults;

namespace BrasilApi.Mapping
{
    public class CepMapping : Profile
    {
        public CepMapping()
        {
           CreateMap(typeof(ResponseGeneric<>), typeof(ResponseGeneric<>));
           CreateMap<CepResponse , CepModel>();
           CreateMap<CepModel , CepResponse >();
        }
        
    }
}