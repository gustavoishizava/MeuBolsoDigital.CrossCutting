namespace MeuBolsoDigital.CrossCutting.Extensions
{
    public static class IEnumerableExtension
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable) =>
            enumerable is null || !enumerable.Any();
    }
}