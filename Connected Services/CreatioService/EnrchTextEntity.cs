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
    /// There are no comments for EnrchTextEntitySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("EnrchTextEntitySingle")]
    public partial class EnrchTextEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EnrchTextEntity>
    {
        /// <summary>
        /// Initialize a new EnrchTextEntitySingle object.
        /// </summary>
        public EnrchTextEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EnrchTextEntitySingle object.
        /// </summary>
        public EnrchTextEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EnrchTextEntitySingle object.
        /// </summary>
        public EnrchTextEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EnrchTextEntity> query)
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
        /// There are no comments for EnrchEmailData in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EnrchEmailData")]
        public virtual global::Terrasoft.Configuration.OData.EnrchEmailDataSingle EnrchEmailData
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EnrchEmailData == null))
                {
                    this._EnrchEmailData = new global::Terrasoft.Configuration.OData.EnrchEmailDataSingle(this.Context, GetPath("EnrchEmailData"));
                }
                return this._EnrchEmailData;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.EnrchEmailDataSingle _EnrchEmailData;
        /// <summary>
        /// There are no comments for Parent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Parent")]
        public virtual global::Terrasoft.Configuration.OData.EnrchTextEntitySingle Parent
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Parent == null))
                {
                    this._Parent = new global::Terrasoft.Configuration.OData.EnrchTextEntitySingle(this.Context, GetPath("Parent"));
                }
                return this._Parent;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.EnrchTextEntitySingle _Parent;
        /// <summary>
        /// There are no comments for EnrchTextEntityCollectionByParent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EnrchTextEntityCollectionByParent")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.EnrchTextEntity> EnrchTextEntityCollectionByParent
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EnrchTextEntityCollectionByParent == null))
                {
                    this._EnrchTextEntityCollectionByParent = Context.CreateQuery<global::Terrasoft.Configuration.OData.EnrchTextEntity>(GetPath("EnrchTextEntityCollectionByParent"));
                }
                return this._EnrchTextEntityCollectionByParent;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.EnrchTextEntity> _EnrchTextEntityCollectionByParent;
        /// <summary>
        /// There are no comments for EnrchFoundAccountCollectionByEnrchTextEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EnrchFoundAccountCollectionByEnrchTextEntity")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.EnrchFoundAccount> EnrchFoundAccountCollectionByEnrchTextEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EnrchFoundAccountCollectionByEnrchTextEntity == null))
                {
                    this._EnrchFoundAccountCollectionByEnrchTextEntity = Context.CreateQuery<global::Terrasoft.Configuration.OData.EnrchFoundAccount>(GetPath("EnrchFoundAccountCollectionByEnrchTextEntity"));
                }
                return this._EnrchFoundAccountCollectionByEnrchTextEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.EnrchFoundAccount> _EnrchFoundAccountCollectionByEnrchTextEntity;
        /// <summary>
        /// There are no comments for EnrchFoundContactCollectionByEnrchTextEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EnrchFoundContactCollectionByEnrchTextEntity")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.EnrchFoundContact> EnrchFoundContactCollectionByEnrchTextEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EnrchFoundContactCollectionByEnrchTextEntity == null))
                {
                    this._EnrchFoundContactCollectionByEnrchTextEntity = Context.CreateQuery<global::Terrasoft.Configuration.OData.EnrchFoundContact>(GetPath("EnrchFoundContactCollectionByEnrchTextEntity"));
                }
                return this._EnrchFoundContactCollectionByEnrchTextEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.EnrchFoundContact> _EnrchFoundContactCollectionByEnrchTextEntity;
    }
    /// <summary>
    /// There are no comments for EnrchTextEntity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("EnrchTextEntity")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("EnrchTextEntity")]
    public partial class EnrchTextEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EnrchTextEntity object.
        /// </summary>
        /// <param name="type">Initial value of Type.</param>
        /// <param name="jsonData">Initial value of JsonData.</param>
        /// <param name="hash">Initial value of Hash.</param>
        /// <param name="duplicationStatus">Initial value of DuplicationStatus.</param>
        /// <param name="source">Initial value of Source.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EnrchTextEntity CreateEnrchTextEntity(string type, string jsonData, string hash, string duplicationStatus, string source)
        {
            EnrchTextEntity enrchTextEntity = new EnrchTextEntity();
            enrchTextEntity.Type = type;
            enrchTextEntity.JsonData = jsonData;
            enrchTextEntity.Hash = hash;
            enrchTextEntity.DuplicationStatus = duplicationStatus;
            enrchTextEntity.Source = source;
            return enrchTextEntity;
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
        /// There are no comments for Property EnrchEmailDataId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnrchEmailDataId")]
        public virtual global::System.Nullable<global::System.Guid> EnrchEmailDataId
        {
            get
            {
                return this._EnrchEmailDataId;
            }
            set
            {
                this.OnEnrchEmailDataIdChanging(value);
                this._EnrchEmailDataId = value;
                this.OnEnrchEmailDataIdChanged();
                this.OnPropertyChanged("EnrchEmailDataId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _EnrchEmailDataId;
        partial void OnEnrchEmailDataIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnEnrchEmailDataIdChanged();
        /// <summary>
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Type")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Type is required.")]
        public virtual string Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Type;
        partial void OnTypeChanging(string value);
        partial void OnTypeChanged();
        /// <summary>
        /// There are no comments for Property JsonData in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JsonData")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JsonData is required.")]
        public virtual string JsonData
        {
            get
            {
                return this._JsonData;
            }
            set
            {
                this.OnJsonDataChanging(value);
                this._JsonData = value;
                this.OnJsonDataChanged();
                this.OnPropertyChanged("JsonData");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JsonData;
        partial void OnJsonDataChanging(string value);
        partial void OnJsonDataChanged();
        /// <summary>
        /// There are no comments for Property Hash in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Hash")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Hash is required.")]
        public virtual string Hash
        {
            get
            {
                return this._Hash;
            }
            set
            {
                this.OnHashChanging(value);
                this._Hash = value;
                this.OnHashChanged();
                this.OnPropertyChanged("Hash");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Hash;
        partial void OnHashChanging(string value);
        partial void OnHashChanged();
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
        /// There are no comments for Property DuplicationStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DuplicationStatus")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DuplicationStatus is required.")]
        public virtual string DuplicationStatus
        {
            get
            {
                return this._DuplicationStatus;
            }
            set
            {
                this.OnDuplicationStatusChanging(value);
                this._DuplicationStatus = value;
                this.OnDuplicationStatusChanged();
                this.OnPropertyChanged("DuplicationStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DuplicationStatus;
        partial void OnDuplicationStatusChanging(string value);
        partial void OnDuplicationStatusChanged();
        /// <summary>
        /// There are no comments for Property Source in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Source")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Source is required.")]
        public virtual string Source
        {
            get
            {
                return this._Source;
            }
            set
            {
                this.OnSourceChanging(value);
                this._Source = value;
                this.OnSourceChanged();
                this.OnPropertyChanged("Source");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Source;
        partial void OnSourceChanging(string value);
        partial void OnSourceChanged();
        /// <summary>
        /// There are no comments for Property HashVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("HashVersion")]
        public virtual global::System.Nullable<int> HashVersion
        {
            get
            {
                return this._HashVersion;
            }
            set
            {
                this.OnHashVersionChanging(value);
                this._HashVersion = value;
                this.OnHashVersionChanged();
                this.OnPropertyChanged("HashVersion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _HashVersion;
        partial void OnHashVersionChanging(global::System.Nullable<int> value);
        partial void OnHashVersionChanged();
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
        /// There are no comments for Property EnrchEmailData in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnrchEmailData")]
        public virtual global::Terrasoft.Configuration.OData.EnrchEmailData EnrchEmailData
        {
            get
            {
                return this._EnrchEmailData;
            }
            set
            {
                this.OnEnrchEmailDataChanging(value);
                this._EnrchEmailData = value;
                this.OnEnrchEmailDataChanged();
                this.OnPropertyChanged("EnrchEmailData");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.EnrchEmailData _EnrchEmailData;
        partial void OnEnrchEmailDataChanging(global::Terrasoft.Configuration.OData.EnrchEmailData value);
        partial void OnEnrchEmailDataChanged();
        /// <summary>
        /// There are no comments for Property Parent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Parent")]
        public virtual global::Terrasoft.Configuration.OData.EnrchTextEntity Parent
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
        private global::Terrasoft.Configuration.OData.EnrchTextEntity _Parent;
        partial void OnParentChanging(global::Terrasoft.Configuration.OData.EnrchTextEntity value);
        partial void OnParentChanged();
        /// <summary>
        /// There are no comments for Property EnrchTextEntityCollectionByParent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnrchTextEntityCollectionByParent")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.EnrchTextEntity> EnrchTextEntityCollectionByParent
        {
            get
            {
                return this._EnrchTextEntityCollectionByParent;
            }
            set
            {
                this.OnEnrchTextEntityCollectionByParentChanging(value);
                this._EnrchTextEntityCollectionByParent = value;
                this.OnEnrchTextEntityCollectionByParentChanged();
                this.OnPropertyChanged("EnrchTextEntityCollectionByParent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.EnrchTextEntity> _EnrchTextEntityCollectionByParent = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.EnrchTextEntity>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEnrchTextEntityCollectionByParentChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.EnrchTextEntity> value);
        partial void OnEnrchTextEntityCollectionByParentChanged();
        /// <summary>
        /// There are no comments for Property EnrchFoundAccountCollectionByEnrchTextEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnrchFoundAccountCollectionByEnrchTextEntity")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.EnrchFoundAccount> EnrchFoundAccountCollectionByEnrchTextEntity
        {
            get
            {
                return this._EnrchFoundAccountCollectionByEnrchTextEntity;
            }
            set
            {
                this.OnEnrchFoundAccountCollectionByEnrchTextEntityChanging(value);
                this._EnrchFoundAccountCollectionByEnrchTextEntity = value;
                this.OnEnrchFoundAccountCollectionByEnrchTextEntityChanged();
                this.OnPropertyChanged("EnrchFoundAccountCollectionByEnrchTextEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.EnrchFoundAccount> _EnrchFoundAccountCollectionByEnrchTextEntity = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.EnrchFoundAccount>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEnrchFoundAccountCollectionByEnrchTextEntityChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.EnrchFoundAccount> value);
        partial void OnEnrchFoundAccountCollectionByEnrchTextEntityChanged();
        /// <summary>
        /// There are no comments for Property EnrchFoundContactCollectionByEnrchTextEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnrchFoundContactCollectionByEnrchTextEntity")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.EnrchFoundContact> EnrchFoundContactCollectionByEnrchTextEntity
        {
            get
            {
                return this._EnrchFoundContactCollectionByEnrchTextEntity;
            }
            set
            {
                this.OnEnrchFoundContactCollectionByEnrchTextEntityChanging(value);
                this._EnrchFoundContactCollectionByEnrchTextEntity = value;
                this.OnEnrchFoundContactCollectionByEnrchTextEntityChanged();
                this.OnPropertyChanged("EnrchFoundContactCollectionByEnrchTextEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.EnrchFoundContact> _EnrchFoundContactCollectionByEnrchTextEntity = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.EnrchFoundContact>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEnrchFoundContactCollectionByEnrchTextEntityChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.EnrchFoundContact> value);
        partial void OnEnrchFoundContactCollectionByEnrchTextEntityChanged();
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
