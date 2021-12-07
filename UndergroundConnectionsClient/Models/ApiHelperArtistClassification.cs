using System.Threading.Tasks;
using RestSharp;

namespace UndergroundConnectionsClient.Models
{
  class ApiHelperArtistClassification
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"artistclassification", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"artistclassification/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task Post(string newArtist)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"artistclassification", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newArtist);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task PostChild (string artistClassification, int classificationId, string artist, string newArtist)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"artistclassification/{classificationId}/artist", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newArtist);
      var response = await client.ExecuteTaskAsync(request);
    }
    public static async Task Put(int id, string newArtistClassification)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"artistclassification/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newArtistClassification);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"artistclassification/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteTaskAsync(request);
    }
  }
}