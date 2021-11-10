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
    /// There are no comments for ChannelSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ChannelSingle")]
    public partial class ChannelSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Channel>
    {
        /// <summary>
        /// Initialize a new ChannelSingle object.
        /// </summary>
        public ChannelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ChannelSingle object.
        /// </summary>
        public ChannelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ChannelSingle object.
        /// </summary>
        public ChannelSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Channel> query)
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
        /// There are no comments for Provider in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Provider")]
        public virtual global::Terrasoft.Configuration.OData.ChannelProviderSingle Provider
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Provider == null))
                {
                    this._Provider = new global::Terrasoft.Configuration.OData.ChannelProviderSingle(this.Context, GetPath("Provider"));
                }
                return this._Provider;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.ChannelProviderSingle _Provider;
        /// <summary>
        /// There are no comments for ChatQueue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ChatQueue")]
        public virtual global::Terrasoft.Configuration.OData.ChatQueueSingle ChatQueue
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ChatQueue == null))
                {
                    this._ChatQueue = new global::Terrasoft.Configuration.OData.ChatQueueSingle(this.Context, GetPath("ChatQueue"));
                }
                return this._ChatQueue;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.ChatQueueSingle _ChatQueue;
        /// <summary>
        /// There are no comments for Language in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Language")]
        public virtual global::Terrasoft.Configuration.OData.SysLanguageSingle Language
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Language == null))
                {
                    this._Language = new global::Terrasoft.Configuration.OData.SysLanguageSingle(this.Context, GetPath("Language"));
                }
                return this._Language;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.SysLanguageSingle _Language;
        /// <summary>
        /// There are no comments for OmniChatCollectionByChannel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("OmniChatCollectionByChannel")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.OmniChat> OmniChatCollectionByChannel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OmniChatCollectionByChannel == null))
                {
                    this._OmniChatCollectionByChannel = Context.CreateQuery<global::Terrasoft.Configuration.OData.OmniChat>(GetPath("OmniChatCollectionByChannel"));
                }
                return this._OmniChatCollectionByChannel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.OmniChat> _OmniChatCollectionByChannel;
        /// <summary>
        /// There are no comments for ChatMessagesCollectionByChannel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ChatMessagesCollectionByChannel")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.ChatMessages> ChatMessagesCollectionByChannel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ChatMessagesCollectionByChannel == null))
                {
                    this._ChatMessagesCollectionByChannel = Context.CreateQuery<global::Terrasoft.Configuration.OData.ChatMessages>(GetPath("ChatMessagesCollectionByChannel"));
                }
                return this._ChatMessagesCollectionByChannel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.ChatMessages> _ChatMessagesCollectionByChannel;
        /// <summary>
        /// There are no comments for ContactIdentityCollectionByChannel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ContactIdentityCollectionByChannel")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.ContactIdentity> ContactIdentityCollectionByChannel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ContactIdentityCollectionByChannel == null))
                {
                    this._ContactIdentityCollectionByChannel = Context.CreateQuery<global::Terrasoft.Configuration.OData.ContactIdentity>(GetPath("ContactIdentityCollectionByChannel"));
                }
                return this._ContactIdentityCollectionByChannel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Terrasoft.Configuration.OData.ContactIdentity> _ContactIdentityCollectionByChannel;
    }
    /// <summary>
    /// There are no comments for Channel in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("Channel")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Channel")]
    public partial class Channel : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Channel object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="source">Initial value of Source.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Channel CreateChannel(string name, string source)
        {
            Channel channel = new Channel();
            channel.Name = name;
            channel.Source = source;
            return channel;
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
        /// There are no comments for Property ProviderId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProviderId")]
        public virtual global::System.Nullable<global::System.Guid> ProviderId
        {
            get
            {
                return this._ProviderId;
            }
            set
            {
                this.OnProviderIdChanging(value);
                this._ProviderId = value;
                this.OnProviderIdChanged();
                this.OnPropertyChanged("ProviderId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _ProviderId;
        partial void OnProviderIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnProviderIdChanged();
        /// <summary>
        /// There are no comments for Property MsgSettingsId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MsgSettingsId")]
        public virtual global::System.Nullable<global::System.Guid> MsgSettingsId
        {
            get
            {
                return this._MsgSettingsId;
            }
            set
            {
                this.OnMsgSettingsIdChanging(value);
                this._MsgSettingsId = value;
                this.OnMsgSettingsIdChanged();
                this.OnPropertyChanged("MsgSettingsId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _MsgSettingsId;
        partial void OnMsgSettingsIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnMsgSettingsIdChanged();
        /// <summary>
        /// There are no comments for Property ChatQueueId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChatQueueId")]
        public virtual global::System.Nullable<global::System.Guid> ChatQueueId
        {
            get
            {
                return this._ChatQueueId;
            }
            set
            {
                this.OnChatQueueIdChanging(value);
                this._ChatQueueId = value;
                this.OnChatQueueIdChanged();
                this.OnPropertyChanged("ChatQueueId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _ChatQueueId;
        partial void OnChatQueueIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnChatQueueIdChanged();
        /// <summary>
        /// There are no comments for Property Source in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Source")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Source is required.")]
        public virtual string Source
        {
            get
            {
                return this._Source;
            }
            set
            {
                this.OnSourceChanging(value);
                this._Source = value;
                this.OnSourceChanged();
                this.OnPropertyChanged("Source");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Source;
        partial void OnSourceChanging(string value);
        partial void OnSourceChanged();
        /// <summary>
        /// There are no comments for Property IsActive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsActive")]
        public virtual global::System.Nullable<bool> IsActive
        {
            get
            {
                return this._IsActive;
            }
            set
            {
                this.OnIsActiveChanging(value);
                this._IsActive = value;
                this.OnIsActiveChanged();
                this.OnPropertyChanged("IsActive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _IsActive;
        partial void OnIsActiveChanging(global::System.Nullable<bool> value);
        partial void OnIsActiveChanged();
        /// <summary>
        /// There are no comments for Property LanguageId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LanguageId")]
        public virtual global::System.Nullable<global::System.Guid> LanguageId
        {
            get
            {
                return this._LanguageId;
            }
            set
            {
                this.OnLanguageIdChanging(value);
                this._LanguageId = value;
                this.OnLanguageIdChanged();
                this.OnPropertyChanged("LanguageId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _LanguageId;
        partial void OnLanguageIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnLanguageIdChanged();
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
        /// There are no comments for Property Provider in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Provider")]
        public virtual global::Terrasoft.Configuration.OData.ChannelProvider Provider
        {
            get
            {
                return this._Provider;
            }
            set
            {
                this.OnProviderChanging(value);
                this._Provider = value;
                this.OnProviderChanged();
                this.OnPropertyChanged("Provider");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.ChannelProvider _Provider;
        partial void OnProviderChanging(global::Terrasoft.Configuration.OData.ChannelProvider value);
        partial void OnProviderChanged();
        /// <summary>
        /// There are no comments for Property ChatQueue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChatQueue")]
        public virtual global::Terrasoft.Configuration.OData.ChatQueue ChatQueue
        {
            get
            {
                return this._ChatQueue;
            }
            set
            {
                this.OnChatQueueChanging(value);
                this._ChatQueue = value;
                this.OnChatQueueChanged();
                this.OnPropertyChanged("ChatQueue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.ChatQueue _ChatQueue;
        partial void OnChatQueueChanging(global::Terrasoft.Configuration.OData.ChatQueue value);
        partial void OnChatQueueChanged();
        /// <summary>
        /// There are no comments for Property Language in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Language")]
        public virtual global::Terrasoft.Configuration.OData.SysLanguage Language
        {
            get
            {
                return this._Language;
            }
            set
            {
                this.OnLanguageChanging(value);
                this._Language = value;
                this.OnLanguageChanged();
                this.OnPropertyChanged("Language");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Terrasoft.Configuration.OData.SysLanguage _Language;
        partial void OnLanguageChanging(global::Terrasoft.Configuration.OData.SysLanguage value);
        partial void OnLanguageChanged();
        /// <summary>
        /// There are no comments for Property OmniChatCollectionByChannel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OmniChatCollectionByChannel")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.OmniChat> OmniChatCollectionByChannel
        {
            get
            {
                return this._OmniChatCollectionByChannel;
            }
            set
            {
                this.OnOmniChatCollectionByChannelChanging(value);
                this._OmniChatCollectionByChannel = value;
                this.OnOmniChatCollectionByChannelChanged();
                this.OnPropertyChanged("OmniChatCollectionByChannel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.OmniChat> _OmniChatCollectionByChannel = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.OmniChat>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnOmniChatCollectionByChannelChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.OmniChat> value);
        partial void OnOmniChatCollectionByChannelChanged();
        /// <summary>
        /// There are no comments for Property ChatMessagesCollectionByChannel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChatMessagesCollectionByChannel")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ChatMessages> ChatMessagesCollectionByChannel
        {
            get
            {
                return this._ChatMessagesCollectionByChannel;
            }
            set
            {
                this.OnChatMessagesCollectionByChannelChanging(value);
                this._ChatMessagesCollectionByChannel = value;
                this.OnChatMessagesCollectionByChannelChanged();
                this.OnPropertyChanged("ChatMessagesCollectionByChannel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ChatMessages> _ChatMessagesCollectionByChannel = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ChatMessages>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnChatMessagesCollectionByChannelChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ChatMessages> value);
        partial void OnChatMessagesCollectionByChannelChanged();
        /// <summary>
        /// There are no comments for Property ContactIdentityCollectionByChannel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContactIdentityCollectionByChannel")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ContactIdentity> ContactIdentityCollectionByChannel
        {
            get
            {
                return this._ContactIdentityCollectionByChannel;
            }
            set
            {
                this.OnContactIdentityCollectionByChannelChanging(value);
                this._ContactIdentityCollectionByChannel = value;
                this.OnContactIdentityCollectionByChannelChanged();
                this.OnPropertyChanged("ContactIdentityCollectionByChannel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ContactIdentity> _ContactIdentityCollectionByChannel = new global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ContactIdentity>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnContactIdentityCollectionByChannelChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Terrasoft.Configuration.OData.ContactIdentity> value);
        partial void OnContactIdentityCollectionByChannelChanged();
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