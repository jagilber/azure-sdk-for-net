// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VpnSitesOperations.
    /// </summary>
    public static partial class VpnSitesOperationsExtensions
    {
            /// <summary>
            /// Retrieves the details of a VPN site.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnSite.
            /// </param>
            /// <param name='vpnSiteName'>
            /// The name of the VpnSite being retrieved.
            /// </param>
            public static VpnSite Get(this IVpnSitesOperations operations, string resourceGroupName, string vpnSiteName)
            {
                return operations.GetAsync(resourceGroupName, vpnSiteName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the details of a VPN site.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnSite.
            /// </param>
            /// <param name='vpnSiteName'>
            /// The name of the VpnSite being retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VpnSite> GetAsync(this IVpnSitesOperations operations, string resourceGroupName, string vpnSiteName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, vpnSiteName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a VpnSite resource if it doesn't exist else updates the existing
            /// VpnSite.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnSite.
            /// </param>
            /// <param name='vpnSiteName'>
            /// The name of the VpnSite being created or updated.
            /// </param>
            /// <param name='vpnSiteParameters'>
            /// Parameters supplied to create or update VpnSite.
            /// </param>
            public static VpnSite CreateOrUpdate(this IVpnSitesOperations operations, string resourceGroupName, string vpnSiteName, VpnSite vpnSiteParameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, vpnSiteName, vpnSiteParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a VpnSite resource if it doesn't exist else updates the existing
            /// VpnSite.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnSite.
            /// </param>
            /// <param name='vpnSiteName'>
            /// The name of the VpnSite being created or updated.
            /// </param>
            /// <param name='vpnSiteParameters'>
            /// Parameters supplied to create or update VpnSite.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VpnSite> CreateOrUpdateAsync(this IVpnSitesOperations operations, string resourceGroupName, string vpnSiteName, VpnSite vpnSiteParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, vpnSiteName, vpnSiteParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates VpnSite tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnSite.
            /// </param>
            /// <param name='vpnSiteName'>
            /// The name of the VpnSite being updated.
            /// </param>
            /// <param name='vpnSiteParameters'>
            /// Parameters supplied to update VpnSite tags.
            /// </param>
            public static VpnSite UpdateTags(this IVpnSitesOperations operations, string resourceGroupName, string vpnSiteName, TagsObject vpnSiteParameters)
            {
                return operations.UpdateTagsAsync(resourceGroupName, vpnSiteName, vpnSiteParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates VpnSite tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnSite.
            /// </param>
            /// <param name='vpnSiteName'>
            /// The name of the VpnSite being updated.
            /// </param>
            /// <param name='vpnSiteParameters'>
            /// Parameters supplied to update VpnSite tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VpnSite> UpdateTagsAsync(this IVpnSitesOperations operations, string resourceGroupName, string vpnSiteName, TagsObject vpnSiteParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateTagsWithHttpMessagesAsync(resourceGroupName, vpnSiteName, vpnSiteParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a VpnSite.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnSite.
            /// </param>
            /// <param name='vpnSiteName'>
            /// The name of the VpnSite being deleted.
            /// </param>
            public static void Delete(this IVpnSitesOperations operations, string resourceGroupName, string vpnSiteName)
            {
                operations.DeleteAsync(resourceGroupName, vpnSiteName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a VpnSite.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnSite.
            /// </param>
            /// <param name='vpnSiteName'>
            /// The name of the VpnSite being deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IVpnSitesOperations operations, string resourceGroupName, string vpnSiteName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, vpnSiteName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all the vpnSites in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnSite.
            /// </param>
            public static IPage<VpnSite> ListByResourceGroup(this IVpnSitesOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the vpnSites in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnSite.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VpnSite>> ListByResourceGroupAsync(this IVpnSitesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the VpnSites in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<VpnSite> List(this IVpnSitesOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the VpnSites in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VpnSite>> ListAsync(this IVpnSitesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a VpnSite resource if it doesn't exist else updates the existing
            /// VpnSite.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnSite.
            /// </param>
            /// <param name='vpnSiteName'>
            /// The name of the VpnSite being created or updated.
            /// </param>
            /// <param name='vpnSiteParameters'>
            /// Parameters supplied to create or update VpnSite.
            /// </param>
            public static VpnSite BeginCreateOrUpdate(this IVpnSitesOperations operations, string resourceGroupName, string vpnSiteName, VpnSite vpnSiteParameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, vpnSiteName, vpnSiteParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a VpnSite resource if it doesn't exist else updates the existing
            /// VpnSite.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnSite.
            /// </param>
            /// <param name='vpnSiteName'>
            /// The name of the VpnSite being created or updated.
            /// </param>
            /// <param name='vpnSiteParameters'>
            /// Parameters supplied to create or update VpnSite.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VpnSite> BeginCreateOrUpdateAsync(this IVpnSitesOperations operations, string resourceGroupName, string vpnSiteName, VpnSite vpnSiteParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, vpnSiteName, vpnSiteParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates VpnSite tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnSite.
            /// </param>
            /// <param name='vpnSiteName'>
            /// The name of the VpnSite being updated.
            /// </param>
            /// <param name='vpnSiteParameters'>
            /// Parameters supplied to update VpnSite tags.
            /// </param>
            public static VpnSite BeginUpdateTags(this IVpnSitesOperations operations, string resourceGroupName, string vpnSiteName, TagsObject vpnSiteParameters)
            {
                return operations.BeginUpdateTagsAsync(resourceGroupName, vpnSiteName, vpnSiteParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates VpnSite tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnSite.
            /// </param>
            /// <param name='vpnSiteName'>
            /// The name of the VpnSite being updated.
            /// </param>
            /// <param name='vpnSiteParameters'>
            /// Parameters supplied to update VpnSite tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VpnSite> BeginUpdateTagsAsync(this IVpnSitesOperations operations, string resourceGroupName, string vpnSiteName, TagsObject vpnSiteParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateTagsWithHttpMessagesAsync(resourceGroupName, vpnSiteName, vpnSiteParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a VpnSite.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnSite.
            /// </param>
            /// <param name='vpnSiteName'>
            /// The name of the VpnSite being deleted.
            /// </param>
            public static void BeginDelete(this IVpnSitesOperations operations, string resourceGroupName, string vpnSiteName)
            {
                operations.BeginDeleteAsync(resourceGroupName, vpnSiteName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a VpnSite.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnSite.
            /// </param>
            /// <param name='vpnSiteName'>
            /// The name of the VpnSite being deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IVpnSitesOperations operations, string resourceGroupName, string vpnSiteName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, vpnSiteName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all the vpnSites in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VpnSite> ListByResourceGroupNext(this IVpnSitesOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the vpnSites in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VpnSite>> ListByResourceGroupNextAsync(this IVpnSitesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the VpnSites in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VpnSite> ListNext(this IVpnSitesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the VpnSites in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VpnSite>> ListNextAsync(this IVpnSitesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
