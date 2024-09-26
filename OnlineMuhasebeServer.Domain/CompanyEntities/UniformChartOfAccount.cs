using OnlineMuhasebeServer.Domain.Abstraction;

namespace OnlineMuhasebeServer.Domain.CompanyEntities
{
    public class UniformChartOfAccount : Entity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public char Type { get; set; }
        public string CompanyId { get; set; }
    }
}
