using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.Shell.Flavor;
using System.Runtime.InteropServices;

//see http://mgolchin.blogspot.com/2009/07/project-subtypes.html

namespace NA.MonoTouchStubProject
{
    [Guid(GuidList.guidMonoTouchStubProjectString)]
    internal sealed class MonoTouchStubProjectFactory : FlavoredProjectFactoryBase
    {
        private MonoTouchStubProjectPackage package_;
        #region [ Constructors ]
        public MonoTouchStubProjectFactory(MonoTouchStubProjectPackage package)
        {
            if(package == null)
                throw new ArgumentNullException("missing package on factory creation");
            this.package_ = package;
        }
        #endregion
        #region [ Overridden Members ]
        protected override object PreCreateForOuter(IntPtr outerProjectIUnknown)
        {
            return new MonoTouchStubProject(this.package_);
        }
        #endregion
    }
}
