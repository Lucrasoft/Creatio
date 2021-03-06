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
    /// There are no comments for VwCampaignLogSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("VwCampaignLogSingle")]
    public partial class VwCampaignLogSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VwCampaignLog>
    {
        /// <summary>
        /// Initialize a new VwCampaignLogSingle object.
        /// </summary>
        public VwCampaignLogSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VwCampaignLogSingle object.
        /// </summary>
        public VwCampaignLogSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VwCampaignLogSingle object.
        /// </summary>
        public VwCampaignLogSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VwCampaignLog> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Campaign in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Campaign")]
        public virtual global::Terrasoft.Configuration.OData.CampaignSingle Campaign
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Campaign == null))
                {
                    this._Campaign = new global::Terrasoft.Configuration.OData.CampaignSingle(this.Context, GetPath("Campaign"));
                }
                return this._Campaign;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.CampaignSingle _Campaign;
        /// <summary>
        /// There are no comments for CampaignItem in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CampaignItem")]
        public virtual global::Terrasoft.Configuration.OData.CampaignItemSingle CampaignItem
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CampaignItem == null))
                {
                    this._CampaignItem = new global::Terrasoft.Configuration.OData.CampaignItemSingle(this.Context, GetPath("CampaignItem"));
                }
                return this._CampaignItem;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.CampaignItemSingle _CampaignItem;
        /// <summary>
        /// There are no comments for Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::Terrasoft.Configuration.OData.CampaignLogStatusSingle Status
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Status == null))
                {
                    this._Status = new global::Terrasoft.Configuration.OData.CampaignLogStatusSingle(this.Context, GetPath("Status"));
                }
                return this._Status;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.CampaignLogStatusSingle _Status;
        /// <summary>
        /// There are no comments for Action in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Action")]
        public virtual global::Terrasoft.Configuration.OData.CampaignLogItemTypeSingle Action
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Action == null))
                {
                    this._Action = new global::Terrasoft.Configuration.OData.CampaignLogItemTypeSingle(this.Context, GetPath("Action"));
                }
                return this._Action;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.CampaignLogItemTypeSingle _Action;
    }
    /// <summary>
    /// There are no comments for VwCampaignLog in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("VwCampaignLog")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("VwCampaignLog")]
    public partial class VwCampaignLog : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VwCampaignLog object.
        /// </summary>
        /// <param name="errorText">Initial value of ErrorText.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VwCampaignLog CreateVwCampaignLog(string errorText)
        {
            VwCampaignLog vwCampaignLog = new VwCampaignLog();
            vwCampaignLog.ErrorText = errorText;
            return vwCampaignLog;
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
        /// There are no comments for Property CampaignId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CampaignId")]
        public virtual global::System.Nullable<global::System.Guid> CampaignId
        {
            get
            {
                return this._CampaignId;
            }
            set
            {
                this.OnCampaignIdChanging(value);
                this._CampaignId = value;
                this.OnCampaignIdChanged();
                this.OnPropertyChanged("CampaignId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _CampaignId;
        partial void OnCampaignIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnCampaignIdChanged();
        /// <summary>
        /// There are no comments for Property CampaignItemId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CampaignItemId")]
        public virtual global::System.Nullable<global::System.Guid> CampaignItemId
        {
            get
            {
                return this._CampaignItemId;
            }
            set
            {
                this.OnCampaignItemIdChanging(value);
                this._CampaignItemId = value;
                this.OnCampaignItemIdChanged();
                this.OnPropertyChanged("CampaignItemId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _CampaignItemId;
        partial void OnCampaignItemIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnCampaignItemIdChanged();
        /// <summary>
        /// There are no comments for Property Amount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Amount")]
        public virtual global::System.Nullable<int> Amount
        {
            get
            {
                return this._Amount;
            }
            set
            {
                this.OnAmountChanging(value);
                this._Amount = value;
                this.OnAmountChanged();
                this.OnPropertyChanged("Amount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _Amount;
        partial void OnAmountChanging(global::System.Nullable<int> value);
        partial void OnAmountChanged();
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
        /// There are no comments for Property ScheduledDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ScheduledDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> ScheduledDate
        {
            get
            {
                return this._ScheduledDate;
            }
            set
            {
                this.OnScheduledDateChanging(value);
                this._ScheduledDate = value;
                this.OnScheduledDateChanged();
                this.OnPropertyChanged("ScheduledDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _ScheduledDate;
        partial void OnScheduledDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnScheduledDateChanged();
        /// <summary>
        /// There are no comments for Property StartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StartDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this.OnStartDateChanging(value);
                this._StartDate = value;
                this.OnStartDateChanged();
                this.OnPropertyChanged("StartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _StartDate;
        partial void OnStartDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnStartDateChanged();
        /// <summary>
        /// There are no comments for Property EndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EndDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> EndDate
        {
            get
            {
                return this._EndDate;
            }
            set
            {
                this.OnEndDateChanging(value);
                this._EndDate = value;
                this.OnEndDateChanged();
                this.OnPropertyChanged("EndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _EndDate;
        partial void OnEndDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnEndDateChanged();
        /// <summary>
        /// There are no comments for Property ErrorText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ErrorText")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ErrorText is required.")]
        public virtual string ErrorText
        {
            get
            {
                return this._ErrorText;
            }
            set
            {
                this.OnErrorTextChanging(value);
                this._ErrorText = value;
                this.OnErrorTextChanged();
                this.OnPropertyChanged("ErrorText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ErrorText;
        partial void OnErrorTextChanging(string value);
        partial void OnErrorTextChanged();
        /// <summary>
        /// There are no comments for Property DurationSs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DurationSs")]
        public virtual global::System.Nullable<int> DurationSs
        {
            get
            {
                return this._DurationSs;
            }
            set
            {
                this.OnDurationSsChanging(value);
                this._DurationSs = value;
                this.OnDurationSsChanged();
                this.OnPropertyChanged("DurationSs");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _DurationSs;
        partial void OnDurationSsChanging(global::System.Nullable<int> value);
        partial void OnDurationSsChanged();
        /// <summary>
        /// There are no comments for Property DurationMi in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DurationMi")]
        public virtual global::System.Nullable<int> DurationMi
        {
            get
            {
                return this._DurationMi;
            }
            set
            {
                this.OnDurationMiChanging(value);
                this._DurationMi = value;
                this.OnDurationMiChanged();
                this.OnPropertyChanged("DurationMi");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _DurationMi;
        partial void OnDurationMiChanging(global::System.Nullable<int> value);
        partial void OnDurationMiChanged();
        /// <summary>
        /// There are no comments for Property StatusId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StatusId")]
        public virtual global::System.Nullable<global::System.Guid> StatusId
        {
            get
            {
                return this._StatusId;
            }
            set
            {
                this.OnStatusIdChanging(value);
                this._StatusId = value;
                this.OnStatusIdChanged();
                this.OnPropertyChanged("StatusId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _StatusId;
        partial void OnStatusIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnStatusIdChanged();
        /// <summary>
        /// There are no comments for Property ActionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActionId")]
        public virtual global::System.Nullable<global::System.Guid> ActionId
        {
            get
            {
                return this._ActionId;
            }
            set
            {
                this.OnActionIdChanging(value);
                this._ActionId = value;
                this.OnActionIdChanged();
                this.OnPropertyChanged("ActionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _ActionId;
        partial void OnActionIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnActionIdChanged();
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
        /// There are no comments for Property Campaign in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Campaign")]
        public virtual global::Terrasoft.Configuration.OData.Campaign Campaign
        {
            get
            {
                return this._Campaign;
            }
            set
            {
                this.OnCampaignChanging(value);
                this._Campaign = value;
                this.OnCampaignChanged();
                this.OnPropertyChanged("Campaign");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.Campaign _Campaign;
        partial void OnCampaignChanging(global::Terrasoft.Configuration.OData.Campaign value);
        partial void OnCampaignChanged();
        /// <summary>
        /// There are no comments for Property CampaignItem in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CampaignItem")]
        public virtual global::Terrasoft.Configuration.OData.CampaignItem CampaignItem
        {
            get
            {
                return this._CampaignItem;
            }
            set
            {
                this.OnCampaignItemChanging(value);
                this._CampaignItem = value;
                this.OnCampaignItemChanged();
                this.OnPropertyChanged("CampaignItem");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.CampaignItem _CampaignItem;
        partial void OnCampaignItemChanging(global::Terrasoft.Configuration.OData.CampaignItem value);
        partial void OnCampaignItemChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::Terrasoft.Configuration.OData.CampaignLogStatus Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.CampaignLogStatus _Status;
        partial void OnStatusChanging(global::Terrasoft.Configuration.OData.CampaignLogStatus value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property Action in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Action")]
        public virtual global::Terrasoft.Configuration.OData.CampaignLogItemType Action
        {
            get
            {
                return this._Action;
            }
            set
            {
                this.OnActionChanging(value);
                this._Action = value;
                this.OnActionChanged();
                this.OnPropertyChanged("Action");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.CampaignLogItemType _Action;
        partial void OnActionChanging(global::Terrasoft.Configuration.OData.CampaignLogItemType value);
        partial void OnActionChanged();
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
