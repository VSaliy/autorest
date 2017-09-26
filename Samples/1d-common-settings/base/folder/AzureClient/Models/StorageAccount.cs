// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AwesomeNamespace.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The storage account.
    /// </summary>
    [JsonTransformation]
    public partial class StorageAccount : Resource
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccount class.
        /// </summary>
        public StorageAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccount class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="location">Resource location</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="provisioningState">Gets the status of the storage
        /// account at the time the operation was called. Possible values
        /// include: 'Creating', 'ResolvingDNS', 'Succeeded'</param>
        /// <param name="accountType">Gets the type of the storage account.
        /// Possible values include: 'Standard_LRS', 'Standard_ZRS',
        /// 'Standard_GRS', 'Standard_RAGRS', 'Premium_LRS'</param>
        /// <param name="primaryEndpoints">Gets the URLs that are used to
        /// perform a retrieval of a public blob, queue or table object.Note
        /// that StandardZRS and PremiumLRS accounts only return the blob
        /// endpoint.</param>
        /// <param name="primaryLocation">Gets the location of the primary for
        /// the storage account.</param>
        /// <param name="statusOfPrimary">Gets the status indicating whether
        /// the primary location of the storage account is available or
        /// unavailable. Possible values include: 'Available',
        /// 'Unavailable'</param>
        /// <param name="lastGeoFailoverTime">Gets the timestamp of the most
        /// recent instance of a failover to the secondary location. Only the
        /// most recent timestamp is retained. This element is not returned if
        /// there has never been a failover instance. Only available if the
        /// accountType is StandardGRS or StandardRAGRS.</param>
        /// <param name="secondaryLocation">Gets the location of the geo
        /// replicated secondary for the storage account. Only available if the
        /// accountType is StandardGRS or StandardRAGRS.</param>
        /// <param name="statusOfSecondary">Gets the status indicating whether
        /// the secondary location of the storage account is available or
        /// unavailable. Only available if the accountType is StandardGRS or
        /// StandardRAGRS. Possible values include: 'Available',
        /// 'Unavailable'</param>
        /// <param name="creationTime">Gets the creation date and time of the
        /// storage account in UTC.</param>
        /// <param name="customDomain">Gets the user assigned custom domain
        /// assigned to this storage account.</param>
        /// <param name="secondaryEndpoints">Gets the URLs that are used to
        /// perform a retrieval of a public blob, queue or table object from
        /// the secondary location of the storage account. Only available if
        /// the accountType is StandardRAGRS.</param>
        public StorageAccount(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ProvisioningState? provisioningState = default(ProvisioningState?), AccountType? accountType = default(AccountType?), Endpoints primaryEndpoints = default(Endpoints), string primaryLocation = default(string), AccountStatus? statusOfPrimary = default(AccountStatus?), System.DateTime? lastGeoFailoverTime = default(System.DateTime?), string secondaryLocation = default(string), AccountStatus? statusOfSecondary = default(AccountStatus?), System.DateTime? creationTime = default(System.DateTime?), CustomDomain customDomain = default(CustomDomain), Endpoints secondaryEndpoints = default(Endpoints))
            : base(id, name, type, location, tags)
        {
            ProvisioningState = provisioningState;
            AccountType = accountType;
            PrimaryEndpoints = primaryEndpoints;
            PrimaryLocation = primaryLocation;
            StatusOfPrimary = statusOfPrimary;
            LastGeoFailoverTime = lastGeoFailoverTime;
            SecondaryLocation = secondaryLocation;
            StatusOfSecondary = statusOfSecondary;
            CreationTime = creationTime;
            CustomDomain = customDomain;
            SecondaryEndpoints = secondaryEndpoints;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the status of the storage account at the time the operation
        /// was called. Possible values include: 'Creating', 'ResolvingDNS',
        /// 'Succeeded'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; set; }

        /// <summary>
        /// Gets the type of the storage account. Possible values include:
        /// 'Standard_LRS', 'Standard_ZRS', 'Standard_GRS', 'Standard_RAGRS',
        /// 'Premium_LRS'
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountType")]
        public AccountType? AccountType { get; set; }

        /// <summary>
        /// Gets the URLs that are used to perform a retrieval of a public
        /// blob, queue or table object.Note that StandardZRS and PremiumLRS
        /// accounts only return the blob endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryEndpoints")]
        public Endpoints PrimaryEndpoints { get; set; }

        /// <summary>
        /// Gets the location of the primary for the storage account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryLocation")]
        public string PrimaryLocation { get; set; }

        /// <summary>
        /// Gets the status indicating whether the primary location of the
        /// storage account is available or unavailable. Possible values
        /// include: 'Available', 'Unavailable'
        /// </summary>
        [JsonProperty(PropertyName = "properties.statusOfPrimary")]
        public AccountStatus? StatusOfPrimary { get; set; }

        /// <summary>
        /// Gets the timestamp of the most recent instance of a failover to the
        /// secondary location. Only the most recent timestamp is retained.
        /// This element is not returned if there has never been a failover
        /// instance. Only available if the accountType is StandardGRS or
        /// StandardRAGRS.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastGeoFailoverTime")]
        public System.DateTime? LastGeoFailoverTime { get; set; }

        /// <summary>
        /// Gets the location of the geo replicated secondary for the storage
        /// account. Only available if the accountType is StandardGRS or
        /// StandardRAGRS.
        /// </summary>
        [JsonProperty(PropertyName = "properties.secondaryLocation")]
        public string SecondaryLocation { get; set; }

        /// <summary>
        /// Gets the status indicating whether the secondary location of the
        /// storage account is available or unavailable. Only available if the
        /// accountType is StandardGRS or StandardRAGRS. Possible values
        /// include: 'Available', 'Unavailable'
        /// </summary>
        [JsonProperty(PropertyName = "properties.statusOfSecondary")]
        public AccountStatus? StatusOfSecondary { get; set; }

        /// <summary>
        /// Gets the creation date and time of the storage account in UTC.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets the user assigned custom domain assigned to this storage
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customDomain")]
        public CustomDomain CustomDomain { get; set; }

        /// <summary>
        /// Gets the URLs that are used to perform a retrieval of a public
        /// blob, queue or table object from the secondary location of the
        /// storage account. Only available if the accountType is
        /// StandardRAGRS.
        /// </summary>
        [JsonProperty(PropertyName = "properties.secondaryEndpoints")]
        public Endpoints SecondaryEndpoints { get; set; }

    }
}
