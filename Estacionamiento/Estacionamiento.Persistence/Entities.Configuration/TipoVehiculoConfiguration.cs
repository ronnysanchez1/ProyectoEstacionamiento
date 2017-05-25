﻿using Estacionamiento.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Persistence.Entities.Configuration
{
    public class TipoVehiculoConfiguration : EntityTypeConfiguration<TipoVehiculo>
    {
        public TipoVehiculoConfiguration()
        {
            ToTable("TipoVehiculo");
            HasKey(cl => cl.TipoVehiculoID);
        }
    }
}
