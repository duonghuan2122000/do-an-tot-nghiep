using System.Collections.Generic;

namespace DBHuan.Shopping.Core
{
    /// <summary>
    /// Class chứa các trường trả về của đầu api lấy danh sách có phân trang và lọc
    /// </summary>
    /// CreatedBy: dbhuan 30/11/2021
    public class PagedResponseDto<TEntity> where TEntity : class
    {
        public PagedResponseDto()
        {
            TotalPages = 0;
            TotalRecord = 0;
            Items = new List<TEntity>();
        }

        /// <summary>
        /// Tổng số bản ghi
        /// </summary>
        public int TotalRecord { get; set; }

        /// <summary>
        /// Tổng số trang
        /// </summary>
        public int TotalPages { get; set; }

        /// <summary>
        /// Danh sách bản ghi trên một trang
        /// </summary>
        public List<TEntity> Items { get; set; }
    }
}
