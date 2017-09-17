﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.IdentityServer.Templates.Clients
{
    using Intent.SoftwareFactory.Templates;
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.IdentityServer\Templates\Clients\IdentityServerClientsTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class IdentityServerClientsTemplate : IntentRoslynProjectItemTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n");
            
            #line 13 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.IdentityServer\Templates\Clients\IdentityServerClientsTemplate.tt"




            
            #line default
            #line hidden
            this.Write("using System.Collections.Generic;\r\nusing IdentityServer3.Core.Models;\r\nusing Inte" +
                    "nt.CodeGen;\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 23 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.IdentityServer\Templates\Clients\IdentityServerClientsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public static class Clients\r\n    {\r\n        public static List<Client> G" +
                    "et()\r\n        {\r\n            return new List<Client>\r\n            {\r\n");
            
            #line 31 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.IdentityServer\Templates\Clients\IdentityServerClientsTemplate.tt"
    foreach(var application in Applications)
    {
            
            #line default
            #line hidden
            this.Write("                new Client\r\n                {\r\n                    Enabled = true" +
                    ",\r\n                    ClientName = \"");
            
            #line 36 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.IdentityServer\Templates\Clients\IdentityServerClientsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(application.ApplicationName));
            
            #line default
            #line hidden
            this.Write("\",\r\n                    ClientId = \"");
            
            #line 37 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.IdentityServer\Templates\Clients\IdentityServerClientsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(application.ApplicationName));
            
            #line default
            #line hidden
            this.Write("\",\r\n\r\n                    Flow = Flows.");
            
            #line 39 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.IdentityServer\Templates\Clients\IdentityServerClientsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(application.AuthenticationType));
            
            #line default
            #line hidden
            this.Write(",\r\n\r\n                    AllowedCorsOrigins = new List<string>\r\n                 " +
                    "   {\r\n                        \"");
            
            #line 43 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.IdentityServer\Templates\Clients\IdentityServerClientsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(application.ApplicationUrl));
            
            #line default
            #line hidden
            this.Write("\"\r\n                    },\r\n\r\n                    RedirectUris = new List<string>\r" +
                    "\n                    {\r\n                        \"");
            
            #line 48 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.IdentityServer\Templates\Clients\IdentityServerClientsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(application.ApplicationUrl));
            
            #line default
            #line hidden
            this.Write("/#/login-callback/\",\r\n                        \"");
            
            #line 49 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.IdentityServer\Templates\Clients\IdentityServerClientsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(application.ApplicationUrl));
            
            #line default
            #line hidden
            this.Write("/App/Auth/RenewToken/SilentRenew.html\"\r\n                    },\r\n\r\n               " +
                    "     RequireConsent = false,\r\n                    AllowAccessToAllScopes = true\r" +
                    "\n                },\r\n");
            
            #line 55 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.IdentityServer\Templates\Clients\IdentityServerClientsTemplate.tt"
    } 
            
            #line default
            #line hidden
            this.Write("            };\r\n        }\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
        private global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost hostValue;
        /// <summary>
        /// The current host for the text templating engine
        /// </summary>
        public virtual global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost Host
        {
            get
            {
                return this.hostValue;
            }
            set
            {
                this.hostValue = value;
            }
        }
    }
    
    #line default
    #line hidden
}
