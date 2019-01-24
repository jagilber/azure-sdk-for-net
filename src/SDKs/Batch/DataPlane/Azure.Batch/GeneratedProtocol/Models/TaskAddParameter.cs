// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Azure Batch task to add.
    /// </summary>
    /// <remarks>
    /// Batch will retry tasks when a recovery operation is triggered on a
    /// compute node. Examples of recovery operations include (but are not
    /// limited to) when an unhealthy compute node is rebooted or a compute
    /// node disappeared due to host failure. Retries due to recovery
    /// operations are independent of and are not counted against the
    /// maxTaskRetryCount. Even if the maxTaskRetryCount is 0, an internal
    /// retry due to a recovery operation may occur. Because of this, all tasks
    /// should be idempotent. This means tasks need to tolerate being
    /// interrupted and restarted without causing any corruption or duplicate
    /// data. The best practice for long running tasks is to use some form of
    /// checkpointing.
    /// </remarks>
    public partial class TaskAddParameter
    {
        /// <summary>
        /// Initializes a new instance of the TaskAddParameter class.
        /// </summary>
        public TaskAddParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaskAddParameter class.
        /// </summary>
        /// <param name="id">A string that uniquely identifies the task within
        /// the job.</param>
        /// <param name="commandLine">The command line of the task.</param>
        /// <param name="displayName">A display name for the task.</param>
        /// <param name="containerSettings">The settings for the container
        /// under which the task runs.</param>
        /// <param name="exitConditions">How the Batch service should respond
        /// when the task completes.</param>
        /// <param name="resourceFiles">A list of files that the Batch service
        /// will download to the compute node before running the command
        /// line.</param>
        /// <param name="outputFiles">A list of files that the Batch service
        /// will upload from the compute node after running the command
        /// line.</param>
        /// <param name="environmentSettings">A list of environment variable
        /// settings for the task.</param>
        /// <param name="affinityInfo">A locality hint that can be used by the
        /// Batch service to select a compute node on which to start the new
        /// task.</param>
        /// <param name="constraints">The execution constraints that apply to
        /// this task.</param>
        /// <param name="userIdentity">The user identity under which the task
        /// runs.</param>
        /// <param name="multiInstanceSettings">An object that indicates that
        /// the task is a multi-instance task, and contains information about
        /// how to run the multi-instance task.</param>
        /// <param name="dependsOn">The tasks that this task depends
        /// on.</param>
        /// <param name="applicationPackageReferences">A list of application
        /// packages that the Batch service will deploy to the compute node
        /// before running the command line.</param>
        /// <param name="authenticationTokenSettings">The settings for an
        /// authentication token that the task can use to perform Batch service
        /// operations.</param>
        public TaskAddParameter(string id, string commandLine, string displayName = default(string), TaskContainerSettings containerSettings = default(TaskContainerSettings), ExitConditions exitConditions = default(ExitConditions), IList<ResourceFile> resourceFiles = default(IList<ResourceFile>), IList<OutputFile> outputFiles = default(IList<OutputFile>), IList<EnvironmentSetting> environmentSettings = default(IList<EnvironmentSetting>), AffinityInformation affinityInfo = default(AffinityInformation), TaskConstraints constraints = default(TaskConstraints), UserIdentity userIdentity = default(UserIdentity), MultiInstanceSettings multiInstanceSettings = default(MultiInstanceSettings), TaskDependencies dependsOn = default(TaskDependencies), IList<ApplicationPackageReference> applicationPackageReferences = default(IList<ApplicationPackageReference>), AuthenticationTokenSettings authenticationTokenSettings = default(AuthenticationTokenSettings))
        {
            Id = id;
            DisplayName = displayName;
            CommandLine = commandLine;
            ContainerSettings = containerSettings;
            ExitConditions = exitConditions;
            ResourceFiles = resourceFiles;
            OutputFiles = outputFiles;
            EnvironmentSettings = environmentSettings;
            AffinityInfo = affinityInfo;
            Constraints = constraints;
            UserIdentity = userIdentity;
            MultiInstanceSettings = multiInstanceSettings;
            DependsOn = dependsOn;
            ApplicationPackageReferences = applicationPackageReferences;
            AuthenticationTokenSettings = authenticationTokenSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a string that uniquely identifies the task within the
        /// job.
        /// </summary>
        /// <remarks>
        /// The ID can contain any combination of alphanumeric characters
        /// including hyphens and underscores, and cannot contain more than 64
        /// characters. The ID is case-preserving and case-insensitive (that
        /// is, you may not have two IDs within a job that differ only by
        /// case).
        /// </remarks>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets a display name for the task.
        /// </summary>
        /// <remarks>
        /// The display name need not be unique and can contain any Unicode
        /// characters up to a maximum length of 1024.
        /// </remarks>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the command line of the task.
        /// </summary>
        /// <remarks>
        /// For multi-instance tasks, the command line is executed as the
        /// primary task, after the primary task and all subtasks have finished
        /// executing the coordination command line. The command line does not
        /// run under a shell, and therefore cannot take advantage of shell
        /// features such as environment variable expansion. If you want to
        /// take advantage of such features, you should invoke the shell in the
        /// command line, for example using "cmd /c MyCommand" in Windows or
        /// "/bin/sh -c MyCommand" in Linux. If the command line refers to file
        /// paths, it should use a relative path (relative to the task working
        /// directory), or use the Batch provided environment variable
        /// (https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables).
        /// </remarks>
        [JsonProperty(PropertyName = "commandLine")]
        public string CommandLine { get; set; }

        /// <summary>
        /// Gets or sets the settings for the container under which the task
        /// runs.
        /// </summary>
        /// <remarks>
        /// If the pool that will run this task has containerConfiguration set,
        /// this must be set as well. If the pool that will run this task
        /// doesn't have containerConfiguration set, this must not be set. When
        /// this is specified, all directories recursively below the
        /// AZ_BATCH_NODE_ROOT_DIR (the root of Azure Batch directories on the
        /// node) are mapped into the container, all task environment variables
        /// are mapped into the container, and the task command line is
        /// executed in the container.
        /// </remarks>
        [JsonProperty(PropertyName = "containerSettings")]
        public TaskContainerSettings ContainerSettings { get; set; }

        /// <summary>
        /// Gets or sets how the Batch service should respond when the task
        /// completes.
        /// </summary>
        [JsonProperty(PropertyName = "exitConditions")]
        public ExitConditions ExitConditions { get; set; }

        /// <summary>
        /// Gets or sets a list of files that the Batch service will download
        /// to the compute node before running the command line.
        /// </summary>
        /// <remarks>
        /// For multi-instance tasks, the resource files will only be
        /// downloaded to the compute node on which the primary task is
        /// executed. There is a maximum size for the list of resource files.
        /// When the max size is exceeded, the request will fail and the
        /// response error code will be RequestEntityTooLarge. If this occurs,
        /// the collection of ResourceFiles must be reduced in size. This can
        /// be achieved using .zip files, Application Packages, or Docker
        /// Containers.
        /// </remarks>
        [JsonProperty(PropertyName = "resourceFiles")]
        public IList<ResourceFile> ResourceFiles { get; set; }

        /// <summary>
        /// Gets or sets a list of files that the Batch service will upload
        /// from the compute node after running the command line.
        /// </summary>
        /// <remarks>
        /// For multi-instance tasks, the files will only be uploaded from the
        /// compute node on which the primary task is executed.
        /// </remarks>
        [JsonProperty(PropertyName = "outputFiles")]
        public IList<OutputFile> OutputFiles { get; set; }

        /// <summary>
        /// Gets or sets a list of environment variable settings for the task.
        /// </summary>
        [JsonProperty(PropertyName = "environmentSettings")]
        public IList<EnvironmentSetting> EnvironmentSettings { get; set; }

        /// <summary>
        /// Gets or sets a locality hint that can be used by the Batch service
        /// to select a compute node on which to start the new task.
        /// </summary>
        [JsonProperty(PropertyName = "affinityInfo")]
        public AffinityInformation AffinityInfo { get; set; }

        /// <summary>
        /// Gets or sets the execution constraints that apply to this task.
        /// </summary>
        /// <remarks>
        /// If you do not specify constraints, the maxTaskRetryCount is the
        /// maxTaskRetryCount specified for the job, the maxWallClockTime is
        /// infinite, and the retentionTime is 7 days.
        /// </remarks>
        [JsonProperty(PropertyName = "constraints")]
        public TaskConstraints Constraints { get; set; }

        /// <summary>
        /// Gets or sets the user identity under which the task runs.
        /// </summary>
        /// <remarks>
        /// If omitted, the task runs as a non-administrative user unique to
        /// the task.
        /// </remarks>
        [JsonProperty(PropertyName = "userIdentity")]
        public UserIdentity UserIdentity { get; set; }

        /// <summary>
        /// Gets or sets an object that indicates that the task is a
        /// multi-instance task, and contains information about how to run the
        /// multi-instance task.
        /// </summary>
        [JsonProperty(PropertyName = "multiInstanceSettings")]
        public MultiInstanceSettings MultiInstanceSettings { get; set; }

        /// <summary>
        /// Gets or sets the tasks that this task depends on.
        /// </summary>
        /// <remarks>
        /// This task will not be scheduled until all tasks that it depends on
        /// have completed successfully. If any of those tasks fail and exhaust
        /// their retry counts, this task will never be scheduled. If the job
        /// does not have usesTaskDependencies set to true, and this element is
        /// present, the request fails with error code
        /// TaskDependenciesNotSpecifiedOnJob.
        /// </remarks>
        [JsonProperty(PropertyName = "dependsOn")]
        public TaskDependencies DependsOn { get; set; }

        /// <summary>
        /// Gets or sets a list of application packages that the Batch service
        /// will deploy to the compute node before running the command line.
        /// </summary>
        /// <remarks>
        /// Application packages are downloaded and deployed to a shared
        /// directory, not the task working directory. Therefore, if a
        /// referenced package is already on the compute node, and is up to
        /// date, then it is not re-downloaded; the existing copy on the
        /// compute node is used. If a referenced application package cannot be
        /// installed, for example because the package has been deleted or
        /// because download failed, the task fails.
        /// </remarks>
        [JsonProperty(PropertyName = "applicationPackageReferences")]
        public IList<ApplicationPackageReference> ApplicationPackageReferences { get; set; }

        /// <summary>
        /// Gets or sets the settings for an authentication token that the task
        /// can use to perform Batch service operations.
        /// </summary>
        /// <remarks>
        /// If this property is set, the Batch service provides the task with
        /// an authentication token which can be used to authenticate Batch
        /// service operations without requiring an account access key. The
        /// token is provided via the AZ_BATCH_AUTHENTICATION_TOKEN environment
        /// variable. The operations that the task can carry out using the
        /// token depend on the settings. For example, a task can request job
        /// permissions in order to add other tasks to the job, or check the
        /// status of the job or of other tasks under the job.
        /// </remarks>
        [JsonProperty(PropertyName = "authenticationTokenSettings")]
        public AuthenticationTokenSettings AuthenticationTokenSettings { get; set; }

    }
}
