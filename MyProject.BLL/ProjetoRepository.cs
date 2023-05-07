using Microsoft.EntityFrameworkCore;
using Myproject.DAL.DBContext;
using Myprojec.MODEL;

namespace MyProject.BLL
{
    public class ProjetoRepository
    {
        public static void Add(Projeto projeto)
        {
            using(var dbContext= new CUsersCcasmSourceReposAtvlp3tabela2MyprojectDalDatabaseDatabase1MdfContext())
            {
                dbContext.Add(projeto);
                dbContext.SaveChanges();
            }
        }


        public static List<Projeto> getAll()
        {
            using(var dbContext = new CUsersCcasmSourceReposAtvlp3tabela2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var projeto = dbContext.Projetos.ToList();
            return projeto;
            }
        }


        public static void Update(Projeto _protect)
        {
            using (var dbContext = new CUsersCcasmSourceReposAtvlp3tabela2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var projetor = dbContext.Projetos.Single(p => (p.NomedoGerentedoProjeto == _protect.NomedoGerentedoProjeto) && (p.NomedoProjeto == _protect.NomedoProjeto));
                projetor.IdStatus = _protect.IdStatus;
                dbContext.SaveChanges();
            }
        }



    }
}
