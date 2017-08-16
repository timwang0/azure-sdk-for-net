// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Metric limits set on an app.
    /// </summary>
    public partial class SiteLimits
    {
        /// <summary>
        /// Initializes a new instance of the SiteLimits class.
        /// </summary>
        public SiteLimits()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SiteLimits class.
        /// </summary>
        /// <param name="maxPercentageCpu">Maximum allowed CPU usage
        /// percentage.</param>
        /// <param name="maxMemoryInMb">Maximum allowed memory usage in
        /// MB.</param>
        /// <param name="maxDiskSizeInMb">Maximum allowed disk size usage in
        /// MB.</param>
        public SiteLimits(double? maxPercentageCpu = default(double?), long? maxMemoryInMb = default(long?), long? maxDiskSizeInMb = default(long?))
        {
            MaxPercentageCpu = maxPercentageCpu;
            MaxMemoryInMb = maxMemoryInMb;
            MaxDiskSizeInMb = maxDiskSizeInMb;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets maximum allowed CPU usage percentage.
        /// </summary>
        [JsonProperty(PropertyName = "maxPercentageCpu")]
        public double? MaxPercentageCpu { get; set; }

        /// <summary>
        /// Gets or sets maximum allowed memory usage in MB.
        /// </summary>
        [JsonProperty(PropertyName = "maxMemoryInMb")]
        public long? MaxMemoryInMb { get; set; }

        /// <summary>
        /// Gets or sets maximum allowed disk size usage in MB.
        /// </summary>
        [JsonProperty(PropertyName = "maxDiskSizeInMb")]
        public long? MaxDiskSizeInMb { get; set; }

    }
}
