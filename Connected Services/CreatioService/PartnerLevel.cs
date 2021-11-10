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
    /// There are no comments for PartnerLevelSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PartnerLevelSingle")]
    public partial class PartnerLevelSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PartnerLevel>
    {
        /// <summary>
        /// Initialize a new PartnerLevelSingle object.
        /// </summary>
        public PartnerLevelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PartnerLevelSingle object.
        /// </summary>
        public PartnerLevelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PartnerLevelSingle object.
        /// </summary>
        public PartnerLevelSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PartnerLevel> query)
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
        /// There are no comments for PartnerType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PartnerType")]
        public virtual global::Terrasoft.Configuration.OData.PartnerTypeSingle PartnerType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PartnerType == null))
                {
                    this._PartnerType = new global::Terrasoft.Configuration.OData.PartnerTypeSingle(this.Context, GetPath("PartnerType"));
                }
                return this._PartnerType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.PartnerTypeSingle _PartnerType;
        /// <summary>
        /// There are no comments for PartnershipCollectionByPartnerLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PartnershipCollectionByPartnerLevel")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.Partnership> PartnershipCollectionByPartnerLevel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PartnershipCollectionByPartnerLevel == null))
                {
                    this._PartnershipCollectionByPartnerLevel = Context.CreateQuery<global::Terrasoft.Configuration.OData.Partnership>(GetPath("PartnershipCollectionByPartnerLevel"));
                }
                return this._PartnershipCollectionByPartnerLevel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.Partnership> _PartnershipCollectionByPartnerLevel;
        /// <summary>
        /// There are no comments for LevelPartnershipParamCollectionByPartnerLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LevelPartnershipParamCollectionByPartnerLevel")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.LevelPartnershipParam> LevelPartnershipParamCollectionByPartnerLevel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LevelPartnershipParamCollectionByPartnerLevel == null))
                {
                    this._LevelPartnershipParamCollectionByPartnerLevel = Context.CreateQuery<global::Terrasoft.Configuration.OData.LevelPartnershipParam>(GetPath("LevelPartnershipParamCollectionByPartnerLevel"));
                }
                return this._LevelPartnershipParamCollectionByPartnerLevel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.LevelPartnershipParam> _LevelPartnershipParamCollectionByPartnerLevel;
        /// <summary>
        /// There are no comments for PartnerParamHistoryCollectionByPartnerLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PartnerParamHistoryCollectionByPartnerLevel")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.PartnerParamHistory> PartnerParamHistoryCollectionByPartnerLevel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PartnerParamHistoryCollectionByPartnerLevel == null))
                {
                    this._PartnerParamHistoryCollectionByPartnerLevel = Context.CreateQuery<global::Terrasoft.Configuration.OData.PartnerParamHistory>(GetPath("PartnerParamHistoryCollectionByPartnerLevel"));
                }
                return this._PartnerParamHistoryCollectionByPartnerLevel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.PartnerParamHistory> _PartnerParamHistoryCollectionByPartnerLevel;
        /// <summary>
        /// There are no comments for PartnershipParameterCollectionByPartnerLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PartnershipParameterCollectionByPartnerLevel")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.PartnershipParameter> PartnershipParameterCollectionByPartnerLevel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PartnershipParameterCollectionByPartnerLevel == null))
                {
                    this._PartnershipParameterCollectionByPartnerLevel = Context.CreateQuery<global::Terrasoft.Configuration.OData.PartnershipParameter>(GetPath("PartnershipParameterCollectionByPartnerLevel"));
                }
                return this._PartnershipParameterCollectionByPartnerLevel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.PartnershipParameter> _PartnershipParameterCollectionByPartnerLevel;
    }
    /// <summary>
    /// There are no comments for PartnerLevel in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("PartnerLevel")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PartnerLevel")]
    public partial class PartnerLevel : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PartnerLevel object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="description">Initial value of Description.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PartnerLevel CreatePartnerLevel(string name, string description)
        {
            PartnerLevel partnerLevel = new PartnerLevel();
            partnerLevel.Name = name;
            partnerLevel.Description = description;
            return partnerLevel;
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
        /// There are no comments for Property PartnerTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PartnerTypeId")]
        public virtual global::System.Nullable<global::System.Guid> PartnerTypeId
        {
            get
            {
                return this._PartnerTypeId;
            }
            set
            {
                this.OnPartnerTypeIdChanging(value);
                this._PartnerTypeId = value;
                this.OnPartnerTypeIdChanged();
                this.OnPropertyChanged("PartnerTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _PartnerTypeId;
        partial void OnPartnerTypeIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnPartnerTypeIdChanged();
        /// <summary>
        /// There are no comments for Property TargetScore in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TargetScore")]
        public virtual global::System.Nullable<decimal> TargetScore
        {
            get
            {
                return this._TargetScore;
            }
            set
            {
                this.OnTargetScoreChanging(value);
                this._TargetScore = value;
                this.OnTargetScoreChanged();
                this.OnPropertyChanged("TargetScore");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<decimal> _TargetScore;
        partial void OnTargetScoreChanging(global::System.Nullable<decimal> value);
        partial void OnTargetScoreChanged();
        /// <summary>
        /// There are no comments for Property Number in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Number")]
        public virtual global::System.Nullable<int> Number
        {
            get
            {
                return this._Number;
            }
            set
            {
                this.OnNumberChanging(value);
                this._Number = value;
                this.OnNumberChanged();
                this.OnPropertyChanged("Number");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _Number;
        partial void OnNumberChanging(global::System.Nullable<int> value);
        partial void OnNumberChanged();
        /// <summary>
        /// There are no comments for Property RecordInactive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecordInactive")]
        public virtual global::System.Nullable<bool> RecordInactive
        {
            get
            {
                return this._RecordInactive;
            }
            set
            {
                this.OnRecordInactiveChanging(value);
                this._RecordInactive = value;
                this.OnRecordInactiveChanged();
                this.OnPropertyChanged("RecordInactive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _RecordInactive;
        partial void OnRecordInactiveChanging(global::System.Nullable<bool> value);
        partial void OnRecordInactiveChanged();
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
        /// There are no comments for Property PartnerType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PartnerType")]
        public virtual global::Terrasoft.Configuration.OData.PartnerType PartnerType
        {
            get
            {
                return this._PartnerType;
            }
            set
            {
                this.OnPartnerTypeChanging(value);
                this._PartnerType = value;
                this.OnPartnerTypeChanged();
                this.OnPropertyChanged("PartnerType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.PartnerType _PartnerType;
        partial void OnPartnerTypeChanging(global::Terrasoft.Configuration.OData.PartnerType value);
        partial void OnPartnerTypeChanged();
        /// <summary>
        /// There are no comments for Property PartnershipCollectionByPartnerLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PartnershipCollectionByPartnerLevel")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.Partnership> PartnershipCollectionByPartnerLevel
        {
            get
            {
                return this._PartnershipCollectionByPartnerLevel;
            }
            set
            {
                this.OnPartnershipCollectionByPartnerLevelChanging(value);
                this._PartnershipCollectionByPartnerLevel = value;
                this.OnPartnershipCollectionByPartnerLevelChanged();
                this.OnPropertyChanged("PartnershipCollectionByPartnerLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.Partnership> _PartnershipCollectionByPartnerLevel = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.Partnership>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPartnershipCollectionByPartnerLevelChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.Partnership> value);
        partial void OnPartnershipCollectionByPartnerLevelChanged();
        /// <summary>
        /// There are no comments for Property LevelPartnershipParamCollectionByPartnerLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LevelPartnershipParamCollectionByPartnerLevel")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.LevelPartnershipParam> LevelPartnershipParamCollectionByPartnerLevel
        {
            get
            {
                return this._LevelPartnershipParamCollectionByPartnerLevel;
            }
            set
            {
                this.OnLevelPartnershipParamCollectionByPartnerLevelChanging(value);
                this._LevelPartnershipParamCollectionByPartnerLevel = value;
                this.OnLevelPartnershipParamCollectionByPartnerLevelChanged();
                this.OnPropertyChanged("LevelPartnershipParamCollectionByPartnerLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.LevelPartnershipParam> _LevelPartnershipParamCollectionByPartnerLevel = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.LevelPartnershipParam>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLevelPartnershipParamCollectionByPartnerLevelChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.LevelPartnershipParam> value);
        partial void OnLevelPartnershipParamCollectionByPartnerLevelChanged();
        /// <summary>
        /// There are no comments for Property PartnerParamHistoryCollectionByPartnerLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PartnerParamHistoryCollectionByPartnerLevel")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.PartnerParamHistory> PartnerParamHistoryCollectionByPartnerLevel
        {
            get
            {
                return this._PartnerParamHistoryCollectionByPartnerLevel;
            }
            set
            {
                this.OnPartnerParamHistoryCollectionByPartnerLevelChanging(value);
                this._PartnerParamHistoryCollectionByPartnerLevel = value;
                this.OnPartnerParamHistoryCollectionByPartnerLevelChanged();
                this.OnPropertyChanged("PartnerParamHistoryCollectionByPartnerLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.PartnerParamHistory> _PartnerParamHistoryCollectionByPartnerLevel = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.PartnerParamHistory>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPartnerParamHistoryCollectionByPartnerLevelChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.PartnerParamHistory> value);
        partial void OnPartnerParamHistoryCollectionByPartnerLevelChanged();
        /// <summary>
        /// There are no comments for Property PartnershipParameterCollectionByPartnerLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PartnershipParameterCollectionByPartnerLevel")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.PartnershipParameter> PartnershipParameterCollectionByPartnerLevel
        {
            get
            {
                return this._PartnershipParameterCollectionByPartnerLevel;
            }
            set
            {
                this.OnPartnershipParameterCollectionByPartnerLevelChanging(value);
                this._PartnershipParameterCollectionByPartnerLevel = value;
                this.OnPartnershipParameterCollectionByPartnerLevelChanged();
                this.OnPropertyChanged("PartnershipParameterCollectionByPartnerLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.PartnershipParameter> _PartnershipParameterCollectionByPartnerLevel = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.PartnershipParameter>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPartnershipParameterCollectionByPartnerLevelChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.PartnershipParameter> value);
        partial void OnPartnershipParameterCollectionByPartnerLevelChanged();
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
