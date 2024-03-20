using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChallengeV1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, EquipmentInfoData> equipmentData = JsonConvert.DeserializeObject<Dictionary<string, EquipmentInfoData>>(JsonData.JsonString);


            ValueCalculator calculator = new ValueCalculator(equipmentData);

            //TASK1 AND TASK 3
            calculator.CalculateValues("67352", 2007);

            calculator.CalculateValues("87694", 2011);

            Console.ReadKey();
        }

    }
}

