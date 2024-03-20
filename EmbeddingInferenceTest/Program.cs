using Parquet.Serialization;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

var sw = new Stopwatch();
var client = new HttpClient();
client.BaseAddress = new Uri("http://localhost:8080/");

IList<DataRecord> data = await ParquetSerializer.DeserializeAsync<DataRecord>("data/0000.parquet");
var subset = data.Take(1000);

sw.Start();
foreach (var record in subset)
{
    await GenerateEmbeddingAsync(record.text);   
}
sw.Stop();

Console.WriteLine($"Time Elapsed (seconds): {sw.ElapsedMilliseconds / 1000}");

async Task GenerateEmbeddingAsync(string text)
{
    await client.PostAsJsonAsync("/embed", new {inputs=text});
}

class DataRecord
{
    public string text { get; set; }
};