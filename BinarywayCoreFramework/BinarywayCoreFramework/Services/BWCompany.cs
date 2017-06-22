using BinarywayCoreFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarywayCoreFramework.Services
{
    public class BWCompany
    {
        CompanyRepository companyRepo = new CompanyRepository();
        public string GetCompanyName() {
           return companyRepo.GetName();
        }
    }
}
