using System.Text.RegularExpressions;
using AidDev.FunkyId;

namespace Tests;

public class FunkyIdGeneratorTests
{
    [Fact]
    public void Generate_DefaultLength_UsesExpectedFormat()
    {
        var result = FunkyIdGenerator.Generate();

        var match = Regex.Match(result, @"^[a-z]+_[a-z]+_[a-z0-9]{4}$");

        Assert.True(match.Success, $"Result '{result}' does not match the expected format adjective_noun_tag.");
    }

    [Theory]
    [InlineData(1)]
    [InlineData(6)]
    [InlineData(10)]
    public void Generate_CustomLength_UsesThatLength(int length)
    {
        var parts = FunkyIdGenerator.Generate(length).Split('_');

        Assert.Equal(3, parts.Length);
        Assert.Equal(length, parts[2].Length);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void Generate_NonPositiveLength_ThrowsArgumentOutOfRange(int invalidLength)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => FunkyIdGenerator.Generate(invalidLength));
    }

    [Fact]
    public void Generate_TagUsesAllowedCharacters()
    {
        const string allowed = "abcdefghijklmnopqrstuvwxyz0123456789";

        for (var i = 0; i < 5; i++)
        {
            var tag = FunkyIdGenerator.Generate();
            var tagSegment = tag.Split('_')[2];

            Assert.All(tagSegment, c => Assert.Contains(c, allowed));
        }
    }
}
