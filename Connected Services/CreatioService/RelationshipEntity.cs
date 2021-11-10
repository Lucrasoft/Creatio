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
    /// There are no comments for RelationshipEntitySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RelationshipEntitySingle")]
    public partial class RelationshipEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RelationshipEntity>
    {
        /// <summary>
        /// Initialize a new RelationshipEntitySingle object.
        /// </summary>
        public RelationshipEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RelationshipEntitySingle object.
        /// </summary>
        public RelationshipEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RelationshipEntitySingle object.
        /// </summary>
        public RelationshipEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RelationshipEntity> query)
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
        /// There are no comments for RelationEntInDiagramCollectionByRelationshipEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RelationEntInDiagramCollectionByRelationshipEntity")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.RelationEntInDiagram> RelationEntInDiagramCollectionByRelationshipEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RelationEntInDiagramCollectionByRelationshipEntity == null))
                {
                    this._RelationEntInDiagramCollectionByRelationshipEntity = Context.CreateQuery<global::Terrasoft.Configuration.OData.RelationEntInDiagram>(GetPath("RelationEntInDiagramCollectionByRelationshipEntity"));
                }
                return this._RelationEntInDiagramCollectionByRelationshipEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.RelationEntInDiagram> _RelationEntInDiagramCollectionByRelationshipEntity;
        /// <summary>
        /// There are no comments for RelationEntityInGroupCollectionByRelationshipEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RelationEntityInGroupCollectionByRelationshipEntity")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.RelationEntityInGroup> RelationEntityInGroupCollectionByRelationshipEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RelationEntityInGroupCollectionByRelationshipEntity == null))
                {
                    this._RelationEntityInGroupCollectionByRelationshipEntity = Context.CreateQuery<global::Terrasoft.Configuration.OData.RelationEntityInGroup>(GetPath("RelationEntityInGroupCollectionByRelationshipEntity"));
                }
                return this._RelationEntityInGroupCollectionByRelationshipEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.RelationEntityInGroup> _RelationEntityInGroupCollectionByRelationshipEntity;
        /// <summary>
        /// There are no comments for RelationshipConnectionCollectionByRelationshipEntityA in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RelationshipConnectionCollectionByRelationshipEntityA")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.RelationshipConnection> RelationshipConnectionCollectionByRelationshipEntityA
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RelationshipConnectionCollectionByRelationshipEntityA == null))
                {
                    this._RelationshipConnectionCollectionByRelationshipEntityA = Context.CreateQuery<global::Terrasoft.Configuration.OData.RelationshipConnection>(GetPath("RelationshipConnectionCollectionByRelationshipEntityA"));
                }
                return this._RelationshipConnectionCollectionByRelationshipEntityA;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.RelationshipConnection> _RelationshipConnectionCollectionByRelationshipEntityA;
        /// <summary>
        /// There are no comments for RelationshipConnectionCollectionByRelationshipEntityB in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RelationshipConnectionCollectionByRelationshipEntityB")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.RelationshipConnection> RelationshipConnectionCollectionByRelationshipEntityB
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RelationshipConnectionCollectionByRelationshipEntityB == null))
                {
                    this._RelationshipConnectionCollectionByRelationshipEntityB = Context.CreateQuery<global::Terrasoft.Configuration.OData.RelationshipConnection>(GetPath("RelationshipConnectionCollectionByRelationshipEntityB"));
                }
                return this._RelationshipConnectionCollectionByRelationshipEntityB;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.RelationshipConnection> _RelationshipConnectionCollectionByRelationshipEntityB;
    }
    /// <summary>
    /// There are no comments for RelationshipEntity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("RelationshipEntity")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RelationshipEntity")]
    public partial class RelationshipEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
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
        /// There are no comments for Property RecordId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecordId")]
        public virtual global::System.Nullable<global::System.Guid> RecordId
        {
            get
            {
                return this._RecordId;
            }
            set
            {
                this.OnRecordIdChanging(value);
                this._RecordId = value;
                this.OnRecordIdChanged();
                this.OnPropertyChanged("RecordId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _RecordId;
        partial void OnRecordIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnRecordIdChanged();
        /// <summary>
        /// There are no comments for Property SchemaUId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SchemaUId")]
        public virtual global::System.Nullable<global::System.Guid> SchemaUId
        {
            get
            {
                return this._SchemaUId;
            }
            set
            {
                this.OnSchemaUIdChanging(value);
                this._SchemaUId = value;
                this.OnSchemaUIdChanged();
                this.OnPropertyChanged("SchemaUId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _SchemaUId;
        partial void OnSchemaUIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnSchemaUIdChanged();
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
        /// There are no comments for Property RelationEntInDiagramCollectionByRelationshipEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RelationEntInDiagramCollectionByRelationshipEntity")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.RelationEntInDiagram> RelationEntInDiagramCollectionByRelationshipEntity
        {
            get
            {
                return this._RelationEntInDiagramCollectionByRelationshipEntity;
            }
            set
            {
                this.OnRelationEntInDiagramCollectionByRelationshipEntityChanging(value);
                this._RelationEntInDiagramCollectionByRelationshipEntity = value;
                this.OnRelationEntInDiagramCollectionByRelationshipEntityChanged();
                this.OnPropertyChanged("RelationEntInDiagramCollectionByRelationshipEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.RelationEntInDiagram> _RelationEntInDiagramCollectionByRelationshipEntity = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.RelationEntInDiagram>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRelationEntInDiagramCollectionByRelationshipEntityChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.RelationEntInDiagram> value);
        partial void OnRelationEntInDiagramCollectionByRelationshipEntityChanged();
        /// <summary>
        /// There are no comments for Property RelationEntityInGroupCollectionByRelationshipEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RelationEntityInGroupCollectionByRelationshipEntity")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.RelationEntityInGroup> RelationEntityInGroupCollectionByRelationshipEntity
        {
            get
            {
                return this._RelationEntityInGroupCollectionByRelationshipEntity;
            }
            set
            {
                this.OnRelationEntityInGroupCollectionByRelationshipEntityChanging(value);
                this._RelationEntityInGroupCollectionByRelationshipEntity = value;
                this.OnRelationEntityInGroupCollectionByRelationshipEntityChanged();
                this.OnPropertyChanged("RelationEntityInGroupCollectionByRelationshipEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.RelationEntityInGroup> _RelationEntityInGroupCollectionByRelationshipEntity = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.RelationEntityInGroup>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRelationEntityInGroupCollectionByRelationshipEntityChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.RelationEntityInGroup> value);
        partial void OnRelationEntityInGroupCollectionByRelationshipEntityChanged();
        /// <summary>
        /// There are no comments for Property RelationshipConnectionCollectionByRelationshipEntityA in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RelationshipConnectionCollectionByRelationshipEntityA")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.RelationshipConnection> RelationshipConnectionCollectionByRelationshipEntityA
        {
            get
            {
                return this._RelationshipConnectionCollectionByRelationshipEntityA;
            }
            set
            {
                this.OnRelationshipConnectionCollectionByRelationshipEntityAChanging(value);
                this._RelationshipConnectionCollectionByRelationshipEntityA = value;
                this.OnRelationshipConnectionCollectionByRelationshipEntityAChanged();
                this.OnPropertyChanged("RelationshipConnectionCollectionByRelationshipEntityA");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.RelationshipConnection> _RelationshipConnectionCollectionByRelationshipEntityA = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.RelationshipConnection>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRelationshipConnectionCollectionByRelationshipEntityAChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.RelationshipConnection> value);
        partial void OnRelationshipConnectionCollectionByRelationshipEntityAChanged();
        /// <summary>
        /// There are no comments for Property RelationshipConnectionCollectionByRelationshipEntityB in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RelationshipConnectionCollectionByRelationshipEntityB")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.RelationshipConnection> RelationshipConnectionCollectionByRelationshipEntityB
        {
            get
            {
                return this._RelationshipConnectionCollectionByRelationshipEntityB;
            }
            set
            {
                this.OnRelationshipConnectionCollectionByRelationshipEntityBChanging(value);
                this._RelationshipConnectionCollectionByRelationshipEntityB = value;
                this.OnRelationshipConnectionCollectionByRelationshipEntityBChanged();
                this.OnPropertyChanged("RelationshipConnectionCollectionByRelationshipEntityB");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.RelationshipConnection> _RelationshipConnectionCollectionByRelationshipEntityB = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.RelationshipConnection>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRelationshipConnectionCollectionByRelationshipEntityBChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.RelationshipConnection> value);
        partial void OnRelationshipConnectionCollectionByRelationshipEntityBChanged();
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