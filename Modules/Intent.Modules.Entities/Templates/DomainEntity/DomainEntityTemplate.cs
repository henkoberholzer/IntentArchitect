﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Packages.Entities.Templates.DomainEntity
{
    using Intent.MetaModel.Domain;
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
    
    #line 1 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class DomainEntityTemplate : Intent.SoftwareFactory.Templates.IntentRoslynProjectItemTemplateBase<IClass>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing Intent.Framework.Domain; " +
                    "\r\nusing Intent.Framework.Core;\r\nusing Intent.CodeGen;\r\n");
            
            #line 18 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 22 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n");
            
            #line 24 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassAnnotations(Model)));
            
            #line default
            #line hidden
            this.Write("\r\n    public ");
            
            #line 25 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.IsAbstract ? "abstract " : ""));
            
            #line default
            #line hidden
            this.Write("partial class ");
            
            #line 25 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 25 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetBaseClass(Model)));
            
            #line default
            #line hidden
            this.Write(", I");
            
            #line 25 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            
            #line 25 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetInterfaces(Model)));
            
            #line default
            #line hidden
            this.Write("\r\n    {");
            
            #line 26 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ConstructorAnnotations(Model)));
            
            #line default
            #line hidden
            this.Write("\r\n\t\tpublic ");
            
            #line 27 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 27 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ConstructorParameters(Model)));
            
            #line default
            #line hidden
            this.Write(") \r\n\t\t{\r\n");
            
            #line 29 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ConstructorBody(Model)));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t}\r\n");
            
            #line 31 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassOtherConstructors(Model)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 32 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
  foreach (var attribute in Model.Attributes)
    {

            
            #line default
            #line hidden
            
            #line 35 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PropertyFieldAnnotations(attribute)));
            
            #line default
            #line hidden
            this.Write("\r\n        private ");
            
            #line 36 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Type(GetDecorators())));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 36 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPrivateMember()));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 37 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PropertyAnnotations(attribute)));
            
            #line default
            #line hidden
            this.Write("\r\n        public ");
            
            #line 38 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Type(GetDecorators())));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 38 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(" \r\n        {\r\n            get { return ");
            
            #line 40 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPrivateMember()));
            
            #line default
            #line hidden
            this.Write("; }\r\n            set\r\n            {\r\n");
            
            #line 43 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PropertySetterBefore(attribute)));
            
            #line default
            #line hidden
            
            #line 43 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
		
		if (attribute.Type.Name == "date")
		{
			if (!attribute.IsNullable)
			{
            
            #line default
            #line hidden
            this.Write("                ");
            
            #line 48 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPrivateMember()));
            
            #line default
            #line hidden
            this.Write(" = value.Date;\r\n");
            
            #line 49 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
			}
			else
			{
            
            #line default
            #line hidden
            this.Write("                ");
            
            #line 52 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPrivateMember()));
            
            #line default
            #line hidden
            this.Write(" = (value == null) ? value : value.Value.Date;\r\n");
            
            #line 53 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
			}
		}
		else
		{
            
            #line default
            #line hidden
            this.Write("                ");
            
            #line 57 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPrivateMember()));
            
            #line default
            #line hidden
            this.Write(" = value;\r\n");
            
            #line 58 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
		}

            
            #line default
            #line hidden
            
            #line 59 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PropertySetterAfter(attribute)));
            
            #line default
            #line hidden
            this.Write("            }\r\n        }\r\n");
            
            #line 61 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
  }
	foreach (var associatedClass in Model.AssociatedClasses)
    {

            
            #line default
            #line hidden
            
            #line 64 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
 	
		if (!associatedClass.IsNavigable) 
		{
			continue;
        }

            
            #line default
            #line hidden
            this.Write("\t\tprivate ");
            
            #line 70 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associatedClass.Type()));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 70 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associatedClass.Name().ToPrivateMember()));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 71 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PropertyAnnotations(associatedClass)));
            
            #line default
            #line hidden
            this.Write("\r\n        public virtual ");
            
            #line 72 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associatedClass.Type()));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 72 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associatedClass.Name().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("\r\n        {\r\n            get\r\n            {\r\n");
            
            #line 76 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
		string associatedClassReturn;
		if (associatedClass.Multiplicity == Multiplicity.Many)
		{
			associatedClassReturn = String.Format("{0} ?? ({0} = new List<{1}>())", associatedClass.Name().ToPrivateMember(), associatedClass.Class.Name + "");
		}
		else
		{
			associatedClassReturn = associatedClass.Name().ToPrivateMember();
		}

            
            #line default
            #line hidden
            this.Write("                return ");
            
            #line 86 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associatedClassReturn));
            
            #line default
            #line hidden
            this.Write(";\r\n            }\r\n            set\r\n            {    \r\n                ");
            
            #line 90 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associatedClass.Name().ToPrivateMember()));
            
            #line default
            #line hidden
            this.Write(" = value;\r\n            }\r\n        }\r\n");
            
            #line 93 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
    }
            
            #line default
            #line hidden
            this.Write("    }\r\n}\r\n");
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