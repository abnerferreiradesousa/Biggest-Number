using Xunit;
using FluentAssertions;
using System;

namespace BiggestNumber.Test;

public class TestBiggestNumber
{
    [Theory]
    [InlineData(0, 0, 0, 0)]
    [InlineData(1, 2, 3, 3)]
    [InlineData(-1, -2, -3, -1)]
    public void TestIdentifyBiggestNumberSucess(int first, int second, int third, int expectedNumber)
    {
        int result = BiggestNumber.IdentifyBiggestNumber(first, second, third);
        result.Should().Be(expectedNumber);
    }
}