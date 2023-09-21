using AutoMapper;
using foodheaven.services.couponapi.Models.Dto;
using foodheaven.services.couponapi.Models;

namespace foodheaven.services.couponapi
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
