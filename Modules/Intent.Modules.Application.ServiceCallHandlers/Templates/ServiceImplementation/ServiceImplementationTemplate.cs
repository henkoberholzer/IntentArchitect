﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Application.ServiceCallHandlers.Templates.ServiceImplementation
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
    
    #line 1 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class ServiceImplementationTemplate : IntentRoslynProjectItemTemplateBase<IServiceModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n");
            
            #line 14 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"


            
            #line default
            #line hidden
            this.Write("\r\nusing System;\r\nusing System.Linq;\r\nusing System.Collections.Generic;\r\nusing Mic" +
                    "rosoft.Practices.Unity;\r\nusing Intent.CodeGen;\r\n");
            
            #line 22 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 26 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public class ");
            
            #line 28 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 28 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetServiceInterfaceName()));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        private readonly IUnityContainer _container;\r\n\r\n        public ");
            
            #line 32 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(IUnityContainer container)\r\n        { \r\n            _container = container;\r\n   " +
                    "     }\r\n\r\n");
            
            #line 37 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
    foreach (var o in Model.Operations)
    {


            
            #line default
            #line hidden
            this.Write("        public ");
            
            #line 40 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetOperationReturnType(o)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 40 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(o.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 40 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetOperationDefinitionParameters(o)));
            
            #line default
            #line hidden
            this.Write(")\r\n        {\r\n            var sch = _container.Resolve<");
            
            #line 42 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetHandlerClassName(o)));
            
            #line default
            #line hidden
            this.Write(">();\r\n            ");
            
            #line 43 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"

        if (o.ReturnType != null)
        {

            
            #line default
            #line hidden
            this.Write("return ");
            
            #line 46 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("sch.Handle(");
            
            #line 48 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetOperationCallParameters(o)));
            
            #line default
            #line hidden
            this.Write(");\r\n        }\r\n\r\n");
            
            #line 51 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
        
    }

            
            #line default
            #line hidden
            this.Write("\r\n        #region IDisposable Members\r\n\r\n        public void Dispose()\r\n        {" +
                    "\r\n            //dispose all resources\r\n        }\r\n\r\n        #endregion\r\n    }\r\n}" +
                    "");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
