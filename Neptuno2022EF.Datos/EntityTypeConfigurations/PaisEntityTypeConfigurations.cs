﻿using Neptuno2022EF.Entidades.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Neptuno2022EF.Datos.EntityTypeConfigurations
{
    public class PaisEntityTypeConfigurations:EntityTypeConfiguration<Pais>
    {
        public PaisEntityTypeConfigurations()
        {
            ToTable("Paises");
            Property(p=>p.RowVersion).IsRowVersion().IsConcurrencyToken();
        }
    }
}
