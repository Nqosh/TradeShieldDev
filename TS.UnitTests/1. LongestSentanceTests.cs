using TS.TechnicalTest;

namespace TS.UnitTests;

[TestClass]
public class LongestSentanceTests
{
    [TestMethod]
    public void Q1_BasicNominalTest()
    {
        var input = $"We test coders. Give us a try";
        var outcome = LongestSentanceAnswer.Solution(input);

        Assert.AreEqual(4, outcome);
    }

    [TestMethod]
    public void Should_Return_2_For_Forget_CVs_Text()
    {
        var result = LongestSentanceAnswer.Solution("Forget CVs..Save time . x x");
        Assert.AreEqual(2, result);
    }
}
