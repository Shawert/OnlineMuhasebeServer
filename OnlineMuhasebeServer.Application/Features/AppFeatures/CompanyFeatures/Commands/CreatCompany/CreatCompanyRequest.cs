using MediatR;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreatCompany
{
    public class CreatCompanyRequest : IRequest<CreatCompanyResponse>
    {
        public string Name { get; set; }
        public string ServerName { get; set; }
        public string DomainName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}
