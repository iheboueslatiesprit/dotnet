﻿using Data.Infrastructure;
using Domain;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ServiceContrat : Service<Contrat>, IServiceContrat
    {
        public ServiceContrat(IUnitOfWork iowk) : base(iowk)
        {
        }
}
