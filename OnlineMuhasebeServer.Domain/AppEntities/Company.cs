﻿using OnlineMuhasebeServer.Domain.Abstraction;

namespace OnlineMuhasebeServer.Domain.AppEntities
{
	public sealed class Company : Entity
	{
        public string Name { get; set; }
        
        public string Adress { get; set; }

        public string IdentityNumber { get; set; }

        public string TaxDepartment { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public string ServerName { get; set; }
        public string DataBaseName { get; set; }
        public string UserId { get; set; }
        public string Passworld { get; set; }

    }
}
