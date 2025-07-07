using Xunit.Abstractions;

namespace CalculatorApp.Tests
{
    public class UnitTestShared
    {
        public int Count { get; set; }
        public UnitTestShared()
        {
            Console.WriteLine("1�񂾂�");
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
            //��̔z��
            List<int> nums = new List<int>() { 8, 2, 9, 1, 7, 4, 5, 3 };
            //�t�B���^�������s��
            List<int> ret  = nums.FindAll(num => num % 2 == 0);
            List<string> emails = new List<string>() {"dd@yoshida-g.ac.jp", "abc@gmail.com" };
            List<string> ret2 = emails.FindAll(email => email.EndsWith("gmail.com"));

            //           this.output.WriteLine(shared.Count.ToString());
            shared.Count++;
            // Arrange�i�����j
            var calculator = new Calculator();

            // Act�i���s�j
            var actual = calculator.Add(1, 2);
            //await Task.Delay(3000);

            // Assert�i�m�F�j
            Assert.Equal(3, actual);
        }

        [Fact]
        public void AddTest2()
        {
 //           this.output.WriteLine(shared.Count.ToString());
            shared.Count++;
            // Arrange�i�����j
            var calculator = new Calculator();

            // Act�i���s�j
            var actual = calculator.Add(2, 2);

            // Assert�i�m�F�j
            Assert.Equal(4, actual);

        }
}
}