using System;
using System.Collections.Generic;

namespace P01_Console {
  class Program {
    static void Main(string[] args) {
      var cityList = new List<string> { "San Jose", "Santa Clara", "Redwood" };
      cityList.Sort();
      foreach (var city in cityList)
        Console.WriteLine(city);
    }
  }
}
