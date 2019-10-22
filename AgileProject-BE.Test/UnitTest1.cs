using System;
using Xunit;
using AgileProject_BE.Controllers;

namespace AgileProject_BE.Test 
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();

        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("liqi", returnValue.ToString());
        }
    }
}
