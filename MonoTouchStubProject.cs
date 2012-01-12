using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.Shell.Flavor;

//see http://mgolchin.blogspot.com/2009/07/project-subtypes.html

namespace NA.MonoTouchStubProject
{
    class MonoTouchStubProject : ProjectNode
    {
        #region [ Constructors ]

        public MonoTouchStubProject(MonoTouchStubProjectPackage package) : base(package) { }

        #endregion
    }
}
