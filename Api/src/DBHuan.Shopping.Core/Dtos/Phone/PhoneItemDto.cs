using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBHuan.Shopping.Core
{
    public class PhoneItemDto
    {
        /// <summary>
        /// id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// mã điện thoại
        /// </summary>
        public string BarCode { get; set; }

        /// <summary>
        /// giá bán
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// điện thoại
        /// </summary>
        public PhoneDto Phone { get; set; }

        /// <summary>
        /// Thời gian tạo
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Thời gian cập nhật
        /// </summary>
        public DateTime UpdatedDate { get; set; }
    }
}
