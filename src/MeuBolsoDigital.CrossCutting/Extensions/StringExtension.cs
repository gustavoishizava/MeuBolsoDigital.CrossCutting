namespace MeuBolsoDigital.CrossCutting.Extensions
{
    public static class StringExtension
    {
        public static string[] ConvertToArray(this string text) =>
            text.Split(Environment.NewLine);
    }
}