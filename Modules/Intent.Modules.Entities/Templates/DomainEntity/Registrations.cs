﻿using Intent.MetaModel.Domain;
using Intent.SoftwareFactory;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.Templates;
using Intent.SoftwareFactory.Templates.Registrations;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Intent.Modules.Entities.Templates.DomainEntity
{
    [Description("Intent Entity Base Template")]
    public class Registrations : ModelTemplateRegistrationBase<Class>
    {
        private IMetaDataManager _metaDataManager;

        public Registrations(IMetaDataManager metaDataManager)
        {
            _metaDataManager = metaDataManager;
        }

        public override string TemplateId
        {
            get
            {
                return DomainEntityTemplate.Identifier;
            }
        }

        public override ITemplate CreateTemplateInstance(IProject project, Class model)
        {
            return new DomainEntityTemplate(model, project);
        }

        public override IEnumerable<Class> GetModels(Intent.SoftwareFactory.Engine.IApplication application)
        {
            return _metaDataManager.GetMetaData<Class>(new MetaDataType("DomainEntity")).Where(x => x.Application.Name == application.ApplicationName).ToList();
        }
    }
}
