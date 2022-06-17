using AutoMapper;
using DomainModel.DomainParcial;
using System.Collections.Generic;
using System.Linq;

namespace Controller.ViewModels.Helpers
{
    public static class MapperHelper
    {
        readonly private static IMapper iMapper;
        static MapperHelper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProductoView, Producto>();
                cfg.CreateMap<Producto, ProductoView>();

                cfg.CreateMap<List<object>, List<object>>().ConvertUsing<CustomResolver>();

            });

            iMapper = config.CreateMapper();
        }
        public static IMapper GetMapper()
        {
            return iMapper;
        }

        private class CustomResolver : ITypeConverter<List<object>, List<object>>
        {
            public List<object> Convert(List<object> source, List<object> destination, ResolutionContext context)
            {
                var objects = new List<object>();
                foreach (var obj in source)
                {
                    //var destinationType = context.ConfigurationProvider.GetAllTypeMaps().First(x => x.SourceType == obj.GetType()).DestinationType;
                    var destinationType = context.GetType().GetNestedTypes().First(x => x.GetType() == obj.GetType()).GetType();
                    var target = context.Mapper.Map(obj, obj.GetType(), destinationType.GetType());
                    objects.Add(target);
                }
                return objects;
            }
        }
    }
}
