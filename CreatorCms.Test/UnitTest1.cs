using CreatorCms.Core.Services;
using Shouldly;
using Xunit;

namespace CreatorCms.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            var response = new CountriesService().GetAllCountries().Result;
            response.ShouldNotBeNull();
        }
    }
}
