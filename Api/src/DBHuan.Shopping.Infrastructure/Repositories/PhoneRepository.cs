using Dapper;
using DBHuan.Shopping.Core;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DBHuan.Shopping.Infrastructure
{
    /// <summary>
    /// repository điện thoại
    /// </summary>
    /// CreatedBy: dbhuan 30/11/2021
    public class PhoneRepository : DbContext, IPhoneRepository
    {
        private readonly string _tableName = "phoneItem";

        /// <summary>
        /// Hàm khởi tạo
        /// </summary>
        public PhoneRepository(IConfiguration configuration) : base(configuration)
        {

        }

        /// <summary>
        /// Lấy danh sách điện thoại
        /// </summary>
        /// CreatedBy: dbhuan 30/11/2021
        public async Task<PagedResponseDto<PhoneItem>> GetListAsync(PagedRequestDto request)
        {
            // tạo response
            var response = new PagedResponseDto<PhoneItem>();

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

                var list = await connection.QueryAsync<PhoneItem>($"SELECT * FROM {_tableName} LIMIT @start, @limit", new { start, limit = request.PageSize });

                response.Items = list.ToList();
            }

            return response;
        }
    }
}
