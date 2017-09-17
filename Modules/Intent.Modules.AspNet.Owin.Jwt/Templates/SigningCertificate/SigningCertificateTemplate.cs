﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.AspNet.Owin.Jwt.Templates.SigningCertificate
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
    
    #line 1 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.Owin.Jwt\Templates\SigningCertificate\SigningCertificateTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class SigningCertificateTemplate : IntentRoslynProjectItemTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\nusing System;\r\nusing System.IO;\r\nusing System.Security.Cryptography.X509Certif" +
                    "icates;\r\nusing Intent.CodeGen;\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n" +
                    "\r\nnamespace ");
            
            #line 20 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.Owin.Jwt\Templates\SigningCertificate\SigningCertificateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    static class SigningCertificate\r\n    {\r\n        public static X509Certif" +
                    "icate2 GetFromX509Store(string findType, string findValue, StoreName storeName =" +
                    " StoreName.My, StoreLocation storeLocation = StoreLocation.LocalMachine)\r\n      " +
                    "  {\r\n            X509FindType parsedFindType;\r\n            if (!Enum.TryParse(fi" +
                    "ndType, out parsedFindType))\r\n            {\r\n                throw new Exception" +
                    "($\"Could not parse string \'{findType}\' as {nameof(X509FindType)}.\");\r\n          " +
                    "  }\r\n\r\n            return GetFromX509Store(\r\n                findValue: findValu" +
                    "e,\r\n                findType: parsedFindType,\r\n                storeName: storeN" +
                    "ame,\r\n                storeLocation: storeLocation);\r\n        }\r\n\r\n        publi" +
                    "c static X509Certificate2 GetFromX509Store(X509FindType findType, string findVal" +
                    "ue, StoreName storeName = StoreName.My, StoreLocation storeLocation = StoreLocat" +
                    "ion.LocalMachine)\r\n        {\r\n            var store = new X509Store(storeName, s" +
                    "toreLocation);\r\n            store.Open(OpenFlags.ReadOnly);\r\n\r\n            var c" +
                    "erts = store.Certificates.Find(findType, findValue, true);\r\n            store.Cl" +
                    "ose();\r\n\r\n            if (certs.Count == 0)\r\n            {\r\n                thro" +
                    "w new Exception($\"Could not find any matching certificate:\\n\" +\r\n               " +
                    "                     $\"    {nameof(findValue)} = {findValue}\\n\" +\r\n             " +
                    "                       $\"    {nameof(findType)} = {findType}\\n\" +\r\n             " +
                    "                       $\"    {nameof(storeName)} = {storeName}\\n\" +\r\n           " +
                    "                         $\"    {nameof(storeLocation)} = {storeLocation}\");\r\n   " +
                    "         }\r\n\r\n            if (certs.Count > 1)\r\n            {\r\n                t" +
                    "hrow new Exception($\"Found more than one matching certificate:\\n\" +\r\n           " +
                    "                         $\"    {nameof(findValue)} = {findValue}\\n\" +\r\n         " +
                    "                           $\"    {nameof(findType)} = {findType}\\n\" +\r\n         " +
                    "                           $\"    {nameof(storeName)} = {storeName}\\n\" +\r\n       " +
                    "                             $\"    {nameof(storeLocation)} = {storeLocation}\");\r" +
                    "\n            }\r\n\r\n            return certs[0];\r\n        }\r\n\r\n        public stat" +
                    "ic X509Certificate2 GetEmbeddedCertificate(string resourceName, string password)" +
                    "\r\n        {\r\n            var assembly = typeof(SigningCertificate).Assembly;\r\n  " +
                    "          using (var stream = assembly.GetManifestResourceStream(resourceName))\r" +
                    "\n            {\r\n                return new X509Certificate2(ReadStream(stream), " +
                    "password);\r\n            }\r\n        }\r\n\r\n        private static byte[] ReadStream" +
                    "(Stream input)\r\n        {\r\n            byte[] buffer = new byte[16 * 1024];\r\n   " +
                    "         using (MemoryStream ms = new MemoryStream())\r\n            {\r\n          " +
                    "      int read;\r\n                while ((read = input.Read(buffer, 0, buffer.Len" +
                    "gth)) > 0)\r\n                {\r\n                    ms.Write(buffer, 0, read);\r\n " +
                    "               }\r\n                return ms.ToArray();\r\n            }\r\n        }" +
                    "\r\n    }\r\n}");
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
