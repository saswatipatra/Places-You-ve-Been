using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TravelDiary.Models;

namespace TravelDiary.Tests
{
    [TestClass]
    public class PlaceTest : IDisposable
    {
        public void Dispose()
        {
            Place.ClearAll();
        }

        [TestMethod]
        public void PlaceConstructor_ReturnsDescription_String()
        {
            Place newPlace = new Place("Seattle");
            Assert.AreEqual("Seattle", newPlace.CityName);
        }

        [TestMethod]
        public void GetAll_ReturnsListOfPlaces_ListOfPlaces()
        {
            Place newPlace1 = new Place("Seattle");
            Place newPlace2 = new Place("Miami");

            List<Place> newList = new List<Place> { newPlace1, newPlace2 };
            List<Place> result = Place.GetAll();

            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void GetId_PlacesInstantiateWithIdAndGetterReturns_Int()
        {
            Place newPlace1 = new Place("Seattle");
            Place newPlace2 = new Place("Miami");

            int result = newPlace2.Id;

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FindId_ReturnsPlaceWithId_Place()
        {
            Place newPlace1 = new Place("Seattle");
            Place newPlace2 = new Place("Miami");

            Place foundPlace = Place.Find(2);
            string result = foundPlace.CityName;

            Assert.AreEqual("Miami", result);
        }
    }
}