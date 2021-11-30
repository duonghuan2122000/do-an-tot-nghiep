using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DBHuan.Shopping.Core
{
    /// <summary>
    /// Service điện thoại
    /// </summary>
    /// CreatedBy: dbhuan 30/11/2021
    public class PhoneService: IPhoneService
    {
        /// <summary>
        /// Repo điện thoại
        /// </summary>
        private readonly IPhoneRepository _phoneRepository;

        private readonly IMapper _mapper;

        public PhoneService(IPhoneRepository phoneRepository, IMapper mapper)
        {
            _phoneRepository = phoneRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Lấy danh sách điện thoại
        /// </summary>
        /// CreatedBy: dbhuan 30/11/2021
        public async Task<PagedResponseDto<PhoneItemDto>> GetListAsync(PagedRequestDto request)
        {
            var resRepo = await _phoneRepository.GetListAsync(request);

            var response = new PagedResponseDto<PhoneItemDto> 
            {
                TotalRecord = resRepo.TotalRecord,
                TotalPages = resRepo.TotalPages,
                Items = _mapper.Map<List<PhoneItemDto>>(resRepo.Items)
            };

            return response;
        }
    }
}
