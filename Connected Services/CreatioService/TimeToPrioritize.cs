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
    /// There are no comments for TimeToPrioritizeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("TimeToPrioritizeSingle")]
    public partial class TimeToPrioritizeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TimeToPrioritize>
    {
        /// <summary>
        /// Initialize a new TimeToPrioritizeSingle object.
        /// </summary>
        public TimeToPrioritizeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TimeToPrioritizeSingle object.
        /// </summary>
        public TimeToPrioritizeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TimeToPrioritizeSingle object.
        /// </summary>
        public TimeToPrioritizeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TimeToPrioritize> query)
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
        /// There are no comments for CasePriority in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CasePriority")]
        public virtual global::Terrasoft.Configuration.OData.CasePrioritySingle CasePriority
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CasePriority == null))
                {
                    this._CasePriority = new global::Terrasoft.Configuration.OData.CasePrioritySingle(this.Context, GetPath("CasePriority"));
                }
                return this._CasePriority;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.CasePrioritySingle _CasePriority;
        /// <summary>
        /// There are no comments for ReactionTimeUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ReactionTimeUnit")]
        public virtual global::Terrasoft.Configuration.OData.TimeUnitSingle ReactionTimeUnit
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReactionTimeUnit == null))
                {
                    this._ReactionTimeUnit = new global::Terrasoft.Configuration.OData.TimeUnitSingle(this.Context, GetPath("ReactionTimeUnit"));
                }
                return this._ReactionTimeUnit;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.TimeUnitSingle _ReactionTimeUnit;
        /// <summary>
        /// There are no comments for SolutionTimeUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SolutionTimeUnit")]
        public virtual global::Terrasoft.Configuration.OData.TimeUnitSingle SolutionTimeUnit
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SolutionTimeUnit == null))
                {
                    this._SolutionTimeUnit = new global::Terrasoft.Configuration.OData.TimeUnitSingle(this.Context, GetPath("SolutionTimeUnit"));
                }
                return this._SolutionTimeUnit;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.TimeUnitSingle _SolutionTimeUnit;
        /// <summary>
        /// There are no comments for ServiceInServicePact in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceInServicePact")]
        public virtual global::Terrasoft.Configuration.OData.ServiceInServicePactSingle ServiceInServicePact
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ServiceInServicePact == null))
                {
                    this._ServiceInServicePact = new global::Terrasoft.Configuration.OData.ServiceInServicePactSingle(this.Context, GetPath("ServiceInServicePact"));
                }
                return this._ServiceInServicePact;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.ServiceInServicePactSingle _ServiceInServicePact;
    }
    /// <summary>
    /// There are no comments for TimeToPrioritize in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("TimeToPrioritize")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("TimeToPrioritize")]
    public partial class TimeToPrioritize : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
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
        /// There are no comments for Property CasePriorityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CasePriorityId")]
        public virtual global::System.Nullable<global::System.Guid> CasePriorityId
        {
            get
            {
                return this._CasePriorityId;
            }
            set
            {
                this.OnCasePriorityIdChanging(value);
                this._CasePriorityId = value;
                this.OnCasePriorityIdChanged();
                this.OnPropertyChanged("CasePriorityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _CasePriorityId;
        partial void OnCasePriorityIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnCasePriorityIdChanged();
        /// <summary>
        /// There are no comments for Property ReactionTimeUnitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReactionTimeUnitId")]
        public virtual global::System.Nullable<global::System.Guid> ReactionTimeUnitId
        {
            get
            {
                return this._ReactionTimeUnitId;
            }
            set
            {
                this.OnReactionTimeUnitIdChanging(value);
                this._ReactionTimeUnitId = value;
                this.OnReactionTimeUnitIdChanged();
                this.OnPropertyChanged("ReactionTimeUnitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _ReactionTimeUnitId;
        partial void OnReactionTimeUnitIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnReactionTimeUnitIdChanged();
        /// <summary>
        /// There are no comments for Property ReactionTimeValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReactionTimeValue")]
        public virtual global::System.Nullable<int> ReactionTimeValue
        {
            get
            {
                return this._ReactionTimeValue;
            }
            set
            {
                this.OnReactionTimeValueChanging(value);
                this._ReactionTimeValue = value;
                this.OnReactionTimeValueChanged();
                this.OnPropertyChanged("ReactionTimeValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _ReactionTimeValue;
        partial void OnReactionTimeValueChanging(global::System.Nullable<int> value);
        partial void OnReactionTimeValueChanged();
        /// <summary>
        /// There are no comments for Property SolutionTimeUnitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SolutionTimeUnitId")]
        public virtual global::System.Nullable<global::System.Guid> SolutionTimeUnitId
        {
            get
            {
                return this._SolutionTimeUnitId;
            }
            set
            {
                this.OnSolutionTimeUnitIdChanging(value);
                this._SolutionTimeUnitId = value;
                this.OnSolutionTimeUnitIdChanged();
                this.OnPropertyChanged("SolutionTimeUnitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _SolutionTimeUnitId;
        partial void OnSolutionTimeUnitIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnSolutionTimeUnitIdChanged();
        /// <summary>
        /// There are no comments for Property SolutionTimeValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SolutionTimeValue")]
        public virtual global::System.Nullable<int> SolutionTimeValue
        {
            get
            {
                return this._SolutionTimeValue;
            }
            set
            {
                this.OnSolutionTimeValueChanging(value);
                this._SolutionTimeValue = value;
                this.OnSolutionTimeValueChanged();
                this.OnPropertyChanged("SolutionTimeValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _SolutionTimeValue;
        partial void OnSolutionTimeValueChanging(global::System.Nullable<int> value);
        partial void OnSolutionTimeValueChanged();
        /// <summary>
        /// There are no comments for Property ServiceInServicePactId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceInServicePactId")]
        public virtual global::System.Nullable<global::System.Guid> ServiceInServicePactId
        {
            get
            {
                return this._ServiceInServicePactId;
            }
            set
            {
                this.OnServiceInServicePactIdChanging(value);
                this._ServiceInServicePactId = value;
                this.OnServiceInServicePactIdChanged();
                this.OnPropertyChanged("ServiceInServicePactId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _ServiceInServicePactId;
        partial void OnServiceInServicePactIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnServiceInServicePactIdChanged();
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
        /// There are no comments for Property CasePriority in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CasePriority")]
        public virtual global::Terrasoft.Configuration.OData.CasePriority CasePriority
        {
            get
            {
                return this._CasePriority;
            }
            set
            {
                this.OnCasePriorityChanging(value);
                this._CasePriority = value;
                this.OnCasePriorityChanged();
                this.OnPropertyChanged("CasePriority");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.CasePriority _CasePriority;
        partial void OnCasePriorityChanging(global::Terrasoft.Configuration.OData.CasePriority value);
        partial void OnCasePriorityChanged();
        /// <summary>
        /// There are no comments for Property ReactionTimeUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReactionTimeUnit")]
        public virtual global::Terrasoft.Configuration.OData.TimeUnit ReactionTimeUnit
        {
            get
            {
                return this._ReactionTimeUnit;
            }
            set
            {
                this.OnReactionTimeUnitChanging(value);
                this._ReactionTimeUnit = value;
                this.OnReactionTimeUnitChanged();
                this.OnPropertyChanged("ReactionTimeUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.TimeUnit _ReactionTimeUnit;
        partial void OnReactionTimeUnitChanging(global::Terrasoft.Configuration.OData.TimeUnit value);
        partial void OnReactionTimeUnitChanged();
        /// <summary>
        /// There are no comments for Property SolutionTimeUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SolutionTimeUnit")]
        public virtual global::Terrasoft.Configuration.OData.TimeUnit SolutionTimeUnit
        {
            get
            {
                return this._SolutionTimeUnit;
            }
            set
            {
                this.OnSolutionTimeUnitChanging(value);
                this._SolutionTimeUnit = value;
                this.OnSolutionTimeUnitChanged();
                this.OnPropertyChanged("SolutionTimeUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.TimeUnit _SolutionTimeUnit;
        partial void OnSolutionTimeUnitChanging(global::Terrasoft.Configuration.OData.TimeUnit value);
        partial void OnSolutionTimeUnitChanged();
        /// <summary>
        /// There are no comments for Property ServiceInServicePact in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceInServicePact")]
        public virtual global::Terrasoft.Configuration.OData.ServiceInServicePact ServiceInServicePact
        {
            get
            {
                return this._ServiceInServicePact;
            }
            set
            {
                this.OnServiceInServicePactChanging(value);
                this._ServiceInServicePact = value;
                this.OnServiceInServicePactChanged();
                this.OnPropertyChanged("ServiceInServicePact");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.ServiceInServicePact _ServiceInServicePact;
        partial void OnServiceInServicePactChanging(global::Terrasoft.Configuration.OData.ServiceInServicePact value);
        partial void OnServiceInServicePactChanged();
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
