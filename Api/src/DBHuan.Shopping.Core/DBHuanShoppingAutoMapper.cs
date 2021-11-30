using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBHuan.Shopping.Core
{
    /// <summary>
    /// auto mapper
    /// </summary>
    /// CreatedBy: dbhuan 30//11/2021
    public class DBHuanShoppingAutoMapper: Profile
    {
        public DBHuanShoppingAutoMapper()
        {
            CreateMap<Phone, PhoneDto>(MemberList.None);
            CreateMap<PhoneItem, PhoneItemDto>(MemberList.None);
        }
    }
}
