using Microsoft.EntityFrameworkCore;
using Myproject.DAL.DBContext;
using Myprojec.MODEL;

namespace MyProject.BLL
{
    public class StatusRepository
    {
        public static void Add(Status status)
        {
            using (var dbContext = new CUsersCcasmSourceReposAtvlp3tabela2MyprojectDalDatabaseDatabase1MdfContext())
            {
                dbContext.Add(status);
                dbContext.SaveChanges();
            }
        }
    }
}
