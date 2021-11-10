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
    /// There are no comments for AutoProcessingLogSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AutoProcessingLogSingle")]
    public partial class AutoProcessingLogSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AutoProcessingLog>
    {
        /// <summary>
        /// Initialize a new AutoProcessingLogSingle object.
        /// </summary>
        public AutoProcessingLogSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AutoProcessingLogSingle object.
        /// </summary>
        public AutoProcessingLogSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AutoProcessingLogSingle object.
        /// </summary>
        public AutoProcessingLogSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AutoProcessingLog> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AutoProcessingLog in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("AutoProcessingLog")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AutoProcessingLog")]
    public partial class AutoProcessingLog : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AutoProcessingLog object.
        /// </summary>
        /// <param name="message">Initial value of Message.</param>
        /// <param name="processingType">Initial value of ProcessingType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AutoProcessingLog CreateAutoProcessingLog(string message, string processingType)
        {
            AutoProcessingLog autoProcessingLog = new AutoProcessingLog();
            autoProcessingLog.Message = message;
            autoProcessingLog.ProcessingType = processingType;
            return autoProcessingLog;
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
        /// There are no comments for Property Message in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Message")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Message is required.")]
        public virtual string Message
        {
            get
            {
                return this._Message;
            }
            set
            {
                this.OnMessageChanging(value);
                this._Message = value;
                this.OnMessageChanged();
                this.OnPropertyChanged("Message");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Message;
        partial void OnMessageChanging(string value);
        partial void OnMessageChanged();
        /// <summary>
        /// There are no comments for Property ProcessingType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProcessingType")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProcessingType is required.")]
        public virtual string ProcessingType
        {
            get
            {
                return this._ProcessingType;
            }
            set
            {
                this.OnProcessingTypeChanging(value);
                this._ProcessingType = value;
                this.OnProcessingTypeChanged();
                this.OnPropertyChanged("ProcessingType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProcessingType;
        partial void OnProcessingTypeChanging(string value);
        partial void OnProcessingTypeChanged();
        /// <summary>
        /// There are no comments for Property ProcessingDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProcessingDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> ProcessingDate
        {
            get
            {
                return this._ProcessingDate;
            }
            set
            {
                this.OnProcessingDateChanging(value);
                this._ProcessingDate = value;
                this.OnProcessingDateChanged();
                this.OnPropertyChanged("ProcessingDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _ProcessingDate;
        partial void OnProcessingDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnProcessingDateChanged();
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
