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
    /// There are no comments for BulkEmailHourlyClicksSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BulkEmailHourlyClicksSingle")]
    public partial class BulkEmailHourlyClicksSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BulkEmailHourlyClicks>
    {
        /// <summary>
        /// Initialize a new BulkEmailHourlyClicksSingle object.
        /// </summary>
        public BulkEmailHourlyClicksSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BulkEmailHourlyClicksSingle object.
        /// </summary>
        public BulkEmailHourlyClicksSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BulkEmailHourlyClicksSingle object.
        /// </summary>
        public BulkEmailHourlyClicksSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BulkEmailHourlyClicks> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for BulkEmailHourlyClicks in the schema.
    /// </summary>
    /// <KeyProperties>
    /// BulkEmailId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("BulkEmailId")]
    [global::Microsoft.OData.Client.EntitySet("BulkEmailHourlyClicks")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BulkEmailHourlyClicks")]
    public partial class BulkEmailHourlyClicks : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
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
        /// There are no comments for Property DateMark in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DateMark")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> DateMark
        {
            get
            {
                return this._DateMark;
            }
            set
            {
                this.OnDateMarkChanging(value);
                this._DateMark = value;
                this.OnDateMarkChanged();
                this.OnPropertyChanged("DateMark");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _DateMark;
        partial void OnDateMarkChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnDateMarkChanged();
        /// <summary>
        /// There are no comments for Property EventsCount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EventsCount")]
        public virtual global::System.Nullable<int> EventsCount
        {
            get
            {
                return this._EventsCount;
            }
            set
            {
                this.OnEventsCountChanging(value);
                this._EventsCount = value;
                this.OnEventsCountChanged();
                this.OnPropertyChanged("EventsCount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _EventsCount;
        partial void OnEventsCountChanging(global::System.Nullable<int> value);
        partial void OnEventsCountChanged();
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
