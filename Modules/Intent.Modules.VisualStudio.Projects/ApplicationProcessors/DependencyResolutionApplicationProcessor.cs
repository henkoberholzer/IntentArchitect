﻿using System.Collections.Generic;
using System.Linq;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.Plugins;
using Intent.SoftwareFactory.Templates;
using Intent.SoftwareFactory.VisualStudio;

namespace Intent.SoftwareFactory.VSProjects.ApplicationProcessors
{
    public class DependencyResolutionApplicationProcessor : ApplicationProcessorBase
    {
        public override string Id
        {
            get
            {
                return "Intent.VSProjects.DependencyResolver";
            }
        }


        public DependencyResolutionApplicationProcessor()
        {
            WhenToRun = ApplicationProcessorExecutionStep.BeforeTemplateExecution;            
        }

        public override void Run(IApplication application)
        {
            // Resolve all dependencies and events
            Logging.Log.Info($"Resolving Dependencies");


            foreach (var project in application.Projects)
            {
                project.InitializeVSMetaData();
                // 1. Identify project dependencies.
                var p = project.TemplateInstances.Select(x => new { x, deps = x.GetAllTemplateDependancies().ToList() }).Where(x => x.deps.Any()).ToList();
                var templateDependencies = project.TemplateInstances
                        .SelectMany(ti => ti.GetAllTemplateDependancies())
                        .Distinct()
                        .ToList();

                var projectDependencies =
                    templateDependencies.Select(x => project.Application.FindProjectWithTemplateInstance(x))
                        .Where(x => x != null && !x.Equals(project))
                        .Distinct()
                        .ToList();

                foreach (var projectDependency in projectDependencies)
                {
                    // 2. Add project dependencies
                    project.AddDependency(projectDependency);
                    // 3. Load nuget packages from project dependencies.
                    project.AddNugetPackages(GetTemplateNugetDependencies(projectDependency));
                }

                // 4. Load this project's nuget dependencies.
                project.AddNugetPackages(GetTemplateNugetDependencies(project));

                // 5. Load reference assembly dependencies.            
                var assemblyDependencies = project.TemplateInstances
                        .SelectMany(ti => ti.GetAllAssemblyDependencies())
                        .Distinct()
                        .ToList();

                foreach (var assemblyDependency in assemblyDependencies)
                {
                    project.AddReference(assemblyDependency);
                }
            }
        }

        private IEnumerable<INugetPackageInfo> GetTemplateNugetDependencies(IProject project)
        {
            return project.TemplateInstances
                    .SelectMany(ti => ti.GetAllNugetDependencies())
                    .Distinct()
                    .ToList();
        }
    }
}
