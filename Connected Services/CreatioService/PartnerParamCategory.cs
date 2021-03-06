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
    /// There are no comments for PartnerParamCategorySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PartnerParamCategorySingle")]
    public partial class PartnerParamCategorySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PartnerParamCategory>
    {
        /// <summary>
        /// Initialize a new PartnerParamCategorySingle object.
        /// </summary>
        public PartnerParamCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PartnerParamCategorySingle object.
        /// </summary>
        public PartnerParamCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PartnerParamCategorySingle object.
        /// </summary>
        public PartnerParamCategorySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PartnerParamCategory> query)
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
        /// There are no comments for LevelPartnershipParamCollectionByPartnerParamCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LevelPartnershipParamCollectionByPartnerParamCategory")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.LevelPartnershipParam> LevelPartnershipParamCollectionByPartnerParamCategory
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LevelPartnershipParamCollectionByPartnerParamCategory == null))
                {
                    this._LevelPartnershipParamCollectionByPartnerParamCategory = Context.CreateQuery<global::Terrasoft.Configuration.OData.LevelPartnershipParam>(GetPath("LevelPartnershipParamCollectionByPartnerParamCategory"));
                }
                return this._LevelPartnershipParamCollectionByPartnerParamCategory;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.LevelPartnershipParam> _LevelPartnershipParamCollectionByPartnerParamCategory;
        /// <summary>
        /// There are no comments for PartnerParamHistoryCollectionByPartnerParamCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PartnerParamHistoryCollectionByPartnerParamCategory")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.PartnerParamHistory> PartnerParamHistoryCollectionByPartnerParamCategory
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PartnerParamHistoryCollectionByPartnerParamCategory == null))
                {
                    this._PartnerParamHistoryCollectionByPartnerParamCategory = Context.CreateQuery<global::Terrasoft.Configuration.OData.PartnerParamHistory>(GetPath("PartnerParamHistoryCollectionByPartnerParamCategory"));
                }
                return this._PartnerParamHistoryCollectionByPartnerParamCategory;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.PartnerParamHistory> _PartnerParamHistoryCollectionByPartnerParamCategory;
        /// <summary>
        /// There are no comments for PartnershipParameterCollectionByPartnerParamCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PartnershipParameterCollectionByPartnerParamCategory")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.PartnershipParameter> PartnershipParameterCollectionByPartnerParamCategory
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PartnershipParameterCollectionByPartnerParamCategory == null))
                {
                    this._PartnershipParameterCollectionByPartnerParamCategory = Context.CreateQuery<global::Terrasoft.Configuration.OData.PartnershipParameter>(GetPath("PartnershipParameterCollectionByPartnerParamCategory"));
                }
                return this._PartnershipParameterCollectionByPartnerParamCategory;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.PartnershipParameter> _PartnershipParameterCollectionByPartnerParamCategory;
    }
    /// <summary>
    /// There are no comments for PartnerParamCategory in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("PartnerParamCategory")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PartnerParamCategory")]
    public partial class PartnerParamCategory : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PartnerParamCategory object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="description">Initial value of Description.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PartnerParamCategory CreatePartnerParamCategory(string name, string description)
        {
            PartnerParamCategory partnerParamCategory = new PartnerParamCategory();
            partnerParamCategory.Name = name;
            partnerParamCategory.Description = description;
            return partnerParamCategory;
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
        /// There are no comments for Property LevelPartnershipParamCollectionByPartnerParamCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LevelPartnershipParamCollectionByPartnerParamCategory")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.LevelPartnershipParam> LevelPartnershipParamCollectionByPartnerParamCategory
        {
            get
            {
                return this._LevelPartnershipParamCollectionByPartnerParamCategory;
            }
            set
            {
                this.OnLevelPartnershipParamCollectionByPartnerParamCategoryChanging(value);
                this._LevelPartnershipParamCollectionByPartnerParamCategory = value;
                this.OnLevelPartnershipParamCollectionByPartnerParamCategoryChanged();
                this.OnPropertyChanged("LevelPartnershipParamCollectionByPartnerParamCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.LevelPartnershipParam> _LevelPartnershipParamCollectionByPartnerParamCategory = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.LevelPartnershipParam>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLevelPartnershipParamCollectionByPartnerParamCategoryChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.LevelPartnershipParam> value);
        partial void OnLevelPartnershipParamCollectionByPartnerParamCategoryChanged();
        /// <summary>
        /// There are no comments for Property PartnerParamHistoryCollectionByPartnerParamCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PartnerParamHistoryCollectionByPartnerParamCategory")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.PartnerParamHistory> PartnerParamHistoryCollectionByPartnerParamCategory
        {
            get
            {
                return this._PartnerParamHistoryCollectionByPartnerParamCategory;
            }
            set
            {
                this.OnPartnerParamHistoryCollectionByPartnerParamCategoryChanging(value);
                this._PartnerParamHistoryCollectionByPartnerParamCategory = value;
                this.OnPartnerParamHistoryCollectionByPartnerParamCategoryChanged();
                this.OnPropertyChanged("PartnerParamHistoryCollectionByPartnerParamCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.PartnerParamHistory> _PartnerParamHistoryCollectionByPartnerParamCategory = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.PartnerParamHistory>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPartnerParamHistoryCollectionByPartnerParamCategoryChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.PartnerParamHistory> value);
        partial void OnPartnerParamHistoryCollectionByPartnerParamCategoryChanged();
        /// <summary>
        /// There are no comments for Property PartnershipParameterCollectionByPartnerParamCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PartnershipParameterCollectionByPartnerParamCategory")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.PartnershipParameter> PartnershipParameterCollectionByPartnerParamCategory
        {
            get
            {
                return this._PartnershipParameterCollectionByPartnerParamCategory;
            }
            set
            {
                this.OnPartnershipParameterCollectionByPartnerParamCategoryChanging(value);
                this._PartnershipParameterCollectionByPartnerParamCategory = value;
                this.OnPartnershipParameterCollectionByPartnerParamCategoryChanged();
                this.OnPropertyChanged("PartnershipParameterCollectionByPartnerParamCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.PartnershipParameter> _PartnershipParameterCollectionByPartnerParamCategory = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.PartnershipParameter>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPartnershipParameterCollectionByPartnerParamCategoryChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.PartnershipParameter> value);
        partial void OnPartnershipParameterCollectionByPartnerParamCategoryChanged();
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
