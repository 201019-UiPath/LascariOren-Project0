using System;
using Xunit;
using UI;
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
        
        [Fact]
        public void PassingAddTest()
        {
            Assert.Equal(4, Program.Add(2,2));
        }
       
        [Fact]
        public void FailingTest()
        {
            Assert.NotEqual(5, Program.Add(2,2));
        }
    }
}
