using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesYouveBeen.Models;
using System.Collections.Generic;
using System;

namespace PlacesYouveBeen.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("test");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCityName_ReturnsCityName_String()
    {
      string cityName = "Hawaii";
      Place newPlace = new Place(cityName);
      string result = newPlace.CityName;
      Assert.AreEqual(cityName, result);
    }

    [TestMethod]
    public void SetCityName_SetCityName_String()
    {
      string cityName = "Hawaii";
      Place newPlace = new Place(cityName);
      string updatedCityName = "Austin, TX";
      newPlace.CityName = updatedCityName;
      string result = newPlace.CityName;
      Assert.AreEqual(updatedCityName, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_PlaceList()
    {
      List<Place> newList = new List<Place> { };
      List<Place> result = Place.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]

    public void GetAll_ReturnsPlaces_PlaceList()
    {
      string cityName1 = "Hawaii";
      string cityName2 = "Austin";
      Place newPlace1 = new Place(cityName1);
      Place newPlace2 = new Place(cityName2);
      List<Place> newList = new List<Place> {newPlace1, newPlace2};

      List<Place> result = Place.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_PlacesInstantiateWithAnIdAndGetterReturns_Int()
    {
      string cityName = "Portland, OR";
      Place newPlace = new Place(cityName);
      int result = newPlace.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectPlace_Place()
    {
      string cityName1 = "Hawaii";
      string cityName2 = "Austin";
      Place newPlace1 = new Place(cityName1);
      Place newPlace2 = new Place(cityName2);
      Place result = Place.Find(2);
      Assert.AreEqual(newPlace2, result);
    }
  }
}