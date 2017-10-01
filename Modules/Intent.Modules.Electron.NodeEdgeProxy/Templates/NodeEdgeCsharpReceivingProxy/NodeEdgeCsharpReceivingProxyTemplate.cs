﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Electron.NodeEdgeProxy.Templates.NodeEdgeCsharpReceivingProxy
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
    
    #line 1 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class NodeEdgeCsharpReceivingProxyTemplate : IntentRoslynProjectItemTemplateBase<ServiceModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n\r\nusing Microsoft.Practices.Unity;\r\nusing Newtonsoft.Json;\r\nusing Newtonsoft.J" +
                    "son.Serialization;\r\nusing System;\r\nusing System.Threading.Tasks;\r\nusing Intent.C" +
                    "odeGen;\r\n");
            
            #line 20 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 24 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public class ");
            
            #line 26 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("NodeEdgeProxy\r\n    {\r\n        private readonly I");
            
            #line 28 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write(" _appService;\r\n        private readonly JsonSerializerSettings _jsonSerializerSet" +
                    "tings;\r\n\r\n        public ");
            
            #line 31 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("NodeEdgeProxy()\r\n        {\r\n            _appService = UnityConfig.GetConfiguredCo" +
                    "ntainer().Resolve<I");
            
            #line 33 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write(@">();
            _jsonSerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        }

        public async Task<object> Invoke(dynamic input)
        {
            return await Task.Factory.StartNew<object>(() =>
            {
                try
                {
                    var operationName = (string)input.operationName;
            
                    switch (operationName)
                    {
");
            
            #line 50 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"

                        // An exception gets thrown if "null" is returned, so we always wrap everthing up in an object and 
                        // then on the receiving side we always just read the "response" property. 
                        foreach(var operation in Model.Operations)
                        {

            
            #line default
            #line hidden
            this.Write("                        case nameof(");
            
            #line 56 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("):\r\n");
            
            #line 57 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"

                            if (operation != null)
                            {

            
            #line default
            #line hidden
            this.Write("                            return JsonConvert.SerializeObject(new\r\n             " +
                    "               {\r\n                                Response = (object) ");
            
            #line 63 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(JsonConvert.DeserializeObject<");
            
            #line 63 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Payload>((string)input.payload))\r\n                            }, _jsonSerializerS" +
                    "ettings);\r\n");
            
            #line 65 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"

                            }
                            else
                            {

            
            #line default
            #line hidden
            this.Write("                            ");
            
            #line 70 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(JsonConvert.DeserializeObject<");
            
            #line 70 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Payload>((string)input.payload));\r\n                            return new { Respo" +
                    "nse = (object) null };\r\n");
            
            #line 72 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"

                            } // if (operation.HasReturnType())
                        } // foreach(var operation in Model.Operations)

            
            #line default
            #line hidden
            this.Write("                        default:\r\n                            throw new Exception" +
                    "($\"Unknown operation: {operationName}\");\r\n                    }\r\n               " +
                    " }\r\n                catch (Exception e)\r\n                {");
            
            #line 81 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
 
                    // Sometimes Edge falls over with a StackOverflow exception when it tries 
                    // to send some exceptions back to the client, so we just wrap all exceptions
                    // just in case.

                    // For example, new System.IO.FileSystemWatcher("invalid path", filterCriteria);
                
            
            #line default
            #line hidden
            this.Write("                    throw new SerializableException(e.Message, e.StackTrace);\r\n  " +
                    "              }\r\n            }, TaskCreationOptions.LongRunning);\r\n        }\r\n");
            
            #line 92 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"

        foreach(var operation in Model.Operations)
        {
            Action getMethodCallParameters = () => GetOperationCallParameters(operation);

            
            #line default
            #line hidden
            this.Write("\r\n        public class ");
            
            #line 98 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Payload\r\n        {\r\n");
            
            #line 100 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"

            foreach (var parameter in operation.Parameters)
            {

            
            #line default
            #line hidden
            this.Write("            public ");
            
            #line 104 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(parameter.TypeReference)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 104 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Name));
            
            #line default
            #line hidden
            this.Write(" { get; set; }\r\n");
            
            #line 105 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"

            }

            
            #line default
            #line hidden
            this.Write("        }\r\n");
            
            #line 109 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
 
            if (operation.ReturnType != null)
            {

            
            #line default
            #line hidden
            this.Write("        private ");
            
            #line 113 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetOperationReturnType(operation)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 113 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 113 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Payload payload)\r\n        {\r\n            return _appService.");
            
            #line 115 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 115 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
 getMethodCallParameters(); 
            
            #line default
            #line hidden
            this.Write(");\r\n        }\r\n");
            
            #line 117 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"

            }
            else
            {

            
            #line default
            #line hidden
            this.Write("        private void ");
            
            #line 122 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 122 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Payload payload)\r\n        {\r\n            _appService.");
            
            #line 124 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 124 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"
 getMethodCallParameters(); 
            
            #line default
            #line hidden
            this.Write(");\r\n        }\r\n");
            
            #line 126 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\NodeEdgeCsharpReceivingProxy\NodeEdgeCsharpReceivingProxyTemplate.tt"

            }
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
