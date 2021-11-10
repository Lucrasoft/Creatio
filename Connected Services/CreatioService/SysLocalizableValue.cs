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
    /// There are no comments for SysLocalizableValueSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SysLocalizableValueSingle")]
    public partial class SysLocalizableValueSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SysLocalizableValue>
    {
        /// <summary>
        /// Initialize a new SysLocalizableValueSingle object.
        /// </summary>
        public SysLocalizableValueSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SysLocalizableValueSingle object.
        /// </summary>
        public SysLocalizableValueSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SysLocalizableValueSingle object.
        /// </summary>
        public SysLocalizableValueSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SysLocalizableValue> query)
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
        /// <summary>
        /// There are no comments for SysSchema in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SysSchema")]
        public virtual global::Terrasoft.Configuration.OData.SysSchemaSingle SysSchema
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SysSchema == null))
                {
                    this._SysSchema = new global::Terrasoft.Configuration.OData.SysSchemaSingle(this.Context, GetPath("SysSchema"));
                }
                return this._SysSchema;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.SysSchemaSingle _SysSchema;
        /// <summary>
        /// There are no comments for SysCulture in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SysCulture")]
        public virtual global::Terrasoft.Configuration.OData.SysCultureSingle SysCulture
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SysCulture == null))
                {
                    this._SysCulture = new global::Terrasoft.Configuration.OData.SysCultureSingle(this.Context, GetPath("SysCulture"));
                }
                return this._SysCulture;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.SysCultureSingle _SysCulture;
    }
    /// <summary>
    /// There are no comments for SysLocalizableValue in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("SysLocalizableValue")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SysLocalizableValue")]
    public partial class SysLocalizableValue : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SysLocalizableValue object.
        /// </summary>
        /// <param name="resourceManager">Initial value of ResourceManager.</param>
        /// <param name="key">Initial value of Key.</param>
        /// <param name="value">Initial value of Value.</param>
        /// <param name="imageData">Initial value of ImageData.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SysLocalizableValue CreateSysLocalizableValue(string resourceManager, string key, string value, global::Microsoft.OData.Client.DataServiceStreamLink imageData)
        {
            SysLocalizableValue sysLocalizableValue = new SysLocalizableValue();
            sysLocalizableValue.ResourceManager = resourceManager;
            sysLocalizableValue.Key = key;
            sysLocalizableValue.Value = value;
            sysLocalizableValue.ImageData = imageData;
            return sysLocalizableValue;
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
        /// There are no comments for Property SysSchemaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysSchemaId")]
        public virtual global::System.Nullable<global::System.Guid> SysSchemaId
        {
            get
            {
                return this._SysSchemaId;
            }
            set
            {
                this.OnSysSchemaIdChanging(value);
                this._SysSchemaId = value;
                this.OnSysSchemaIdChanged();
                this.OnPropertyChanged("SysSchemaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _SysSchemaId;
        partial void OnSysSchemaIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnSysSchemaIdChanged();
        /// <summary>
        /// There are no comments for Property ResourceManager in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ResourceManager")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ResourceManager is required.")]
        public virtual string ResourceManager
        {
            get
            {
                return this._ResourceManager;
            }
            set
            {
                this.OnResourceManagerChanging(value);
                this._ResourceManager = value;
                this.OnResourceManagerChanged();
                this.OnPropertyChanged("ResourceManager");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ResourceManager;
        partial void OnResourceManagerChanging(string value);
        partial void OnResourceManagerChanged();
        /// <summary>
        /// There are no comments for Property SysCultureId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysCultureId")]
        public virtual global::System.Nullable<global::System.Guid> SysCultureId
        {
            get
            {
                return this._SysCultureId;
            }
            set
            {
                this.OnSysCultureIdChanging(value);
                this._SysCultureId = value;
                this.OnSysCultureIdChanged();
                this.OnPropertyChanged("SysCultureId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _SysCultureId;
        partial void OnSysCultureIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnSysCultureIdChanged();
        /// <summary>
        /// There are no comments for Property ResourceType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ResourceType")]
        public virtual global::System.Nullable<int> ResourceType
        {
            get
            {
                return this._ResourceType;
            }
            set
            {
                this.OnResourceTypeChanging(value);
                this._ResourceType = value;
                this.OnResourceTypeChanged();
                this.OnPropertyChanged("ResourceType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _ResourceType;
        partial void OnResourceTypeChanging(global::System.Nullable<int> value);
        partial void OnResourceTypeChanged();
        /// <summary>
        /// There are no comments for Property IsChanged in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsChanged")]
        public virtual global::System.Nullable<bool> IsChanged
        {
            get
            {
                return this._IsChanged;
            }
            set
            {
                this.OnIsChangedChanging(value);
                this._IsChanged = value;
                this.OnIsChangedChanged();
                this.OnPropertyChanged("IsChanged");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _IsChanged;
        partial void OnIsChangedChanging(global::System.Nullable<bool> value);
        partial void OnIsChangedChanged();
        /// <summary>
        /// There are no comments for Property Key in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Key")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Key is required.")]
        public virtual string Key
        {
            get
            {
                return this._Key;
            }
            set
            {
                this.OnKeyChanging(value);
                this._Key = value;
                this.OnKeyChanged();
                this.OnPropertyChanged("Key");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Key;
        partial void OnKeyChanging(string value);
        partial void OnKeyChanged();
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Value")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Value is required.")]
        public virtual string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
                this.OnPropertyChanged("Value");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Value;
        partial void OnValueChanging(string value);
        partial void OnValueChanged();
        /// <summary>
        /// There are no comments for Property ImageData in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ImageData")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ImageData is required.")]
        public virtual global::Microsoft.OData.Client.DataServiceStreamLink ImageData
        {
            get
            {
                return this._ImageData;
            }
            set
            {
                this.OnImageDataChanging(value);
                this._ImageData = value;
                this.OnImageDataChanged();
                this.OnPropertyChanged("ImageData");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceStreamLink _ImageData;
        partial void OnImageDataChanging(global::Microsoft.OData.Client.DataServiceStreamLink value);
        partial void OnImageDataChanged();
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
        /// There are no comments for Property SysSchema in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysSchema")]
        public virtual global::Terrasoft.Configuration.OData.SysSchema SysSchema
        {
            get
            {
                return this._SysSchema;
            }
            set
            {
                this.OnSysSchemaChanging(value);
                this._SysSchema = value;
                this.OnSysSchemaChanged();
                this.OnPropertyChanged("SysSchema");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.SysSchema _SysSchema;
        partial void OnSysSchemaChanging(global::Terrasoft.Configuration.OData.SysSchema value);
        partial void OnSysSchemaChanged();
        /// <summary>
        /// There are no comments for Property SysCulture in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysCulture")]
        public virtual global::Terrasoft.Configuration.OData.SysCulture SysCulture
        {
            get
            {
                return this._SysCulture;
            }
            set
            {
                this.OnSysCultureChanging(value);
                this._SysCulture = value;
                this.OnSysCultureChanged();
                this.OnPropertyChanged("SysCulture");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.SysCulture _SysCulture;
        partial void OnSysCultureChanging(global::Terrasoft.Configuration.OData.SysCulture value);
        partial void OnSysCultureChanged();
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
