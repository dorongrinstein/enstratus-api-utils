﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dell.CTO.Enstratius {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class XmlTemplates {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal XmlTemplates() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Dell.CTO.Enstratius.XmlTemplates", typeof(XmlTemplates).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to &lt;addUser&gt;&lt;users&gt;&lt;user&gt;&lt;account accountId=&quot;{accountId}&quot; /&gt;&lt;givenName&gt;{givenName}&lt;/givenName&gt;&lt;familyName&gt;{familyName}&lt;/familyName&gt;&lt;email&gt;{email}&lt;/email&gt;&lt;notificationsTargets&gt;&lt;emailTarget&gt;{emailTarget}&lt;/emailTarget&gt;&lt;/notificationsTargets&gt;&lt;notificationsSettings&gt;&lt;notificationsSetting&gt;&lt;notifyViaEmail&gt;{notifyViaEmail}&lt;/notifyViaEmail&gt;&lt;notifyViaScreen&gt;{notifyViaScreen}&lt;/notifyViaScreen&gt;&lt;eventType&gt;{eventType}&lt;/eventType&gt;&lt;severity&gt;{severity}&lt;/severity&gt;&lt;/notificationsSetting&gt;&lt;/notificationsSettings&gt;&lt;billingCodes&gt;&lt;bill [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string add_user {
            get {
                return ResourceManager.GetString("add_user", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;addDeployment&gt;
        ///  &lt;deployment budget=&quot;{budget}&quot; type=&quot;{deployment_type}&quot; &gt;
        ///    &lt;name&gt;{name}&lt;/name&gt;
        ///	&lt;description&gt;{description}&lt;/description&gt;
        ///	&lt;label&gt;{label}&lt;/label&gt;
        ///	&lt;forServiceCatalog&gt;{for_service_catalog}&lt;/forServiceCatalog&gt;
        ///	&lt;drStorageRegion regionId=&quot;{storage_region_id}&quot; /&gt;
        ///	&lt;backupWindow&gt;
        ///	 &lt;timeWindow daysOfWeek=&quot;{backup_days_of_week}&quot; startHour=&quot;{backup_start_hour}&quot; startMinute=&quot;{backup_start_minute}&quot; endHour=&quot;{backup_end_hour}&quot; endMinute=&quot;{backup_end_minute}&quot; /&gt;
        ///	&lt;/backupWindow&gt;
        ///	&lt;maintena [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string create_deployment {
            get {
                return ResourceManager.GetString("create_deployment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;deploy&gt;
        ///  &lt;deployment  /&gt;
        ///&lt;/deploy&gt;.
        /// </summary>
        internal static string launch_deployment {
            get {
                return ResourceManager.GetString("launch_deployment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;stop&gt;
        ///  &lt;deployment  /&gt;
        ///&lt;/stop&gt;.
        /// </summary>
        internal static string stop_deployment {
            get {
                return ResourceManager.GetString("stop_deployment", resourceCulture);
            }
        }
    }
}
