//------------------------------------------------------------------------------
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
    /// There are no comments for SysLookupFolderSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SysLookupFolderSingle")]
    public partial class SysLookupFolderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SysLookupFolder>
    {
        /// <summary>
        /// Initialize a new SysLookupFolderSingle object.
        /// </summary>
        public SysLookupFolderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SysLookupFolderSingle object.
        /// </summary>
        public SysLookupFolderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SysLookupFolderSingle object.
        /// </summary>
        public SysLookupFolderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SysLookupFolder> query)
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
        public virtual global::Terrasoft.Configuration.OData.SysLookupFolderSingle Parent
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Parent == null))
                {
                    this._Parent = new global::Terrasoft.Configuration.OData.SysLookupFolderSingle(this.Context, GetPath("Parent"));
                }
                return this._Parent;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.SysLookupFolderSingle _Parent;
        /// <summary>
        /// There are no comments for SysLookupFolderCollectionByParent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SysLookupFolderCollectionByParent")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.SysLookupFolder> SysLookupFolderCollectionByParent
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SysLookupFolderCollectionByParent == null))
                {
                    this._SysLookupFolderCollectionByParent = Context.CreateQuery<global::Terrasoft.Configuration.OData.SysLookupFolder>(GetPath("SysLookupFolderCollectionByParent"));
                }
                return this._SysLookupFolderCollectionByParent;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.SysLookupFolder> _SysLookupFolderCollectionByParent;
        /// <summary>
        /// There are no comments for FolderType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("FolderType")]
        public virtual global::Terrasoft.Configuration.OData.FolderTypeSingle FolderType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FolderType == null))
                {
                    this._FolderType = new global::Terrasoft.Configuration.OData.FolderTypeSingle(this.Context, GetPath("FolderType"));
                }
                return this._FolderType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.FolderTypeSingle _FolderType;
        /// <summary>
        /// There are no comments for SysLookupCollectionBySysFolder in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SysLookupCollectionBySysFolder")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.SysLookup> SysLookupCollectionBySysFolder
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SysLookupCollectionBySysFolder == null))
                {
                    this._SysLookupCollectionBySysFolder = Context.CreateQuery<global::Terrasoft.Configuration.OData.SysLookup>(GetPath("SysLookupCollectionBySysFolder"));
                }
                return this._SysLookupCollectionBySysFolder;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.SysLookup> _SysLookupCollectionBySysFolder;
        /// <summary>
        /// There are no comments for VwSysLookupCollectionBySysFolder in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("VwSysLookupCollectionBySysFolder")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.VwSysLookup> VwSysLookupCollectionBySysFolder
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VwSysLookupCollectionBySysFolder == null))
                {
                    this._VwSysLookupCollectionBySysFolder = Context.CreateQuery<global::Terrasoft.Configuration.OData.VwSysLookup>(GetPath("VwSysLookupCollectionBySysFolder"));
                }
                return this._VwSysLookupCollectionBySysFolder;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.VwSysLookup> _VwSysLookupCollectionBySysFolder;
        /// <summary>
        /// There are no comments for VwSysLookupInFolderCollectionByFolder in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("VwSysLookupInFolderCollectionByFolder")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.VwSysLookupInFolder> VwSysLookupInFolderCollectionByFolder
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VwSysLookupInFolderCollectionByFolder == null))
                {
                    this._VwSysLookupInFolderCollectionByFolder = Context.CreateQuery<global::Terrasoft.Configuration.OData.VwSysLookupInFolder>(GetPath("VwSysLookupInFolderCollectionByFolder"));
                }
                return this._VwSysLookupInFolderCollectionByFolder;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.VwSysLookupInFolder> _VwSysLookupInFolderCollectionByFolder;
    }
    /// <summary>
    /// There are no comments for SysLookupFolder in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("SysLookupFolder")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SysLookupFolder")]
    public partial class SysLookupFolder : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SysLookupFolder object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="description">Initial value of Description.</param>
        /// <param name="searchData">Initial value of SearchData.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SysLookupFolder CreateSysLookupFolder(string name, string description, global::Microsoft.OData.Client.DataServiceStreamLink searchData)
        {
            SysLookupFolder sysLookupFolder = new SysLookupFolder();
            sysLookupFolder.Name = name;
            sysLookupFolder.Description = description;
            sysLookupFolder.SearchData = searchData;
            return sysLookupFolder;
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
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Description")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Description is required.")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
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
        /// There are no comments for Property FolderTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FolderTypeId")]
        public virtual global::System.Nullable<global::System.Guid> FolderTypeId
        {
            get
            {
                return this._FolderTypeId;
            }
            set
            {
                this.OnFolderTypeIdChanging(value);
                this._FolderTypeId = value;
                this.OnFolderTypeIdChanged();
                this.OnPropertyChanged("FolderTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _FolderTypeId;
        partial void OnFolderTypeIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnFolderTypeIdChanged();
        /// <summary>
        /// There are no comments for Property SearchData in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SearchData")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SearchData is required.")]
        public virtual global::Microsoft.OData.Client.DataServiceStreamLink SearchData
        {
            get
            {
                return this._SearchData;
            }
            set
            {
                this.OnSearchDataChanging(value);
                this._SearchData = value;
                this.OnSearchDataChanged();
                this.OnPropertyChanged("SearchData");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceStreamLink _SearchData;
        partial void OnSearchDataChanging(global::Microsoft.OData.Client.DataServiceStreamLink value);
        partial void OnSearchDataChanged();
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
        /// There are no comments for Property OptimizationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OptimizationType")]
        public virtual global::System.Nullable<int> OptimizationType
        {
            get
            {
                return this._OptimizationType;
            }
            set
            {
                this.OnOptimizationTypeChanging(value);
                this._OptimizationType = value;
                this.OnOptimizationTypeChanged();
                this.OnPropertyChanged("OptimizationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _OptimizationType;
        partial void OnOptimizationTypeChanging(global::System.Nullable<int> value);
        partial void OnOptimizationTypeChanged();
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
        public virtual global::Terrasoft.Configuration.OData.SysLookupFolder Parent
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
        private global::Terrasoft.Configuration.OData.SysLookupFolder _Parent;
        partial void OnParentChanging(global::Terrasoft.Configuration.OData.SysLookupFolder value);
        partial void OnParentChanged();
        /// <summary>
        /// There are no comments for Property SysLookupFolderCollectionByParent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysLookupFolderCollectionByParent")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.SysLookupFolder> SysLookupFolderCollectionByParent
        {
            get
            {
                return this._SysLookupFolderCollectionByParent;
            }
            set
            {
                this.OnSysLookupFolderCollectionByParentChanging(value);
                this._SysLookupFolderCollectionByParent = value;
                this.OnSysLookupFolderCollectionByParentChanged();
                this.OnPropertyChanged("SysLookupFolderCollectionByParent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.SysLookupFolder> _SysLookupFolderCollectionByParent = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.SysLookupFolder>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnSysLookupFolderCollectionByParentChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.SysLookupFolder> value);
        partial void OnSysLookupFolderCollectionByParentChanged();
        /// <summary>
        /// There are no comments for Property FolderType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FolderType")]
        public virtual global::Terrasoft.Configuration.OData.FolderType FolderType
        {
            get
            {
                return this._FolderType;
            }
            set
            {
                this.OnFolderTypeChanging(value);
                this._FolderType = value;
                this.OnFolderTypeChanged();
                this.OnPropertyChanged("FolderType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.FolderType _FolderType;
        partial void OnFolderTypeChanging(global::Terrasoft.Configuration.OData.FolderType value);
        partial void OnFolderTypeChanged();
        /// <summary>
        /// There are no comments for Property SysLookupCollectionBySysFolder in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysLookupCollectionBySysFolder")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.SysLookup> SysLookupCollectionBySysFolder
        {
            get
            {
                return this._SysLookupCollectionBySysFolder;
            }
            set
            {
                this.OnSysLookupCollectionBySysFolderChanging(value);
                this._SysLookupCollectionBySysFolder = value;
                this.OnSysLookupCollectionBySysFolderChanged();
                this.OnPropertyChanged("SysLookupCollectionBySysFolder");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.SysLookup> _SysLookupCollectionBySysFolder = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.SysLookup>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnSysLookupCollectionBySysFolderChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.SysLookup> value);
        partial void OnSysLookupCollectionBySysFolderChanged();
        /// <summary>
        /// There are no comments for Property VwSysLookupCollectionBySysFolder in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VwSysLookupCollectionBySysFolder")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.VwSysLookup> VwSysLookupCollectionBySysFolder
        {
            get
            {
                return this._VwSysLookupCollectionBySysFolder;
            }
            set
            {
                this.OnVwSysLookupCollectionBySysFolderChanging(value);
                this._VwSysLookupCollectionBySysFolder = value;
                this.OnVwSysLookupCollectionBySysFolderChanged();
                this.OnPropertyChanged("VwSysLookupCollectionBySysFolder");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.VwSysLookup> _VwSysLookupCollectionBySysFolder = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.VwSysLookup>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnVwSysLookupCollectionBySysFolderChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.VwSysLookup> value);
        partial void OnVwSysLookupCollectionBySysFolderChanged();
        /// <summary>
        /// There are no comments for Property VwSysLookupInFolderCollectionByFolder in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VwSysLookupInFolderCollectionByFolder")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.VwSysLookupInFolder> VwSysLookupInFolderCollectionByFolder
        {
            get
            {
                return this._VwSysLookupInFolderCollectionByFolder;
            }
            set
            {
                this.OnVwSysLookupInFolderCollectionByFolderChanging(value);
                this._VwSysLookupInFolderCollectionByFolder = value;
                this.OnVwSysLookupInFolderCollectionByFolderChanged();
                this.OnPropertyChanged("VwSysLookupInFolderCollectionByFolder");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.VwSysLookupInFolder> _VwSysLookupInFolderCollectionByFolder = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.VwSysLookupInFolder>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnVwSysLookupInFolderCollectionByFolderChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.VwSysLookupInFolder> value);
        partial void OnVwSysLookupInFolderCollectionByFolderChanged();
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
