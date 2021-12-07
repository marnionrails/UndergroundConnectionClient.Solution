using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UndergroundConnectionsClient.Models
{
  public class ArtistClassification
  {
  public int ArtistClassificationId { get; set;}
  public int ArtistId { get; set; }
  public int ClassificationId { get; set;}
  public virtual Artist Artist { get; set;}
  public virtual Classification Classification { get; set; }
    public static List<ArtistClassification> GetArtistClassifications()
    {
      var apiCallTask = ApiHelperArtistClassification.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<ArtistClassification> artistClassificationList = JsonConvert.DeserializeObject<List<ArtistClassification>>(jsonResponse.ToString());

      return artistClassificationList;
    }

    public static ArtistClassification GetDetails(int id)
    {
      var apiCallTask = ApiHelperArtistClassification.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      ArtistClassification artistClassification = JsonConvert.DeserializeObject<ArtistClassification>(jsonResponse.ToString());

      return artistClassification;
    }

    public static void Include(Artist thisArtist, int ClassificationId)
    {
      string jsonArtist = JsonConvert.SerializeObject(thisArtist);
      var apiCallTask = ApiHelperArtistClassification.PostChild("classifications",ClassificationId,"artists", jsonArtist);
    }
    public static void Post(ArtistClassification artistClassification)
    {
      string jsonArtist = JsonConvert.SerializeObject(artistClassification);
      var apiCallTask = ApiHelperArtistClassification.Post(jsonArtist);
    }

    public static void NewPost(ArtistClassification thisArtist, int classificationId)
    {
      string jsonPost = JsonConvert.SerializeObject(thisArtist);
      var apiCallTask = ApiHelperArtistClassification.PostChild("classifications", classificationId, "artists",jsonPost);
    }
    public static void Put(ArtistClassification artistClassification)
    {
      string jsonArtist = JsonConvert.SerializeObject(artistClassification);
      var apiCallTask = ApiHelperArtistClassification.Put(artistClassification.ArtistClassificationId, jsonArtist);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelperArtistClassification.Delete(id);
    }
  }
}