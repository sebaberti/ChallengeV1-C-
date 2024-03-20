using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeV1
{
    public class EquipmentInfoData
    {
        public Schedule Schedule { get; set; }
        public SaleDetails SaleDetails { get; set; }
        public Classification Classification { get; set; }
    }
}
