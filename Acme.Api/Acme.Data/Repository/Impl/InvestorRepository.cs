using Acme.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Acme.Data.Repository.Impl
{
    public class InvestorRepository : BaseRepository, IInvestorRepository
    {
        private readonly DbSet<InvestorDetails> investorEntity;
        
        /// <summary>
        /// Investor repository constructor
        /// </summary>
        /// <param name="context">Acme DB context</param>
        public InvestorRepository(AcmeContext context): base(context)
        {
            // Set Investor Entity
            investorEntity = context.Set<InvestorDetails>();
        }

        public void AddInvestor(InvestorDetails investorDetails)
        {
            this.investorEntity.Add(investorDetails);
            this._context.SaveChanges();
        }
    }
}
