﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 09/11/2021 14:00:59
namespace Terrasoft.Configuration.OData
{
    /// <summary>
    /// There are no comments for VwSysEntitySchemaInPackageSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("VwSysEntitySchemaInPackageSingle")]
    public partial class VwSysEntitySchemaInPackageSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VwSysEntitySchemaInPackage>
    {
        /// <summary>
        /// Initialize a new VwSysEntitySchemaInPackageSingle object.
        /// </summary>
        public VwSysEntitySchemaInPackageSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VwSysEntitySchemaInPackageSingle object.
        /// </summary>
        public VwSysEntitySchemaInPackageSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VwSysEntitySchemaInPackageSingle object.
        /// </summary>
        public VwSysEntitySchemaInPackageSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VwSysEntitySchemaInPackage> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CreatedBy")]
        public virtual global::Terrasoft.Configuration.OData.ContactSingle CreatedBy
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CreatedBy == null))
                {
                    this._CreatedBy = new global::Terrasoft.Configuration.OData.ContactSingle(this.Context, GetPath("CreatedBy"));
                }
                return this._CreatedBy;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.ContactSingle _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ModifiedBy")]
        public virtual global::Terrasoft.Configuration.OData.ContactSingle ModifiedBy
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ModifiedBy == null))
                {
                    this._ModifiedBy = new global::Terrasoft.Configuration.OData.ContactSingle(this.Context, GetPath("ModifiedBy"));
                }
                return this._ModifiedBy;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.ContactSingle _ModifiedBy;
        /// <summary>
        /// There are no comments for Parent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Parent")]
        public virtual global::Terrasoft.Configuration.OData.VwSysSchemaInPackageSingle Parent
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Parent == null))
                {
                    this._Parent = new global::Terrasoft.Configuration.OData.VwSysSchemaInPackageSingle(this.Context, GetPath("Parent"));
                }
                return this._Parent;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.VwSysSchemaInPackageSingle _Parent;
        /// <summary>
        /// There are no comments for SysWorkspace in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SysWorkspace")]
        public virtual global::Terrasoft.Configuration.OData.SysWorkspaceSingle SysWorkspace
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SysWorkspace == null))
                {
                    this._SysWorkspace = new global::Terrasoft.Configuration.OData.SysWorkspaceSingle(this.Context, GetPath("SysWorkspace"));
                }
                return this._SysWorkspace;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.SysWorkspaceSingle _SysWorkspace;
        /// <summary>
        /// There are no comments for SysPackage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SysPackage")]
        public virtual global::Terrasoft.Configuration.OData.SysPackageSingle SysPackage
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SysPackage == null))
                {
                    this._SysPackage = new global::Terrasoft.Configuration.OData.SysPackageSingle(this.Context, GetPath("SysPackage"));
                }
                return this._SysPackage;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.SysPackageSingle _SysPackage;
    }
    /// <summary>
    /// There are no comments for VwSysEntitySchemaInPackage in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("VwSysEntitySchemaInPackage")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("VwSysEntitySchemaInPackage")]
    public partial class VwSysEntitySchemaInPackage : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VwSysEntitySchemaInPackage object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="caption">Initial value of Caption.</param>
        /// <param name="managerName">Initial value of ManagerName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VwSysEntitySchemaInPackage CreateVwSysEntitySchemaInPackage(string name, string caption, string managerName)
        {
            VwSysEntitySchemaInPackage vwSysEntitySchemaInPackage = new VwSysEntitySchemaInPackage();
            vwSysEntitySchemaInPackage.Name = name;
            vwSysEntitySchemaInPackage.Caption = caption;
            vwSysEntitySchemaInPackage.ManagerName = managerName;
            return vwSysEntitySchemaInPackage;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Id")]
        public virtual global::System.Nullable<global::System.Guid> Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _Id;
        partial void OnIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property CreatedOn in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreatedOn")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> CreatedOn
        {
            get
            {
                return this._CreatedOn;
            }
            set
            {
                this.OnCreatedOnChanging(value);
                this._CreatedOn = value;
                this.OnCreatedOnChanged();
                this.OnPropertyChanged("CreatedOn");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _CreatedOn;
        partial void OnCreatedOnChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnCreatedOnChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreatedById")]
        public virtual global::System.Nullable<global::System.Guid> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property ModifiedOn in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ModifiedOn")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> ModifiedOn
        {
            get
            {
                return this._ModifiedOn;
            }
            set
            {
                this.OnModifiedOnChanging(value);
                this._ModifiedOn = value;
                this.OnModifiedOnChanged();
                this.OnPropertyChanged("ModifiedOn");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _ModifiedOn;
        partial void OnModifiedOnChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnModifiedOnChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ModifiedById")]
        public virtual global::System.Nullable<global::System.Guid> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property ProcessListeners in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProcessListeners")]
        public virtual global::System.Nullable<int> ProcessListeners
        {
            get
            {
                return this._ProcessListeners;
            }
            set
            {
                this.OnProcessListenersChanging(value);
                this._ProcessListeners = value;
                this.OnProcessListenersChanged();
                this.OnPropertyChanged("ProcessListeners");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _ProcessListeners;
        partial void OnProcessListenersChanging(global::System.Nullable<int> value);
        partial void OnProcessListenersChanged();
        /// <summary>
        /// There are no comments for Property UId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UId")]
        public virtual global::System.Nullable<global::System.Guid> UId
        {
            get
            {
                return this._UId;
            }
            set
            {
                this.OnUIdChanging(value);
                this._UId = value;
                this.OnUIdChanged();
                this.OnPropertyChanged("UId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _UId;
        partial void OnUIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnUIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Name is required.")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Caption in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Caption")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Caption is required.")]
        public virtual string Caption
        {
            get
            {
                return this._Caption;
            }
            set
            {
                this.OnCaptionChanging(value);
                this._Caption = value;
                this.OnCaptionChanged();
                this.OnPropertyChanged("Caption");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Caption;
        partial void OnCaptionChanging(string value);
        partial void OnCaptionChanged();
        /// <summary>
        /// There are no comments for Property ManagerName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ManagerName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ManagerName is required.")]
        public virtual string ManagerName
        {
            get
            {
                return this._ManagerName;
            }
            set
            {
                this.OnManagerNameChanging(value);
                this._ManagerName = value;
                this.OnManagerNameChanged();
                this.OnPropertyChanged("ManagerName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ManagerName;
        partial void OnManagerNameChanging(string value);
        partial void OnManagerNameChanged();
        /// <summary>
        /// There are no comments for Property ParentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ParentId")]
        public virtual global::System.Nullable<global::System.Guid> ParentId
        {
            get
            {
                return this._ParentId;
            }
            set
            {
                this.OnParentIdChanging(value);
                this._ParentId = value;
                this.OnParentIdChanged();
                this.OnPropertyChanged("ParentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _ParentId;
        partial void OnParentIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnParentIdChanged();
        /// <summary>
        /// There are no comments for Property SysWorkspaceId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysWorkspaceId")]
        public virtual global::System.Nullable<global::System.Guid> SysWorkspaceId
        {
            get
            {
                return this._SysWorkspaceId;
            }
            set
            {
                this.OnSysWorkspaceIdChanging(value);
                this._SysWorkspaceId = value;
                this.OnSysWorkspaceIdChanged();
                this.OnPropertyChanged("SysWorkspaceId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _SysWorkspaceId;
        partial void OnSysWorkspaceIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnSysWorkspaceIdChanged();
        /// <summary>
        /// There are no comments for Property SysPackageId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysPackageId")]
        public virtual global::System.Nullable<global::System.Guid> SysPackageId
        {
            get
            {
                return this._SysPackageId;
            }
            set
            {
                this.OnSysPackageIdChanging(value);
                this._SysPackageId = value;
                this.OnSysPackageIdChanged();
                this.OnPropertyChanged("SysPackageId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _SysPackageId;
        partial void OnSysPackageIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnSysPackageIdChanged();
        /// <summary>
        /// There are no comments for Property SysPackageUId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysPackageUId")]
        public virtual global::System.Nullable<global::System.Guid> SysPackageUId
        {
            get
            {
                return this._SysPackageUId;
            }
            set
            {
                this.OnSysPackageUIdChanging(value);
                this._SysPackageUId = value;
                this.OnSysPackageUIdChanged();
                this.OnPropertyChanged("SysPackageUId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _SysPackageUId;
        partial void OnSysPackageUIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnSysPackageUIdChanged();
        /// <summary>
        /// There are no comments for Property SysPackageLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysPackageLevel")]
        public virtual global::System.Nullable<int> SysPackageLevel
        {
            get
            {
                return this._SysPackageLevel;
            }
            set
            {
                this.OnSysPackageLevelChanging(value);
                this._SysPackageLevel = value;
                this.OnSysPackageLevelChanged();
                this.OnPropertyChanged("SysPackageLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _SysPackageLevel;
        partial void OnSysPackageLevelChanging(global::System.Nullable<int> value);
        partial void OnSysPackageLevelChanged();
        /// <summary>
        /// There are no comments for Property IsVirtual in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsVirtual")]
        public virtual global::System.Nullable<bool> IsVirtual
        {
            get
            {
                return this._IsVirtual;
            }
            set
            {
                this.OnIsVirtualChanging(value);
                this._IsVirtual = value;
                this.OnIsVirtualChanged();
                this.OnPropertyChanged("IsVirtual");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _IsVirtual;
        partial void OnIsVirtualChanging(global::System.Nullable<bool> value);
        partial void OnIsVirtualChanged();
        /// <summary>
        /// There are no comments for Property ExtendParent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExtendParent")]
        public virtual global::System.Nullable<bool> ExtendParent
        {
            get
            {
                return this._ExtendParent;
            }
            set
            {
                this.OnExtendParentChanging(value);
                this._ExtendParent = value;
                this.OnExtendParentChanged();
                this.OnPropertyChanged("ExtendParent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _ExtendParent;
        partial void OnExtendParentChanging(global::System.Nullable<bool> value);
        partial void OnExtendParentChanged();
        /// <summary>
        /// There are no comments for Property CreatedBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreatedBy")]
        public virtual global::Terrasoft.Configuration.OData.Contact CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this.OnCreatedByChanging(value);
                this._CreatedBy = value;
                this.OnCreatedByChanged();
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.Contact _CreatedBy;
        partial void OnCreatedByChanging(global::Terrasoft.Configuration.OData.Contact value);
        partial void OnCreatedByChanged();
        /// <summary>
        /// There are no comments for Property ModifiedBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ModifiedBy")]
        public virtual global::Terrasoft.Configuration.OData.Contact ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this.OnModifiedByChanging(value);
                this._ModifiedBy = value;
                this.OnModifiedByChanged();
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.Contact _ModifiedBy;
        partial void OnModifiedByChanging(global::Terrasoft.Configuration.OData.Contact value);
        partial void OnModifiedByChanged();
        /// <summary>
        /// There are no comments for Property Parent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Parent")]
        public virtual global::Terrasoft.Configuration.OData.VwSysSchemaInPackage Parent
        {
            get
            {
                return this._Parent;
            }
            set
            {
                this.OnParentChanging(value);
                this._Parent = value;
                this.OnParentChanged();
                this.OnPropertyChanged("Parent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.VwSysSchemaInPackage _Parent;
        partial void OnParentChanging(global::Terrasoft.Configuration.OData.VwSysSchemaInPackage value);
        partial void OnParentChanged();
        /// <summary>
        /// There are no comments for Property SysWorkspace in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysWorkspace")]
        public virtual global::Terrasoft.Configuration.OData.SysWorkspace SysWorkspace
        {
            get
            {
                return this._SysWorkspace;
            }
            set
            {
                this.OnSysWorkspaceChanging(value);
                this._SysWorkspace = value;
                this.OnSysWorkspaceChanged();
                this.OnPropertyChanged("SysWorkspace");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.SysWorkspace _SysWorkspace;
        partial void OnSysWorkspaceChanging(global::Terrasoft.Configuration.OData.SysWorkspace value);
        partial void OnSysWorkspaceChanged();
        /// <summary>
        /// There are no comments for Property SysPackage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysPackage")]
        public virtual global::Terrasoft.Configuration.OData.SysPackage SysPackage
        {
            get
            {
                return this._SysPackage;
            }
            set
            {
                this.OnSysPackageChanging(value);
                this._SysPackage = value;
                this.OnSysPackageChanged();
                this.OnPropertyChanged("SysPackage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.SysPackage _SysPackage;
        partial void OnSysPackageChanging(global::Terrasoft.Configuration.OData.SysPackage value);
        partial void OnSysPackageChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
