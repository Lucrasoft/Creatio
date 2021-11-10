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
    /// There are no comments for VwOpportFunnelDataSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("VwOpportFunnelDataSingle")]
    public partial class VwOpportFunnelDataSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VwOpportFunnelData>
    {
        /// <summary>
        /// Initialize a new VwOpportFunnelDataSingle object.
        /// </summary>
        public VwOpportFunnelDataSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VwOpportFunnelDataSingle object.
        /// </summary>
        public VwOpportFunnelDataSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VwOpportFunnelDataSingle object.
        /// </summary>
        public VwOpportFunnelDataSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VwOpportFunnelData> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Opportunity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Opportunity")]
        public virtual global::Terrasoft.Configuration.OData.OpportunitySingle Opportunity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Opportunity == null))
                {
                    this._Opportunity = new global::Terrasoft.Configuration.OData.OpportunitySingle(this.Context, GetPath("Opportunity"));
                }
                return this._Opportunity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.OpportunitySingle _Opportunity;
        /// <summary>
        /// There are no comments for FStage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("fStage")]
        public virtual global::Terrasoft.Configuration.OData.OpportunityStageSingle FStage
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FStage == null))
                {
                    this._FStage = new global::Terrasoft.Configuration.OData.OpportunityStageSingle(this.Context, GetPath("fStage"));
                }
                return this._FStage;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.OpportunityStageSingle _FStage;
        /// <summary>
        /// There are no comments for LStage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("lStage")]
        public virtual global::Terrasoft.Configuration.OData.OpportunityStageSingle LStage
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LStage == null))
                {
                    this._LStage = new global::Terrasoft.Configuration.OData.OpportunityStageSingle(this.Context, GetPath("lStage"));
                }
                return this._LStage;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.OpportunityStageSingle _LStage;
    }
    /// <summary>
    /// There are no comments for VwOpportFunnelData in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("VwOpportFunnelData")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("VwOpportFunnelData")]
    public partial class VwOpportFunnelData : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
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
        /// There are no comments for Property OpportunityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OpportunityId")]
        public virtual global::System.Nullable<global::System.Guid> OpportunityId
        {
            get
            {
                return this._OpportunityId;
            }
            set
            {
                this.OnOpportunityIdChanging(value);
                this._OpportunityId = value;
                this.OnOpportunityIdChanged();
                this.OnPropertyChanged("OpportunityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _OpportunityId;
        partial void OnOpportunityIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnOpportunityIdChanged();
        /// <summary>
        /// There are no comments for Property FStageId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("fStageId")]
        public virtual global::System.Nullable<global::System.Guid> FStageId
        {
            get
            {
                return this._FStageId;
            }
            set
            {
                this.OnFStageIdChanging(value);
                this._FStageId = value;
                this.OnFStageIdChanged();
                this.OnPropertyChanged("fStageId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _FStageId;
        partial void OnFStageIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnFStageIdChanged();
        /// <summary>
        /// There are no comments for Property FStageNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("fStageNumber")]
        public virtual global::System.Nullable<int> FStageNumber
        {
            get
            {
                return this._FStageNumber;
            }
            set
            {
                this.OnFStageNumberChanging(value);
                this._FStageNumber = value;
                this.OnFStageNumberChanged();
                this.OnPropertyChanged("fStageNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _FStageNumber;
        partial void OnFStageNumberChanging(global::System.Nullable<int> value);
        partial void OnFStageNumberChanged();
        /// <summary>
        /// There are no comments for Property FStartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("fStartDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> FStartDate
        {
            get
            {
                return this._FStartDate;
            }
            set
            {
                this.OnFStartDateChanging(value);
                this._FStartDate = value;
                this.OnFStartDateChanged();
                this.OnPropertyChanged("fStartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _FStartDate;
        partial void OnFStartDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnFStartDateChanged();
        /// <summary>
        /// There are no comments for Property FDueDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("fDueDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> FDueDate
        {
            get
            {
                return this._FDueDate;
            }
            set
            {
                this.OnFDueDateChanging(value);
                this._FDueDate = value;
                this.OnFDueDateChanged();
                this.OnPropertyChanged("fDueDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _FDueDate;
        partial void OnFDueDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnFDueDateChanged();
        /// <summary>
        /// There are no comments for Property FCreatedOn in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("fCreatedOn")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> FCreatedOn
        {
            get
            {
                return this._FCreatedOn;
            }
            set
            {
                this.OnFCreatedOnChanging(value);
                this._FCreatedOn = value;
                this.OnFCreatedOnChanged();
                this.OnPropertyChanged("fCreatedOn");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _FCreatedOn;
        partial void OnFCreatedOnChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnFCreatedOnChanged();
        /// <summary>
        /// There are no comments for Property LStageId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("lStageId")]
        public virtual global::System.Nullable<global::System.Guid> LStageId
        {
            get
            {
                return this._LStageId;
            }
            set
            {
                this.OnLStageIdChanging(value);
                this._LStageId = value;
                this.OnLStageIdChanged();
                this.OnPropertyChanged("lStageId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _LStageId;
        partial void OnLStageIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnLStageIdChanged();
        /// <summary>
        /// There are no comments for Property LStageNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("lStageNumber")]
        public virtual global::System.Nullable<int> LStageNumber
        {
            get
            {
                return this._LStageNumber;
            }
            set
            {
                this.OnLStageNumberChanging(value);
                this._LStageNumber = value;
                this.OnLStageNumberChanged();
                this.OnPropertyChanged("lStageNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _LStageNumber;
        partial void OnLStageNumberChanging(global::System.Nullable<int> value);
        partial void OnLStageNumberChanged();
        /// <summary>
        /// There are no comments for Property LStartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("lStartDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> LStartDate
        {
            get
            {
                return this._LStartDate;
            }
            set
            {
                this.OnLStartDateChanging(value);
                this._LStartDate = value;
                this.OnLStartDateChanged();
                this.OnPropertyChanged("lStartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _LStartDate;
        partial void OnLStartDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnLStartDateChanged();
        /// <summary>
        /// There are no comments for Property LDueDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("lDueDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> LDueDate
        {
            get
            {
                return this._LDueDate;
            }
            set
            {
                this.OnLDueDateChanging(value);
                this._LDueDate = value;
                this.OnLDueDateChanged();
                this.OnPropertyChanged("lDueDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _LDueDate;
        partial void OnLDueDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnLDueDateChanged();
        /// <summary>
        /// There are no comments for Property LCreatedOn in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("lCreatedOn")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> LCreatedOn
        {
            get
            {
                return this._LCreatedOn;
            }
            set
            {
                this.OnLCreatedOnChanging(value);
                this._LCreatedOn = value;
                this.OnLCreatedOnChanged();
                this.OnPropertyChanged("lCreatedOn");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _LCreatedOn;
        partial void OnLCreatedOnChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnLCreatedOnChanged();
        /// <summary>
        /// There are no comments for Property IsInStageConversion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsInStageConversion")]
        public virtual global::System.Nullable<int> IsInStageConversion
        {
            get
            {
                return this._IsInStageConversion;
            }
            set
            {
                this.OnIsInStageConversionChanging(value);
                this._IsInStageConversion = value;
                this.OnIsInStageConversionChanged();
                this.OnPropertyChanged("IsInStageConversion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _IsInStageConversion;
        partial void OnIsInStageConversionChanging(global::System.Nullable<int> value);
        partial void OnIsInStageConversionChanged();
        /// <summary>
        /// There are no comments for Property Opportunity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Opportunity")]
        public virtual global::Terrasoft.Configuration.OData.Opportunity Opportunity
        {
            get
            {
                return this._Opportunity;
            }
            set
            {
                this.OnOpportunityChanging(value);
                this._Opportunity = value;
                this.OnOpportunityChanged();
                this.OnPropertyChanged("Opportunity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.Opportunity _Opportunity;
        partial void OnOpportunityChanging(global::Terrasoft.Configuration.OData.Opportunity value);
        partial void OnOpportunityChanged();
        /// <summary>
        /// There are no comments for Property FStage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("fStage")]
        public virtual global::Terrasoft.Configuration.OData.OpportunityStage FStage
        {
            get
            {
                return this._FStage;
            }
            set
            {
                this.OnFStageChanging(value);
                this._FStage = value;
                this.OnFStageChanged();
                this.OnPropertyChanged("fStage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.OpportunityStage _FStage;
        partial void OnFStageChanging(global::Terrasoft.Configuration.OData.OpportunityStage value);
        partial void OnFStageChanged();
        /// <summary>
        /// There are no comments for Property LStage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("lStage")]
        public virtual global::Terrasoft.Configuration.OData.OpportunityStage LStage
        {
            get
            {
                return this._LStage;
            }
            set
            {
                this.OnLStageChanging(value);
                this._LStage = value;
                this.OnLStageChanged();
                this.OnPropertyChanged("lStage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.OpportunityStage _LStage;
        partial void OnLStageChanging(global::Terrasoft.Configuration.OData.OpportunityStage value);
        partial void OnLStageChanged();
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