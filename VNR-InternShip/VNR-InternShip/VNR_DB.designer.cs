﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VNR_InternShip
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="VNR_InternShip")]
	public partial class VNR_DBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKhoaHoc(KhoaHoc instance);
    partial void UpdateKhoaHoc(KhoaHoc instance);
    partial void DeleteKhoaHoc(KhoaHoc instance);
    partial void InsertMonHoc(MonHoc instance);
    partial void UpdateMonHoc(MonHoc instance);
    partial void DeleteMonHoc(MonHoc instance);
    #endregion
		
		public VNR_DBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["VNR_InternShipConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public VNR_DBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VNR_DBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VNR_DBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VNR_DBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<KhoaHoc> KhoaHocs
		{
			get
			{
				return this.GetTable<KhoaHoc>();
			}
		}
		
		public System.Data.Linq.Table<MonHoc> MonHocs
		{
			get
			{
				return this.GetTable<MonHoc>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhoaHoc")]
	public partial class KhoaHoc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _TenKhoaHoc;
		
		private EntitySet<MonHoc> _MonHocs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTenKhoaHocChanging(string value);
    partial void OnTenKhoaHocChanged();
    #endregion
		
		public KhoaHoc()
		{
			this._MonHocs = new EntitySet<MonHoc>(new Action<MonHoc>(this.attach_MonHocs), new Action<MonHoc>(this.detach_MonHocs));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKhoaHoc", DbType="NVarChar(30)")]
		public string TenKhoaHoc
		{
			get
			{
				return this._TenKhoaHoc;
			}
			set
			{
				if ((this._TenKhoaHoc != value))
				{
					this.OnTenKhoaHocChanging(value);
					this.SendPropertyChanging();
					this._TenKhoaHoc = value;
					this.SendPropertyChanged("TenKhoaHoc");
					this.OnTenKhoaHocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhoaHoc_MonHoc", Storage="_MonHocs", ThisKey="ID", OtherKey="KhoaHocID")]
		public EntitySet<MonHoc> MonHocs
		{
			get
			{
				return this._MonHocs;
			}
			set
			{
				this._MonHocs.Assign(value);
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
		
		private void attach_MonHocs(MonHoc entity)
		{
			this.SendPropertyChanging();
			entity.KhoaHoc = this;
		}
		
		private void detach_MonHocs(MonHoc entity)
		{
			this.SendPropertyChanging();
			entity.KhoaHoc = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MonHoc")]
	public partial class MonHoc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _TenMonHoc;
		
		private string _MoTa;
		
		private int _KhoaHocID;
		
		private EntityRef<KhoaHoc> _KhoaHoc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTenMonHocChanging(string value);
    partial void OnTenMonHocChanged();
    partial void OnMoTaChanging(string value);
    partial void OnMoTaChanged();
    partial void OnKhoaHocIDChanging(int value);
    partial void OnKhoaHocIDChanged();
    #endregion
		
		public MonHoc()
		{
			this._KhoaHoc = default(EntityRef<KhoaHoc>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenMonHoc", DbType="NVarChar(100)")]
		public string TenMonHoc
		{
			get
			{
				return this._TenMonHoc;
			}
			set
			{
				if ((this._TenMonHoc != value))
				{
					this.OnTenMonHocChanging(value);
					this.SendPropertyChanging();
					this._TenMonHoc = value;
					this.SendPropertyChanged("TenMonHoc");
					this.OnTenMonHocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoTa", DbType="NVarChar(100)")]
		public string MoTa
		{
			get
			{
				return this._MoTa;
			}
			set
			{
				if ((this._MoTa != value))
				{
					this.OnMoTaChanging(value);
					this.SendPropertyChanging();
					this._MoTa = value;
					this.SendPropertyChanged("MoTa");
					this.OnMoTaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KhoaHocID", DbType="Int NOT NULL")]
		public int KhoaHocID
		{
			get
			{
				return this._KhoaHocID;
			}
			set
			{
				if ((this._KhoaHocID != value))
				{
					if (this._KhoaHoc.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnKhoaHocIDChanging(value);
					this.SendPropertyChanging();
					this._KhoaHocID = value;
					this.SendPropertyChanged("KhoaHocID");
					this.OnKhoaHocIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhoaHoc_MonHoc", Storage="_KhoaHoc", ThisKey="KhoaHocID", OtherKey="ID", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public KhoaHoc KhoaHoc
		{
			get
			{
				return this._KhoaHoc.Entity;
			}
			set
			{
				KhoaHoc previousValue = this._KhoaHoc.Entity;
				if (((previousValue != value) 
							|| (this._KhoaHoc.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KhoaHoc.Entity = null;
						previousValue.MonHocs.Remove(this);
					}
					this._KhoaHoc.Entity = value;
					if ((value != null))
					{
						value.MonHocs.Add(this);
						this._KhoaHocID = value.ID;
					}
					else
					{
						this._KhoaHocID = default(int);
					}
					this.SendPropertyChanged("KhoaHoc");
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