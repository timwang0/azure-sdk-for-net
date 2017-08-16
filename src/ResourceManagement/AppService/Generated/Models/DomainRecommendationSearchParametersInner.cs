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
    /// Domain recommendation search parameters.
    /// </summary>
    public partial class DomainRecommendationSearchParametersInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DomainRecommendationSearchParametersInner class.
        /// </summary>
        public DomainRecommendationSearchParametersInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DomainRecommendationSearchParametersInner class.
        /// </summary>
        /// <param name="keywords">Keywords to be used for generating domain
        /// recommendations.</param>
        /// <param name="maxDomainRecommendations">Maximum number of
        /// recommendations.</param>
        public DomainRecommendationSearchParametersInner(string keywords = default(string), int? maxDomainRecommendations = default(int?))
        {
            Keywords = keywords;
            MaxDomainRecommendations = maxDomainRecommendations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets keywords to be used for generating domain
        /// recommendations.
        /// </summary>
        [JsonProperty(PropertyName = "keywords")]
        public string Keywords { get; set; }

        /// <summary>
        /// Gets or sets maximum number of recommendations.
        /// </summary>
        [JsonProperty(PropertyName = "maxDomainRecommendations")]
        public int? MaxDomainRecommendations { get; set; }

    }
}
