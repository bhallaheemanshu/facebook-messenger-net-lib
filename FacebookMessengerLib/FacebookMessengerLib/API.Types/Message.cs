﻿using FacebookMessengerLib.API.Types.Attachments;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookMessengerLib.API.Types
{
    [JsonObject]
    public class Message
    {
        [JsonProperty(PropertyName = "text", Required = Required.Always)]
        public string Text { get; set; }
        [JsonProperty(PropertyName = "attachment", Required = Required.Always)]
        public Attachment Attachment { get; set; }
    }
}
