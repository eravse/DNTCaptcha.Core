using DNTCaptcha.Core.Providers;

namespace DNTCaptcha.Core.Contracts
{
    /// <summary>
    /// SumOfTwoNumbers Provider
    /// </summary>
    public interface ISumOfTwoNumbersProvider
    {
        /// <summary>
        /// display a numeric value using the equivalent text
        /// </summary>
        /// <param name="number">input number</param>
        /// <param name="language">local language</param>
        /// <returns>the equivalent text</returns>
        string GetText(long number, Language language);
    }
}