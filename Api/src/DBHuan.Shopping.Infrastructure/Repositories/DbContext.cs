using DBHuan.Shopping.Core;
using Microsoft.Extensions.Configuration;

namespace DBHuan.Shopping.Infrastructure
{
    /// <summary>
    /// Db context
    /// </summary>
    /// CreatedBy: dbhuan 30/11/2021
    public class DbContext
    {
        /// <summary>
        /// config appsettings
        /// </summary>
        /// CreatedBy: dbhuan 30/11/2021
        protected readonly IConfiguration _configuration;

        /// <summary>
        /// chuỗi kết nối db
        /// </summary>
        /// CreatedBy: dbhuan 30/11/2021
        protected readonly string _connectionString;

        public DbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString(DbContextConstant.DbContextString);
        }
    }
}
