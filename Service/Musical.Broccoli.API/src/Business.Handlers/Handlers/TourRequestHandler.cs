﻿using Business.Contracts;
using Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Handlers.Handlers.contracts;

namespace Business.Handlers.Handlers
{
    public class TourRequestHandler : BaseRequestHandler<TourDTO>, ITourRequestHandler
    {
        public TourRequestHandler(ITourConnector connector) : base(connector)
        {
        }

        public override Musical.Broccoli.API.Response.Response<TourDTO> HandleFilteredRequest(Musical.Broccoli.API.Request.DataRequest<TourDTO> request)
        {
            throw new NotImplementedException();
        }

        public override Musical.Broccoli.API.Response.Response<TourDTO> HandleFilteredRequest(Musical.Broccoli.API.Request.FilteredRequest<TourDTO> request)
        {
            throw new NotImplementedException();
        }
    }
}
