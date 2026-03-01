using Obsitrail.Result;
using System;
using System.Collections.Generic;
using System.Text;

namespace Obsitrail.Result.Tests
{
    public class ResultTests
    {
        [Fact]
        public void Success_ShouldContainValue()
        {
            var result = Result<int>.Success(10);

            Assert.True(result.IsSuccess);
            Assert.Equal(10, result.Value);
        }

        [Fact]
        public void Failure_ShouldContainError()
        {
            var result = Result<int>.Failure("error");

            Assert.False(result.IsSuccess);
            Assert.Equal("error", result.Error.Message);
        }


        [Fact]
        public void Success_ShouldHaveNullError()
        {
            var result = Result<int>.Success(5);
            Assert.Null(result.Error);
        }

        [Fact]
        public void Failure_ShouldHaveDefaultValue()
        {
            var result = Result<int>.Failure("fail");
            Assert.Equal(default(int), result.Value);
        }

    }
}
