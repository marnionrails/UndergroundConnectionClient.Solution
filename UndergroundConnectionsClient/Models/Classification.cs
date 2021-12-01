using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UndergroundConnectionsClient.Models
{
  public class Classification
  {
    public int ClassificationId { get; set; }
    public string ClassificationName { get; set; }
    public string ClassificationSpecification { get; set; }

    public static List<Classification> GetClassifications()
    {
      var apiCallTask = ApiHelperClassification.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Classification> classificationList = JsonConvert.DeserializeObject<List<Classification>>(jsonResponse.ToString());

      return classificationList;
    }

    public static Classification GetDetails(int id)
    {
      var apiCallTask = ApiHelperClassification.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Classification classification = JsonConvert.DeserializeObject<Classification>(jsonResponse.ToString());

      return classification;
    }

    public static void Post(Classification classification)
    {
      string jsonClassification = JsonConvert.SerializeObject(classification);
      var apiCallTask = ApiHelperClassification.Post(jsonClassification);
    }

    public static void Put(Classification classification)
    {
      string jsonClassification = JsonConvert.SerializeObject(classification);
      var apiCallTask = ApiHelperClassification.Put(classification.ClassificationId, jsonClassification);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelperClassification.Delete(id);
    }
  }
}