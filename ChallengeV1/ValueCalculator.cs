using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeV1
{
    public class ValueCalculator
    {
        private Dictionary<string, EquipmentInfoData> _equipmentData;

        public ValueCalculator(Dictionary<string, EquipmentInfoData> equipmentData)
        {
            _equipmentData = equipmentData;
        }

        //TASK 1 FUNCTION THAT RETURNS THE CALCULATED VALUES

        public (double marketValue, double auctionValue) CalculateValues(string equipmentId, int year)
        {
            double marketValue = 0.0;
            double auctionValue = 0.0;

            if (_equipmentData.ContainsKey(equipmentId))
            {
                var equipmentInfo = _equipmentData[equipmentId];

                
                if (equipmentInfo.Schedule.Years.ContainsKey(year.ToString()))
                {
                    var yearData = equipmentInfo.Schedule.Years[year.ToString()];
                    marketValue = yearData.MarketRatio * equipmentInfo.SaleDetails.Cost;
                    auctionValue = yearData.AuctionRatio * equipmentInfo.SaleDetails.Cost;
                }
                else
                {
                    Console.WriteLine($"No se encontró información para el año {year}.");
                }
            }
            else
            {
                //TASK 2 
                Console.WriteLine($"No se encontró información para el equipo con ID {equipmentId}.");
            }

            return (marketValue, auctionValue);
        }



    }
}