using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using StringManipulationApp;

namespace StringManipulationApp.Test.StringManipulationTest {
    public class StringManipulationAppTest {

        [Fact]
        public void Program_ManipulateStrings_ShouldReturn_ListofStrings() {
            // Arrange

            List<string> inputList = new List<string> {
                "13173697-n",
                "11613219-a",
                "12505253-v"
            };

            List<string> expectedOutput = new List<string> {
                "n13173697",
                "a11613219",
                "v12505253"
            };


            // Act
            List<string> result = Program.ManipulateStrings(inputList);

            // Assert
            result.Should().BeOfType<List<string>>();
            result.Should().BeEquivalentTo(expectedOutput);

        }// end ManipulateStrings test
    }
}
