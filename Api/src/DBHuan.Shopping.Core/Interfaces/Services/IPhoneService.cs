using System.Threading.Tasks;

namespace DBHuan.Shopping.Core
{
    /// <summary>
    /// Interface chứa các hàm xử lý logic điện thoại
    /// </summary>
    /// CreatedBy: dbhuan 30/11/2021
    public interface IPhoneService
    {
        /// <summary>
        /// Lấy danh sách điện thoại
        /// </summary>
        /// CreatedBy: dbhuan 30/11/2021
        Task<PagedResponseDto<PhoneItemDto>> GetListAsync(PagedRequestDto request);
    }
}
