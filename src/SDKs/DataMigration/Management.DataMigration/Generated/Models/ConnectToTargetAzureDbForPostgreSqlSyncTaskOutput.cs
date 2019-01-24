// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Output for the task that validates connection to Azure Database for
    /// PostgreSQL and target server requirements
    /// </summary>
    public partial class ConnectToTargetAzureDbForPostgreSqlSyncTaskOutput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ConnectToTargetAzureDbForPostgreSqlSyncTaskOutput class.
        /// </summary>
        public ConnectToTargetAzureDbForPostgreSqlSyncTaskOutput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ConnectToTargetAzureDbForPostgreSqlSyncTaskOutput class.
        /// </summary>
        /// <param name="id">Result identifier</param>
        /// <param name="targetServerVersion">Version of the target
        /// server</param>
        /// <param name="databases">List of databases on target server</param>
        /// <param name="targetServerBrandVersion">Target server brand
        /// version</param>
        /// <param name="validationErrors">Validation errors associated with
        /// the task</param>
        public ConnectToTargetAzureDbForPostgreSqlSyncTaskOutput(string id = default(string), string targetServerVersion = default(string), IList<string> databases = default(IList<string>), string targetServerBrandVersion = default(string), IList<ReportableException> validationErrors = default(IList<ReportableException>))
        {
            Id = id;
            TargetServerVersion = targetServerVersion;
            Databases = databases;
            TargetServerBrandVersion = targetServerBrandVersion;
            ValidationErrors = validationErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets result identifier
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets version of the target server
        /// </summary>
        [JsonProperty(PropertyName = "targetServerVersion")]
        public string TargetServerVersion { get; private set; }

        /// <summary>
        /// Gets list of databases on target server
        /// </summary>
        [JsonProperty(PropertyName = "databases")]
        public IList<string> Databases { get; private set; }

        /// <summary>
        /// Gets target server brand version
        /// </summary>
        [JsonProperty(PropertyName = "targetServerBrandVersion")]
        public string TargetServerBrandVersion { get; private set; }

        /// <summary>
        /// Gets validation errors associated with the task
        /// </summary>
        [JsonProperty(PropertyName = "validationErrors")]
        public IList<ReportableException> ValidationErrors { get; private set; }

    }
}
