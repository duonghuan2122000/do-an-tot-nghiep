using System;

namespace DBHuan.Shopping.Core
{
    /// <summary>
    /// 
    /// </summary>
    public class PhoneDto
    {
        /// <summary>
        /// id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Tên
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Ảnh
        /// </summary>
        public string Images { get; set; }

        /// <summary>
        /// Ảnh thumbnail
        /// </summary>
        public string Thumbnail { get; set; }

        /// <summary>
        /// Thông số cấu hình
        /// </summary>
        public string Specifications { get; set; }

        /// <summary>
        /// Mô tả
        /// </summary>
        public string Description { get; set; }

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
