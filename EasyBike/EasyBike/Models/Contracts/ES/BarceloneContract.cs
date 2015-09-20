﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBike.Models.Contracts.ES
{
    public class BarceloneContract : Contract
    {
        public BarceloneContract()
        {
            ServiceProvider = "The City of Barcelona, Vodafone, Clear Channel";
            StationsUrl = "https://www.bicing.cat/availability_map/getJsonObject";
        }

        public override async Task<List<StationModelBase>> InnerGetStationsAsync()
        {
            using (var client = new HttpClient(new NativeMessageHandler()))
            {
                HttpResponseMessage response = await client.GetAsync(new Uri(string.Format(StationsUrl + "?" + Guid.NewGuid().ToString()))).ConfigureAwait(false);
                var responseBodyAsText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<List<BarceloneModel>>(responseBodyAsText).ToList<StationModelBase>();
            }
        }

        public override async Task<List<StationModelBase>> InnerRefreshAsync()
        {
            return await InnerGetStationsAsync().ConfigureAwait(false);
        }
    }

    public class BarceloneModel : StationBaseModel
    {
        [JsonProperty("bikes")]
        public override int AvailableBikes { get; set; }

        [JsonProperty("slots")]
        public override int? AvailableBikeStands { get; set; }

        [JsonProperty("lat")]
        public override double Latitude { get; set; }

        [JsonProperty("lon")]
        public override double Longitude { get; set; }
    }
}