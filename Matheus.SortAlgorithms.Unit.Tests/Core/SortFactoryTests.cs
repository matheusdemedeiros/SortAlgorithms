using Matheus.SortAlgorithms.Abstractions;
using Matheus.SortAlgorithms.Core;
using System.Collections.Concurrent;

namespace Matheus.SortAlgorithms.Unit.Tests.Core
{
    public class SortFactoryTests
    {
        [Fact]
        public void Create_ShouldReturnCorrectAlgorithmInstance()
        {
            // Arrange
            var algorithms = Enum.GetValues(typeof(SortAlgorithms.Core.SortAlgorithms)).Cast<SortAlgorithms.Core.SortAlgorithms>();

            // Act & Asserts
            foreach (var algorithm in algorithms)
            {
                var instance = SortFactory.Create(algorithm);
                Assert.NotNull(instance);
                Assert.IsAssignableFrom<ISortAlgorithm>(instance);
                Assert.Equal(algorithm.ToString(), instance.GetType().Name);
            }
        }

        [Fact]
        public void Create_ShouldThrowArgumentException_ForInvalidAlgorithm()
        {
            // Arrange
            var invalidAlgorithm = (SortAlgorithms.Core.SortAlgorithms)999;

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => SortFactory.Create(invalidAlgorithm));
            Assert.Equal("Invalid algorithm type", exception.Message);
        }

        [Fact]
        public void Create_ShouldReturnDifferentInstances_ForMultipleCalls()
        {
            // Arrange
            var algorithm = SortAlgorithms.Core.SortAlgorithms.QuickSort;

            // Act
            var instance1 = SortFactory.Create(algorithm);
            var instance2 = SortFactory.Create(algorithm);

            // Assert
            Assert.NotSame(instance1, instance2);
        }

        [Fact]
        public void Create_ShouldHandleAllDefinedAlgorithms()
        {
            // Arrange
            var definedAlgorithms = Enum.GetValues(typeof(SortAlgorithms.Core.SortAlgorithms)).Cast<SortAlgorithms.Core.SortAlgorithms>().ToList();
            var createdAlgorithms = new List<SortAlgorithms.Core.SortAlgorithms>();
            // Act
            foreach (var algorithm in definedAlgorithms)
            {
                var instance = SortFactory.Create(algorithm);
                createdAlgorithms.Add(algorithm);
            }
            // Assert
            Assert.Equal(definedAlgorithms.Count, createdAlgorithms.Count);
            Assert.All(definedAlgorithms, alg => Assert.Contains(alg, createdAlgorithms));
        }
    }
}
