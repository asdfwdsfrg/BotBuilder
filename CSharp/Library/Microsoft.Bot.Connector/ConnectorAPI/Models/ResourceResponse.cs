// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// A response containing a resource ID
    /// </summary>
    public partial class ResourceResponse
    {
        /// <summary>
        /// Initializes a new instance of the ResourceResponse class.
        /// </summary>
        public ResourceResponse() { }

        /// <summary>
        /// Initializes a new instance of the ResourceResponse class.
        /// </summary>
        public ResourceResponse(string id = default(string))
        {
            Id = id;
        }

        /// <summary>
        /// Id of the resource
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}
