using MediatR;
using OnlineMuhasebeServer.Application.Services.AppServices;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreatCompany
{
    public class CreatCompanyHandler : IRequestHandler<CreatCompanyRequest, CreatCompanyResponse>

    {
        private readonly ICompanyService _companyService;

        public CreatCompanyHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<CreatCompanyResponse> Handle(CreatCompanyRequest request, CancellationToken cancellationToken)
        {
            await _companyService.CreateCompany(request);
            return new();
        }
    }
}
