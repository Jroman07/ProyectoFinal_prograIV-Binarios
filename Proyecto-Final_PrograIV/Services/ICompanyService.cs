using Proyecto_Final_PrograIV.Entities;

namespace Proyecto_Final_PrograIV.Services
{
    public interface ICompanyService
    {
        public List<Company> GetAllCompany();
        public Company GettCompanyById(int id);
        public List<Company> GetCompanyByName(string companyName);

        public Company AddCompany(Company company);
        public Company UpdateCompany(int id, Company company);
        public void DeleteCompanyById(int id);

    }
}
