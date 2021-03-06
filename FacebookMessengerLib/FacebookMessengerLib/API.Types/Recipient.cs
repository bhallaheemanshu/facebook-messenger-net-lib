﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookMessengerLib.API.Types
{
    /// <summary>
    /// The object represents recipient of message
    /// </summary>
    [JsonObject]
    public class Recipient
    {
        //id or phone_number must be set in request
        [JsonProperty(PropertyName = "id", Required = Required.Default)]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "phone_number", Required = Required.Default)]
        [DefaultValue("")]
        public string PhoneNumber { get; set; }

        public Recipient(long id, string phoneNumber = "")
        {
            Id = id;
            PhoneNumber = phoneNumber;
        }
    }
}
