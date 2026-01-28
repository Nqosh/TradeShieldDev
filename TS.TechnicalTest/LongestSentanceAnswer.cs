
namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return 0;

        char[] delimiters = { '.', '?', '!' };
        string[] sentences = s.Split(delimiters, StringSplitOptions.None);

        int maxWordCount = 0;

        foreach (var sentence in sentences)
        {
            var words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int wordCount = words
                .Count(word => word.Any(char.IsLetter));

            if (wordCount > maxWordCount)
                maxWordCount = wordCount;
        }

        return maxWordCount;
    }
}
