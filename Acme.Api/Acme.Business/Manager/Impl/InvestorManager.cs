using Acme.Data.Models;
using Acme.Data.Repository;
using System;

namespace Acme.Business.Manager.Impl
{
    public class InvestorManager : IInvestorManager
    {
        private readonly IInvestorRepository _investorRepository;

        // Constructor
        public InvestorManager(IInvestorRepository investorRepository)
        {
            _investorRepository = investorRepository;
        }

        /// <summary>
        /// Business method to add new Investor
        /// </summary>
        /// <param name="investorDetails">Investor details</param>
        public void AddInvestor(InvestorDetails investorDetails)
        {
            try
            {
                this._investorRepository.AddInvestor(investorDetails);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
