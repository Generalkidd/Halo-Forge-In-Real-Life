using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.ApiClients.DataTypes
{
    [Serializable]
    public class Adjustment
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public int Quantity { get; set; }
        public int ReasonId { get; set; }
    }
}
