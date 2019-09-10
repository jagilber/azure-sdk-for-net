// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Details the service to which the subnet is delegated.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Delegation : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the Delegation class.
        /// </summary>
        public Delegation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Delegation class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="serviceName">The name of the service to whom the
        /// subnet should be delegated (e.g. Microsoft.Sql/servers).</param>
        /// <param name="actions">Describes the actions permitted to the
        /// service upon delegation.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// service delegation resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="name">The name of the resource that is unique within a
        /// subnet. This name can be used to access the resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public Delegation(string id = default(string), string serviceName = default(string), IList<string> actions = default(IList<string>), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            ServiceName = serviceName;
            Actions = actions;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the service to whom the subnet should be
        /// delegated (e.g. Microsoft.Sql/servers).
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceName")]
        public string ServiceName { get; set; }

        /// <summary>
        /// Gets or sets describes the actions permitted to the service upon
        /// delegation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.actions")]
        public IList<string> Actions { get; set; }

        /// <summary>
        /// Gets the provisioning state of the service delegation resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// subnet. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
