using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChallengeV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonString = @"
{
  ""67352"": {
    ""schedule"": {
      ""years"": {
        ""2006"": {
          ""marketRatio"": 0.311276,
          ""auctionRatio"": 0.181383
        },
        ""2007"": {
          ""marketRatio"": 0.317628,
          ""auctionRatio"": 0.185085
        },
        ""2008"": {
          ""marketRatio"": 0.324111,
          ""auctionRatio"": 0.188862
        },
        ""2009"": {
          ""marketRatio"": 0.330725,
          ""auctionRatio"": 0.192716
        },
        ""2010"": {
          ""marketRatio"": 0.363179,
          ""auctionRatio"": 0.198498
        },
        ""2011"": {
          ""marketRatio"": 0.374074,
          ""auctionRatio"": 0.206337
        },
        ""2012"": {
          ""marketRatio"": 0.431321,
          ""auctionRatio"": 0.213178
        }
      },
      ""defaultMarketRatio"": 0.02,
      ""defaultAuctionRatio"": 0.02
    },
    ""saleDetails"": {
      ""cost"": 681252,
      ""retailSaleCount"": 122,
      ""auctionSaleCount"": 17
    },
    ""classification"": {
      ""category"": ""Earthmoving Equipment"",
      ""subcategory"": ""Dozers"",
      ""make"": ""Caterpillar"",
      ""model"": ""D8T""
    }
  },
  ""87390"": {
    ""schedule"": {
      ""years"": {
        ""2016"": {
          ""marketRatio"": 0.613292,
          ""auctionRatio"": 0.417468
        },
        ""2017"": {
          ""marketRatio"": 0.692965,
          ""auctionRatio"": 0.473205
        },
        ""2018"": {
          ""marketRatio"": 0.980485,
          ""auctionRatio"": 0.684991
        },
        ""2019"": {
          ""marketRatio"": 1.041526,
          ""auctionRatio"": 0.727636
        },
        ""2020"": {
          ""marketRatio"": 1.106366,
          ""auctionRatio"": 0.772935
        }
      },
      ""defaultMarketRatio"": 0.06,
      ""defaultAuctionRatio"": 0.06
    },
    ""saleDetails"": {
      ""cost"": 48929,
      ""retailSaleCount"": 12,
      ""auctionSaleCount"": 127
    },
    ""classification"": {
      ""category"": ""Aerial Equipment"",
      ""subcategory"": ""Boom Lifts"",
      ""make"": ""JLG"",
      ""model"": ""340AJ""
    }
  }
}"; Dictionary<string, EquipmentInfoData> equipmentData = JsonConvert.DeserializeObject<Dictionary<string, EquipmentInfoData>>(jsonString);


            ValueCalculator calculator = new ValueCalculator(equipmentData);

            //TASK1 AND TASK 3
            var result = calculator.CalculateValues("67352", 2007);

            calculator.CalculateValues("87694", 2011);

            Console.WriteLine("Valor de Mercado y Subasta para el equipo 67352 en el año 2007:");
            Console.WriteLine($"Valor de Mercado: {result.marketValue}");
            Console.WriteLine($"Valor de Subasta: {result.auctionValue}");

            Console.ReadKey();
        }

    }
}

