﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.AspNet.WebApi.Templates.WebApiBadHttpRequestException
{
    using Intent.SoftwareFactory.MetaModels.Class;
    using Intent.SoftwareFactory.MetaModels.Service;
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
    
    #line 1 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Templates\WebApiBadHttpRequestException\WebApiBadHttpRequestExceptionTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class WebApiBadHttpRequestExceptionTemplate : IntentRoslynProjectItemTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\nusing System;\r\nusing Intent.CodeGen;\r\n\r\n[assembly: DefaultIntentManaged(Mode.F" +
                    "ully)]\r\n\r\nnamespace ");
            
            #line 19 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Templates\WebApiBadHttpRequestException\WebApiBadHttpRequestExceptionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public class BadHttpRequestException : Exception\r\n    {\r\n        public " +
                    "BadHttpRequestException(string message) : base(message)\r\n        {\r\n            " +
                    "\r\n        }\r\n    }\r\n}");
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
