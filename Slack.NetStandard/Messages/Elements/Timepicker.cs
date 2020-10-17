﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Slack.NetStandard.Messages.Elements
{
    public class TimePicker:IMessageElement
    {
        public string Type => nameof(TimePicker).ToLower();

        [JsonProperty("placeholder")]
        public PlainText Placeholder { get; set; }

        [JsonProperty("action_id")]
        public string ActionId { get; set; }

        [JsonProperty("initial_time", NullValueHandling = NullValueHandling.Ignore)]
        public string InitialTime { get; set; }

        [JsonProperty("confirm", NullValueHandling = NullValueHandling.Ignore)]
        public Confirmation Confirm { get; set; }
    }
}