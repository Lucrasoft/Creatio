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
    /// There are no comments for SysModuleEditDetailParentAsscSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SysModuleEditDetailParentAsscSingle")]
    public partial class SysModuleEditDetailParentAsscSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SysModuleEditDetailParentAssc>
    {
        /// <summary>
        /// Initialize a new SysModuleEditDetailParentAsscSingle object.
        /// </summary>
        public SysModuleEditDetailParentAsscSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SysModuleEditDetailParentAsscSingle object.
        /// </summary>
        public SysModuleEditDetailParentAsscSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SysModuleEditDetailParentAsscSingle object.
        /// </summary>
        public SysModuleEditDetailParentAsscSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SysModuleEditDetailParentAssc> query)
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
        /// There are no comments for SysModuleEditDetail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SysModuleEditDetail")]
        public virtual global::Terrasoft.Configuration.OData.SysModuleEditDetailSingle SysModuleEditDetail
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SysModuleEditDetail == null))
                {
                    this._SysModuleEditDetail = new global::Terrasoft.Configuration.OData.SysModuleEditDetailSingle(this.Context, GetPath("SysModuleEditDetail"));
                }
                return this._SysModuleEditDetail;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.SysModuleEditDetailSingle _SysModuleEditDetail;
        /// <summary>
        /// There are no comments for SysParentAssociationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SysParentAssociationType")]
        public virtual global::Terrasoft.Configuration.OData.SysParentAssociationTypeSingle SysParentAssociationType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SysParentAssociationType == null))
                {
                    this._SysParentAssociationType = new global::Terrasoft.Configuration.OData.SysParentAssociationTypeSingle(this.Context, GetPath("SysParentAssociationType"));
                }
                return this._SysParentAssociationType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.SysParentAssociationTypeSingle _SysParentAssociationType;
    }
    /// <summary>
    /// There are no comments for SysModuleEditDetailParentAssc in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("SysModuleEditDetailParentAssc")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SysModuleEditDetailParentAssc")]
    public partial class SysModuleEditDetailParentAssc : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SysModuleEditDetailParentAssc object.
        /// </summary>
        /// <param name="columnMetaPath">Initial value of ColumnMetaPath.</param>
        /// <param name="parentColumnMetaPath">Initial value of ParentColumnMetaPath.</param>
        /// <param name="columnCaption">Initial value of ColumnCaption.</param>
        /// <param name="parentColumnCaption">Initial value of ParentColumnCaption.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SysModuleEditDetailParentAssc CreateSysModuleEditDetailParentAssc(string columnMetaPath, string parentColumnMetaPath, string columnCaption, string parentColumnCaption)
        {
            SysModuleEditDetailParentAssc sysModuleEditDetailParentAssc = new SysModuleEditDetailParentAssc();
            sysModuleEditDetailParentAssc.ColumnMetaPath = columnMetaPath;
            sysModuleEditDetailParentAssc.ParentColumnMetaPath = parentColumnMetaPath;
            sysModuleEditDetailParentAssc.ColumnCaption = columnCaption;
            sysModuleEditDetailParentAssc.ParentColumnCaption = parentColumnCaption;
            return sysModuleEditDetailParentAssc;
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
        /// There are no comments for Property SysModuleEditDetailId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysModuleEditDetailId")]
        public virtual global::System.Nullable<global::System.Guid> SysModuleEditDetailId
        {
            get
            {
                return this._SysModuleEditDetailId;
            }
            set
            {
                this.OnSysModuleEditDetailIdChanging(value);
                this._SysModuleEditDetailId = value;
                this.OnSysModuleEditDetailIdChanged();
                this.OnPropertyChanged("SysModuleEditDetailId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _SysModuleEditDetailId;
        partial void OnSysModuleEditDetailIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnSysModuleEditDetailIdChanged();
        /// <summary>
        /// There are no comments for Property ColumnMetaPath in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnMetaPath")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ColumnMetaPath is required.")]
        public virtual string ColumnMetaPath
        {
            get
            {
                return this._ColumnMetaPath;
            }
            set
            {
                this.OnColumnMetaPathChanging(value);
                this._ColumnMetaPath = value;
                this.OnColumnMetaPathChanged();
                this.OnPropertyChanged("ColumnMetaPath");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnMetaPath;
        partial void OnColumnMetaPathChanging(string value);
        partial void OnColumnMetaPathChanged();
        /// <summary>
        /// There are no comments for Property ParentColumnMetaPath in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ParentColumnMetaPath")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ParentColumnMetaPath is required.")]
        public virtual string ParentColumnMetaPath
        {
            get
            {
                return this._ParentColumnMetaPath;
            }
            set
            {
                this.OnParentColumnMetaPathChanging(value);
                this._ParentColumnMetaPath = value;
                this.OnParentColumnMetaPathChanged();
                this.OnPropertyChanged("ParentColumnMetaPath");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ParentColumnMetaPath;
        partial void OnParentColumnMetaPathChanging(string value);
        partial void OnParentColumnMetaPathChanged();
        /// <summary>
        /// There are no comments for Property SysParentAssociationTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysParentAssociationTypeId")]
        public virtual global::System.Nullable<global::System.Guid> SysParentAssociationTypeId
        {
            get
            {
                return this._SysParentAssociationTypeId;
            }
            set
            {
                this.OnSysParentAssociationTypeIdChanging(value);
                this._SysParentAssociationTypeId = value;
                this.OnSysParentAssociationTypeIdChanged();
                this.OnPropertyChanged("SysParentAssociationTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _SysParentAssociationTypeId;
        partial void OnSysParentAssociationTypeIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnSysParentAssociationTypeIdChanged();
        /// <summary>
        /// There are no comments for Property ColumnCaption in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnCaption")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ColumnCaption is required.")]
        public virtual string ColumnCaption
        {
            get
            {
                return this._ColumnCaption;
            }
            set
            {
                this.OnColumnCaptionChanging(value);
                this._ColumnCaption = value;
                this.OnColumnCaptionChanged();
                this.OnPropertyChanged("ColumnCaption");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnCaption;
        partial void OnColumnCaptionChanging(string value);
        partial void OnColumnCaptionChanged();
        /// <summary>
        /// There are no comments for Property ParentColumnCaption in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ParentColumnCaption")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ParentColumnCaption is required.")]
        public virtual string ParentColumnCaption
        {
            get
            {
                return this._ParentColumnCaption;
            }
            set
            {
                this.OnParentColumnCaptionChanging(value);
                this._ParentColumnCaption = value;
                this.OnParentColumnCaptionChanged();
                this.OnPropertyChanged("ParentColumnCaption");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ParentColumnCaption;
        partial void OnParentColumnCaptionChanging(string value);
        partial void OnParentColumnCaptionChanged();
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
        /// There are no comments for Property SysModuleEditDetail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysModuleEditDetail")]
        public virtual global::Terrasoft.Configuration.OData.SysModuleEditDetail SysModuleEditDetail
        {
            get
            {
                return this._SysModuleEditDetail;
            }
            set
            {
                this.OnSysModuleEditDetailChanging(value);
                this._SysModuleEditDetail = value;
                this.OnSysModuleEditDetailChanged();
                this.OnPropertyChanged("SysModuleEditDetail");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.SysModuleEditDetail _SysModuleEditDetail;
        partial void OnSysModuleEditDetailChanging(global::Terrasoft.Configuration.OData.SysModuleEditDetail value);
        partial void OnSysModuleEditDetailChanged();
        /// <summary>
        /// There are no comments for Property SysParentAssociationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysParentAssociationType")]
        public virtual global::Terrasoft.Configuration.OData.SysParentAssociationType SysParentAssociationType
        {
            get
            {
                return this._SysParentAssociationType;
            }
            set
            {
                this.OnSysParentAssociationTypeChanging(value);
                this._SysParentAssociationType = value;
                this.OnSysParentAssociationTypeChanged();
                this.OnPropertyChanged("SysParentAssociationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.SysParentAssociationType _SysParentAssociationType;
        partial void OnSysParentAssociationTypeChanging(global::Terrasoft.Configuration.OData.SysParentAssociationType value);
        partial void OnSysParentAssociationTypeChanged();
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
