using Acme.Api.Controllers;
using Acme.Business.Dtos.Address;
using Acme.Business.Manager;
using Acme.Data.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Acme.UnitTest.Controllers
{
    public class AddressControllerTest
    {
            #region Private variables
            private readonly Mock<IMapper> mockMapper;
            private readonly Mock<IAddressManager> mockAddressManager;
            private readonly AddressController addressController;
            #endregion

            public AddressControllerTest()
            {
                mockMapper = new Mock<IMapper>();
                mockAddressManager = new Mock<IAddressManager>();

                addressController = new AddressController(mockMapper.Object, mockAddressManager.Object);
            }

            /// <summary>
            /// Test case for GetCountryList
            /// </summary>
            [Fact]
            public void GetCountryListSuccess()
            {
                // Arrange
                mockAddressManager.Setup(k => k.GetCountryList()).Returns((new List<Country>() { new Country() { CountryId = 1001, CountryName = "Aus" }}).AsEnumerable());
                mockMapper.Setup(m => m.Map<IEnumerable<CountryDto>>(It.IsAny<IEnumerable<Country>>())).Returns(new List<CountryDto>() { new CountryDto() { CountryId = 1001, CountryName = "Aus" } });

                // Act
                var result = Assert.IsType<OkObjectResult>(addressController.GetCountryList());

                // Assert
                Assert.Equal(200, result.StatusCode);
            }

            /// <summary>
            /// Test case for get Postcodes
            /// </summary>
            [Fact]
            public void GetPostcodesSuccess()
            {
                //// Arrange
                //mockAddressManager.Setup(k => k.GetPostcodes()).Returns((new List<Postcodes>() { new Postcodes() { Id = 1001, Pcode = "BY53XU" } }).AsEnumerable());
                //mockMapper.Setup(m => m.Map<IEnumerable<PostcodesDto>>(It.IsAny<IEnumerable<Postcodes>>())).Returns(new List<PostcodesDto>() { new PostcodesDto() { Id = 1001, Pcode = "BY53XU" } });

                //// Act
                //var result = Assert.IsType<OkObjectResult>(addressController.GetPostcodes());

                //// Assert
                //Assert.Equal(200, result.StatusCode);
            }
    }
}
