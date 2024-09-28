using OnlineMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreatCompany;

namespace OnlineMuhasebeServer.Application.Services.AppServices
{
    public interface ICompanyService
    {
        Task CreateCompany(CreatCompanyRequest creatCompanyRequest);
    }
}
