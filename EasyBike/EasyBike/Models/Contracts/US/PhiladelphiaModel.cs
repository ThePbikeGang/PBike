﻿using Newtonsoft.Json;
using System;

namespace EasyBike.Models.Contracts.US
{

    //public class PhiladelphiaModel 
    //{
    //    [JsonProperty(PropertyName = "features")]
    //    public List<Feature> Features { get; set; }
    //}

    //public class Features : StationModelBase
    //{
    //    [JsonProperty(PropertyName = "BikesAvailable")]
    //    public override int AvailableBikes { get; set; }

    //    [JsonProperty(PropertyName = "DocksAvailable")]
    //    public override int? AvailableBikeStands { get; set; }

    //    public override bool Banking { get; set; }

    //    public override double Latitude { get; set; }

    //    public override double Longitude { get; set; }

    //    [JsonProperty]
    //    public Location Location { get; set; }

    //    [JsonProperty(PropertyName = "Name")]
    //    public string Name { get; set; }

    //    [JsonProperty(PropertyName = "Status")]
    //    public string status { get; set; }

    //    public override bool Status { get; set; }

    //    [OnDeserialized]
    //    internal new void OnDeserializedMethod(StreamingContext context)
    //    {
    //        Longitude = Math.Round(Location.Longitude, 5);
    //        Latitude = Math.Round(Location.Latitude, 5);
    //        Status = status == "OPEN" ? true : false;
    //    }
    //}
    //public class Location
    //{
    //    [JsonProperty(PropertyName = "Latitude")]
    //    public double Latitude { get; set; }

    //    [JsonProperty(PropertyName = "Longitude")]
    //    public double Longitude { get; set; }
    //}
}
