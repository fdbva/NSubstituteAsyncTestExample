using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace NSubstituteReturnsAsyncExample
{
    [TestClass]
    public partial class NSubstituteAsyncTests
    {
        [TestMethod]
        public async Task NSubstitute_AsyncReturns()
        {
            //Arrange
            var mockClassSubstitute = Substitute.For<MockClass>();
            var methodReturn = new List<int> { 1 };
            mockClassSubstitute.MockMethodAsync().Returns(methodReturn);

            //Act
            var result = await mockClassSubstitute.MockMethodAsync();

            //Assert
            Assert.AreEqual(1, result.Take(1).FirstOrDefault());
        }

        [TestMethod]
        public async Task NSubstitute_AsyncReturnsTask()
        {
            //Arrange
            var mockClassSubstitute = Substitute.For<MockClass>();
            var methodReturn = new List<int> { 1 };
            var taskReturn = Task.FromResult(methodReturn.AsEnumerable());
            mockClassSubstitute.MockMethodAsync().Returns(taskReturn);

            //Act
            var result = await mockClassSubstitute.MockMethodAsync();

            //Assert
            Assert.AreEqual(1, result.Take(1).FirstOrDefault());
        }

        [TestMethod]
        public async Task NSubstitute_AsyncReturnsLambda()
        {
            //Arrange
            var mockClassSubstitute = Substitute.For<MockClass>();
            var methodReturn = new List<int> { 1 };
            mockClassSubstitute.MockMethodAsync().Returns(x => methodReturn);

            //Act
            var result = await mockClassSubstitute.MockMethodAsync();

            //Assert
            Assert.AreEqual(1, result.Take(1).FirstOrDefault());
        }

        [TestMethod]
        public async Task NSubstitute_AsyncReturnsTaskLambda()
        {
            //Arrange
            var mockClassSubstitute = Substitute.For<MockClass>();
            var methodReturn = new List<int> { 1 };
            var taskReturn = Task.FromResult(methodReturn.AsEnumerable());
            mockClassSubstitute.MockMethodAsync().Returns(x => taskReturn);

            //Act
            var result = await mockClassSubstitute.MockMethodAsync();

            //Assert
            Assert.AreEqual(1, result.Take(1).FirstOrDefault());
        }

        [TestMethod]
        public async Task NSubstitute_AsyncReturnsAsyncTaskLambda()
        {
            //Arrange
            var mockClassSubstitute = Substitute.For<MockClass>();
            var methodReturn = new List<int> { 1 };
            var taskReturn = Task.FromResult(methodReturn.AsEnumerable());
            mockClassSubstitute.MockMethodAsync().Returns(async x => await taskReturn);

            //Act
            var result = await mockClassSubstitute.MockMethodAsync();

            //Assert
            Assert.AreEqual(1, result.Take(1).FirstOrDefault());
        }
    }
}