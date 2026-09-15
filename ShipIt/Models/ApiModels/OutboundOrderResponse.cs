// Only list types that are used in the response model, e.g. System.Collections.Generic.List<T> if the response model contains a list of items.
using System;
using System.Text;

// This endpoint needs to report one piece of data: the estimated number of trucks needed to transport an order
namespace ShipIt.Models.ApiModels
{
    public class OutboundOrderResponse
    {
        public int EstimatedTrucksPerOrder { get; set; }

        //Empty constructor needed for Xml serialization
        public OutboundOrderResponse()
        {
        }

        public override String ToString()
        {
            return new StringBuilder()
                .AppendFormat("estimatedTrucksPerOrder: {0}", EstimatedTrucksPerOrder)
                .ToString();
        }
    }
}