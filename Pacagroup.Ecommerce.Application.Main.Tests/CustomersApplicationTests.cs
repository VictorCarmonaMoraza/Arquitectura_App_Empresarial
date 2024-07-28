using Xunit;
using Moq;
using Pacagroup.Ecommerce.Domain.Interface;
using AutoMapper;
using Pacagroup.Ecommerce.Domain.Entity;
using Assert = Xunit.Assert;

namespace Pacagroup.Ecommerce.Application.Main.Tests
{
    public class CustomersApplicationTests
    {

        private readonly Mock<ICustomersDomain> _mockCustomersDomain;
        private readonly Mock<IMapper> _mockMapper;

        public CustomersApplicationTests()
        {
            _mockCustomersDomain = new Mock<ICustomersDomain>();
            _mockMapper = new Mock<IMapper>();
        }

        [Fact]
        public void InsertAsync()
        {


        }
    }
}