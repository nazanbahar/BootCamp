using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.CCS;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //address
            builder.RegisterType<AddressManager>().As<IAddressService>();
            builder.RegisterType<EfAddressDal>().As<IAddressDal>();

            //basket
            builder.RegisterType<BasketManager>().As<IBasketService>();
            builder.RegisterType<EfBasketDal>().As<IBasketDal>();

            //brand
            builder.RegisterType<BrandManager>().As<IBrandService>();
            builder.RegisterType<EfBrandDal>().As<IBrandDal>();

            //category
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            //city
            builder.RegisterType<CityManager>().As<ICityService>();
            builder.RegisterType<EfCityDal>().As<ICityDal>();

            //country
            builder.RegisterType<CountryManager>().As<ICountryService>();
            builder.RegisterType<EfCountryDal>().As<ICountryDal>();

            //order
            builder.RegisterType<OrderManager>().As<IOrderService>();
            builder.RegisterType<EfOrderDal>().As<IOrderDal>();

            //order detail
            builder.RegisterType<OrderDetailManager>().As<IOrderDetailService>();
            builder.RegisterType<EfOrderDetailDal>().As<IOrderDetailDal>();

            //order status
            builder.RegisterType<OrderStatusManager>().As<IOrderStatusService>();
            builder.RegisterType<EfOrderStatusDal>().As<IOrderStatusDal>();

            //product
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();



            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();


        }
    }
}
