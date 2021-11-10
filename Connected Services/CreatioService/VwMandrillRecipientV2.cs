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
    /// There are no comments for VwMandrillRecipientV2Single in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("VwMandrillRecipientV2Single")]
    public partial class VwMandrillRecipientV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<VwMandrillRecipientV2>
    {
        /// <summary>
        /// Initialize a new VwMandrillRecipientV2Single object.
        /// </summary>
        public VwMandrillRecipientV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VwMandrillRecipientV2Single object.
        /// </summary>
        public VwMandrillRecipientV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VwMandrillRecipientV2Single object.
        /// </summary>
        public VwMandrillRecipientV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<VwMandrillRecipientV2> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BulkEmail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BulkEmail")]
        public virtual global::Terrasoft.Configuration.OData.BulkEmailSingle BulkEmail
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BulkEmail == null))
                {
                    this._BulkEmail = new global::Terrasoft.Configuration.OData.BulkEmailSingle(this.Context, GetPath("BulkEmail"));
                }
                return this._BulkEmail;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.BulkEmailSingle _BulkEmail;
        /// <summary>
        /// There are no comments for Contact in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Contact")]
        public virtual global::Terrasoft.Configuration.OData.ContactSingle Contact
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Contact == null))
                {
                    this._Contact = new global::Terrasoft.Configuration.OData.ContactSingle(this.Context, GetPath("Contact"));
                }
                return this._Contact;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.ContactSingle _Contact;
        /// <summary>
        /// There are no comments for LinkedEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LinkedEntity")]
        public virtual global::Terrasoft.Configuration.OData.ContactSingle LinkedEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LinkedEntity == null))
                {
                    this._LinkedEntity = new global::Terrasoft.Configuration.OData.ContactSingle(this.Context, GetPath("LinkedEntity"));
                }
                return this._LinkedEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.ContactSingle _LinkedEntity;
    }
    /// <summary>
    /// There are no comments for VwMandrillRecipientV2 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("VwMandrillRecipientV2")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("VwMandrillRecipientV2")]
    public partial class VwMandrillRecipientV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property BulkEmailId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BulkEmailId")]
        public virtual global::System.Nullable<global::System.Guid> BulkEmailId
        {
            get
            {
                return this._BulkEmailId;
            }
            set
            {
                this.OnBulkEmailIdChanging(value);
                this._BulkEmailId = value;
                this.OnBulkEmailIdChanged();
                this.OnPropertyChanged("BulkEmailId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _BulkEmailId;
        partial void OnBulkEmailIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnBulkEmailIdChanged();
        /// <summary>
        /// There are no comments for Property ContactId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContactId")]
        public virtual global::System.Nullable<global::System.Guid> ContactId
        {
            get
            {
                return this._ContactId;
            }
            set
            {
                this.OnContactIdChanging(value);
                this._ContactId = value;
                this.OnContactIdChanged();
                this.OnPropertyChanged("ContactId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _ContactId;
        partial void OnContactIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnContactIdChanged();
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
        /// There are no comments for Property LinkedEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LinkedEntityId")]
        public virtual global::System.Nullable<global::System.Guid> LinkedEntityId
        {
            get
            {
                return this._LinkedEntityId;
            }
            set
            {
                this.OnLinkedEntityIdChanging(value);
                this._LinkedEntityId = value;
                this.OnLinkedEntityIdChanged();
                this.OnPropertyChanged("LinkedEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _LinkedEntityId;
        partial void OnLinkedEntityIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnLinkedEntityIdChanged();
        /// <summary>
        /// There are no comments for Property BulkEmail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BulkEmail")]
        public virtual global::Terrasoft.Configuration.OData.BulkEmail BulkEmail
        {
            get
            {
                return this._BulkEmail;
            }
            set
            {
                this.OnBulkEmailChanging(value);
                this._BulkEmail = value;
                this.OnBulkEmailChanged();
                this.OnPropertyChanged("BulkEmail");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.BulkEmail _BulkEmail;
        partial void OnBulkEmailChanging(global::Terrasoft.Configuration.OData.BulkEmail value);
        partial void OnBulkEmailChanged();
        /// <summary>
        /// There are no comments for Property Contact in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Contact")]
        public virtual global::Terrasoft.Configuration.OData.Contact Contact
        {
            get
            {
                return this._Contact;
            }
            set
            {
                this.OnContactChanging(value);
                this._Contact = value;
                this.OnContactChanged();
                this.OnPropertyChanged("Contact");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.Contact _Contact;
        partial void OnContactChanging(global::Terrasoft.Configuration.OData.Contact value);
        partial void OnContactChanged();
        /// <summary>
        /// There are no comments for Property LinkedEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LinkedEntity")]
        public virtual global::Terrasoft.Configuration.OData.Contact LinkedEntity
        {
            get
            {
                return this._LinkedEntity;
            }
            set
            {
                this.OnLinkedEntityChanging(value);
                this._LinkedEntity = value;
                this.OnLinkedEntityChanged();
                this.OnPropertyChanged("LinkedEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.Contact _LinkedEntity;
        partial void OnLinkedEntityChanging(global::Terrasoft.Configuration.OData.Contact value);
        partial void OnLinkedEntityChanged();
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