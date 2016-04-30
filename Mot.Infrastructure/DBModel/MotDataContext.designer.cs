﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mot.Infrastructure.DBModel
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MoT")]
	public partial class MotDataContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSetting(Setting instance);
    partial void UpdateSetting(Setting instance);
    partial void DeleteSetting(Setting instance);
    partial void InsertUrl_RestApi(Url_RestApi instance);
    partial void UpdateUrl_RestApi(Url_RestApi instance);
    partial void DeleteUrl_RestApi(Url_RestApi instance);
    partial void InsertTank(Tank instance);
    partial void UpdateTank(Tank instance);
    partial void DeleteTank(Tank instance);
    #endregion
		
		public MotDataContextDataContext() : 
				base(global::Mot.Infrastructure.Properties.Settings.Default.MoTConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MotDataContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MotDataContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MotDataContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MotDataContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Setting> Settings
		{
			get
			{
				return this.GetTable<Setting>();
			}
		}
		
		public System.Data.Linq.Table<Url_RestApi> Url_RestApis
		{
			get
			{
				return this.GetTable<Url_RestApi>();
			}
		}
		
		public System.Data.Linq.Table<Tank> Tanks
		{
			get
			{
				return this.GetTable<Tank>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Settings")]
	public partial class Setting : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Application_ID;
		
		private int _ID;
		
		private EntitySet<Url_RestApi> _Url_RestApis;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnApplication_IDChanging(string value);
    partial void OnApplication_IDChanged();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    #endregion
		
		public Setting()
		{
			this._Url_RestApis = new EntitySet<Url_RestApi>(new Action<Url_RestApi>(this.attach_Url_RestApis), new Action<Url_RestApi>(this.detach_Url_RestApis));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Application_ID", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string Application_ID
		{
			get
			{
				return this._Application_ID;
			}
			set
			{
				if ((this._Application_ID != value))
				{
					this.OnApplication_IDChanging(value);
					this.SendPropertyChanging();
					this._Application_ID = value;
					this.SendPropertyChanged("Application_ID");
					this.OnApplication_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Setting_Url_RestApi", Storage="_Url_RestApis", ThisKey="ID", OtherKey="SettingsId")]
		public EntitySet<Url_RestApi> Url_RestApis
		{
			get
			{
				return this._Url_RestApis;
			}
			set
			{
				this._Url_RestApis.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Url_RestApis(Url_RestApi entity)
		{
			this.SendPropertyChanging();
			entity.Setting = this;
		}
		
		private void detach_Url_RestApis(Url_RestApi entity)
		{
			this.SendPropertyChanging();
			entity.Setting = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Url_RestApi")]
	public partial class Url_RestApi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Api_Prefix;
		
		private string _Server;
		
		private int _SettingsId;
		
		private EntityRef<Setting> _Setting;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnApi_PrefixChanging(string value);
    partial void OnApi_PrefixChanged();
    partial void OnServerChanging(string value);
    partial void OnServerChanged();
    partial void OnSettingsIdChanging(int value);
    partial void OnSettingsIdChanged();
    #endregion
		
		public Url_RestApi()
		{
			this._Setting = default(EntityRef<Setting>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Api_Prefix", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string Api_Prefix
		{
			get
			{
				return this._Api_Prefix;
			}
			set
			{
				if ((this._Api_Prefix != value))
				{
					this.OnApi_PrefixChanging(value);
					this.SendPropertyChanging();
					this._Api_Prefix = value;
					this.SendPropertyChanged("Api_Prefix");
					this.OnApi_PrefixChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Server", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Server
		{
			get
			{
				return this._Server;
			}
			set
			{
				if ((this._Server != value))
				{
					this.OnServerChanging(value);
					this.SendPropertyChanging();
					this._Server = value;
					this.SendPropertyChanged("Server");
					this.OnServerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SettingsId", DbType="Int NOT NULL")]
		public int SettingsId
		{
			get
			{
				return this._SettingsId;
			}
			set
			{
				if ((this._SettingsId != value))
				{
					if (this._Setting.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSettingsIdChanging(value);
					this.SendPropertyChanging();
					this._SettingsId = value;
					this.SendPropertyChanged("SettingsId");
					this.OnSettingsIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Setting_Url_RestApi", Storage="_Setting", ThisKey="SettingsId", OtherKey="ID", IsForeignKey=true)]
		public Setting Setting
		{
			get
			{
				return this._Setting.Entity;
			}
			set
			{
				Setting previousValue = this._Setting.Entity;
				if (((previousValue != value) 
							|| (this._Setting.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Setting.Entity = null;
						previousValue.Url_RestApis.Remove(this);
					}
					this._Setting.Entity = value;
					if ((value != null))
					{
						value.Url_RestApis.Add(this);
						this._SettingsId = value.ID;
					}
					else
					{
						this._SettingsId = default(int);
					}
					this.SendPropertyChanged("Setting");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tank")]
	public partial class Tank : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private int _TankId;
		
		private string _Nation;
		
		private int _Tier;
		
		private string _ImageUrl;
		
		private string _Type;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnTankIdChanging(int value);
    partial void OnTankIdChanged();
    partial void OnNationChanging(string value);
    partial void OnNationChanged();
    partial void OnTierChanging(int value);
    partial void OnTierChanged();
    partial void OnImageUrlChanging(string value);
    partial void OnImageUrlChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    #endregion
		
		public Tank()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TankId", DbType="Int NOT NULL")]
		public int TankId
		{
			get
			{
				return this._TankId;
			}
			set
			{
				if ((this._TankId != value))
				{
					this.OnTankIdChanging(value);
					this.SendPropertyChanging();
					this._TankId = value;
					this.SendPropertyChanged("TankId");
					this.OnTankIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nation", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string Nation
		{
			get
			{
				return this._Nation;
			}
			set
			{
				if ((this._Nation != value))
				{
					this.OnNationChanging(value);
					this.SendPropertyChanging();
					this._Nation = value;
					this.SendPropertyChanged("Nation");
					this.OnNationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tier", DbType="Int NOT NULL")]
		public int Tier
		{
			get
			{
				return this._Tier;
			}
			set
			{
				if ((this._Tier != value))
				{
					this.OnTierChanging(value);
					this.SendPropertyChanging();
					this._Tier = value;
					this.SendPropertyChanged("Tier");
					this.OnTierChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageUrl", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string ImageUrl
		{
			get
			{
				return this._ImageUrl;
			}
			set
			{
				if ((this._ImageUrl != value))
				{
					this.OnImageUrlChanging(value);
					this.SendPropertyChanging();
					this._ImageUrl = value;
					this.SendPropertyChanged("ImageUrl");
					this.OnImageUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
