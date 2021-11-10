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
    /// There are no comments for QualifyStatusDecouplingSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("QualifyStatusDecouplingSingle")]
    public partial class QualifyStatusDecouplingSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<QualifyStatusDecoupling>
    {
        /// <summary>
        /// Initialize a new QualifyStatusDecouplingSingle object.
        /// </summary>
        public QualifyStatusDecouplingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new QualifyStatusDecouplingSingle object.
        /// </summary>
        public QualifyStatusDecouplingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new QualifyStatusDecouplingSingle object.
        /// </summary>
        public QualifyStatusDecouplingSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<QualifyStatusDecoupling> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CurrentStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CurrentStatus")]
        public virtual global::Terrasoft.Configuration.OData.QualifyStatusSingle CurrentStatus
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CurrentStatus == null))
                {
                    this._CurrentStatus = new global::Terrasoft.Configuration.OData.QualifyStatusSingle(this.Context, GetPath("CurrentStatus"));
                }
                return this._CurrentStatus;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.QualifyStatusSingle _CurrentStatus;
        /// <summary>
        /// There are no comments for AvailableStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AvailableStatus")]
        public virtual global::Terrasoft.Configuration.OData.QualifyStatusSingle AvailableStatus
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AvailableStatus == null))
                {
                    this._AvailableStatus = new global::Terrasoft.Configuration.OData.QualifyStatusSingle(this.Context, GetPath("AvailableStatus"));
                }
                return this._AvailableStatus;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.QualifyStatusSingle _AvailableStatus;
    }
    /// <summary>
    /// There are no comments for QualifyStatusDecoupling in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("QualifyStatusDecoupling")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("QualifyStatusDecoupling")]
    public partial class QualifyStatusDecoupling : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
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
        /// There are no comments for Property CurrentStatusId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CurrentStatusId")]
        public virtual global::System.Nullable<global::System.Guid> CurrentStatusId
        {
            get
            {
                return this._CurrentStatusId;
            }
            set
            {
                this.OnCurrentStatusIdChanging(value);
                this._CurrentStatusId = value;
                this.OnCurrentStatusIdChanged();
                this.OnPropertyChanged("CurrentStatusId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _CurrentStatusId;
        partial void OnCurrentStatusIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnCurrentStatusIdChanged();
        /// <summary>
        /// There are no comments for Property AvailableStatusId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AvailableStatusId")]
        public virtual global::System.Nullable<global::System.Guid> AvailableStatusId
        {
            get
            {
                return this._AvailableStatusId;
            }
            set
            {
                this.OnAvailableStatusIdChanging(value);
                this._AvailableStatusId = value;
                this.OnAvailableStatusIdChanged();
                this.OnPropertyChanged("AvailableStatusId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _AvailableStatusId;
        partial void OnAvailableStatusIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnAvailableStatusIdChanged();
        /// <summary>
        /// There are no comments for Property CurrentStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CurrentStatus")]
        public virtual global::Terrasoft.Configuration.OData.QualifyStatus CurrentStatus
        {
            get
            {
                return this._CurrentStatus;
            }
            set
            {
                this.OnCurrentStatusChanging(value);
                this._CurrentStatus = value;
                this.OnCurrentStatusChanged();
                this.OnPropertyChanged("CurrentStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.QualifyStatus _CurrentStatus;
        partial void OnCurrentStatusChanging(global::Terrasoft.Configuration.OData.QualifyStatus value);
        partial void OnCurrentStatusChanged();
        /// <summary>
        /// There are no comments for Property AvailableStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AvailableStatus")]
        public virtual global::Terrasoft.Configuration.OData.QualifyStatus AvailableStatus
        {
            get
            {
                return this._AvailableStatus;
            }
            set
            {
                this.OnAvailableStatusChanging(value);
                this._AvailableStatus = value;
                this.OnAvailableStatusChanged();
                this.OnPropertyChanged("AvailableStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.QualifyStatus _AvailableStatus;
        partial void OnAvailableStatusChanging(global::Terrasoft.Configuration.OData.QualifyStatus value);
        partial void OnAvailableStatusChanged();
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