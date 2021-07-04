using SafeInt;
using Xunit;

namespace SafeInte.Tests
{
    public class Tests
    {
        [Fact]
        public void MyClass_ToSafeInt_Should_Returns_IntegerValue()
        {
            // Arrange
            MyClass myClass = new MyClass();

            // Act
            var result = myClass.ToSafeInt("12");

            // Assert
            Assert.IsType<int>(result);
            Assert.Equal(12, result);
        }

        [Fact]
        public void MyClass_ToSafeInt_Should_Returns_DefaultValue()
        {
            // Arrange
            MyClass myClass = new MyClass();

            // Act
            var result = myClass.ToSafeInt("abc");

            // Assert
            Assert.IsType<int>(result);
            Assert.Equal(0, result);
        }

        [Fact]
        public void MyClass_ToSafeInt_Should_Returns_Set_DefaultValue()
        {
            // Arrange
            MyClass myClass = new MyClass();

            // Act
            var result = myClass.ToSafeInt("abc", 111);

            // Assert
            Assert.IsType<int>(result);
            Assert.Equal(111, result);
        }

        [Fact]
        public void MyClass_ToSafeInt_Extension_Should_Returns_IntegerValue()
        {
            // Arrange
            var value = "12";

            // Act
            var result = value.ToSafeInt();

            // Assert
            Assert.IsType<int>(result);
            Assert.Equal(12, result);
        }

        [Fact]
        public void MyClass_ToSafeInt_Extension_Should_Returns_DefaultValue()
        {
            // Arrange
            var value = "abc";

            // Act
            var result = value.ToSafeInt();

            // Assert
            Assert.IsType<int>(result);
            Assert.Equal(0, result);
        }
    }
}