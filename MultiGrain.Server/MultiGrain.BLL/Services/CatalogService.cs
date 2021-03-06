﻿using AutoMapper;
using Microsoft.Extensions.Logging;
using MultiGrain.BLL.Dtos;
using MultiGrain.DAL.Entities;
using MultiGrain.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using MultiGrain.BLL.Helpers;
using MultiGrain.BLL.Dtos.Result;

namespace MultiGrain.BLL.Services
{
    public class CatalogService : ServiceBase, ICatalogService
    {
        public CatalogService(IUnitOfWork uow, IAutoMapperService mapper, ILogger<CatalogService> logger) : base(uow, mapper, logger)
        {
        }

        public async Task<IEnumerable<Catalog>> GetCatalogAsync(CancellationToken ct)
        {
            IEnumerable<Catalog> CatalogEntity = await _uow.Catalog.GetCatalogAsync(ct);
            //IEnumerable<CatalogDto> CatalogDto = _mapper.Mapper.Map<IEnumerable<CatalogDto>>(CatalogEntity);
            return CatalogEntity.ToList();
        }

        public  List<FullTeachingUnitDto>  GetCatalog(int id)
        {
            //List<TeachingUnit> CatalogEntity = _uow.Catalog.GetCatalog(id);
            //CatalogDto CatalogDto = _mapper.Mapper.Map<CatalogDto>(CatalogEntity);
            return new ListFullTeachingUnitDto().list;
        }

        //public async Task<int?> CreateCatalogAsync(CreateCatalogDto CreateCatalogDto, CancellationToken ct)
        //{
        //    Catalog CatalogEntity = _mapper.Mapper.Map<Catalog>(CreateCatalogDto);
        //    _uow.Catalog.CreateCatalog(CatalogEntity);

        //    if (await _uow.SaveChangesAsync(ct) > 0)
        //        return CatalogEntity.Id;
        //    else
        //        return null;
        //}

    }

}
