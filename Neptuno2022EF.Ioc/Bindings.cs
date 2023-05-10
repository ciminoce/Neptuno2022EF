﻿using Neptuno2022EF.Datos;
using Neptuno2022EF.Datos.Interfaces;
using Neptuno2022EF.Datos.Repositorios;
using Neptuno2022EF.Servicios.Interfaces;
using Neptuno2022EF.Servicios.Servicios;
using Ninject.Extensions.Factory;
using Ninject.Modules;

namespace Neptuno2022EF.Ioc
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {

            Bind<NeptunoDbContext>().ToSelf().InSingletonScope();

            Bind<IRepositorioPaises>().To<RepositorioPaises>();
            Bind<IServiciosPaises>().To<ServiciosPaises>();

            Bind<IRepositorioCiudades>().To<RepositorioCiudades>();
            Bind<IServiciosCiudades>().To<ServiciosCiudades>();

            Bind<IRepositorioClientes>().To<RepositorioClientes>();
            Bind<IServiciosClientes>().To<ServiciosClientes>();

            Bind<IUnitOfWork>().To<UnitOfWork>();
        }
    }
}
