﻿using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.MetaModels.UMLModel;
using Intent.SoftwareFactory.Templates;
using Intent.SoftwareFactory.VisualStudio;
using System.Collections.Generic;
using System.Linq;

namespace Intent.Modules.RichDomain.Templates.EntityStateInterface
{
    partial class DomainEntityStateInterfaceTemplate : IntentRoslynProjectItemTemplateBase<Class>, ITemplate, IHasNugetDependencies, IHasDecorators<IDomainEntityStateInterfaceTemplateDecorator>
    {
        public const string Identifier = "Intent.RichDomain.EntityStateInterface";
        private IEnumerable<IDomainEntityStateInterfaceTemplateDecorator> _decorators;

        public DomainEntityStateInterfaceTemplate(Class model, IProject project)
            : base(Identifier, project, model)
        {
        }

        public override IEnumerable<INugetPackageInfo> GetNugetDependencies()
        {
            return new[]
            {
                NugetPackages.IntentFrameworkDomain,
            }
            .Union(base.GetNugetDependencies())
            .ToArray();
        }

        public override RoslynMergeConfig ConfigureRoslynMerger()
        {
            return new RoslynMergeConfig(new TemplateMetaData(Id, "1.0"));
        }

        protected override RoslynDefaultFileMetaData DefineRoslynDefaultFileMetaData()
        {
            return new RoslynDefaultFileMetaData(
                overwriteBehaviour: OverwriteBehaviour.Always,
                fileName: $"{Model.Name}Interfaces",
                fileExtension: "cs",
                defaultLocationInProject: "Generated\\StateInterfaces",
                className: "I${Model.Name}",
                @namespace: "${Project.ProjectName}"
            );
        }

        public IEnumerable<IDomainEntityStateInterfaceTemplateDecorator> GetDecorators()
        {
            return _decorators ?? (_decorators = Project.ResolveDecorators(this));
        }

        public string InterfaceProperties(Class @class)
        {
            return GetDecorators().Aggregate(x => x.InterfaceProperties(@class));
        }

        public string ImplementationPartialProperties(Class @class, string readOnlyInterfaceName)
        {
            return GetDecorators().Aggregate(x => x.ImplementationPartialProperties(@class, readOnlyInterfaceName));
        }
    }

    public interface IDomainEntityStateInterfaceTemplateDecorator : ITemplateDecorator
    {
        string[] InterfaceProperties(Class @class);
        string[] ImplementationPartialProperties(Class @class, string readOnlyInterfaceName);
    }
}
