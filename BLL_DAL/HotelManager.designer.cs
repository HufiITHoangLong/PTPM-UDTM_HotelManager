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

namespace BLL_DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Hotel_Manager")]
	public partial class HotelManagerDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPHONG(PHONG instance);
    partial void UpdatePHONG(PHONG instance);
    partial void DeletePHONG(PHONG instance);
    partial void InsertDICHVU(DICHVU instance);
    partial void UpdateDICHVU(DICHVU instance);
    partial void DeleteDICHVU(DICHVU instance);
    partial void InsertLOAIPHONG(LOAIPHONG instance);
    partial void UpdateLOAIPHONG(LOAIPHONG instance);
    partial void DeleteLOAIPHONG(LOAIPHONG instance);
    partial void InsertNHANVIEN(NHANVIEN instance);
    partial void UpdateNHANVIEN(NHANVIEN instance);
    partial void DeleteNHANVIEN(NHANVIEN instance);
    partial void InsertKHACHHANG(KHACHHANG instance);
    partial void UpdateKHACHHANG(KHACHHANG instance);
    partial void DeleteKHACHHANG(KHACHHANG instance);
    partial void InsertCT_NHANPHONG(CT_NHANPHONG instance);
    partial void UpdateCT_NHANPHONG(CT_NHANPHONG instance);
    partial void DeleteCT_NHANPHONG(CT_NHANPHONG instance);
    #endregion
		
		public HotelManagerDataContext() : 
				base(global::BLL_DAL.Properties.Settings.Default.Hotel_ManagerConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public HotelManagerDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HotelManagerDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HotelManagerDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HotelManagerDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<PHONG> PHONGs
		{
			get
			{
				return this.GetTable<PHONG>();
			}
		}
		
		public System.Data.Linq.Table<DICHVU> DICHVUs
		{
			get
			{
				return this.GetTable<DICHVU>();
			}
		}
		
		public System.Data.Linq.Table<LOAIPHONG> LOAIPHONGs
		{
			get
			{
				return this.GetTable<LOAIPHONG>();
			}
		}
		
		public System.Data.Linq.Table<NHANVIEN> NHANVIENs
		{
			get
			{
				return this.GetTable<NHANVIEN>();
			}
		}
		
		public System.Data.Linq.Table<KHACHHANG> KHACHHANGs
		{
			get
			{
				return this.GetTable<KHACHHANG>();
			}
		}
		
		public System.Data.Linq.Table<CT_NHANPHONG> CT_NHANPHONGs
		{
			get
			{
				return this.GetTable<CT_NHANPHONG>();
			}
		}
		
		public System.Data.Linq.Table<HoaDon> HoaDons
		{
			get
			{
				return this.GetTable<HoaDon>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PHONG")]
	public partial class PHONG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MAPHONG;
		
		private System.Nullable<int> _TRANGTHAI;
		
		private System.Nullable<int> _SUCCHUA;
		
		private System.Nullable<int> _MALOAIPHONG;
		
		private EntityRef<LOAIPHONG> _LOAIPHONG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAPHONGChanging(string value);
    partial void OnMAPHONGChanged();
    partial void OnTRANGTHAIChanging(System.Nullable<int> value);
    partial void OnTRANGTHAIChanged();
    partial void OnSUCCHUAChanging(System.Nullable<int> value);
    partial void OnSUCCHUAChanged();
    partial void OnMALOAIPHONGChanging(System.Nullable<int> value);
    partial void OnMALOAIPHONGChanged();
    #endregion
		
		public PHONG()
		{
			this._LOAIPHONG = default(EntityRef<LOAIPHONG>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAPHONG", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MAPHONG
		{
			get
			{
				return this._MAPHONG;
			}
			set
			{
				if ((this._MAPHONG != value))
				{
					this.OnMAPHONGChanging(value);
					this.SendPropertyChanging();
					this._MAPHONG = value;
					this.SendPropertyChanged("MAPHONG");
					this.OnMAPHONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TRANGTHAI", DbType="Int")]
		public System.Nullable<int> TRANGTHAI
		{
			get
			{
				return this._TRANGTHAI;
			}
			set
			{
				if ((this._TRANGTHAI != value))
				{
					this.OnTRANGTHAIChanging(value);
					this.SendPropertyChanging();
					this._TRANGTHAI = value;
					this.SendPropertyChanged("TRANGTHAI");
					this.OnTRANGTHAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SUCCHUA", DbType="Int")]
		public System.Nullable<int> SUCCHUA
		{
			get
			{
				return this._SUCCHUA;
			}
			set
			{
				if ((this._SUCCHUA != value))
				{
					this.OnSUCCHUAChanging(value);
					this.SendPropertyChanging();
					this._SUCCHUA = value;
					this.SendPropertyChanged("SUCCHUA");
					this.OnSUCCHUAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MALOAIPHONG", DbType="Int")]
		public System.Nullable<int> MALOAIPHONG
		{
			get
			{
				return this._MALOAIPHONG;
			}
			set
			{
				if ((this._MALOAIPHONG != value))
				{
					if (this._LOAIPHONG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMALOAIPHONGChanging(value);
					this.SendPropertyChanging();
					this._MALOAIPHONG = value;
					this.SendPropertyChanged("MALOAIPHONG");
					this.OnMALOAIPHONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAIPHONG_PHONG", Storage="_LOAIPHONG", ThisKey="MALOAIPHONG", OtherKey="MALOAIPHONG", IsForeignKey=true)]
		public LOAIPHONG LOAIPHONG
		{
			get
			{
				return this._LOAIPHONG.Entity;
			}
			set
			{
				LOAIPHONG previousValue = this._LOAIPHONG.Entity;
				if (((previousValue != value) 
							|| (this._LOAIPHONG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LOAIPHONG.Entity = null;
						previousValue.PHONGs.Remove(this);
					}
					this._LOAIPHONG.Entity = value;
					if ((value != null))
					{
						value.PHONGs.Add(this);
						this._MALOAIPHONG = value.MALOAIPHONG;
					}
					else
					{
						this._MALOAIPHONG = default(Nullable<int>);
					}
					this.SendPropertyChanged("LOAIPHONG");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DICHVU")]
	public partial class DICHVU : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MADV;
		
		private string _TENDV;
		
		private System.Nullable<int> _DONGIA;
		
		private EntitySet<CT_NHANPHONG> _CT_NHANPHONGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMADVChanging(string value);
    partial void OnMADVChanged();
    partial void OnTENDVChanging(string value);
    partial void OnTENDVChanged();
    partial void OnDONGIAChanging(System.Nullable<int> value);
    partial void OnDONGIAChanged();
    #endregion
		
		public DICHVU()
		{
			this._CT_NHANPHONGs = new EntitySet<CT_NHANPHONG>(new Action<CT_NHANPHONG>(this.attach_CT_NHANPHONGs), new Action<CT_NHANPHONG>(this.detach_CT_NHANPHONGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MADV", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MADV
		{
			get
			{
				return this._MADV;
			}
			set
			{
				if ((this._MADV != value))
				{
					this.OnMADVChanging(value);
					this.SendPropertyChanging();
					this._MADV = value;
					this.SendPropertyChanged("MADV");
					this.OnMADVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENDV", DbType="NVarChar(50)")]
		public string TENDV
		{
			get
			{
				return this._TENDV;
			}
			set
			{
				if ((this._TENDV != value))
				{
					this.OnTENDVChanging(value);
					this.SendPropertyChanging();
					this._TENDV = value;
					this.SendPropertyChanged("TENDV");
					this.OnTENDVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DONGIA", DbType="Int")]
		public System.Nullable<int> DONGIA
		{
			get
			{
				return this._DONGIA;
			}
			set
			{
				if ((this._DONGIA != value))
				{
					this.OnDONGIAChanging(value);
					this.SendPropertyChanging();
					this._DONGIA = value;
					this.SendPropertyChanged("DONGIA");
					this.OnDONGIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DICHVU_CT_NHANPHONG", Storage="_CT_NHANPHONGs", ThisKey="MADV", OtherKey="MADV")]
		public EntitySet<CT_NHANPHONG> CT_NHANPHONGs
		{
			get
			{
				return this._CT_NHANPHONGs;
			}
			set
			{
				this._CT_NHANPHONGs.Assign(value);
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
		
		private void attach_CT_NHANPHONGs(CT_NHANPHONG entity)
		{
			this.SendPropertyChanging();
			entity.DICHVU = this;
		}
		
		private void detach_CT_NHANPHONGs(CT_NHANPHONG entity)
		{
			this.SendPropertyChanging();
			entity.DICHVU = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LOAIPHONG")]
	public partial class LOAIPHONG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MALOAIPHONG;
		
		private string _TENLOAIPHONG;
		
		private System.Nullable<int> _DONGIA;
		
		private System.Nullable<System.DateTime> _NGAYCAPNHAT;
		
		private string _NGUOICAPNHAT;
		
		private EntitySet<PHONG> _PHONGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMALOAIPHONGChanging(int value);
    partial void OnMALOAIPHONGChanged();
    partial void OnTENLOAIPHONGChanging(string value);
    partial void OnTENLOAIPHONGChanged();
    partial void OnDONGIAChanging(System.Nullable<int> value);
    partial void OnDONGIAChanged();
    partial void OnNGAYCAPNHATChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYCAPNHATChanged();
    partial void OnNGUOICAPNHATChanging(string value);
    partial void OnNGUOICAPNHATChanged();
    #endregion
		
		public LOAIPHONG()
		{
			this._PHONGs = new EntitySet<PHONG>(new Action<PHONG>(this.attach_PHONGs), new Action<PHONG>(this.detach_PHONGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MALOAIPHONG", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MALOAIPHONG
		{
			get
			{
				return this._MALOAIPHONG;
			}
			set
			{
				if ((this._MALOAIPHONG != value))
				{
					this.OnMALOAIPHONGChanging(value);
					this.SendPropertyChanging();
					this._MALOAIPHONG = value;
					this.SendPropertyChanged("MALOAIPHONG");
					this.OnMALOAIPHONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENLOAIPHONG", DbType="NVarChar(30)")]
		public string TENLOAIPHONG
		{
			get
			{
				return this._TENLOAIPHONG;
			}
			set
			{
				if ((this._TENLOAIPHONG != value))
				{
					this.OnTENLOAIPHONGChanging(value);
					this.SendPropertyChanging();
					this._TENLOAIPHONG = value;
					this.SendPropertyChanged("TENLOAIPHONG");
					this.OnTENLOAIPHONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DONGIA", DbType="Int")]
		public System.Nullable<int> DONGIA
		{
			get
			{
				return this._DONGIA;
			}
			set
			{
				if ((this._DONGIA != value))
				{
					this.OnDONGIAChanging(value);
					this.SendPropertyChanging();
					this._DONGIA = value;
					this.SendPropertyChanged("DONGIA");
					this.OnDONGIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYCAPNHAT", DbType="DateTime")]
		public System.Nullable<System.DateTime> NGAYCAPNHAT
		{
			get
			{
				return this._NGAYCAPNHAT;
			}
			set
			{
				if ((this._NGAYCAPNHAT != value))
				{
					this.OnNGAYCAPNHATChanging(value);
					this.SendPropertyChanging();
					this._NGAYCAPNHAT = value;
					this.SendPropertyChanged("NGAYCAPNHAT");
					this.OnNGAYCAPNHATChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGUOICAPNHAT", DbType="VarChar(20)")]
		public string NGUOICAPNHAT
		{
			get
			{
				return this._NGUOICAPNHAT;
			}
			set
			{
				if ((this._NGUOICAPNHAT != value))
				{
					this.OnNGUOICAPNHATChanging(value);
					this.SendPropertyChanging();
					this._NGUOICAPNHAT = value;
					this.SendPropertyChanged("NGUOICAPNHAT");
					this.OnNGUOICAPNHATChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAIPHONG_PHONG", Storage="_PHONGs", ThisKey="MALOAIPHONG", OtherKey="MALOAIPHONG")]
		public EntitySet<PHONG> PHONGs
		{
			get
			{
				return this._PHONGs;
			}
			set
			{
				this._PHONGs.Assign(value);
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
		
		private void attach_PHONGs(PHONG entity)
		{
			this.SendPropertyChanging();
			entity.LOAIPHONG = this;
		}
		
		private void detach_PHONGs(PHONG entity)
		{
			this.SendPropertyChanging();
			entity.LOAIPHONG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NHANVIEN")]
	public partial class NHANVIEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _USERNAME;
		
		private string _PASSWORD;
		
		private string _HOTENNV;
		
		private string _DIENTHOAI;
		
		private string _DIACHI;
		
		private string _QUYEN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUSERNAMEChanging(string value);
    partial void OnUSERNAMEChanged();
    partial void OnPASSWORDChanging(string value);
    partial void OnPASSWORDChanged();
    partial void OnHOTENNVChanging(string value);
    partial void OnHOTENNVChanged();
    partial void OnDIENTHOAIChanging(string value);
    partial void OnDIENTHOAIChanged();
    partial void OnDIACHIChanging(string value);
    partial void OnDIACHIChanged();
    partial void OnQUYENChanging(string value);
    partial void OnQUYENChanged();
    #endregion
		
		public NHANVIEN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USERNAME", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string USERNAME
		{
			get
			{
				return this._USERNAME;
			}
			set
			{
				if ((this._USERNAME != value))
				{
					this.OnUSERNAMEChanging(value);
					this.SendPropertyChanging();
					this._USERNAME = value;
					this.SendPropertyChanged("USERNAME");
					this.OnUSERNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PASSWORD", DbType="VarChar(20)")]
		public string PASSWORD
		{
			get
			{
				return this._PASSWORD;
			}
			set
			{
				if ((this._PASSWORD != value))
				{
					this.OnPASSWORDChanging(value);
					this.SendPropertyChanging();
					this._PASSWORD = value;
					this.SendPropertyChanged("PASSWORD");
					this.OnPASSWORDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOTENNV", DbType="NVarChar(50)")]
		public string HOTENNV
		{
			get
			{
				return this._HOTENNV;
			}
			set
			{
				if ((this._HOTENNV != value))
				{
					this.OnHOTENNVChanging(value);
					this.SendPropertyChanging();
					this._HOTENNV = value;
					this.SendPropertyChanged("HOTENNV");
					this.OnHOTENNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIENTHOAI", DbType="Char(11)")]
		public string DIENTHOAI
		{
			get
			{
				return this._DIENTHOAI;
			}
			set
			{
				if ((this._DIENTHOAI != value))
				{
					this.OnDIENTHOAIChanging(value);
					this.SendPropertyChanging();
					this._DIENTHOAI = value;
					this.SendPropertyChanged("DIENTHOAI");
					this.OnDIENTHOAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIACHI", DbType="NVarChar(30)")]
		public string DIACHI
		{
			get
			{
				return this._DIACHI;
			}
			set
			{
				if ((this._DIACHI != value))
				{
					this.OnDIACHIChanging(value);
					this.SendPropertyChanging();
					this._DIACHI = value;
					this.SendPropertyChanged("DIACHI");
					this.OnDIACHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QUYEN", DbType="VarChar(10)")]
		public string QUYEN
		{
			get
			{
				return this._QUYEN;
			}
			set
			{
				if ((this._QUYEN != value))
				{
					this.OnQUYENChanging(value);
					this.SendPropertyChanging();
					this._QUYEN = value;
					this.SendPropertyChanged("QUYEN");
					this.OnQUYENChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHACHHANG")]
	public partial class KHACHHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MAKH;
		
		private string _TENKH;
		
		private string _CMND;
		
		private string _GIOITINH;
		
		private string _DTHOAI;
		
		private string _DCHI;
		
		private EntitySet<CT_NHANPHONG> _CT_NHANPHONGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAKHChanging(string value);
    partial void OnMAKHChanged();
    partial void OnTENKHChanging(string value);
    partial void OnTENKHChanged();
    partial void OnCMNDChanging(string value);
    partial void OnCMNDChanged();
    partial void OnGIOITINHChanging(string value);
    partial void OnGIOITINHChanged();
    partial void OnDTHOAIChanging(string value);
    partial void OnDTHOAIChanged();
    partial void OnDCHIChanging(string value);
    partial void OnDCHIChanged();
    #endregion
		
		public KHACHHANG()
		{
			this._CT_NHANPHONGs = new EntitySet<CT_NHANPHONG>(new Action<CT_NHANPHONG>(this.attach_CT_NHANPHONGs), new Action<CT_NHANPHONG>(this.detach_CT_NHANPHONGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAKH", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MAKH
		{
			get
			{
				return this._MAKH;
			}
			set
			{
				if ((this._MAKH != value))
				{
					this.OnMAKHChanging(value);
					this.SendPropertyChanging();
					this._MAKH = value;
					this.SendPropertyChanged("MAKH");
					this.OnMAKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENKH", DbType="NVarChar(50)")]
		public string TENKH
		{
			get
			{
				return this._TENKH;
			}
			set
			{
				if ((this._TENKH != value))
				{
					this.OnTENKHChanging(value);
					this.SendPropertyChanging();
					this._TENKH = value;
					this.SendPropertyChanged("TENKH");
					this.OnTENKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CMND", DbType="Char(14)")]
		public string CMND
		{
			get
			{
				return this._CMND;
			}
			set
			{
				if ((this._CMND != value))
				{
					this.OnCMNDChanging(value);
					this.SendPropertyChanging();
					this._CMND = value;
					this.SendPropertyChanged("CMND");
					this.OnCMNDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GIOITINH", DbType="NVarChar(6)")]
		public string GIOITINH
		{
			get
			{
				return this._GIOITINH;
			}
			set
			{
				if ((this._GIOITINH != value))
				{
					this.OnGIOITINHChanging(value);
					this.SendPropertyChanging();
					this._GIOITINH = value;
					this.SendPropertyChanged("GIOITINH");
					this.OnGIOITINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DTHOAI", DbType="Char(10)")]
		public string DTHOAI
		{
			get
			{
				return this._DTHOAI;
			}
			set
			{
				if ((this._DTHOAI != value))
				{
					this.OnDTHOAIChanging(value);
					this.SendPropertyChanging();
					this._DTHOAI = value;
					this.SendPropertyChanged("DTHOAI");
					this.OnDTHOAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DCHI", DbType="NVarChar(50)")]
		public string DCHI
		{
			get
			{
				return this._DCHI;
			}
			set
			{
				if ((this._DCHI != value))
				{
					this.OnDCHIChanging(value);
					this.SendPropertyChanging();
					this._DCHI = value;
					this.SendPropertyChanged("DCHI");
					this.OnDCHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_CT_NHANPHONG", Storage="_CT_NHANPHONGs", ThisKey="MAKH", OtherKey="MAKH")]
		public EntitySet<CT_NHANPHONG> CT_NHANPHONGs
		{
			get
			{
				return this._CT_NHANPHONGs;
			}
			set
			{
				this._CT_NHANPHONGs.Assign(value);
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
		
		private void attach_CT_NHANPHONGs(CT_NHANPHONG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = this;
		}
		
		private void detach_CT_NHANPHONGs(CT_NHANPHONG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CT_NHANPHONG")]
	public partial class CT_NHANPHONG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MAPN;
		
		private string _MAKH;
		
		private string _MADV;
		
		private System.Nullable<int> _SOLUONG;
		
		private System.Nullable<int> _DONGIA;
		
		private System.Nullable<System.DateTime> _NGAYVAO;
		
		private System.Nullable<System.DateTime> _NGAYDI;
		
		private EntityRef<DICHVU> _DICHVU;
		
		private EntityRef<KHACHHANG> _KHACHHANG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAPNChanging(string value);
    partial void OnMAPNChanged();
    partial void OnMAKHChanging(string value);
    partial void OnMAKHChanged();
    partial void OnMADVChanging(string value);
    partial void OnMADVChanged();
    partial void OnSOLUONGChanging(System.Nullable<int> value);
    partial void OnSOLUONGChanged();
    partial void OnDONGIAChanging(System.Nullable<int> value);
    partial void OnDONGIAChanged();
    partial void OnNGAYVAOChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYVAOChanged();
    partial void OnNGAYDIChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYDIChanged();
    #endregion
		
		public CT_NHANPHONG()
		{
			this._DICHVU = default(EntityRef<DICHVU>);
			this._KHACHHANG = default(EntityRef<KHACHHANG>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAPN", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MAPN
		{
			get
			{
				return this._MAPN;
			}
			set
			{
				if ((this._MAPN != value))
				{
					this.OnMAPNChanging(value);
					this.SendPropertyChanging();
					this._MAPN = value;
					this.SendPropertyChanged("MAPN");
					this.OnMAPNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAKH", DbType="Char(10)")]
		public string MAKH
		{
			get
			{
				return this._MAKH;
			}
			set
			{
				if ((this._MAKH != value))
				{
					if (this._KHACHHANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMAKHChanging(value);
					this.SendPropertyChanging();
					this._MAKH = value;
					this.SendPropertyChanged("MAKH");
					this.OnMAKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MADV", DbType="Char(10)")]
		public string MADV
		{
			get
			{
				return this._MADV;
			}
			set
			{
				if ((this._MADV != value))
				{
					if (this._DICHVU.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMADVChanging(value);
					this.SendPropertyChanging();
					this._MADV = value;
					this.SendPropertyChanged("MADV");
					this.OnMADVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOLUONG", DbType="Int")]
		public System.Nullable<int> SOLUONG
		{
			get
			{
				return this._SOLUONG;
			}
			set
			{
				if ((this._SOLUONG != value))
				{
					this.OnSOLUONGChanging(value);
					this.SendPropertyChanging();
					this._SOLUONG = value;
					this.SendPropertyChanged("SOLUONG");
					this.OnSOLUONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DONGIA", DbType="Int")]
		public System.Nullable<int> DONGIA
		{
			get
			{
				return this._DONGIA;
			}
			set
			{
				if ((this._DONGIA != value))
				{
					this.OnDONGIAChanging(value);
					this.SendPropertyChanging();
					this._DONGIA = value;
					this.SendPropertyChanged("DONGIA");
					this.OnDONGIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYVAO", DbType="DateTime")]
		public System.Nullable<System.DateTime> NGAYVAO
		{
			get
			{
				return this._NGAYVAO;
			}
			set
			{
				if ((this._NGAYVAO != value))
				{
					this.OnNGAYVAOChanging(value);
					this.SendPropertyChanging();
					this._NGAYVAO = value;
					this.SendPropertyChanged("NGAYVAO");
					this.OnNGAYVAOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYDI", DbType="DateTime")]
		public System.Nullable<System.DateTime> NGAYDI
		{
			get
			{
				return this._NGAYDI;
			}
			set
			{
				if ((this._NGAYDI != value))
				{
					this.OnNGAYDIChanging(value);
					this.SendPropertyChanging();
					this._NGAYDI = value;
					this.SendPropertyChanged("NGAYDI");
					this.OnNGAYDIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DICHVU_CT_NHANPHONG", Storage="_DICHVU", ThisKey="MADV", OtherKey="MADV", IsForeignKey=true)]
		public DICHVU DICHVU
		{
			get
			{
				return this._DICHVU.Entity;
			}
			set
			{
				DICHVU previousValue = this._DICHVU.Entity;
				if (((previousValue != value) 
							|| (this._DICHVU.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DICHVU.Entity = null;
						previousValue.CT_NHANPHONGs.Remove(this);
					}
					this._DICHVU.Entity = value;
					if ((value != null))
					{
						value.CT_NHANPHONGs.Add(this);
						this._MADV = value.MADV;
					}
					else
					{
						this._MADV = default(string);
					}
					this.SendPropertyChanged("DICHVU");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_CT_NHANPHONG", Storage="_KHACHHANG", ThisKey="MAKH", OtherKey="MAKH", IsForeignKey=true)]
		public KHACHHANG KHACHHANG
		{
			get
			{
				return this._KHACHHANG.Entity;
			}
			set
			{
				KHACHHANG previousValue = this._KHACHHANG.Entity;
				if (((previousValue != value) 
							|| (this._KHACHHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KHACHHANG.Entity = null;
						previousValue.CT_NHANPHONGs.Remove(this);
					}
					this._KHACHHANG.Entity = value;
					if ((value != null))
					{
						value.CT_NHANPHONGs.Add(this);
						this._MAKH = value.MAKH;
					}
					else
					{
						this._MAKH = default(string);
					}
					this.SendPropertyChanged("KHACHHANG");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HoaDon")]
	public partial class HoaDon
	{
		
		private string _MAHD;
		
		private string _MAPN;
		
		private string _TENKH;
		
		private System.Nullable<int> _TONGTIEN;
		
		public HoaDon()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAHD", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string MAHD
		{
			get
			{
				return this._MAHD;
			}
			set
			{
				if ((this._MAHD != value))
				{
					this._MAHD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAPN", DbType="Char(10)")]
		public string MAPN
		{
			get
			{
				return this._MAPN;
			}
			set
			{
				if ((this._MAPN != value))
				{
					this._MAPN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENKH", DbType="NVarChar(50)")]
		public string TENKH
		{
			get
			{
				return this._TENKH;
			}
			set
			{
				if ((this._TENKH != value))
				{
					this._TENKH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TONGTIEN", DbType="Int")]
		public System.Nullable<int> TONGTIEN
		{
			get
			{
				return this._TONGTIEN;
			}
			set
			{
				if ((this._TONGTIEN != value))
				{
					this._TONGTIEN = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
