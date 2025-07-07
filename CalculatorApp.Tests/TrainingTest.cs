using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace CalculatorApp.Tests
{
    public class TestData
    {
        public static bool testBool = true;
    }
    public class TrainingTest
    {
        private readonly ITestOutputHelper testOutputHelper;
        private TestData testData;

        public TrainingTest(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }
        [Fact]
        [Trait("カテゴリ", "プレイヤー")]
        public void TestA()
        {
            testOutputHelper.WriteLine("ログ出力テスト");
            Assert.Equal(0, 0);
            Assert.True(TestData.testBool);
        }

        [Fact]
        [Trait("カテゴリ", "プレイヤー")]
        public void TestB()
        {
            Assert.Equal(0, 0);
        }

        [Fact]
        [Trait("カテゴリ", "エネミー")]
        public void TestC()
        {
            Assert.Equal(0, 1);
        }

        [Fact]
        public void IsEvenTest()
        {
            // Arrange（準備）
            var training = new Training();

            // Act（実行）
            var isEven = training.IsEven(2);

            // Assert（確認）
            Assert.True(isEven);
        }

        [Theory]
        [InlineData(0, "0円")]
        [InlineData(100, "110円")]
        [InlineData(2000, "2200円")]
        public void TestX(int price, string result)
        {
            // Arrange（準備）
            var training = new Training();

            // Act（実行）
            var taxResult = training.GetTaxPrice(price);

            // Assert（確認）
            Assert.Equal(result, taxResult);
        }
    }
}
