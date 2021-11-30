using System;

namespace DBHuan.Shopping.Core
{
    /// <summary>
    /// Entity phoneitem
    /// </summary>
    /// CreatedBy: dbhuan 30/11/2021
    public class PhoneItem
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
        public Phone Phone { get; set; }

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
