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
    /// There are no comments for VwSysProcessSchemaUserRightSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("VwSysProcessSchemaUserRightSingle")]
    public partial class VwSysProcessSchemaUserRightSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VwSysProcessSchemaUserRight>
    {
        /// <summary>
        /// Initialize a new VwSysProcessSchemaUserRightSingle object.
        /// </summary>
        public VwSysProcessSchemaUserRightSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VwSysProcessSchemaUserRightSingle object.
        /// </summary>
        public VwSysProcessSchemaUserRightSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VwSysProcessSchemaUserRightSingle object.
        /// </summary>
        public VwSysProcessSchemaUserRightSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VwSysProcessSchemaUserRight> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for SysAdminUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SysAdminUnit")]
        public virtual global::Terrasoft.Configuration.OData.SysAdminUnitSingle SysAdminUnit
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SysAdminUnit == null))
                {
                    this._SysAdminUnit = new global::Terrasoft.Configuration.OData.SysAdminUnitSingle(this.Context, GetPath("SysAdminUnit"));
                }
                return this._SysAdminUnit;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.SysAdminUnitSingle _SysAdminUnit;
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
    }
    /// <summary>
    /// There are no comments for VwSysProcessSchemaUserRight in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("VwSysProcessSchemaUserRight")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("VwSysProcessSchemaUserRight")]
    public partial class VwSysProcessSchemaUserRight : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
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
        /// There are no comments for Property SysAdminUnitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysAdminUnitId")]
        public virtual global::System.Nullable<global::System.Guid> SysAdminUnitId
        {
            get
            {
                return this._SysAdminUnitId;
            }
            set
            {
                this.OnSysAdminUnitIdChanging(value);
                this._SysAdminUnitId = value;
                this.OnSysAdminUnitIdChanged();
                this.OnPropertyChanged("SysAdminUnitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _SysAdminUnitId;
        partial void OnSysAdminUnitIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnSysAdminUnitIdChanged();
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
        /// There are no comments for Property SysAdminUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysAdminUnit")]
        public virtual global::Terrasoft.Configuration.OData.SysAdminUnit SysAdminUnit
        {
            get
            {
                return this._SysAdminUnit;
            }
            set
            {
                this.OnSysAdminUnitChanging(value);
                this._SysAdminUnit = value;
                this.OnSysAdminUnitChanged();
                this.OnPropertyChanged("SysAdminUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.SysAdminUnit _SysAdminUnit;
        partial void OnSysAdminUnitChanging(global::Terrasoft.Configuration.OData.SysAdminUnit value);
        partial void OnSysAdminUnitChanged();
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
