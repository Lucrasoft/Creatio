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
    /// There are no comments for DCReplicaSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DCReplicaSingle")]
    public partial class DCReplicaSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DCReplica>
    {
        /// <summary>
        /// Initialize a new DCReplicaSingle object.
        /// </summary>
        public DCReplicaSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DCReplicaSingle object.
        /// </summary>
        public DCReplicaSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DCReplicaSingle object.
        /// </summary>
        public DCReplicaSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DCReplica> query)
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
        /// There are no comments for DCTemplate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DCTemplate")]
        public virtual global::Terrasoft.Configuration.OData.DCTemplateSingle DCTemplate
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DCTemplate == null))
                {
                    this._DCTemplate = new global::Terrasoft.Configuration.OData.DCTemplateSingle(this.Context, GetPath("DCTemplate"));
                }
                return this._DCTemplate;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.DCTemplateSingle _DCTemplate;
        /// <summary>
        /// There are no comments for BulkEmailRecipientReplicaCollectionByDCReplica in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BulkEmailRecipientReplicaCollectionByDCReplica")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.BulkEmailRecipientReplica> BulkEmailRecipientReplicaCollectionByDCReplica
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BulkEmailRecipientReplicaCollectionByDCReplica == null))
                {
                    this._BulkEmailRecipientReplicaCollectionByDCReplica = Context.CreateQuery<global::Terrasoft.Configuration.OData.BulkEmailRecipientReplica>(GetPath("BulkEmailRecipientReplicaCollectionByDCReplica"));
                }
                return this._BulkEmailRecipientReplicaCollectionByDCReplica;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.BulkEmailRecipientReplica> _BulkEmailRecipientReplicaCollectionByDCReplica;
        /// <summary>
        /// There are no comments for BulkEmailReplicaHeadersCollectionByDCReplica in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BulkEmailReplicaHeadersCollectionByDCReplica")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.BulkEmailReplicaHeaders> BulkEmailReplicaHeadersCollectionByDCReplica
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BulkEmailReplicaHeadersCollectionByDCReplica == null))
                {
                    this._BulkEmailReplicaHeadersCollectionByDCReplica = Context.CreateQuery<global::Terrasoft.Configuration.OData.BulkEmailReplicaHeaders>(GetPath("BulkEmailReplicaHeadersCollectionByDCReplica"));
                }
                return this._BulkEmailReplicaHeadersCollectionByDCReplica;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.BulkEmailReplicaHeaders> _BulkEmailReplicaHeadersCollectionByDCReplica;
        /// <summary>
        /// There are no comments for DCBlockInReplicaCollectionByDCReplica in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DCBlockInReplicaCollectionByDCReplica")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.DCBlockInReplica> DCBlockInReplicaCollectionByDCReplica
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DCBlockInReplicaCollectionByDCReplica == null))
                {
                    this._DCBlockInReplicaCollectionByDCReplica = Context.CreateQuery<global::Terrasoft.Configuration.OData.DCBlockInReplica>(GetPath("DCBlockInReplicaCollectionByDCReplica"));
                }
                return this._DCBlockInReplicaCollectionByDCReplica;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.DCBlockInReplica> _DCBlockInReplicaCollectionByDCReplica;
        /// <summary>
        /// There are no comments for DCRecipientCollectionByDCReplica in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DCRecipientCollectionByDCReplica")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.DCRecipient> DCRecipientCollectionByDCReplica
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DCRecipientCollectionByDCReplica == null))
                {
                    this._DCRecipientCollectionByDCReplica = Context.CreateQuery<global::Terrasoft.Configuration.OData.DCRecipient>(GetPath("DCRecipientCollectionByDCReplica"));
                }
                return this._DCRecipientCollectionByDCReplica;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.DCRecipient> _DCRecipientCollectionByDCReplica;
        /// <summary>
        /// There are no comments for VwBulkEmailAudienceCollectionByReplica in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("VwBulkEmailAudienceCollectionByReplica")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.VwBulkEmailAudience> VwBulkEmailAudienceCollectionByReplica
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VwBulkEmailAudienceCollectionByReplica == null))
                {
                    this._VwBulkEmailAudienceCollectionByReplica = Context.CreateQuery<global::Terrasoft.Configuration.OData.VwBulkEmailAudience>(GetPath("VwBulkEmailAudienceCollectionByReplica"));
                }
                return this._VwBulkEmailAudienceCollectionByReplica;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.VwBulkEmailAudience> _VwBulkEmailAudienceCollectionByReplica;
        /// <summary>
        /// There are no comments for VwBulkEmailTargetCollectionByReplica in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("VwBulkEmailTargetCollectionByReplica")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.VwBulkEmailTarget> VwBulkEmailTargetCollectionByReplica
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VwBulkEmailTargetCollectionByReplica == null))
                {
                    this._VwBulkEmailTargetCollectionByReplica = Context.CreateQuery<global::Terrasoft.Configuration.OData.VwBulkEmailTarget>(GetPath("VwBulkEmailTargetCollectionByReplica"));
                }
                return this._VwBulkEmailTargetCollectionByReplica;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.VwBulkEmailTarget> _VwBulkEmailTargetCollectionByReplica;
    }
    /// <summary>
    /// There are no comments for DCReplica in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("DCReplica")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("DCReplica")]
    public partial class DCReplica : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DCReplica object.
        /// </summary>
        /// <param name="content">Initial value of Content.</param>
        /// <param name="caption">Initial value of Caption.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DCReplica CreateDCReplica(string content, string caption)
        {
            DCReplica dCReplica = new DCReplica();
            dCReplica.Content = content;
            dCReplica.Caption = caption;
            return dCReplica;
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
        /// There are no comments for Property Mask in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Mask")]
        public virtual global::System.Nullable<int> Mask
        {
            get
            {
                return this._Mask;
            }
            set
            {
                this.OnMaskChanging(value);
                this._Mask = value;
                this.OnMaskChanged();
                this.OnPropertyChanged("Mask");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _Mask;
        partial void OnMaskChanging(global::System.Nullable<int> value);
        partial void OnMaskChanged();
        /// <summary>
        /// There are no comments for Property Content in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Content")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Content is required.")]
        public virtual string Content
        {
            get
            {
                return this._Content;
            }
            set
            {
                this.OnContentChanging(value);
                this._Content = value;
                this.OnContentChanged();
                this.OnPropertyChanged("Content");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Content;
        partial void OnContentChanging(string value);
        partial void OnContentChanged();
        /// <summary>
        /// There are no comments for Property DCTemplateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DCTemplateId")]
        public virtual global::System.Nullable<global::System.Guid> DCTemplateId
        {
            get
            {
                return this._DCTemplateId;
            }
            set
            {
                this.OnDCTemplateIdChanging(value);
                this._DCTemplateId = value;
                this.OnDCTemplateIdChanged();
                this.OnPropertyChanged("DCTemplateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _DCTemplateId;
        partial void OnDCTemplateIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnDCTemplateIdChanged();
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
        /// There are no comments for Property DCTemplate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DCTemplate")]
        public virtual global::Terrasoft.Configuration.OData.DCTemplate DCTemplate
        {
            get
            {
                return this._DCTemplate;
            }
            set
            {
                this.OnDCTemplateChanging(value);
                this._DCTemplate = value;
                this.OnDCTemplateChanged();
                this.OnPropertyChanged("DCTemplate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.DCTemplate _DCTemplate;
        partial void OnDCTemplateChanging(global::Terrasoft.Configuration.OData.DCTemplate value);
        partial void OnDCTemplateChanged();
        /// <summary>
        /// There are no comments for Property BulkEmailRecipientReplicaCollectionByDCReplica in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BulkEmailRecipientReplicaCollectionByDCReplica")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.BulkEmailRecipientReplica> BulkEmailRecipientReplicaCollectionByDCReplica
        {
            get
            {
                return this._BulkEmailRecipientReplicaCollectionByDCReplica;
            }
            set
            {
                this.OnBulkEmailRecipientReplicaCollectionByDCReplicaChanging(value);
                this._BulkEmailRecipientReplicaCollectionByDCReplica = value;
                this.OnBulkEmailRecipientReplicaCollectionByDCReplicaChanged();
                this.OnPropertyChanged("BulkEmailRecipientReplicaCollectionByDCReplica");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.BulkEmailRecipientReplica> _BulkEmailRecipientReplicaCollectionByDCReplica = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.BulkEmailRecipientReplica>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBulkEmailRecipientReplicaCollectionByDCReplicaChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.BulkEmailRecipientReplica> value);
        partial void OnBulkEmailRecipientReplicaCollectionByDCReplicaChanged();
        /// <summary>
        /// There are no comments for Property BulkEmailReplicaHeadersCollectionByDCReplica in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BulkEmailReplicaHeadersCollectionByDCReplica")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.BulkEmailReplicaHeaders> BulkEmailReplicaHeadersCollectionByDCReplica
        {
            get
            {
                return this._BulkEmailReplicaHeadersCollectionByDCReplica;
            }
            set
            {
                this.OnBulkEmailReplicaHeadersCollectionByDCReplicaChanging(value);
                this._BulkEmailReplicaHeadersCollectionByDCReplica = value;
                this.OnBulkEmailReplicaHeadersCollectionByDCReplicaChanged();
                this.OnPropertyChanged("BulkEmailReplicaHeadersCollectionByDCReplica");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.BulkEmailReplicaHeaders> _BulkEmailReplicaHeadersCollectionByDCReplica = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.BulkEmailReplicaHeaders>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBulkEmailReplicaHeadersCollectionByDCReplicaChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.BulkEmailReplicaHeaders> value);
        partial void OnBulkEmailReplicaHeadersCollectionByDCReplicaChanged();
        /// <summary>
        /// There are no comments for Property DCBlockInReplicaCollectionByDCReplica in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DCBlockInReplicaCollectionByDCReplica")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.DCBlockInReplica> DCBlockInReplicaCollectionByDCReplica
        {
            get
            {
                return this._DCBlockInReplicaCollectionByDCReplica;
            }
            set
            {
                this.OnDCBlockInReplicaCollectionByDCReplicaChanging(value);
                this._DCBlockInReplicaCollectionByDCReplica = value;
                this.OnDCBlockInReplicaCollectionByDCReplicaChanged();
                this.OnPropertyChanged("DCBlockInReplicaCollectionByDCReplica");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.DCBlockInReplica> _DCBlockInReplicaCollectionByDCReplica = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.DCBlockInReplica>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDCBlockInReplicaCollectionByDCReplicaChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.DCBlockInReplica> value);
        partial void OnDCBlockInReplicaCollectionByDCReplicaChanged();
        /// <summary>
        /// There are no comments for Property DCRecipientCollectionByDCReplica in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DCRecipientCollectionByDCReplica")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.DCRecipient> DCRecipientCollectionByDCReplica
        {
            get
            {
                return this._DCRecipientCollectionByDCReplica;
            }
            set
            {
                this.OnDCRecipientCollectionByDCReplicaChanging(value);
                this._DCRecipientCollectionByDCReplica = value;
                this.OnDCRecipientCollectionByDCReplicaChanged();
                this.OnPropertyChanged("DCRecipientCollectionByDCReplica");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.DCRecipient> _DCRecipientCollectionByDCReplica = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.DCRecipient>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDCRecipientCollectionByDCReplicaChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.DCRecipient> value);
        partial void OnDCRecipientCollectionByDCReplicaChanged();
        /// <summary>
        /// There are no comments for Property VwBulkEmailAudienceCollectionByReplica in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VwBulkEmailAudienceCollectionByReplica")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.VwBulkEmailAudience> VwBulkEmailAudienceCollectionByReplica
        {
            get
            {
                return this._VwBulkEmailAudienceCollectionByReplica;
            }
            set
            {
                this.OnVwBulkEmailAudienceCollectionByReplicaChanging(value);
                this._VwBulkEmailAudienceCollectionByReplica = value;
                this.OnVwBulkEmailAudienceCollectionByReplicaChanged();
                this.OnPropertyChanged("VwBulkEmailAudienceCollectionByReplica");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.VwBulkEmailAudience> _VwBulkEmailAudienceCollectionByReplica = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.VwBulkEmailAudience>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnVwBulkEmailAudienceCollectionByReplicaChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.VwBulkEmailAudience> value);
        partial void OnVwBulkEmailAudienceCollectionByReplicaChanged();
        /// <summary>
        /// There are no comments for Property VwBulkEmailTargetCollectionByReplica in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VwBulkEmailTargetCollectionByReplica")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.VwBulkEmailTarget> VwBulkEmailTargetCollectionByReplica
        {
            get
            {
                return this._VwBulkEmailTargetCollectionByReplica;
            }
            set
            {
                this.OnVwBulkEmailTargetCollectionByReplicaChanging(value);
                this._VwBulkEmailTargetCollectionByReplica = value;
                this.OnVwBulkEmailTargetCollectionByReplicaChanged();
                this.OnPropertyChanged("VwBulkEmailTargetCollectionByReplica");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.VwBulkEmailTarget> _VwBulkEmailTargetCollectionByReplica = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.VwBulkEmailTarget>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnVwBulkEmailTargetCollectionByReplicaChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.VwBulkEmailTarget> value);
        partial void OnVwBulkEmailTargetCollectionByReplicaChanged();
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
