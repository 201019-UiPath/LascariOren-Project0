using System;
using Xunit;
using Lib;
namespace Tests
{
    public class BasicTests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }
        [Fact]
        public void Test2()
        {
            var product = new Product("NA","Pillow",100);
            //test if product is 0 for price
            Assert.Throws<InvalidOperationException>(

                ()=>product.price(0,"No Price")
            );

          
        }
        [Fact]
        public void chooseAction()
        {
            // choose action should not be null
            Assert.NotNull(choice);
        }
        [Fact]
        public void Test4()
        {
            Assert.True(true);
        }
        [Fact]
        public void Test5()
        {
            Assert.True(true);
        }
        [Fact]
        public void Test6()
        {
            Assert.True(true);
        }
        [Fact]
        public void Test7()
        {
            Assert.True(true);
        }
        [Fact]
        public void Test8()
        {
            Assert.True(true);
        }
        [Fact]
        public void Test9()
        {
            Assert.True(true);
        }
        [Fact]
        public void Test10()
        {
            Assert.True(true);
        }
    }
}
