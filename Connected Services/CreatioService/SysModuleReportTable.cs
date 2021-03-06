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
    /// There are no comments for SysModuleReportTableSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SysModuleReportTableSingle")]
    public partial class SysModuleReportTableSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SysModuleReportTable>
    {
        /// <summary>
        /// Initialize a new SysModuleReportTableSingle object.
        /// </summary>
        public SysModuleReportTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SysModuleReportTableSingle object.
        /// </summary>
        public SysModuleReportTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SysModuleReportTableSingle object.
        /// </summary>
        public SysModuleReportTableSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SysModuleReportTable> query)
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
        /// There are no comments for SysModuleReport in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SysModuleReport")]
        public virtual global::Terrasoft.Configuration.OData.SysModuleReportSingle SysModuleReport
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SysModuleReport == null))
                {
                    this._SysModuleReport = new global::Terrasoft.Configuration.OData.SysModuleReportSingle(this.Context, GetPath("SysModuleReport"));
                }
                return this._SysModuleReport;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.SysModuleReportSingle _SysModuleReport;
    }
    /// <summary>
    /// There are no comments for SysModuleReportTable in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("SysModuleReportTable")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SysModuleReportTable")]
    public partial class SysModuleReportTable : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SysModuleReportTable object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="macrosList">Initial value of MacrosList.</param>
        /// <param name="referenceColumn">Initial value of ReferenceColumn.</param>
        /// <param name="caption">Initial value of Caption.</param>
        /// <param name="filter">Initial value of Filter.</param>
        /// <param name="objectColumnPath">Initial value of ObjectColumnPath.</param>
        /// <param name="objectColumnCaption">Initial value of ObjectColumnCaption.</param>
        /// <param name="referenceColumnCaption">Initial value of ReferenceColumnCaption.</param>
        /// <param name="filterSettings">Initial value of FilterSettings.</param>
        /// <param name="macrosSettings">Initial value of MacrosSettings.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SysModuleReportTable CreateSysModuleReportTable(string name, 
                    string macrosList, 
                    string referenceColumn, 
                    string caption, 
                    global::Microsoft.OData.Client.DataServiceStreamLink filter, 
                    string objectColumnPath, 
                    string objectColumnCaption, 
                    string referenceColumnCaption, 
                    string filterSettings, 
                    string macrosSettings)
        {
            SysModuleReportTable sysModuleReportTable = new SysModuleReportTable();
            sysModuleReportTable.Name = name;
            sysModuleReportTable.MacrosList = macrosList;
            sysModuleReportTable.ReferenceColumn = referenceColumn;
            sysModuleReportTable.Caption = caption;
            sysModuleReportTable.Filter = filter;
            sysModuleReportTable.ObjectColumnPath = objectColumnPath;
            sysModuleReportTable.ObjectColumnCaption = objectColumnCaption;
            sysModuleReportTable.ReferenceColumnCaption = referenceColumnCaption;
            sysModuleReportTable.FilterSettings = filterSettings;
            sysModuleReportTable.MacrosSettings = macrosSettings;
            return sysModuleReportTable;
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
        /// There are no comments for Property MacrosList in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MacrosList")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MacrosList is required.")]
        public virtual string MacrosList
        {
            get
            {
                return this._MacrosList;
            }
            set
            {
                this.OnMacrosListChanging(value);
                this._MacrosList = value;
                this.OnMacrosListChanged();
                this.OnPropertyChanged("MacrosList");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MacrosList;
        partial void OnMacrosListChanging(string value);
        partial void OnMacrosListChanged();
        /// <summary>
        /// There are no comments for Property SysModuleReportId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysModuleReportId")]
        public virtual global::System.Nullable<global::System.Guid> SysModuleReportId
        {
            get
            {
                return this._SysModuleReportId;
            }
            set
            {
                this.OnSysModuleReportIdChanging(value);
                this._SysModuleReportId = value;
                this.OnSysModuleReportIdChanged();
                this.OnPropertyChanged("SysModuleReportId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _SysModuleReportId;
        partial void OnSysModuleReportIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnSysModuleReportIdChanged();
        /// <summary>
        /// There are no comments for Property ReferenceColumn in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReferenceColumn")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReferenceColumn is required.")]
        public virtual string ReferenceColumn
        {
            get
            {
                return this._ReferenceColumn;
            }
            set
            {
                this.OnReferenceColumnChanging(value);
                this._ReferenceColumn = value;
                this.OnReferenceColumnChanged();
                this.OnPropertyChanged("ReferenceColumn");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReferenceColumn;
        partial void OnReferenceColumnChanging(string value);
        partial void OnReferenceColumnChanged();
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
        /// There are no comments for Property Filter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Filter")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Filter is required.")]
        public virtual global::Microsoft.OData.Client.DataServiceStreamLink Filter
        {
            get
            {
                return this._Filter;
            }
            set
            {
                this.OnFilterChanging(value);
                this._Filter = value;
                this.OnFilterChanged();
                this.OnPropertyChanged("Filter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceStreamLink _Filter;
        partial void OnFilterChanging(global::Microsoft.OData.Client.DataServiceStreamLink value);
        partial void OnFilterChanged();
        /// <summary>
        /// There are no comments for Property ObjectId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ObjectId")]
        public virtual global::System.Nullable<global::System.Guid> ObjectId
        {
            get
            {
                return this._ObjectId;
            }
            set
            {
                this.OnObjectIdChanging(value);
                this._ObjectId = value;
                this.OnObjectIdChanged();
                this.OnPropertyChanged("ObjectId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _ObjectId;
        partial void OnObjectIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnObjectIdChanged();
        /// <summary>
        /// There are no comments for Property ObjectColumnPath in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ObjectColumnPath")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ObjectColumnPath is required.")]
        public virtual string ObjectColumnPath
        {
            get
            {
                return this._ObjectColumnPath;
            }
            set
            {
                this.OnObjectColumnPathChanging(value);
                this._ObjectColumnPath = value;
                this.OnObjectColumnPathChanged();
                this.OnPropertyChanged("ObjectColumnPath");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ObjectColumnPath;
        partial void OnObjectColumnPathChanging(string value);
        partial void OnObjectColumnPathChanged();
        /// <summary>
        /// There are no comments for Property ObjectColumnCaption in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ObjectColumnCaption")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ObjectColumnCaption is required.")]
        public virtual string ObjectColumnCaption
        {
            get
            {
                return this._ObjectColumnCaption;
            }
            set
            {
                this.OnObjectColumnCaptionChanging(value);
                this._ObjectColumnCaption = value;
                this.OnObjectColumnCaptionChanged();
                this.OnPropertyChanged("ObjectColumnCaption");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ObjectColumnCaption;
        partial void OnObjectColumnCaptionChanging(string value);
        partial void OnObjectColumnCaptionChanged();
        /// <summary>
        /// There are no comments for Property ReferenceColumnCaption in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReferenceColumnCaption")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReferenceColumnCaption is required.")]
        public virtual string ReferenceColumnCaption
        {
            get
            {
                return this._ReferenceColumnCaption;
            }
            set
            {
                this.OnReferenceColumnCaptionChanging(value);
                this._ReferenceColumnCaption = value;
                this.OnReferenceColumnCaptionChanged();
                this.OnPropertyChanged("ReferenceColumnCaption");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReferenceColumnCaption;
        partial void OnReferenceColumnCaptionChanging(string value);
        partial void OnReferenceColumnCaptionChanged();
        /// <summary>
        /// There are no comments for Property IsEmptyTableHide in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsEmptyTableHide")]
        public virtual global::System.Nullable<bool> IsEmptyTableHide
        {
            get
            {
                return this._IsEmptyTableHide;
            }
            set
            {
                this.OnIsEmptyTableHideChanging(value);
                this._IsEmptyTableHide = value;
                this.OnIsEmptyTableHideChanged();
                this.OnPropertyChanged("IsEmptyTableHide");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _IsEmptyTableHide;
        partial void OnIsEmptyTableHideChanging(global::System.Nullable<bool> value);
        partial void OnIsEmptyTableHideChanged();
        /// <summary>
        /// There are no comments for Property FilterSettings in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FilterSettings")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FilterSettings is required.")]
        public virtual string FilterSettings
        {
            get
            {
                return this._FilterSettings;
            }
            set
            {
                this.OnFilterSettingsChanging(value);
                this._FilterSettings = value;
                this.OnFilterSettingsChanged();
                this.OnPropertyChanged("FilterSettings");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FilterSettings;
        partial void OnFilterSettingsChanging(string value);
        partial void OnFilterSettingsChanged();
        /// <summary>
        /// There are no comments for Property MacrosSettings in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MacrosSettings")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MacrosSettings is required.")]
        public virtual string MacrosSettings
        {
            get
            {
                return this._MacrosSettings;
            }
            set
            {
                this.OnMacrosSettingsChanging(value);
                this._MacrosSettings = value;
                this.OnMacrosSettingsChanged();
                this.OnPropertyChanged("MacrosSettings");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MacrosSettings;
        partial void OnMacrosSettingsChanging(string value);
        partial void OnMacrosSettingsChanged();
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
        /// There are no comments for Property SysModuleReport in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysModuleReport")]
        public virtual global::Terrasoft.Configuration.OData.SysModuleReport SysModuleReport
        {
            get
            {
                return this._SysModuleReport;
            }
            set
            {
                this.OnSysModuleReportChanging(value);
                this._SysModuleReport = value;
                this.OnSysModuleReportChanged();
                this.OnPropertyChanged("SysModuleReport");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.SysModuleReport _SysModuleReport;
        partial void OnSysModuleReportChanging(global::Terrasoft.Configuration.OData.SysModuleReport value);
        partial void OnSysModuleReportChanged();
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
