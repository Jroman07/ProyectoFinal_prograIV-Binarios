using Proyecto_Final_PrograIV.Entities;

namespace Proyecto_Final_PrograIV.Services.CompanyService
{
    public interface ICompanyService
    {
       public List<Company> GetAllCompany();
       public Company GetCompanyById(int id);

        public List<Company> GetCompanyByName(string name);

        public Company AddCompany(Company company);

        public Company UpdateCompany(int id, Company company);

        public void DeleteCompanyById(int id);
    }
}
