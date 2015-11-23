﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IdentityServer4.Core.Resources {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Messages() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("IdentityServer4.Core.Resources.Messages", typeof(Messages).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Client identifier is required.
        /// </summary>
        internal static string ClientIdRequired {
            get {
                return ResourceManager.GetString("ClientIdRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to There was an error logging into the external provider. The error message is: {0}.
        /// </summary>
        internal static string ExternalProviderError {
            get {
                return ResourceManager.GetString("ExternalProviderError", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The client application made an invalid request..
        /// </summary>
        internal static string invalid_request {
            get {
                return ResourceManager.GetString("invalid_request", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The client application tried to access a resource it does not have access to..
        /// </summary>
        internal static string invalid_scope {
            get {
                return ResourceManager.GetString("invalid_scope", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Invalid username or password.
        /// </summary>
        internal static string InvalidUsernameOrPassword {
            get {
                return ResourceManager.GetString("InvalidUsernameOrPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to client_id is missing.
        /// </summary>
        internal static string MissingClientId {
            get {
                return ResourceManager.GetString("MissingClientId", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Token is missing.
        /// </summary>
        internal static string MissingToken {
            get {
                return ResourceManager.GetString("MissingToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Must select at least one permission..
        /// </summary>
        internal static string MustSelectAtLeastOnePermission {
            get {
                return ResourceManager.GetString("MustSelectAtLeastOnePermission", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The external login provider was not provided..
        /// </summary>
        internal static string NoExternalProvider {
            get {
                return ResourceManager.GetString("NoExternalProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Invalid Account.
        /// </summary>
        internal static string NoMatchingExternalAccount {
            get {
                return ResourceManager.GetString("NoMatchingExternalAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to There is an error determining which application you are signing into. Return to the application and try again..
        /// </summary>
        internal static string NoSignInCookie {
            get {
                return ResourceManager.GetString("NoSignInCookie", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Error authenticating with external provider.
        /// </summary>
        internal static string NoSubjectFromExternalProvider {
            get {
                return ResourceManager.GetString("NoSubjectFromExternalProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Password is required.
        /// </summary>
        internal static string PasswordRequired {
            get {
                return ResourceManager.GetString("PasswordRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to SSL is required.
        /// </summary>
        internal static string SslRequired {
            get {
                return ResourceManager.GetString("SslRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The client application is not known or is not authorized..
        /// </summary>
        internal static string unauthorized_client {
            get {
                return ResourceManager.GetString("unauthorized_client", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to There was an unexpected error.
        /// </summary>
        internal static string UnexpectedError {
            get {
                return ResourceManager.GetString("UnexpectedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The authorization server does not support the requested response type..
        /// </summary>
        internal static string unsupported_response_type {
            get {
                return ResourceManager.GetString("unsupported_response_type", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Unsupported Media Type.
        /// </summary>
        internal static string UnsupportedMediaType {
            get {
                return ResourceManager.GetString("UnsupportedMediaType", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Username is required.
        /// </summary>
        internal static string UsernameRequired {
            get {
                return ResourceManager.GetString("UsernameRequired", resourceCulture);
            }
        }
    }
}
