﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Slack.NetStandard.Objects
{
    public class ViewState
    {
        [JsonProperty("values",NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Dictionary<string,ElementValue>> Values { get; set; }
    }
}