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
    /// There are no comments for DuplicatesRuleSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DuplicatesRuleSingle")]
    public partial class DuplicatesRuleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DuplicatesRule>
    {
        /// <summary>
        /// Initialize a new DuplicatesRuleSingle object.
        /// </summary>
        public DuplicatesRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DuplicatesRuleSingle object.
        /// </summary>
        public DuplicatesRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DuplicatesRuleSingle object.
        /// </summary>
        public DuplicatesRuleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DuplicatesRule> query)
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
        /// There are no comments for Object in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Object")]
        public virtual global::Terrasoft.Configuration.OData.VwDuplicatesRuleTypeSingle Object
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Object == null))
                {
                    this._Object = new global::Terrasoft.Configuration.OData.VwDuplicatesRuleTypeSingle(this.Context, GetPath("Object"));
                }
                return this._Object;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.VwDuplicatesRuleTypeSingle _Object;
        /// <summary>
        /// There are no comments for SearchObject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SearchObject")]
        public virtual global::Terrasoft.Configuration.OData.VwDuplicatesRuleTypeSingle SearchObject
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SearchObject == null))
                {
                    this._SearchObject = new global::Terrasoft.Configuration.OData.VwDuplicatesRuleTypeSingle(this.Context, GetPath("SearchObject"));
                }
                return this._SearchObject;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.VwDuplicatesRuleTypeSingle _SearchObject;
        /// <summary>
        /// There are no comments for DuplicatesRuleInFolderCollectionByDuplicatesRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DuplicatesRuleInFolderCollectionByDuplicatesRule")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.DuplicatesRuleInFolder> DuplicatesRuleInFolderCollectionByDuplicatesRule
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DuplicatesRuleInFolderCollectionByDuplicatesRule == null))
                {
                    this._DuplicatesRuleInFolderCollectionByDuplicatesRule = Context.CreateQuery<global::Terrasoft.Configuration.OData.DuplicatesRuleInFolder>(GetPath("DuplicatesRuleInFolderCollectionByDuplicatesRule"));
                }
                return this._DuplicatesRuleInFolderCollectionByDuplicatesRule;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.DuplicatesRuleInFolder> _DuplicatesRuleInFolderCollectionByDuplicatesRule;
        /// <summary>
        /// There are no comments for DuplicatesRuleInTagCollectionByEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DuplicatesRuleInTagCollectionByEntity")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.DuplicatesRuleInTag> DuplicatesRuleInTagCollectionByEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DuplicatesRuleInTagCollectionByEntity == null))
                {
                    this._DuplicatesRuleInTagCollectionByEntity = Context.CreateQuery<global::Terrasoft.Configuration.OData.DuplicatesRuleInTag>(GetPath("DuplicatesRuleInTagCollectionByEntity"));
                }
                return this._DuplicatesRuleInTagCollectionByEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.DuplicatesRuleInTag> _DuplicatesRuleInTagCollectionByEntity;
    }
    /// <summary>
    /// There are no comments for DuplicatesRule in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("DuplicatesRule")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("DuplicatesRule")]
    public partial class DuplicatesRule : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DuplicatesRule object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="ruleBody">Initial value of RuleBody.</param>
        /// <param name="procedureName">Initial value of ProcedureName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DuplicatesRule CreateDuplicatesRule(string name, string ruleBody, string procedureName)
        {
            DuplicatesRule duplicatesRule = new DuplicatesRule();
            duplicatesRule.Name = name;
            duplicatesRule.RuleBody = ruleBody;
            duplicatesRule.ProcedureName = procedureName;
            return duplicatesRule;
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
        /// There are no comments for Property IsActive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsActive")]
        public virtual global::System.Nullable<bool> IsActive
        {
            get
            {
                return this._IsActive;
            }
            set
            {
                this.OnIsActiveChanging(value);
                this._IsActive = value;
                this.OnIsActiveChanged();
                this.OnPropertyChanged("IsActive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _IsActive;
        partial void OnIsActiveChanging(global::System.Nullable<bool> value);
        partial void OnIsActiveChanged();
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
        /// There are no comments for Property RuleBody in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RuleBody")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RuleBody is required.")]
        public virtual string RuleBody
        {
            get
            {
                return this._RuleBody;
            }
            set
            {
                this.OnRuleBodyChanging(value);
                this._RuleBody = value;
                this.OnRuleBodyChanged();
                this.OnPropertyChanged("RuleBody");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RuleBody;
        partial void OnRuleBodyChanging(string value);
        partial void OnRuleBodyChanged();
        /// <summary>
        /// There are no comments for Property ProcedureName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProcedureName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProcedureName is required.")]
        public virtual string ProcedureName
        {
            get
            {
                return this._ProcedureName;
            }
            set
            {
                this.OnProcedureNameChanging(value);
                this._ProcedureName = value;
                this.OnProcedureNameChanged();
                this.OnPropertyChanged("ProcedureName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProcedureName;
        partial void OnProcedureNameChanging(string value);
        partial void OnProcedureNameChanged();
        /// <summary>
        /// There are no comments for Property UseAtSave in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UseAtSave")]
        public virtual global::System.Nullable<bool> UseAtSave
        {
            get
            {
                return this._UseAtSave;
            }
            set
            {
                this.OnUseAtSaveChanging(value);
                this._UseAtSave = value;
                this.OnUseAtSaveChanged();
                this.OnPropertyChanged("UseAtSave");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _UseAtSave;
        partial void OnUseAtSaveChanging(global::System.Nullable<bool> value);
        partial void OnUseAtSaveChanged();
        /// <summary>
        /// There are no comments for Property SearchObjectId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SearchObjectId")]
        public virtual global::System.Nullable<global::System.Guid> SearchObjectId
        {
            get
            {
                return this._SearchObjectId;
            }
            set
            {
                this.OnSearchObjectIdChanging(value);
                this._SearchObjectId = value;
                this.OnSearchObjectIdChanged();
                this.OnPropertyChanged("SearchObjectId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _SearchObjectId;
        partial void OnSearchObjectIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnSearchObjectIdChanged();
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
        /// There are no comments for Property Object in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Object")]
        public virtual global::Terrasoft.Configuration.OData.VwDuplicatesRuleType Object
        {
            get
            {
                return this._Object;
            }
            set
            {
                this.OnObjectChanging(value);
                this._Object = value;
                this.OnObjectChanged();
                this.OnPropertyChanged("Object");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.VwDuplicatesRuleType _Object;
        partial void OnObjectChanging(global::Terrasoft.Configuration.OData.VwDuplicatesRuleType value);
        partial void OnObjectChanged();
        /// <summary>
        /// There are no comments for Property SearchObject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SearchObject")]
        public virtual global::Terrasoft.Configuration.OData.VwDuplicatesRuleType SearchObject
        {
            get
            {
                return this._SearchObject;
            }
            set
            {
                this.OnSearchObjectChanging(value);
                this._SearchObject = value;
                this.OnSearchObjectChanged();
                this.OnPropertyChanged("SearchObject");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.VwDuplicatesRuleType _SearchObject;
        partial void OnSearchObjectChanging(global::Terrasoft.Configuration.OData.VwDuplicatesRuleType value);
        partial void OnSearchObjectChanged();
        /// <summary>
        /// There are no comments for Property DuplicatesRuleInFolderCollectionByDuplicatesRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DuplicatesRuleInFolderCollectionByDuplicatesRule")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.DuplicatesRuleInFolder> DuplicatesRuleInFolderCollectionByDuplicatesRule
        {
            get
            {
                return this._DuplicatesRuleInFolderCollectionByDuplicatesRule;
            }
            set
            {
                this.OnDuplicatesRuleInFolderCollectionByDuplicatesRuleChanging(value);
                this._DuplicatesRuleInFolderCollectionByDuplicatesRule = value;
                this.OnDuplicatesRuleInFolderCollectionByDuplicatesRuleChanged();
                this.OnPropertyChanged("DuplicatesRuleInFolderCollectionByDuplicatesRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.DuplicatesRuleInFolder> _DuplicatesRuleInFolderCollectionByDuplicatesRule = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.DuplicatesRuleInFolder>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDuplicatesRuleInFolderCollectionByDuplicatesRuleChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.DuplicatesRuleInFolder> value);
        partial void OnDuplicatesRuleInFolderCollectionByDuplicatesRuleChanged();
        /// <summary>
        /// There are no comments for Property DuplicatesRuleInTagCollectionByEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DuplicatesRuleInTagCollectionByEntity")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.DuplicatesRuleInTag> DuplicatesRuleInTagCollectionByEntity
        {
            get
            {
                return this._DuplicatesRuleInTagCollectionByEntity;
            }
            set
            {
                this.OnDuplicatesRuleInTagCollectionByEntityChanging(value);
                this._DuplicatesRuleInTagCollectionByEntity = value;
                this.OnDuplicatesRuleInTagCollectionByEntityChanged();
                this.OnPropertyChanged("DuplicatesRuleInTagCollectionByEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.DuplicatesRuleInTag> _DuplicatesRuleInTagCollectionByEntity = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.DuplicatesRuleInTag>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDuplicatesRuleInTagCollectionByEntityChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.DuplicatesRuleInTag> value);
        partial void OnDuplicatesRuleInTagCollectionByEntityChanged();
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
