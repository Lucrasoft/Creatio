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
    /// There are no comments for CertificateSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CertificateSingle")]
    public partial class CertificateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Certificate>
    {
        /// <summary>
        /// Initialize a new CertificateSingle object.
        /// </summary>
        public CertificateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CertificateSingle object.
        /// </summary>
        public CertificateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CertificateSingle object.
        /// </summary>
        public CertificateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Certificate> query)
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
        /// There are no comments for EducationActivity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EducationActivity")]
        public virtual global::Terrasoft.Configuration.OData.EducationActivitySingle EducationActivity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EducationActivity == null))
                {
                    this._EducationActivity = new global::Terrasoft.Configuration.OData.EducationActivitySingle(this.Context, GetPath("EducationActivity"));
                }
                return this._EducationActivity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.EducationActivitySingle _EducationActivity;
        /// <summary>
        /// There are no comments for CompetenceLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CompetenceLevel")]
        public virtual global::Terrasoft.Configuration.OData.CompetenceLevelSingle CompetenceLevel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompetenceLevel == null))
                {
                    this._CompetenceLevel = new global::Terrasoft.Configuration.OData.CompetenceLevelSingle(this.Context, GetPath("CompetenceLevel"));
                }
                return this._CompetenceLevel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.CompetenceLevelSingle _CompetenceLevel;
    }
    /// <summary>
    /// There are no comments for Certificate in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("Certificate")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Certificate")]
    public partial class Certificate : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Certificate object.
        /// </summary>
        /// <param name="certificateNumber">Initial value of CertificateNumber.</param>
        /// <param name="comments">Initial value of Comments.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Certificate CreateCertificate(string certificateNumber, string comments)
        {
            Certificate certificate = new Certificate();
            certificate.CertificateNumber = certificateNumber;
            certificate.Comments = comments;
            return certificate;
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
        /// There are no comments for Property EducationActivityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EducationActivityId")]
        public virtual global::System.Nullable<global::System.Guid> EducationActivityId
        {
            get
            {
                return this._EducationActivityId;
            }
            set
            {
                this.OnEducationActivityIdChanging(value);
                this._EducationActivityId = value;
                this.OnEducationActivityIdChanged();
                this.OnPropertyChanged("EducationActivityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _EducationActivityId;
        partial void OnEducationActivityIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnEducationActivityIdChanged();
        /// <summary>
        /// There are no comments for Property IssueDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IssueDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> IssueDate
        {
            get
            {
                return this._IssueDate;
            }
            set
            {
                this.OnIssueDateChanging(value);
                this._IssueDate = value;
                this.OnIssueDateChanged();
                this.OnPropertyChanged("IssueDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _IssueDate;
        partial void OnIssueDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnIssueDateChanged();
        /// <summary>
        /// There are no comments for Property ExpireDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExpireDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> ExpireDate
        {
            get
            {
                return this._ExpireDate;
            }
            set
            {
                this.OnExpireDateChanging(value);
                this._ExpireDate = value;
                this.OnExpireDateChanged();
                this.OnPropertyChanged("ExpireDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _ExpireDate;
        partial void OnExpireDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnExpireDateChanged();
        /// <summary>
        /// There are no comments for Property CompetenceLevelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompetenceLevelId")]
        public virtual global::System.Nullable<global::System.Guid> CompetenceLevelId
        {
            get
            {
                return this._CompetenceLevelId;
            }
            set
            {
                this.OnCompetenceLevelIdChanging(value);
                this._CompetenceLevelId = value;
                this.OnCompetenceLevelIdChanged();
                this.OnPropertyChanged("CompetenceLevelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _CompetenceLevelId;
        partial void OnCompetenceLevelIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnCompetenceLevelIdChanged();
        /// <summary>
        /// There are no comments for Property ResultScore in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ResultScore")]
        public virtual global::System.Nullable<decimal> ResultScore
        {
            get
            {
                return this._ResultScore;
            }
            set
            {
                this.OnResultScoreChanging(value);
                this._ResultScore = value;
                this.OnResultScoreChanged();
                this.OnPropertyChanged("ResultScore");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<decimal> _ResultScore;
        partial void OnResultScoreChanging(global::System.Nullable<decimal> value);
        partial void OnResultScoreChanged();
        /// <summary>
        /// There are no comments for Property CertificateNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CertificateNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CertificateNumber is required.")]
        public virtual string CertificateNumber
        {
            get
            {
                return this._CertificateNumber;
            }
            set
            {
                this.OnCertificateNumberChanging(value);
                this._CertificateNumber = value;
                this.OnCertificateNumberChanged();
                this.OnPropertyChanged("CertificateNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CertificateNumber;
        partial void OnCertificateNumberChanging(string value);
        partial void OnCertificateNumberChanged();
        /// <summary>
        /// There are no comments for Property Comments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Comments")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Comments is required.")]
        public virtual string Comments
        {
            get
            {
                return this._Comments;
            }
            set
            {
                this.OnCommentsChanging(value);
                this._Comments = value;
                this.OnCommentsChanged();
                this.OnPropertyChanged("Comments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Comments;
        partial void OnCommentsChanging(string value);
        partial void OnCommentsChanged();
        /// <summary>
        /// There are no comments for Property NotificationSent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NotificationSent")]
        public virtual global::System.Nullable<bool> NotificationSent
        {
            get
            {
                return this._NotificationSent;
            }
            set
            {
                this.OnNotificationSentChanging(value);
                this._NotificationSent = value;
                this.OnNotificationSentChanged();
                this.OnPropertyChanged("NotificationSent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _NotificationSent;
        partial void OnNotificationSentChanging(global::System.Nullable<bool> value);
        partial void OnNotificationSentChanged();
        /// <summary>
        /// There are no comments for Property DateOfNotification in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DateOfNotification")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> DateOfNotification
        {
            get
            {
                return this._DateOfNotification;
            }
            set
            {
                this.OnDateOfNotificationChanging(value);
                this._DateOfNotification = value;
                this.OnDateOfNotificationChanged();
                this.OnPropertyChanged("DateOfNotification");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _DateOfNotification;
        partial void OnDateOfNotificationChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnDateOfNotificationChanged();
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
        /// There are no comments for Property EducationActivity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EducationActivity")]
        public virtual global::Terrasoft.Configuration.OData.EducationActivity EducationActivity
        {
            get
            {
                return this._EducationActivity;
            }
            set
            {
                this.OnEducationActivityChanging(value);
                this._EducationActivity = value;
                this.OnEducationActivityChanged();
                this.OnPropertyChanged("EducationActivity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.EducationActivity _EducationActivity;
        partial void OnEducationActivityChanging(global::Terrasoft.Configuration.OData.EducationActivity value);
        partial void OnEducationActivityChanged();
        /// <summary>
        /// There are no comments for Property CompetenceLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompetenceLevel")]
        public virtual global::Terrasoft.Configuration.OData.CompetenceLevel CompetenceLevel
        {
            get
            {
                return this._CompetenceLevel;
            }
            set
            {
                this.OnCompetenceLevelChanging(value);
                this._CompetenceLevel = value;
                this.OnCompetenceLevelChanged();
                this.OnPropertyChanged("CompetenceLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.CompetenceLevel _CompetenceLevel;
        partial void OnCompetenceLevelChanging(global::Terrasoft.Configuration.OData.CompetenceLevel value);
        partial void OnCompetenceLevelChanged();
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
