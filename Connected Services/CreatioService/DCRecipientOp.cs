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
    /// There are no comments for DCRecipientOpSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DCRecipientOpSingle")]
    public partial class DCRecipientOpSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DCRecipientOp>
    {
        /// <summary>
        /// Initialize a new DCRecipientOpSingle object.
        /// </summary>
        public DCRecipientOpSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DCRecipientOpSingle object.
        /// </summary>
        public DCRecipientOpSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DCRecipientOpSingle object.
        /// </summary>
        public DCRecipientOpSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DCRecipientOp> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for DCRecipientOp in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("DCRecipientOp")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("DCRecipientOp")]
    public partial class DCRecipientOp : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
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
        /// There are no comments for Property GroupIndex in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GroupIndex")]
        public virtual global::System.Nullable<int> GroupIndex
        {
            get
            {
                return this._GroupIndex;
            }
            set
            {
                this.OnGroupIndexChanging(value);
                this._GroupIndex = value;
                this.OnGroupIndexChanged();
                this.OnPropertyChanged("GroupIndex");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _GroupIndex;
        partial void OnGroupIndexChanging(global::System.Nullable<int> value);
        partial void OnGroupIndexChanged();
        /// <summary>
        /// There are no comments for Property BlockIndex in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BlockIndex")]
        public virtual global::System.Nullable<int> BlockIndex
        {
            get
            {
                return this._BlockIndex;
            }
            set
            {
                this.OnBlockIndexChanging(value);
                this._BlockIndex = value;
                this.OnBlockIndexChanged();
                this.OnPropertyChanged("BlockIndex");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _BlockIndex;
        partial void OnBlockIndexChanging(global::System.Nullable<int> value);
        partial void OnBlockIndexChanged();
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
        /// There are no comments for Property SessionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SessionId")]
        public virtual global::System.Nullable<global::System.Guid> SessionId
        {
            get
            {
                return this._SessionId;
            }
            set
            {
                this.OnSessionIdChanging(value);
                this._SessionId = value;
                this.OnSessionIdChanged();
                this.OnPropertyChanged("SessionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _SessionId;
        partial void OnSessionIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnSessionIdChanged();
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