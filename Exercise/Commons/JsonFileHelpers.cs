using System.Text.Json;

namespace Exercise.Commons
{
    public static class JsonFileHelpers
    {
        public static async Task<T> ReadAsync<T>(string filePath)
        {
            await using FileStream stream = File.OpenRead(filePath);
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }
        
        public static async Task<T> WriteAsync<T>(T model, string filePath)
        {
            T list = await ReadAsync(filePath);
        }
    }
}