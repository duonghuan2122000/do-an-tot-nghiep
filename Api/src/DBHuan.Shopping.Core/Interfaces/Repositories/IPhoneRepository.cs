using System.Threading.Tasks;

namespace DBHuan.Shopping.Core
{
    /// <summary>
    /// Interface chứa các hàm truy vấn đến entity phone và phoneItem
    /// </summary>
    /// CreatedBy: dbhuan 30/11/2021
    public interface IPhoneRepository
    {
        /// <summary>
        /// Lấy danh sách điện thoại
        /// </summary>
        /// CreatedBy: dbhuan 30/11/2021
        Task<PagedResponseDto<PhoneItem>> GetListAsync(PagedRequestDto request);
    }
}
