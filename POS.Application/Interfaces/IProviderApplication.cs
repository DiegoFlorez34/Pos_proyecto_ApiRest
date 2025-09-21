using POS.Application.Commons.Base.Request;
using POS.Application.Commons.Base.Response;
using POS.Application.Dtos.Provider.Request;
using POS.Application.Dtos.Provider.Response;

namespace POS.Application.Interfaces
{
    public interface IProviderApplication
    {
        Task<BaseResponse<IEnumerable<ProviderResponseDto>>> ListProviders(BaseFiltersRequest filters);
        Task<BaseResponse<ProviderByIdResponseDto>> ProviderById(int providerId);
        Task<BaseResponse<bool>> RegisterProvider(ProviderRequestDto requestDto);
        Task<BaseResponse<bool>> EditProvider(int providerId, ProviderRequestDto requestDto);
        Task<BaseResponse<bool>> RemoveProvider(int providerId);


    }
}
