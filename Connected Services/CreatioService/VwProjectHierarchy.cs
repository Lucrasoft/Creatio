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
    /// There are no comments for VwProjectHierarchySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("VwProjectHierarchySingle")]
    public partial class VwProjectHierarchySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VwProjectHierarchy>
    {
        /// <summary>
        /// Initialize a new VwProjectHierarchySingle object.
        /// </summary>
        public VwProjectHierarchySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VwProjectHierarchySingle object.
        /// </summary>
        public VwProjectHierarchySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VwProjectHierarchySingle object.
        /// </summary>
        public VwProjectHierarchySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VwProjectHierarchy> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Project in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Project")]
        public virtual global::Terrasoft.Configuration.OData.ProjectSingle Project
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Project == null))
                {
                    this._Project = new global::Terrasoft.Configuration.OData.ProjectSingle(this.Context, GetPath("Project"));
                }
                return this._Project;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.ProjectSingle _Project;
        /// <summary>
        /// There are no comments for BaseProject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BaseProject")]
        public virtual global::Terrasoft.Configuration.OData.ProjectSingle BaseProject
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BaseProject == null))
                {
                    this._BaseProject = new global::Terrasoft.Configuration.OData.ProjectSingle(this.Context, GetPath("BaseProject"));
                }
                return this._BaseProject;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.ProjectSingle _BaseProject;
        /// <summary>
        /// There are no comments for Account in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Account")]
        public virtual global::Terrasoft.Configuration.OData.AccountSingle Account
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Account == null))
                {
                    this._Account = new global::Terrasoft.Configuration.OData.AccountSingle(this.Context, GetPath("Account"));
                }
                return this._Account;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.AccountSingle _Account;
    }
    /// <summary>
    /// There are no comments for VwProjectHierarchy in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("VwProjectHierarchy")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("VwProjectHierarchy")]
    public partial class VwProjectHierarchy : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property ProjectId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectId")]
        public virtual global::System.Nullable<global::System.Guid> ProjectId
        {
            get
            {
                return this._ProjectId;
            }
            set
            {
                this.OnProjectIdChanging(value);
                this._ProjectId = value;
                this.OnProjectIdChanged();
                this.OnPropertyChanged("ProjectId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _ProjectId;
        partial void OnProjectIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnProjectIdChanged();
        /// <summary>
        /// There are no comments for Property BaseProjectId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BaseProjectId")]
        public virtual global::System.Nullable<global::System.Guid> BaseProjectId
        {
            get
            {
                return this._BaseProjectId;
            }
            set
            {
                this.OnBaseProjectIdChanging(value);
                this._BaseProjectId = value;
                this.OnBaseProjectIdChanged();
                this.OnPropertyChanged("BaseProjectId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _BaseProjectId;
        partial void OnBaseProjectIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnBaseProjectIdChanged();
        /// <summary>
        /// There are no comments for Property IsFirst in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsFirst")]
        public virtual global::System.Nullable<bool> IsFirst
        {
            get
            {
                return this._IsFirst;
            }
            set
            {
                this.OnIsFirstChanging(value);
                this._IsFirst = value;
                this.OnIsFirstChanged();
                this.OnPropertyChanged("IsFirst");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _IsFirst;
        partial void OnIsFirstChanging(global::System.Nullable<bool> value);
        partial void OnIsFirstChanged();
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
        /// There are no comments for Property AccountId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountId")]
        public virtual global::System.Nullable<global::System.Guid> AccountId
        {
            get
            {
                return this._AccountId;
            }
            set
            {
                this.OnAccountIdChanging(value);
                this._AccountId = value;
                this.OnAccountIdChanged();
                this.OnPropertyChanged("AccountId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _AccountId;
        partial void OnAccountIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnAccountIdChanged();
        /// <summary>
        /// There are no comments for Property Project in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Project")]
        public virtual global::Terrasoft.Configuration.OData.Project Project
        {
            get
            {
                return this._Project;
            }
            set
            {
                this.OnProjectChanging(value);
                this._Project = value;
                this.OnProjectChanged();
                this.OnPropertyChanged("Project");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.Project _Project;
        partial void OnProjectChanging(global::Terrasoft.Configuration.OData.Project value);
        partial void OnProjectChanged();
        /// <summary>
        /// There are no comments for Property BaseProject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BaseProject")]
        public virtual global::Terrasoft.Configuration.OData.Project BaseProject
        {
            get
            {
                return this._BaseProject;
            }
            set
            {
                this.OnBaseProjectChanging(value);
                this._BaseProject = value;
                this.OnBaseProjectChanged();
                this.OnPropertyChanged("BaseProject");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.Project _BaseProject;
        partial void OnBaseProjectChanging(global::Terrasoft.Configuration.OData.Project value);
        partial void OnBaseProjectChanged();
        /// <summary>
        /// There are no comments for Property Account in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Account")]
        public virtual global::Terrasoft.Configuration.OData.Account Account
        {
            get
            {
                return this._Account;
            }
            set
            {
                this.OnAccountChanging(value);
                this._Account = value;
                this.OnAccountChanged();
                this.OnPropertyChanged("Account");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.Account _Account;
        partial void OnAccountChanging(global::Terrasoft.Configuration.OData.Account value);
        partial void OnAccountChanged();
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
