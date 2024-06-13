using OnlineMuhasebeServer.Domain.Abstraction;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMuhasebeServer.Domain.AppEntities.Identity
{
	public class UserAndCompanyRelationShip : Entity
	{
		[ForeignKey("AppUser")]
		public string AppUserId { get; set; }

		public AppUser appUser { get; set; }

		[ForeignKey("Company")]
		public string CompanyId { get; set; }
	
		public Company	company { get; set; }

	}
}
