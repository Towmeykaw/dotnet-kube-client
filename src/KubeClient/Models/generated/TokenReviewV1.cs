using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     TokenReview attempts to authenticate a token to a known user. Note: TokenReview requests may be cached by the webhook token authenticator plugin in the kube-apiserver.
    /// </summary>
    [KubeObject("TokenReview", "v1")]
    [KubeApi(KubeAction.Create, "apis/authentication.k8s.io/v1/tokenreviews")]
    public partial class TokenReviewV1 : KubeResourceV1
    {
        /// <summary>
        ///     Spec holds information about the request being evaluated
        /// </summary>
        [JsonProperty("spec")]
        [YamlMember(Alias = "spec")]
        public TokenReviewSpecV1 Spec { get; set; }

        /// <summary>
        ///     Status is filled in by the server and indicates whether the request can be authenticated.
        /// </summary>
        [JsonProperty("status")]
        [YamlMember(Alias = "status")]
        public TokenReviewStatusV1 Status { get; set; }
    }
}