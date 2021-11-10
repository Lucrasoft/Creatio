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
    /// There are no comments for VwSysProcessEntitySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("VwSysProcessEntitySingle")]
    public partial class VwSysProcessEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VwSysProcessEntity>
    {
        /// <summary>
        /// Initialize a new VwSysProcessEntitySingle object.
        /// </summary>
        public VwSysProcessEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VwSysProcessEntitySingle object.
        /// </summary>
        public VwSysProcessEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VwSysProcessEntitySingle object.
        /// </summary>
        public VwSysProcessEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VwSysProcessEntity> query)
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
        /// There are no comments for SysProcess in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SysProcess")]
        public virtual global::Terrasoft.Configuration.OData.VwSysProcessLogSingle SysProcess
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SysProcess == null))
                {
                    this._SysProcess = new global::Terrasoft.Configuration.OData.VwSysProcessLogSingle(this.Context, GetPath("SysProcess"));
                }
                return this._SysProcess;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.VwSysProcessLogSingle _SysProcess;
        /// <summary>
        /// There are no comments for SysSchema in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SysSchema")]
        public virtual global::Terrasoft.Configuration.OData.VwSysSchemaInWorkspaceSingle SysSchema
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SysSchema == null))
                {
                    this._SysSchema = new global::Terrasoft.Configuration.OData.VwSysSchemaInWorkspaceSingle(this.Context, GetPath("SysSchema"));
                }
                return this._SysSchema;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.VwSysSchemaInWorkspaceSingle _SysSchema;
        /// <summary>
        /// There are no comments for SysWorkspace in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SysWorkspace")]
        public virtual global::Terrasoft.Configuration.OData.SysWorkspaceSingle SysWorkspace
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SysWorkspace == null))
                {
                    this._SysWorkspace = new global::Terrasoft.Configuration.OData.SysWorkspaceSingle(this.Context, GetPath("SysWorkspace"));
                }
                return this._SysWorkspace;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.SysWorkspaceSingle _SysWorkspace;
    }
    /// <summary>
    /// There are no comments for VwSysProcessEntity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("VwSysProcessEntity")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("VwSysProcessEntity")]
    public partial class VwSysProcessEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VwSysProcessEntity object.
        /// </summary>
        /// <param name="entityDisplayValue">Initial value of EntityDisplayValue.</param>
        /// <param name="referenceSchemaName">Initial value of ReferenceSchemaName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VwSysProcessEntity CreateVwSysProcessEntity(string entityDisplayValue, string referenceSchemaName)
        {
            VwSysProcessEntity vwSysProcessEntity = new VwSysProcessEntity();
            vwSysProcessEntity.EntityDisplayValue = entityDisplayValue;
            vwSysProcessEntity.ReferenceSchemaName = referenceSchemaName;
            return vwSysProcessEntity;
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
        /// There are no comments for Property SysProcessId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysProcessId")]
        public virtual global::System.Nullable<global::System.Guid> SysProcessId
        {
            get
            {
                return this._SysProcessId;
            }
            set
            {
                this.OnSysProcessIdChanging(value);
                this._SysProcessId = value;
                this.OnSysProcessIdChanged();
                this.OnPropertyChanged("SysProcessId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _SysProcessId;
        partial void OnSysProcessIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnSysProcessIdChanged();
        /// <summary>
        /// There are no comments for Property EntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EntityId")]
        public virtual global::System.Nullable<global::System.Guid> EntityId
        {
            get
            {
                return this._EntityId;
            }
            set
            {
                this.OnEntityIdChanging(value);
                this._EntityId = value;
                this.OnEntityIdChanged();
                this.OnPropertyChanged("EntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _EntityId;
        partial void OnEntityIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnEntityIdChanged();
        /// <summary>
        /// There are no comments for Property EntityDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EntityDisplayValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EntityDisplayValue is required.")]
        public virtual string EntityDisplayValue
        {
            get
            {
                return this._EntityDisplayValue;
            }
            set
            {
                this.OnEntityDisplayValueChanging(value);
                this._EntityDisplayValue = value;
                this.OnEntityDisplayValueChanged();
                this.OnPropertyChanged("EntityDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EntityDisplayValue;
        partial void OnEntityDisplayValueChanging(string value);
        partial void OnEntityDisplayValueChanged();
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
        /// There are no comments for Property SysWorkspaceId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysWorkspaceId")]
        public virtual global::System.Nullable<global::System.Guid> SysWorkspaceId
        {
            get
            {
                return this._SysWorkspaceId;
            }
            set
            {
                this.OnSysWorkspaceIdChanging(value);
                this._SysWorkspaceId = value;
                this.OnSysWorkspaceIdChanged();
                this.OnPropertyChanged("SysWorkspaceId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _SysWorkspaceId;
        partial void OnSysWorkspaceIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnSysWorkspaceIdChanged();
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
        /// There are no comments for Property ReferenceSchemaName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReferenceSchemaName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReferenceSchemaName is required.")]
        public virtual string ReferenceSchemaName
        {
            get
            {
                return this._ReferenceSchemaName;
            }
            set
            {
                this.OnReferenceSchemaNameChanging(value);
                this._ReferenceSchemaName = value;
                this.OnReferenceSchemaNameChanged();
                this.OnPropertyChanged("ReferenceSchemaName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReferenceSchemaName;
        partial void OnReferenceSchemaNameChanging(string value);
        partial void OnReferenceSchemaNameChanged();
        /// <summary>
        /// There are no comments for Property Archived in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Archived")]
        public virtual global::System.Nullable<bool> Archived
        {
            get
            {
                return this._Archived;
            }
            set
            {
                this.OnArchivedChanging(value);
                this._Archived = value;
                this.OnArchivedChanged();
                this.OnPropertyChanged("Archived");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _Archived;
        partial void OnArchivedChanging(global::System.Nullable<bool> value);
        partial void OnArchivedChanged();
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
        /// There are no comments for Property SysProcess in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysProcess")]
        public virtual global::Terrasoft.Configuration.OData.VwSysProcessLog SysProcess
        {
            get
            {
                return this._SysProcess;
            }
            set
            {
                this.OnSysProcessChanging(value);
                this._SysProcess = value;
                this.OnSysProcessChanged();
                this.OnPropertyChanged("SysProcess");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.VwSysProcessLog _SysProcess;
        partial void OnSysProcessChanging(global::Terrasoft.Configuration.OData.VwSysProcessLog value);
        partial void OnSysProcessChanged();
        /// <summary>
        /// There are no comments for Property SysSchema in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysSchema")]
        public virtual global::Terrasoft.Configuration.OData.VwSysSchemaInWorkspace SysSchema
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
        private global::Terrasoft.Configuration.OData.VwSysSchemaInWorkspace _SysSchema;
        partial void OnSysSchemaChanging(global::Terrasoft.Configuration.OData.VwSysSchemaInWorkspace value);
        partial void OnSysSchemaChanged();
        /// <summary>
        /// There are no comments for Property SysWorkspace in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysWorkspace")]
        public virtual global::Terrasoft.Configuration.OData.SysWorkspace SysWorkspace
        {
            get
            {
                return this._SysWorkspace;
            }
            set
            {
                this.OnSysWorkspaceChanging(value);
                this._SysWorkspace = value;
                this.OnSysWorkspaceChanged();
                this.OnPropertyChanged("SysWorkspace");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.SysWorkspace _SysWorkspace;
        partial void OnSysWorkspaceChanging(global::Terrasoft.Configuration.OData.SysWorkspace value);
        partial void OnSysWorkspaceChanged();
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
