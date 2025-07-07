using Xunit.Abstractions;

namespace CalculatorApp.Tests
{
    public class UnitTestShared
    {
        public int Count { get; set; }
        public UnitTestShared()
        {
            Console.WriteLine("1回だけ");
        }
    }
    public class CalculatorTest : IClassFixture<UnitTestShared>
    {
        UnitTestShared shared;

        public CalculatorTest(UnitTestShared shared)
        {
            //this.output = output;
            this.shared = shared;
        }

        [Fact]
         public void AddTest()
        {
            //基の配列
            List<int> nums = new List<int>() { 8, 2, 9, 1, 7, 4, 5, 3 };
            //フィルタ処理を行う
            List<int> ret  = nums.FindAll(num => num % 2 == 0);
            List<string> emails = new List<string>() {"dd@yoshida-g.ac.jp", "abc@gmail.com" };
            List<string> ret2 = emails.FindAll(email => email.EndsWith("gmail.com"));

            //           this.output.WriteLine(shared.Count.ToString());
            shared.Count++;
            // Arrange（準備）
            var calculator = new Calculator();

            // Act（実行）
            var actual = calculator.Add(1, 2);
            //await Task.Delay(3000);

            // Assert（確認）
            Assert.Equal(3, actual);
        }

        [Fact]
        public void AddTest2()
        {
 //           this.output.WriteLine(shared.Count.ToString());
            shared.Count++;
            // Arrange（準備）
            var calculator = new Calculator();

            // Act（実行）
            var actual = calculator.Add(2, 2);

            // Assert（確認）
            Assert.Equal(4, actual);

        }
}
}