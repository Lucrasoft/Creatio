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
    /// There are no comments for OPPEmailInitialStatusSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("OPPEmailInitialStatusSingle")]
    public partial class OPPEmailInitialStatusSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<OPPEmailInitialStatus>
    {
        /// <summary>
        /// Initialize a new OPPEmailInitialStatusSingle object.
        /// </summary>
        public OPPEmailInitialStatusSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new OPPEmailInitialStatusSingle object.
        /// </summary>
        public OPPEmailInitialStatusSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new OPPEmailInitialStatusSingle object.
        /// </summary>
        public OPPEmailInitialStatusSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<OPPEmailInitialStatus> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for OPPEmailInitialStatus in the schema.
    /// </summary>
    /// <KeyProperties>
    /// MandrillId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("MandrillId")]
    [global::Microsoft.OData.Client.EntitySet("OPPEmailInitialStatus")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("OPPEmailInitialStatus")]
    public partial class OPPEmailInitialStatus : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new OPPEmailInitialStatus object.
        /// </summary>
        /// <param name="emailAddress">Initial value of EmailAddress.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static OPPEmailInitialStatus CreateOPPEmailInitialStatus(string emailAddress)
        {
            OPPEmailInitialStatus oPPEmailInitialStatus = new OPPEmailInitialStatus();
            oPPEmailInitialStatus.EmailAddress = emailAddress;
            return oPPEmailInitialStatus;
        }
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
        /// There are no comments for Property EmailAddress in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmailAddress")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EmailAddress is required.")]
        public virtual string EmailAddress
        {
            get
            {
                return this._EmailAddress;
            }
            set
            {
                this.OnEmailAddressChanging(value);
                this._EmailAddress = value;
                this.OnEmailAddressChanged();
                this.OnPropertyChanged("EmailAddress");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EmailAddress;
        partial void OnEmailAddressChanging(string value);
        partial void OnEmailAddressChanged();
        /// <summary>
        /// There are no comments for Property MandrillId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MandrillId")]
        public virtual global::System.Nullable<global::System.Guid> MandrillId
        {
            get
            {
                return this._MandrillId;
            }
            set
            {
                this.OnMandrillIdChanging(value);
                this._MandrillId = value;
                this.OnMandrillIdChanged();
                this.OnPropertyChanged("MandrillId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _MandrillId;
        partial void OnMandrillIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnMandrillIdChanged();
        /// <summary>
        /// There are no comments for Property EmailResponseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmailResponseId")]
        public virtual global::System.Nullable<global::System.Guid> EmailResponseId
        {
            get
            {
                return this._EmailResponseId;
            }
            set
            {
                this.OnEmailResponseIdChanging(value);
                this._EmailResponseId = value;
                this.OnEmailResponseIdChanged();
                this.OnPropertyChanged("EmailResponseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _EmailResponseId;
        partial void OnEmailResponseIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnEmailResponseIdChanged();
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