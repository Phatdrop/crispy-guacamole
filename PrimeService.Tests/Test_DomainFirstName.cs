using Xunit;
using Prime.Services;
using System;
namespace Prime.UnitTests.Services;

public class FirstNameTests
{
    [Theory]
    [InlineData(1)]              // Lower boundary: minimum length (assuming 1)
    [InlineData(25)]             // Nominal case: a length well within the range
    [InlineData(50)]             // Upper boundary: maximum length (assuming 50)
    public void ValidateName_WithValidLength_DoesNotThrowException(int length)
    {
        var validator = new FirstName();
        string validName = new string('A', length);

        validator.ValidateName(validName);
    }

    [Theory]
    [InlineData(0)]              // Lower boundary minus 1: name is empty (or too short)
    [InlineData(51)]             // Upper boundary plus 1: name is too long
    public void ValidateName_WithInvalidLength_ThrowsArgumentException(int length)
    {
        var validator = new FirstName();
        string invalidName = new string('A', length);

        Assert.Throws<ArgumentException>(() => validator.ValidateName(invalidName));
    }

    [Fact]
    public void ValidateName_WithNullName_ThrowsArgumentNullException()
    {
        var validator = new FirstName();
        string nullName = null;

        Assert.Throws<ArgumentNullException>(() => validator.ValidateName(nullName));
    }
}