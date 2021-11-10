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
    /// There are no comments for SysLDAPSynchGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SysLDAPSynchGroupSingle")]
    public partial class SysLDAPSynchGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SysLDAPSynchGroup>
    {
        /// <summary>
        /// Initialize a new SysLDAPSynchGroupSingle object.
        /// </summary>
        public SysLDAPSynchGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SysLDAPSynchGroupSingle object.
        /// </summary>
        public SysLDAPSynchGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SysLDAPSynchGroupSingle object.
        /// </summary>
        public SysLDAPSynchGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SysLDAPSynchGroup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for SysLDAPSynchGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// RecordId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("RecordId")]
    [global::Microsoft.OData.Client.EntitySet("SysLDAPSynchGroup")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SysLDAPSynchGroup")]
    public partial class SysLDAPSynchGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SysLDAPSynchGroup object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="dn">Initial value of Dn.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SysLDAPSynchGroup CreateSysLDAPSynchGroup(string ID, string name, string dn)
        {
            SysLDAPSynchGroup sysLDAPSynchGroup = new SysLDAPSynchGroup();
            sysLDAPSynchGroup.Id = ID;
            sysLDAPSynchGroup.Name = name;
            sysLDAPSynchGroup.Dn = dn;
            return sysLDAPSynchGroup;
        }
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
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Id")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Id is required.")]
        public virtual string Id
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
        private string _Id;
        partial void OnIdChanging(string value);
        partial void OnIdChanged();
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
        /// There are no comments for Property Dn in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Dn")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Dn is required.")]
        public virtual string Dn
        {
            get
            {
                return this._Dn;
            }
            set
            {
                this.OnDnChanging(value);
                this._Dn = value;
                this.OnDnChanged();
                this.OnPropertyChanged("Dn");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Dn;
        partial void OnDnChanging(string value);
        partial void OnDnChanged();
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
        /// There are no comments for Property LdapSyncId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LdapSyncId")]
        public virtual global::System.Nullable<global::System.Guid> LdapSyncId
        {
            get
            {
                return this._LdapSyncId;
            }
            set
            {
                this.OnLdapSyncIdChanging(value);
                this._LdapSyncId = value;
                this.OnLdapSyncIdChanged();
                this.OnPropertyChanged("LdapSyncId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _LdapSyncId;
        partial void OnLdapSyncIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnLdapSyncIdChanged();
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
