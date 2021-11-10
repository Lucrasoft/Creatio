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
    /// There are no comments for WebServiceSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("WebServiceSingle")]
    public partial class WebServiceSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WebService>
    {
        /// <summary>
        /// Initialize a new WebServiceSingle object.
        /// </summary>
        public WebServiceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WebServiceSingle object.
        /// </summary>
        public WebServiceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WebServiceSingle object.
        /// </summary>
        public WebServiceSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WebService> query)
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
        /// There are no comments for WebServiceURLCollectionByWebService in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("WebServiceURLCollectionByWebService")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.WebServiceURL> WebServiceURLCollectionByWebService
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WebServiceURLCollectionByWebService == null))
                {
                    this._WebServiceURLCollectionByWebService = Context.CreateQuery<global::Terrasoft.Configuration.OData.WebServiceURL>(GetPath("WebServiceURLCollectionByWebService"));
                }
                return this._WebServiceURLCollectionByWebService;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.WebServiceURL> _WebServiceURLCollectionByWebService;
        /// <summary>
        /// There are no comments for WebServiceURL in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("WebServiceURL")]
        public virtual global::Terrasoft.Configuration.OData.WebServiceURLSingle WebServiceURL
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WebServiceURL == null))
                {
                    this._WebServiceURL = new global::Terrasoft.Configuration.OData.WebServiceURLSingle(this.Context, GetPath("WebServiceURL"));
                }
                return this._WebServiceURL;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.WebServiceURLSingle _WebServiceURL;
        /// <summary>
        /// There are no comments for HTTPAuthType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("HTTPAuthType")]
        public virtual global::Terrasoft.Configuration.OData.HTTPAuthTypeSingle HTTPAuthType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._HTTPAuthType == null))
                {
                    this._HTTPAuthType = new global::Terrasoft.Configuration.OData.HTTPAuthTypeSingle(this.Context, GetPath("HTTPAuthType"));
                }
                return this._HTTPAuthType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.HTTPAuthTypeSingle _HTTPAuthType;
    }
    /// <summary>
    /// There are no comments for WebService in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("WebService")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("WebService")]
    public partial class WebService : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WebService object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="description">Initial value of Description.</param>
        /// <param name="caption">Initial value of Caption.</param>
        /// <param name="wSDLURL">Initial value of WSDLURL.</param>
        /// <param name="wSDL">Initial value of WSDL.</param>
        /// <param name="login">Initial value of Login.</param>
        /// <param name="password">Initial value of Password.</param>
        /// <param name="namespace">Initial value of Namespace.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WebService CreateWebService(string name, 
                    string description, 
                    string caption, 
                    string wSDLURL, 
                    string wSDL, 
                    string login, 
                    string password, 
                    string @namespace)
        {
            WebService webService = new WebService();
            webService.Name = name;
            webService.Description = description;
            webService.Caption = caption;
            webService.WSDLURL = wSDLURL;
            webService.WSDL = wSDL;
            webService.Login = login;
            webService.Password = password;
            webService.Namespace = @namespace;
            return webService;
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
        /// There are no comments for Property WebServiceURLId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WebServiceURLId")]
        public virtual global::System.Nullable<global::System.Guid> WebServiceURLId
        {
            get
            {
                return this._WebServiceURLId;
            }
            set
            {
                this.OnWebServiceURLIdChanging(value);
                this._WebServiceURLId = value;
                this.OnWebServiceURLIdChanged();
                this.OnPropertyChanged("WebServiceURLId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _WebServiceURLId;
        partial void OnWebServiceURLIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnWebServiceURLIdChanged();
        /// <summary>
        /// There are no comments for Property WSDLURL in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WSDLURL")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "WSDLURL is required.")]
        public virtual string WSDLURL
        {
            get
            {
                return this._WSDLURL;
            }
            set
            {
                this.OnWSDLURLChanging(value);
                this._WSDLURL = value;
                this.OnWSDLURLChanged();
                this.OnPropertyChanged("WSDLURL");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WSDLURL;
        partial void OnWSDLURLChanging(string value);
        partial void OnWSDLURLChanged();
        /// <summary>
        /// There are no comments for Property WSDL in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WSDL")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "WSDL is required.")]
        public virtual string WSDL
        {
            get
            {
                return this._WSDL;
            }
            set
            {
                this.OnWSDLChanging(value);
                this._WSDL = value;
                this.OnWSDLChanged();
                this.OnPropertyChanged("WSDL");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WSDL;
        partial void OnWSDLChanging(string value);
        partial void OnWSDLChanged();
        /// <summary>
        /// There are no comments for Property Timeout in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Timeout")]
        public virtual global::System.Nullable<int> Timeout
        {
            get
            {
                return this._Timeout;
            }
            set
            {
                this.OnTimeoutChanging(value);
                this._Timeout = value;
                this.OnTimeoutChanged();
                this.OnPropertyChanged("Timeout");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _Timeout;
        partial void OnTimeoutChanging(global::System.Nullable<int> value);
        partial void OnTimeoutChanged();
        /// <summary>
        /// There are no comments for Property HTTPAuthTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("HTTPAuthTypeId")]
        public virtual global::System.Nullable<global::System.Guid> HTTPAuthTypeId
        {
            get
            {
                return this._HTTPAuthTypeId;
            }
            set
            {
                this.OnHTTPAuthTypeIdChanging(value);
                this._HTTPAuthTypeId = value;
                this.OnHTTPAuthTypeIdChanged();
                this.OnPropertyChanged("HTTPAuthTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _HTTPAuthTypeId;
        partial void OnHTTPAuthTypeIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnHTTPAuthTypeIdChanged();
        /// <summary>
        /// There are no comments for Property Login in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Login")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Login is required.")]
        public virtual string Login
        {
            get
            {
                return this._Login;
            }
            set
            {
                this.OnLoginChanging(value);
                this._Login = value;
                this.OnLoginChanged();
                this.OnPropertyChanged("Login");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Login;
        partial void OnLoginChanging(string value);
        partial void OnLoginChanged();
        /// <summary>
        /// There are no comments for Property Password in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Password")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Password is required.")]
        public virtual string Password
        {
            get
            {
                return this._Password;
            }
            set
            {
                this.OnPasswordChanging(value);
                this._Password = value;
                this.OnPasswordChanged();
                this.OnPropertyChanged("Password");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Password;
        partial void OnPasswordChanging(string value);
        partial void OnPasswordChanged();
        /// <summary>
        /// There are no comments for Property GenerateProxy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GenerateProxy")]
        public virtual global::System.Nullable<bool> GenerateProxy
        {
            get
            {
                return this._GenerateProxy;
            }
            set
            {
                this.OnGenerateProxyChanging(value);
                this._GenerateProxy = value;
                this.OnGenerateProxyChanged();
                this.OnPropertyChanged("GenerateProxy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _GenerateProxy;
        partial void OnGenerateProxyChanging(global::System.Nullable<bool> value);
        partial void OnGenerateProxyChanged();
        /// <summary>
        /// There are no comments for Property Namespace in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Namespace")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Namespace is required.")]
        public virtual string Namespace
        {
            get
            {
                return this._Namespace;
            }
            set
            {
                this.OnNamespaceChanging(value);
                this._Namespace = value;
                this.OnNamespaceChanged();
                this.OnPropertyChanged("Namespace");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Namespace;
        partial void OnNamespaceChanging(string value);
        partial void OnNamespaceChanged();
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
        /// There are no comments for Property WebServiceURLCollectionByWebService in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WebServiceURLCollectionByWebService")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.WebServiceURL> WebServiceURLCollectionByWebService
        {
            get
            {
                return this._WebServiceURLCollectionByWebService;
            }
            set
            {
                this.OnWebServiceURLCollectionByWebServiceChanging(value);
                this._WebServiceURLCollectionByWebService = value;
                this.OnWebServiceURLCollectionByWebServiceChanged();
                this.OnPropertyChanged("WebServiceURLCollectionByWebService");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.WebServiceURL> _WebServiceURLCollectionByWebService = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.WebServiceURL>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWebServiceURLCollectionByWebServiceChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.WebServiceURL> value);
        partial void OnWebServiceURLCollectionByWebServiceChanged();
        /// <summary>
        /// There are no comments for Property WebServiceURL in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WebServiceURL")]
        public virtual global::Terrasoft.Configuration.OData.WebServiceURL WebServiceURL
        {
            get
            {
                return this._WebServiceURL;
            }
            set
            {
                this.OnWebServiceURLChanging(value);
                this._WebServiceURL = value;
                this.OnWebServiceURLChanged();
                this.OnPropertyChanged("WebServiceURL");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.WebServiceURL _WebServiceURL;
        partial void OnWebServiceURLChanging(global::Terrasoft.Configuration.OData.WebServiceURL value);
        partial void OnWebServiceURLChanged();
        /// <summary>
        /// There are no comments for Property HTTPAuthType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("HTTPAuthType")]
        public virtual global::Terrasoft.Configuration.OData.HTTPAuthType HTTPAuthType
        {
            get
            {
                return this._HTTPAuthType;
            }
            set
            {
                this.OnHTTPAuthTypeChanging(value);
                this._HTTPAuthType = value;
                this.OnHTTPAuthTypeChanged();
                this.OnPropertyChanged("HTTPAuthType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.HTTPAuthType _HTTPAuthType;
        partial void OnHTTPAuthTypeChanging(global::Terrasoft.Configuration.OData.HTTPAuthType value);
        partial void OnHTTPAuthTypeChanged();
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
