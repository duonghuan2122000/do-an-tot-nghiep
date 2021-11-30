using DBHuan.Shopping.Core.Dtos;
using DBHuan.Shopping.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBHuan.Shopping.Infrastructure.Repositories
{
    /// <summary>
    /// Base repository
    /// </summary>
    /// CreatedBy: dbhuan 30/11/2021
    public class BaseRepository<TEntity>: IBaseRepository<TEntity> where TEntity: class
    {
        public BaseRepository()
        {

        }

        /// <summary>
        /// Lấy danh sách bản ghi có phân trang và lọc
        /// </summary>
        /// CreatedBy: dbhuan 30/11/2021
        public async Task<PagedResponseDto<TEntity>> GetListAsync(PagedRequestDto request)
        {
            // tạo response
            var response = new PagedResponseDto<TEntity>();



            return response;
        }

        /// <summary>
        /// Lấy bản ghi đầu tiên có id thỏa mã. Nếu không tồn tại bản ghi nào thỏa mãn thì sẽ trả về null
        /// </summary>
        /// CreatedBy: dbhuan 30/11/2021
        public async Task<TEntity> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Thêm mới bản ghi
        /// </summary>
        /// CreatedBy: dbhuan 30/11/2021
        public async Task<bool> InsertAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cập nhật bản ghi
        /// </summary>
        /// CreatedBy: dbhuan 30/11/2021
        public async Task<bool> UpdateAsync(Guid id, TEntity entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Xóa bản ghi
        /// </summary>
        /// CreatedBy: dbhuan 30/11/2021
        public async Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
