using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBHuan.Shopping.Core.Dtos
{
    /// <summary>
    /// Class chứa các trường request của đầu api lấy danh sách có phân trang và filter
    /// </summary>
    /// CreatedBy: dbhuan 30/11/2021
    public class PagedRequestDto
    {
        /// <summary>
        /// Điều kiện lọc
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        /// Trang hiện tại
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Số bản ghi trên một trang
        /// </summary>
        public int PageSize { get; set; }
    }
}
