using Acme.Business.Dtos.Investor;
using Acme.Business.Manager;
using Acme.Data.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Acme.Api.Controllers
{
    [Route("api/investor")]
    [ApiController]
    public class InvestorController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IInvestorManager _investorManager;

        public InvestorController(IMapper mapper, IInvestorManager investorManager)
        {
            _mapper = mapper;
            _investorManager = investorManager;
        }

        [HttpPost("get")]
        public IActionResult Get()
        {
            return Ok("Hello");
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody]InvestorDtoForCreate investorDetailsDto)
        {
            try
            {
                if (investorDetailsDto != null && ModelState.IsValid)
                {
                    // Convert investor dto to DB model
                    var investorModel = _mapper.Map<InvestorDetails>(investorDetailsDto);

                    // Call Business method to add Investor
                    _investorManager.AddInvestor(investorModel);

                    return Ok(true);
                }
                else
                {
                    return BadRequest("Investor details are not valid.");
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
    public class Dto
    {
        public string Name { get; set; }
    }
}