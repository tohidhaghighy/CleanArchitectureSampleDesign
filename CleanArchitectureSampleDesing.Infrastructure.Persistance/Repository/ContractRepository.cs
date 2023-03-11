//using System.Collections.Generic;
//using System.Linq;
//using Framework.Persistance;
//using LTMS.Core.SearchContext;
//using LTMS.Domain.IRepositroy;
//using LTMS.Domain.Model;
//using Microsoft.EntityFrameworkCore;

//namespace LTMS.Infrastructure.Persistance.Repository
//{
//    public class ContractRepository : EFRepositoryBase<LtmsDbContext, Contract, long>, IContractRepository
//    {
//        public ContractRepository(LtmsDbContext context) : base(context)
//        {

//        }

//        public IEnumerable<Contract> SearchContract(SearchContractCntx cntx)
//        {
//            return _dbContext.Set<Contract>()
//                   .Include(a=>a.AuditType)
//                   .Include(a=>a.Customer)
//                   .Where(a=>
//                                (a.Id == cntx.ContractId || cntx.ContractId == null)
//                             && (a.AuditTypeId == cntx.AuditTypeId || cntx.AuditTypeId == null)
//                             &&(a.CustomerId == cntx.CustomerId || cntx.CustomerId == null)
//                             &&(a.AgreementTypeId == cntx.AgreementTypeId || cntx.AgreementTypeId == null)
//                             &&(a.ContractType == cntx.ContractType || cntx.ContractType ==null)
//                             &&(a.StartDate >= cntx.StartDate || cntx.StartDate == null)
//                             &&(a.EndDate <= cntx.EndDate || cntx.EndDate == null))
//                   .Take(cntx.Take).Skip(cntx.Skip)
//                   .ToList();
//        }
//    }
//}
