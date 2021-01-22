using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AnimalShelterClient.Models
{
  public class Cat
  {
    public int CatId { get; set; }
    public string Name { get; set; }

    public string Breed { get; set; }
    public string Age { get; set; }

    public static List<Cat> GetCats();
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonCovert.DeserializedObject<JArray>(result);
      List<Cat> catList = JsonCovert.DeserializedObject<List<Cat>>(JsonResponse.ToString());

      return catList;
    }
  }
}