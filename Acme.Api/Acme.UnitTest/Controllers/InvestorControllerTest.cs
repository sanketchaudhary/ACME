using Acme.Api.Controllers;
using Acme.Business.Manager;
using AutoMapper;
using Moq;

namespace Acme.UnitTest.Controllers
{
    public class InvestorControllerTest
    {
        #region Private variables
        private readonly Mock<IMapper> mockMapper;
        private readonly Mock<IInvestorManager> mockInvestorManager;
        private readonly InvestorController investorController;
        #endregion

        public InvestorControllerTest()
        {
            mockMapper = new Mock<IMapper>();
            mockInvestorManager = new Mock<IInvestorManager>();

            investorController = new InvestorController(mockMapper.Object, mockInvestorManager.Object);
        }
    }
}
