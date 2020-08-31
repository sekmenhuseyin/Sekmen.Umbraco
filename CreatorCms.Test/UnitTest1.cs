using CreatorCms.Core.Services;
using CreatorCms.Core.Services.Models;
using Shouldly;
using System.Collections.Generic;
using Xunit;

namespace CreatorCms.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            List<CountryResponse> response = new CountriesService().GetAllCountries().Result;
            response.ShouldNotBeNull();
            response.Count.ShouldBeGreaterThan(1);
        }
    }
}
