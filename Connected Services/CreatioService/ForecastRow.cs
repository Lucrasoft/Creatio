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
    /// There are no comments for ForecastRowSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ForecastRowSingle")]
    public partial class ForecastRowSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ForecastRow>
    {
        /// <summary>
        /// Initialize a new ForecastRowSingle object.
        /// </summary>
        public ForecastRowSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ForecastRowSingle object.
        /// </summary>
        public ForecastRowSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ForecastRowSingle object.
        /// </summary>
        public ForecastRowSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ForecastRow> query)
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
        /// There are no comments for AccountForecastCollectionByRow in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountForecastCollectionByRow")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.AccountForecast> AccountForecastCollectionByRow
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AccountForecastCollectionByRow == null))
                {
                    this._AccountForecastCollectionByRow = Context.CreateQuery<global::Terrasoft.Configuration.OData.AccountForecast>(GetPath("AccountForecastCollectionByRow"));
                }
                return this._AccountForecastCollectionByRow;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.AccountForecast> _AccountForecastCollectionByRow;
        /// <summary>
        /// There are no comments for ContactForecastCollectionByRow in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ContactForecastCollectionByRow")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.ContactForecast> ContactForecastCollectionByRow
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ContactForecastCollectionByRow == null))
                {
                    this._ContactForecastCollectionByRow = Context.CreateQuery<global::Terrasoft.Configuration.OData.ContactForecast>(GetPath("ContactForecastCollectionByRow"));
                }
                return this._ContactForecastCollectionByRow;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.ContactForecast> _ContactForecastCollectionByRow;
        /// <summary>
        /// There are no comments for ForecastHistoryCellCollectionByRow in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ForecastHistoryCellCollectionByRow")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.ForecastHistoryCell> ForecastHistoryCellCollectionByRow
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ForecastHistoryCellCollectionByRow == null))
                {
                    this._ForecastHistoryCellCollectionByRow = Context.CreateQuery<global::Terrasoft.Configuration.OData.ForecastHistoryCell>(GetPath("ForecastHistoryCellCollectionByRow"));
                }
                return this._ForecastHistoryCellCollectionByRow;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.ForecastHistoryCell> _ForecastHistoryCellCollectionByRow;
        /// <summary>
        /// There are no comments for ForecastHistoryRowCollectionByRow in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ForecastHistoryRowCollectionByRow")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.ForecastHistoryRow> ForecastHistoryRowCollectionByRow
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ForecastHistoryRowCollectionByRow == null))
                {
                    this._ForecastHistoryRowCollectionByRow = Context.CreateQuery<global::Terrasoft.Configuration.OData.ForecastHistoryRow>(GetPath("ForecastHistoryRowCollectionByRow"));
                }
                return this._ForecastHistoryRowCollectionByRow;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.ForecastHistoryRow> _ForecastHistoryRowCollectionByRow;
        /// <summary>
        /// There are no comments for LeadTypeForecastCollectionByRow in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LeadTypeForecastCollectionByRow")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.LeadTypeForecast> LeadTypeForecastCollectionByRow
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LeadTypeForecastCollectionByRow == null))
                {
                    this._LeadTypeForecastCollectionByRow = Context.CreateQuery<global::Terrasoft.Configuration.OData.LeadTypeForecast>(GetPath("LeadTypeForecastCollectionByRow"));
                }
                return this._LeadTypeForecastCollectionByRow;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.LeadTypeForecast> _LeadTypeForecastCollectionByRow;
        /// <summary>
        /// There are no comments for OppDepartmentForecastCollectionByRow in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("OppDepartmentForecastCollectionByRow")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.OppDepartmentForecast> OppDepartmentForecastCollectionByRow
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OppDepartmentForecastCollectionByRow == null))
                {
                    this._OppDepartmentForecastCollectionByRow = Context.CreateQuery<global::Terrasoft.Configuration.OData.OppDepartmentForecast>(GetPath("OppDepartmentForecastCollectionByRow"));
                }
                return this._OppDepartmentForecastCollectionByRow;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.OppDepartmentForecast> _OppDepartmentForecastCollectionByRow;
        /// <summary>
        /// There are no comments for ProductForecastCollectionByRow in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductForecastCollectionByRow")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.ProductForecast> ProductForecastCollectionByRow
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductForecastCollectionByRow == null))
                {
                    this._ProductForecastCollectionByRow = Context.CreateQuery<global::Terrasoft.Configuration.OData.ProductForecast>(GetPath("ProductForecastCollectionByRow"));
                }
                return this._ProductForecastCollectionByRow;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.ProductForecast> _ProductForecastCollectionByRow;
    }
    /// <summary>
    /// There are no comments for ForecastRow in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("ForecastRow")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ForecastRow")]
    public partial class ForecastRow : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
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
        /// There are no comments for Property DeletedOn in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeletedOn")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> DeletedOn
        {
            get
            {
                return this._DeletedOn;
            }
            set
            {
                this.OnDeletedOnChanging(value);
                this._DeletedOn = value;
                this.OnDeletedOnChanged();
                this.OnPropertyChanged("DeletedOn");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _DeletedOn;
        partial void OnDeletedOnChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnDeletedOnChanged();
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
        /// There are no comments for Property AccountForecastCollectionByRow in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountForecastCollectionByRow")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.AccountForecast> AccountForecastCollectionByRow
        {
            get
            {
                return this._AccountForecastCollectionByRow;
            }
            set
            {
                this.OnAccountForecastCollectionByRowChanging(value);
                this._AccountForecastCollectionByRow = value;
                this.OnAccountForecastCollectionByRowChanged();
                this.OnPropertyChanged("AccountForecastCollectionByRow");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.AccountForecast> _AccountForecastCollectionByRow = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.AccountForecast>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAccountForecastCollectionByRowChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.AccountForecast> value);
        partial void OnAccountForecastCollectionByRowChanged();
        /// <summary>
        /// There are no comments for Property ContactForecastCollectionByRow in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContactForecastCollectionByRow")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ContactForecast> ContactForecastCollectionByRow
        {
            get
            {
                return this._ContactForecastCollectionByRow;
            }
            set
            {
                this.OnContactForecastCollectionByRowChanging(value);
                this._ContactForecastCollectionByRow = value;
                this.OnContactForecastCollectionByRowChanged();
                this.OnPropertyChanged("ContactForecastCollectionByRow");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ContactForecast> _ContactForecastCollectionByRow = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ContactForecast>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnContactForecastCollectionByRowChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ContactForecast> value);
        partial void OnContactForecastCollectionByRowChanged();
        /// <summary>
        /// There are no comments for Property ForecastHistoryCellCollectionByRow in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ForecastHistoryCellCollectionByRow")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ForecastHistoryCell> ForecastHistoryCellCollectionByRow
        {
            get
            {
                return this._ForecastHistoryCellCollectionByRow;
            }
            set
            {
                this.OnForecastHistoryCellCollectionByRowChanging(value);
                this._ForecastHistoryCellCollectionByRow = value;
                this.OnForecastHistoryCellCollectionByRowChanged();
                this.OnPropertyChanged("ForecastHistoryCellCollectionByRow");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ForecastHistoryCell> _ForecastHistoryCellCollectionByRow = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ForecastHistoryCell>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnForecastHistoryCellCollectionByRowChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ForecastHistoryCell> value);
        partial void OnForecastHistoryCellCollectionByRowChanged();
        /// <summary>
        /// There are no comments for Property ForecastHistoryRowCollectionByRow in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ForecastHistoryRowCollectionByRow")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ForecastHistoryRow> ForecastHistoryRowCollectionByRow
        {
            get
            {
                return this._ForecastHistoryRowCollectionByRow;
            }
            set
            {
                this.OnForecastHistoryRowCollectionByRowChanging(value);
                this._ForecastHistoryRowCollectionByRow = value;
                this.OnForecastHistoryRowCollectionByRowChanged();
                this.OnPropertyChanged("ForecastHistoryRowCollectionByRow");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ForecastHistoryRow> _ForecastHistoryRowCollectionByRow = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ForecastHistoryRow>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnForecastHistoryRowCollectionByRowChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ForecastHistoryRow> value);
        partial void OnForecastHistoryRowCollectionByRowChanged();
        /// <summary>
        /// There are no comments for Property LeadTypeForecastCollectionByRow in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LeadTypeForecastCollectionByRow")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.LeadTypeForecast> LeadTypeForecastCollectionByRow
        {
            get
            {
                return this._LeadTypeForecastCollectionByRow;
            }
            set
            {
                this.OnLeadTypeForecastCollectionByRowChanging(value);
                this._LeadTypeForecastCollectionByRow = value;
                this.OnLeadTypeForecastCollectionByRowChanged();
                this.OnPropertyChanged("LeadTypeForecastCollectionByRow");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.LeadTypeForecast> _LeadTypeForecastCollectionByRow = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.LeadTypeForecast>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLeadTypeForecastCollectionByRowChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.LeadTypeForecast> value);
        partial void OnLeadTypeForecastCollectionByRowChanged();
        /// <summary>
        /// There are no comments for Property OppDepartmentForecastCollectionByRow in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OppDepartmentForecastCollectionByRow")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.OppDepartmentForecast> OppDepartmentForecastCollectionByRow
        {
            get
            {
                return this._OppDepartmentForecastCollectionByRow;
            }
            set
            {
                this.OnOppDepartmentForecastCollectionByRowChanging(value);
                this._OppDepartmentForecastCollectionByRow = value;
                this.OnOppDepartmentForecastCollectionByRowChanged();
                this.OnPropertyChanged("OppDepartmentForecastCollectionByRow");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.OppDepartmentForecast> _OppDepartmentForecastCollectionByRow = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.OppDepartmentForecast>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnOppDepartmentForecastCollectionByRowChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.OppDepartmentForecast> value);
        partial void OnOppDepartmentForecastCollectionByRowChanged();
        /// <summary>
        /// There are no comments for Property ProductForecastCollectionByRow in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductForecastCollectionByRow")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ProductForecast> ProductForecastCollectionByRow
        {
            get
            {
                return this._ProductForecastCollectionByRow;
            }
            set
            {
                this.OnProductForecastCollectionByRowChanging(value);
                this._ProductForecastCollectionByRow = value;
                this.OnProductForecastCollectionByRowChanged();
                this.OnPropertyChanged("ProductForecastCollectionByRow");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ProductForecast> _ProductForecastCollectionByRow = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ProductForecast>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductForecastCollectionByRowChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ProductForecast> value);
        partial void OnProductForecastCollectionByRowChanged();
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
