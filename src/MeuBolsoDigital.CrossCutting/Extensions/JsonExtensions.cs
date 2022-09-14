using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Text.Json;

namespace MeuBolsoDigital.CrossCutting.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class JsonExtensions
    {
        private static JsonSerializerOptions JsonSerializerOptionsDefault = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        private static JsonSerializerOptions JsonDeserializerOptionsDefault = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public static T Deserialize<T>(this ReadOnlyMemory<byte> bytes, JsonSerializerOptions jsonSerializerOptions = null)
            => JsonSerializer.Deserialize<T>(Encoding.UTF8.GetString(bytes.ToArray()), jsonSerializerOptions ?? JsonDeserializerOptionsDefault);

        public static T Deserialize<T>(this string content, JsonSerializerOptions jsonSerializerOptions = null)
            => JsonSerializer.Deserialize<T>(content, jsonSerializerOptions ?? JsonDeserializerOptionsDefault);

        public static string Serialize<T>(this T value, JsonSerializerOptions jsonSerializerOptions = null) where T : class
            => JsonSerializer.Serialize(value, jsonSerializerOptions ?? JsonSerializerOptionsDefault);
    }
}