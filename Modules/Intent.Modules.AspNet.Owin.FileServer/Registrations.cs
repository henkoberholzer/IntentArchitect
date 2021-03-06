﻿using Intent.Modules.AspNet.Owin.FileServer.Decorators;
using Intent.Modules.AspNet.Owin.Templates.OwinStartup;
using Intent.Modules.VisualStudio.Projects.Decorators;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.Registrations;

namespace Intent.Modules.AspNet.Owin.FileServer
{
    public class Registrations : OldProjectTemplateRegistration
    {
        public Registrations()
        {
        }

        public override void RegisterStuff(IApplication application, IMetaDataManager metaDataManager)
        {
            RegisterDecorator<IOwinStartupDecorator>(RootLocationOwinStartupDecorator.Identifier, new RootLocationOwinStartupDecorator());
            RegisterDecorator<IWebConfigDecorator>(RootLocationWebConfigDecorator.Identifier, new RootLocationWebConfigDecorator());
        }
    }
}
