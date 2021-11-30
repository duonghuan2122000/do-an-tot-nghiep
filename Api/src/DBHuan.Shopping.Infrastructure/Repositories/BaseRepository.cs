using Dapper;
using DBHuan.Shopping.Core.Constant;
using DBHuan.Shopping.Core.Dtos;
using DBHuan.Shopping.Core.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DBHuan.Shopping.Infrastructure.Repositories
{
    /// <summary>
    /// Base repository
    /// </summary>
    /// CreatedBy: dbhuan 30/11/2021
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// config appsettings
        /// </summary>
        /// CreatedBy: dbhuan 30/11/2021
        private readonly IConfiguration _configuration;

        /// <summary>
        /// chuỗi kết nối db
        /// </summary>
        /// CreatedBy: dbhuan 30/11/2021
        private readonly string _connectionString;

        private readonly string _tableName = typeof(TEntity).Name;

        public BaseRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString(DbContextConstant.DbContextString);
        }

        /// <summary>
        /// Lấy danh sách bản ghi có phân trang và lọc
        /// </summary>
        /// CreatedBy: dbhuan 30/11/2021
        public async Task<PagedResponseDto<TEntity>> GetListAsync(PagedRequestDto request)
        {
            // tạo response
            var response = new PagedResponseDto<TEntity>();

            // tạo kết nối db
            using (var connection = new MySqlConnection(_connectionString))
            {
                // tính tổng bản ghi
                response.TotalRecord = await connection.QuerySingleOrDefaultAsync<int>($"SELECT COUNT(*) AS Total FROM {_tableName}");

                // nếu tổng số bản ghi = 0 thì return
                if (response.TotalRecord == 0)
                    return response;

                // tính tổng số trang
                response.TotalPages = (int)Math.Ceiling((decimal)response.TotalRecord / request.PageSize);

                // tính vị trí bắt đầu lấy bản ghi
                int start = (request.Page - 1) * request.PageSize;

                var list = await connection.QueryAsync<TEntity>($"SELECT * FROM {_tableName} LIMIT @start, @limit", new { start, limit = request.PageSize });

                response.Items = list.ToList();
            }

            return response;
        }

        /// <summary>
        /// Lấy bản ghi đầu tiên có id thỏa mã. Nếu không tồn tại bản ghi nào thỏa mãn thì sẽ trả về null
        /// </summary>
        /// CreatedBy: dbhuan 30/11/2021
        public async Task<TEntity> GetAsync(Guid id)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                var entity = await connection.QueryFirstOrDefaultAsync<TEntity>($"SELECT * FROM {_tableName} WHERE Id = @id", new { id });
                return entity;
            }
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
