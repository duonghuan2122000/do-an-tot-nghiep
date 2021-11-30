using DBHuan.Shopping.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBHuan.Shopping.HttpApi.Controllers
{
    [Route("api/phones")]
    [ApiController]
    public class PhoneController : ControllerBase
    {
        /// <summary>
        /// Service điện thoại
        /// </summary>
        /// CreatedBy: dbhuan 30/11/2021
        private readonly IPhoneService _phoneService;

        /// <summary>
        /// Hàm khởi tạo
        /// </summary>
        /// CreatedBy: dbhuan 30/11//22021
        public PhoneController(IPhoneService phoneService)
        {
            _phoneService = phoneService;
        }

        /// <summary>
        /// Api lấy danh sách điện thoại có phân trang và lọc
        /// </summary>
        [HttpGet]
        public async Task<PagedResponseDto<PhoneItemDto>> GetListAsync([FromQuery] PagedRequestDto request)
        {
            var response = await _phoneService.GetListAsync(request);
            return response;
        }
    }
}
