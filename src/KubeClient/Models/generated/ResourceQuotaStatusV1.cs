using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     ResourceQuotaStatus defines the enforced hard limits and observed use.
    /// </summary>
    public partial class ResourceQuotaStatusV1
    {
        /// <summary>
        ///     Hard is the set of enforced hard limits for each named resource. More info: https://kubernetes.io/docs/concepts/policy/resource-quotas/
        /// </summary>
        [YamlMember(Alias = "hard")]
        [JsonProperty("hard", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Hard { get; set; } = new Dictionary<string, string>();

        /// <summary>
        ///     Used is the current observed total usage of the resource in the namespace.
        /// </summary>
        [YamlMember(Alias = "used")]
        [JsonProperty("used", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Used { get; set; } = new Dictionary<string, string>();
    }
}