﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Packages.Application.Contracts.Templates.ServiceContract
{
    using Intent.SoftwareFactory.Templates;
    using Intent.MetaModel.Service;
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Application.Contracts\Templates\ServiceContract\ServiceContractTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class ServiceContractTemplate : Intent.SoftwareFactory.Templates.IntentRoslynProjectItemTemplateBase<ServiceModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n");
            
            #line 14 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Application.Contracts\Templates\ServiceContract\ServiceContractTemplate.tt"


            
            #line default
            #line hidden
            this.Write("\r\nusing System;\r\nusing System.Collections.Generic;\r\nusing Intent.CodeGen;\r\n");
            
            #line 20 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Application.Contracts\Templates\ServiceContract\ServiceContractTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 24 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Application.Contracts\Templates\ServiceContract\ServiceContractTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public interface ");
            
            #line 26 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Application.Contracts\Templates\ServiceContract\ServiceContractTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : IDisposable\r\n    {\r\n");
            
            #line 28 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Application.Contracts\Templates\ServiceContract\ServiceContractTemplate.tt"

    foreach (var o in Model.Operations)
    {

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 31 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Application.Contracts\Templates\ServiceContract\ServiceContractTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetOperationReturnType(o)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 31 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Application.Contracts\Templates\ServiceContract\ServiceContractTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(o.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 31 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Application.Contracts\Templates\ServiceContract\ServiceContractTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetOperationDefinitionParameters(o)));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 32 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Application.Contracts\Templates\ServiceContract\ServiceContractTemplate.tt"
        
    }

            
            #line default
            #line hidden
            this.Write("    }\r\n}");
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