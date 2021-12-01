using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UndergroundConnectionsClient.Models
{
  public class Artist
  {
    
    public int ArtistId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set;}
    public string Bio { get; set; }
    public string Seeking { get; set; }
    public string PastWork { get; set; }
    public static List<Artist> GetArtists()
    {
      var apiCallTask = ApiHelperArtist.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Artist> artistList = JsonConvert.DeserializeObject<List<Artist>>(jsonResponse.ToString());

      return artistList;
    }

    public static Artist GetDetails(int id)
    {
      var apiCallTask = ApiHelperArtist.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Artist artist = JsonConvert.DeserializeObject<Artist>(jsonResponse.ToString());

      return artist;
    }
    public static void Post(Artist artist)
    {
      string jsonArtist = JsonConvert.SerializeObject(artist);
      var apiCallTask = ApiHelperArtist.Post(jsonArtist);
    }

    public static void Put(Artist artist)
    {
      string jsonArtist = JsonConvert.SerializeObject(artist);
      var apiCallTask = ApiHelperArtist.Put(artist.ArtistId, jsonArtist);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelperArtist.Delete(id);
    }
  }
}