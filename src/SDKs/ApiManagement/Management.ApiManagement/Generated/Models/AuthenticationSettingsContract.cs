// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// API Authentication Settings.
    /// </summary>
    public partial class AuthenticationSettingsContract
    {
        /// <summary>
        /// Initializes a new instance of the AuthenticationSettingsContract
        /// class.
        /// </summary>
        public AuthenticationSettingsContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AuthenticationSettingsContract
        /// class.
        /// </summary>
        /// <param name="oAuth2">OAuth2 Authentication settings</param>
        /// <param name="openid">OpenID Connect Authentication Settings</param>
        /// <param name="subscriptionKeyRequired">Specifies whether
        /// subscription key is required during call to this API, true - API is
        /// included into closed products only, false - API is included into
        /// open products alone, null - there is a mix of products.</param>
        public AuthenticationSettingsContract(OAuth2AuthenticationSettingsContract oAuth2 = default(OAuth2AuthenticationSettingsContract), OpenIdAuthenticationSettingsContract openid = default(OpenIdAuthenticationSettingsContract), bool? subscriptionKeyRequired = default(bool?))
        {
            OAuth2 = oAuth2;
            Openid = openid;
            SubscriptionKeyRequired = subscriptionKeyRequired;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets oAuth2 Authentication settings
        /// </summary>
        [JsonProperty(PropertyName = "oAuth2")]
        public OAuth2AuthenticationSettingsContract OAuth2 { get; set; }

        /// <summary>
        /// Gets or sets openID Connect Authentication Settings
        /// </summary>
        [JsonProperty(PropertyName = "openid")]
        public OpenIdAuthenticationSettingsContract Openid { get; set; }

        /// <summary>
        /// Gets or sets specifies whether subscription key is required during
        /// call to this API, true - API is included into closed products only,
        /// false - API is included into open products alone, null - there is a
        /// mix of products.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionKeyRequired")]
        public bool? SubscriptionKeyRequired { get; set; }

    }
}
