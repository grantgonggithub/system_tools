using AutoMapper;

using SuperGMS.DB.MapperEx;

using System.Collections.Generic;

namespace SXCRM.Service
{
    /// <summary>
    /// 注册对象映射
    /// <see cref="AutoMapperProfile" langword="" />
    /// </summary>
    public class AutoMapperProfile : Profile
    {
        // 注册对象映射
        public AutoMapperProfile()
        {
            //this.CreateMap<DomesticTicketOrder, GetDomesticTicketOrderListResult>();
            //this.CreateMap<Account, GetAccountListResult>();
        }
    }

    /// <summary>
    /// 初始化AutoMapper
    /// </summary>
    public class AutoMapperRegister : AutoMapperTool
    {
        /// <summary>
        /// 初始化AutoMapper
        /// </summary>
        public static void Initlize()
        {
            new AutoMapperRegister().RegisterMap();
        }

        public override List<Profile> GetProfiles()
        {
            var profiles = new List<Profile>
            {
                new AutoMapperProfile(),
            };
            return profiles;
        }
    }
}