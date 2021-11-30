using DBHuan.Shopping.Core.Dtos;
using System;
using System.Threading.Tasks;

namespace DBHuan.Shopping.Core.Interfaces.Repositories
{
    /// <summary>
    /// Interface base repository. Chứa các hàm lấy thông tin truy vấn db
    /// </summary>
    /// CreatedBy: dbhuan 30/11/2021
    public interface IBaseRepository<TEntity> where TEntity: class 
    {
        /// <summary>
        /// Lấy danh sách bản ghi có phân trang và lọc
        /// </summary>
        /// CreatedBy: dbhuan 30/11/2021
        Task<PagedResponseDto<TEntity>> GetListAsync(PagedRequestDto request);

        /// <summary>
        /// Lấy bản ghi đầu tiên có id thỏa mã. Nếu không tồn tại bản ghi nào thỏa mãn thì sẽ trả về null
        /// </summary>
        /// CreatedBy: dbhuan 30/11/2021
        Task<TEntity> GetAsync(Guid id);

        /// <summary>
        /// Thêm mới bản ghi
        /// </summary>
        /// CreatedBy: dbhuan 30/11/2021
        Task<bool> InsertAsync(TEntity entity);

        /// <summary>
        /// Cập nhật bản ghi
        /// </summary>
        /// CreatedBy: dbhuan 30/11/2021
        Task<bool> UpdateAsync(Guid id, TEntity entity);

        /// <summary>
        /// Xóa bản ghi
        /// </summary>
        /// CreatedBy: dbhuan 30/11/2021
        Task<bool> DeleteAsync(Guid id);
    }
}
