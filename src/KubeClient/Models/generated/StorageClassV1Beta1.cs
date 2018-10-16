using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     StorageClass describes the parameters for a class of storage for which PersistentVolumes can be dynamically provisioned.
    ///     
    ///     StorageClasses are non-namespaced; the name of the storage class according to etcd is in ObjectMeta.Name.
    /// </summary>
    [KubeObject("StorageClass", "v1beta1")]
    [KubeApi(KubeAction.List, "apis/storage.k8s.io/v1beta1/storageclasses")]
    [KubeApi(KubeAction.Create, "apis/storage.k8s.io/v1beta1/storageclasses")]
    [KubeApi(KubeAction.Get, "apis/storage.k8s.io/v1beta1/storageclasses/{name}")]
    [KubeApi(KubeAction.Patch, "apis/storage.k8s.io/v1beta1/storageclasses/{name}")]
    [KubeApi(KubeAction.Delete, "apis/storage.k8s.io/v1beta1/storageclasses/{name}")]
    [KubeApi(KubeAction.Update, "apis/storage.k8s.io/v1beta1/storageclasses/{name}")]
    [KubeApi(KubeAction.WatchList, "apis/storage.k8s.io/v1beta1/watch/storageclasses")]
    [KubeApi(KubeAction.DeleteCollection, "apis/storage.k8s.io/v1beta1/storageclasses")]
    [KubeApi(KubeAction.Watch, "apis/storage.k8s.io/v1beta1/watch/storageclasses/{name}")]
    public partial class StorageClassV1Beta1 : KubeResourceV1
    {
        /// <summary>
        ///     VolumeBindingMode indicates how PersistentVolumeClaims should be provisioned and bound.  When unset, VolumeBindingImmediate is used. This field is alpha-level and is only honored by servers that enable the VolumeScheduling feature.
        /// </summary>
        [JsonProperty("volumeBindingMode")]
        [YamlMember(Alias = "volumeBindingMode")]
        public string VolumeBindingMode { get; set; }

        /// <summary>
        ///     AllowVolumeExpansion shows whether the storage class allow volume expand
        /// </summary>
        [JsonProperty("allowVolumeExpansion")]
        [YamlMember(Alias = "allowVolumeExpansion")]
        public bool AllowVolumeExpansion { get; set; }

        /// <summary>
        ///     Provisioner indicates the type of the provisioner.
        /// </summary>
        [JsonProperty("provisioner")]
        [YamlMember(Alias = "provisioner")]
        public string Provisioner { get; set; }

        /// <summary>
        ///     Restrict the node topologies where volumes can be dynamically provisioned. Each volume plugin defines its own supported topology specifications. An empty TopologySelectorTerm list means there is no topology restriction. This field is alpha-level and is only honored by servers that enable the DynamicProvisioningScheduling feature.
        /// </summary>
        [YamlMember(Alias = "allowedTopologies")]
        [JsonProperty("allowedTopologies", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopologySelectorTermV1> AllowedTopologies { get; set; } = new List<TopologySelectorTermV1>();

        /// <summary>
        ///     Dynamically provisioned PersistentVolumes of this storage class are created with these mountOptions, e.g. ["ro", "soft"]. Not validated - mount of the PVs will simply fail if one is invalid.
        /// </summary>
        [YamlMember(Alias = "mountOptions")]
        [JsonProperty("mountOptions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MountOptions { get; set; } = new List<string>();

        /// <summary>
        ///     Parameters holds the parameters for the provisioner that should create volumes of this storage class.
        /// </summary>
        [YamlMember(Alias = "parameters")]
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Parameters { get; set; } = new Dictionary<string, string>();

        /// <summary>
        ///     Dynamically provisioned PersistentVolumes of this storage class are created with this reclaimPolicy. Defaults to Delete.
        /// </summary>
        [JsonProperty("reclaimPolicy")]
        [YamlMember(Alias = "reclaimPolicy")]
        public string ReclaimPolicy { get; set; }
    }
}