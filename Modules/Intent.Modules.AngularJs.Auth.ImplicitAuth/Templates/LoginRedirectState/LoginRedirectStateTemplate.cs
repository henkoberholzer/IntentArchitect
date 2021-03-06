﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.AngularJs.Auth.ImplicitAuth.Templates.LoginRedirectState
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
    
    #line 1 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.Auth.ImplicitAuth\Templates\LoginRedirectState\LoginRedirectStateTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class LoginRedirectStateTemplate : IntentProjectItemTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n");
            
            #line 13 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.Auth.ImplicitAuth\Templates\LoginRedirectState\LoginRedirectStateTemplate.tt"




            
            #line default
            #line hidden
            this.Write(@"'use strict';
namespace App.Auth {
    export class LoginRedirectState implements ng.ui.IState {
        url = ""/login-redirect"";
        data = {
            allowAnonymous: true
        };
        templateUrl = ""/App/Auth/LoginRedirect/LoginRedirect.html"";
        resolve = {
            viewModel: [() => { return {}; }
            ]
        };
        controller = [
            ""$scope"", ""viewModel"", ""OidcTokenManager"", ($scope: ng.IScope, viewModel: any, tokenManager: Oidc.OidcTokenManager) => {
                (<any>$scope).vm = viewModel;
                if (!tokenManager.expired)
                    return;

                tokenManager.redirectForToken()
                    .then(success => {
                    },
                    error => {
                        $scope.$apply(() => {
                            viewModel.errors = (error && error.message) ? error.message : error;
                            console.debug(error);
                        });
                    });
            }
        ];
    }
}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
