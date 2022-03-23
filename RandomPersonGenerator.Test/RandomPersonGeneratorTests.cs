using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApp;
using SimpleApp.Generator;
using Xunit;
namespace SimpleApp.Tests

{
    
    public class RandomPersonGeneratorTests
    {
        [Fact]
        public void RandomName_MustreturnDifferentNames()
        {
            

            //Arrange
            int namelegth = 4;
            int seed1 =1;
            int seed2 =2;
            
            string expected = RandomPersonGenerator.RandomName(namelegth,seed2);
            

            //Act
            string actual = RandomPersonGenerator.RandomName(namelegth,seed1);
           
            
            //Assert
            Assert.NotEqual(expected, actual);
       

        }
        [Theory]
        [InlineData(60,true)]
        [InlineData(30,false)]
        [InlineData(0,false)]
        public void IsHealthy_HealthIsLessThan40_FalseExpected(int health,bool expected)
        {
            RandomPersonGenerator person = new RandomPersonGenerator(1);

            //Arrange
          


            //Act
            bool actual = person.IsHealthy(health, out string message);


            //Assert
            Assert.Equal(expected, actual);
            //Assert.NotEqual(expectedIfHealthy, actualIfHealthy);
        }
    }
}
