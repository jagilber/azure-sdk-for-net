// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A managed server security alert policy.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ManagedServerSecurityAlertPolicy : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ManagedServerSecurityAlertPolicy
        /// class.
        /// </summary>
        public ManagedServerSecurityAlertPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedServerSecurityAlertPolicy
        /// class.
        /// </summary>
        /// <param name="state">Specifies the state of the policy, whether it
        /// is enabled or disabled. Possible values include: 'New', 'Enabled',
        /// 'Disabled'</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="disabledAlerts">Specifies an array of alerts that are
        /// disabled. Allowed values are: Sql_Injection,
        /// Sql_Injection_Vulnerability, Access_Anomaly, Data_Exfiltration,
        /// Unsafe_Action</param>
        /// <param name="emailAddresses">Specifies an array of e-mail addresses
        /// to which the alert is sent.</param>
        /// <param name="emailAccountAdmins">Specifies that the alert is sent
        /// to the account administrators.</param>
        /// <param name="storageEndpoint">Specifies the blob storage endpoint
        /// (e.g. https://MyAccount.blob.core.windows.net). This blob storage
        /// will hold all Threat Detection audit logs.</param>
        /// <param name="storageAccountAccessKey">Specifies the identifier key
        /// of the Threat Detection audit storage account.</param>
        /// <param name="retentionDays">Specifies the number of days to keep in
        /// the Threat Detection audit logs.</param>
        /// <param name="creationTime">Specifies the UTC creation time of the
        /// policy.</param>
        public ManagedServerSecurityAlertPolicy(SecurityAlertPolicyState state, string id = default(string), string name = default(string), string type = default(string), IList<string> disabledAlerts = default(IList<string>), IList<string> emailAddresses = default(IList<string>), bool? emailAccountAdmins = default(bool?), string storageEndpoint = default(string), string storageAccountAccessKey = default(string), int? retentionDays = default(int?), System.DateTime? creationTime = default(System.DateTime?))
            : base(id, name, type)
        {
            State = state;
            DisabledAlerts = disabledAlerts;
            EmailAddresses = emailAddresses;
            EmailAccountAdmins = emailAccountAdmins;
            StorageEndpoint = storageEndpoint;
            StorageAccountAccessKey = storageAccountAccessKey;
            RetentionDays = retentionDays;
            CreationTime = creationTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the state of the policy, whether it is
        /// enabled or disabled. Possible values include: 'New', 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public SecurityAlertPolicyState State { get; set; }

        /// <summary>
        /// Gets or sets specifies an array of alerts that are disabled.
        /// Allowed values are: Sql_Injection, Sql_Injection_Vulnerability,
        /// Access_Anomaly, Data_Exfiltration, Unsafe_Action
        /// </summary>
        [JsonProperty(PropertyName = "properties.disabledAlerts")]
        public IList<string> DisabledAlerts { get; set; }

        /// <summary>
        /// Gets or sets specifies an array of e-mail addresses to which the
        /// alert is sent.
        /// </summary>
        [JsonProperty(PropertyName = "properties.emailAddresses")]
        public IList<string> EmailAddresses { get; set; }

        /// <summary>
        /// Gets or sets specifies that the alert is sent to the account
        /// administrators.
        /// </summary>
        [JsonProperty(PropertyName = "properties.emailAccountAdmins")]
        public bool? EmailAccountAdmins { get; set; }

        /// <summary>
        /// Gets or sets specifies the blob storage endpoint (e.g.
        /// https://MyAccount.blob.core.windows.net). This blob storage will
        /// hold all Threat Detection audit logs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageEndpoint")]
        public string StorageEndpoint { get; set; }

        /// <summary>
        /// Gets or sets specifies the identifier key of the Threat Detection
        /// audit storage account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccountAccessKey")]
        public string StorageAccountAccessKey { get; set; }

        /// <summary>
        /// Gets or sets specifies the number of days to keep in the Threat
        /// Detection audit logs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.retentionDays")]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// Gets specifies the UTC creation time of the policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
