using System;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Flavor;
using Microsoft.VisualStudio.Shell.Interop;

//see http://mgolchin.blogspot.com/2009/07/project-subtypes.html

internal abstract class ProjectNode : FlavoredProjectBase
{

    #region [ Local Fields ]

    private Package package_;
    private string location_, name_;

    #endregion

    #region [ Constructors ]

    protected ProjectNode(Package package)
    {
        if (package == null)
            throw new ArgumentNullException("package missing");

        this.package_ = package;
    }

    #endregion

    #region [ Protected Virtual Properties ]

    protected virtual Package Package
    {
        get { return this.package_; }
    }

    protected virtual string Location
    {
        get { return this.location_; }
    }

    public virtual string Name
    {
        get { return this.name_; }
    }

    #endregion

    #region [ Overriden Members ]

    protected override void SetInnerProject(IntPtr innerIUnknown)
    {
        if (this.serviceProvider == null)
            this.serviceProvider = this.package_;

        base.SetInnerProject(innerIUnknown);
    }

    protected override void InitializeForOuter(string fileName, string location, string name, uint flags, ref Guid guidProject, out bool cancel)
    {
        this.location_ = location;
        this.name_ = name;

        base.InitializeForOuter(fileName, location, name, flags, ref guidProject, out cancel);
    }

    #endregion

}