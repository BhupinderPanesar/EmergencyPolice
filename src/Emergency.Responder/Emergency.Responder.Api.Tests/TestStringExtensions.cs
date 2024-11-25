namespace Emergency.Responder.Api.Tests;
using Extensions;
using Xunit;
using FluentAssertions;

public class TestStringExtensions
{

    [Fact]
    public void WhenGivenOver12Characters_MethodHasOverTwelveCharacters_ShouldBeTrue()
    {
        "Testings".HasOverTwelveCharacters().Should().BeTrue();
    }
}