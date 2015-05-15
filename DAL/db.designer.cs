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

namespace DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ProgramFile")]
	public partial class dbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMsCD(MsCD instance);
    partial void UpdateMsCD(MsCD instance);
    partial void DeleteMsCD(MsCD instance);
    partial void InsertTopLink(TopLink instance);
    partial void UpdateTopLink(TopLink instance);
    partial void DeleteTopLink(TopLink instance);
    partial void InsertMsCustomer(MsCustomer instance);
    partial void UpdateMsCustomer(MsCustomer instance);
    partial void DeleteMsCustomer(MsCustomer instance);
    partial void InsertMsPenjualan(MsPenjualan instance);
    partial void UpdateMsPenjualan(MsPenjualan instance);
    partial void DeleteMsPenjualan(MsPenjualan instance);
    partial void InsertMsProgram(MsProgram instance);
    partial void UpdateMsProgram(MsProgram instance);
    partial void DeleteMsProgram(MsProgram instance);
    #endregion
		
		public dbDataContext() : 
				base(global::DAL.Properties.Settings.Default.ProgramFileConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<MsCD> MsCDs
		{
			get
			{
				return this.GetTable<MsCD>();
			}
		}
		
		public System.Data.Linq.Table<TopLink> TopLinks
		{
			get
			{
				return this.GetTable<TopLink>();
			}
		}
		
		public System.Data.Linq.Table<MsCustomer> MsCustomers
		{
			get
			{
				return this.GetTable<MsCustomer>();
			}
		}
		
		public System.Data.Linq.Table<MsPenjualan> MsPenjualans
		{
			get
			{
				return this.GetTable<MsPenjualan>();
			}
		}
		
		public System.Data.Linq.Table<MsProgram> MsPrograms
		{
			get
			{
				return this.GetTable<MsProgram>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MsCD")]
	public partial class MsCD : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _idCD;
		
		private char _status;
		
		private int _ukuran;
		
		private int _biaya;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidCDChanging(string value);
    partial void OnidCDChanged();
    partial void OnstatusChanging(char value);
    partial void OnstatusChanged();
    partial void OnukuranChanging(int value);
    partial void OnukuranChanged();
    partial void OnbiayaChanging(int value);
    partial void OnbiayaChanged();
    #endregion
		
		public MsCD()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCD", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string idCD
		{
			get
			{
				return this._idCD;
			}
			set
			{
				if ((this._idCD != value))
				{
					this.OnidCDChanging(value);
					this.SendPropertyChanging();
					this._idCD = value;
					this.SendPropertyChanged("idCD");
					this.OnidCDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Char(1) NOT NULL")]
		public char status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ukuran", DbType="Int NOT NULL")]
		public int ukuran
		{
			get
			{
				return this._ukuran;
			}
			set
			{
				if ((this._ukuran != value))
				{
					this.OnukuranChanging(value);
					this.SendPropertyChanging();
					this._ukuran = value;
					this.SendPropertyChanged("ukuran");
					this.OnukuranChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_biaya", DbType="Int NOT NULL")]
		public int biaya
		{
			get
			{
				return this._biaya;
			}
			set
			{
				if ((this._biaya != value))
				{
					this.OnbiayaChanging(value);
					this.SendPropertyChanging();
					this._biaya = value;
					this.SendPropertyChanged("biaya");
					this.OnbiayaChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TopLink")]
	public partial class TopLink : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idLink;
		
		private string _name;
		
		private string _links;
		
		private int _status;
		
		private System.Nullable<int> _level;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidLinkChanging(int value);
    partial void OnidLinkChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnlinksChanging(string value);
    partial void OnlinksChanged();
    partial void OnstatusChanging(int value);
    partial void OnstatusChanged();
    partial void OnlevelChanging(System.Nullable<int> value);
    partial void OnlevelChanged();
    #endregion
		
		public TopLink()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idLink", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idLink
		{
			get
			{
				return this._idLink;
			}
			set
			{
				if ((this._idLink != value))
				{
					this.OnidLinkChanging(value);
					this.SendPropertyChanging();
					this._idLink = value;
					this.SendPropertyChanged("idLink");
					this.OnidLinkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_links", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string links
		{
			get
			{
				return this._links;
			}
			set
			{
				if ((this._links != value))
				{
					this.OnlinksChanging(value);
					this.SendPropertyChanging();
					this._links = value;
					this.SendPropertyChanged("links");
					this.OnlinksChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Int NOT NULL")]
		public int status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[level]", Storage="_level", DbType="Int")]
		public System.Nullable<int> level
		{
			get
			{
				return this._level;
			}
			set
			{
				if ((this._level != value))
				{
					this.OnlevelChanging(value);
					this.SendPropertyChanging();
					this._level = value;
					this.SendPropertyChanged("level");
					this.OnlevelChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MsCustomer")]
	public partial class MsCustomer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _idCustomer;
		
		private string _nama;
		
		private string _alamat;
		
		private string _username;
		
		private string _pwd;
		
		private string _kodepos;
		
		private string _email;
		
		private string _telp;
		
		private string _provinsi;
		
		private string _kota;
		
		private string _img;
		
		private int _lvl;
		
		private EntitySet<MsPenjualan> _MsPenjualans;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidCustomerChanging(string value);
    partial void OnidCustomerChanged();
    partial void OnnamaChanging(string value);
    partial void OnnamaChanged();
    partial void OnalamatChanging(string value);
    partial void OnalamatChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpwdChanging(string value);
    partial void OnpwdChanged();
    partial void OnkodeposChanging(string value);
    partial void OnkodeposChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OntelpChanging(string value);
    partial void OntelpChanged();
    partial void OnprovinsiChanging(string value);
    partial void OnprovinsiChanged();
    partial void OnkotaChanging(string value);
    partial void OnkotaChanged();
    partial void OnimgChanging(string value);
    partial void OnimgChanged();
    partial void OnlvlChanging(int value);
    partial void OnlvlChanged();
    #endregion
		
		public MsCustomer()
		{
			this._MsPenjualans = new EntitySet<MsPenjualan>(new Action<MsPenjualan>(this.attach_MsPenjualans), new Action<MsPenjualan>(this.detach_MsPenjualans));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCustomer", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string idCustomer
		{
			get
			{
				return this._idCustomer;
			}
			set
			{
				if ((this._idCustomer != value))
				{
					this.OnidCustomerChanging(value);
					this.SendPropertyChanging();
					this._idCustomer = value;
					this.SendPropertyChanged("idCustomer");
					this.OnidCustomerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nama", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string nama
		{
			get
			{
				return this._nama;
			}
			set
			{
				if ((this._nama != value))
				{
					this.OnnamaChanging(value);
					this.SendPropertyChanging();
					this._nama = value;
					this.SendPropertyChanged("nama");
					this.OnnamaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_alamat", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string alamat
		{
			get
			{
				return this._alamat;
			}
			set
			{
				if ((this._alamat != value))
				{
					this.OnalamatChanging(value);
					this.SendPropertyChanging();
					this._alamat = value;
					this.SendPropertyChanged("alamat");
					this.OnalamatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pwd", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string pwd
		{
			get
			{
				return this._pwd;
			}
			set
			{
				if ((this._pwd != value))
				{
					this.OnpwdChanging(value);
					this.SendPropertyChanging();
					this._pwd = value;
					this.SendPropertyChanged("pwd");
					this.OnpwdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kodepos", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string kodepos
		{
			get
			{
				return this._kodepos;
			}
			set
			{
				if ((this._kodepos != value))
				{
					this.OnkodeposChanging(value);
					this.SendPropertyChanging();
					this._kodepos = value;
					this.SendPropertyChanged("kodepos");
					this.OnkodeposChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telp", DbType="VarChar(12) NOT NULL", CanBeNull=false)]
		public string telp
		{
			get
			{
				return this._telp;
			}
			set
			{
				if ((this._telp != value))
				{
					this.OntelpChanging(value);
					this.SendPropertyChanging();
					this._telp = value;
					this.SendPropertyChanged("telp");
					this.OntelpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_provinsi", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string provinsi
		{
			get
			{
				return this._provinsi;
			}
			set
			{
				if ((this._provinsi != value))
				{
					this.OnprovinsiChanging(value);
					this.SendPropertyChanging();
					this._provinsi = value;
					this.SendPropertyChanged("provinsi");
					this.OnprovinsiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kota", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string kota
		{
			get
			{
				return this._kota;
			}
			set
			{
				if ((this._kota != value))
				{
					this.OnkotaChanging(value);
					this.SendPropertyChanging();
					this._kota = value;
					this.SendPropertyChanged("kota");
					this.OnkotaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_img", DbType="VarChar(MAX)")]
		public string img
		{
			get
			{
				return this._img;
			}
			set
			{
				if ((this._img != value))
				{
					this.OnimgChanging(value);
					this.SendPropertyChanging();
					this._img = value;
					this.SendPropertyChanged("img");
					this.OnimgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lvl", DbType="Int NOT NULL")]
		public int lvl
		{
			get
			{
				return this._lvl;
			}
			set
			{
				if ((this._lvl != value))
				{
					this.OnlvlChanging(value);
					this.SendPropertyChanging();
					this._lvl = value;
					this.SendPropertyChanged("lvl");
					this.OnlvlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MsCustomer_MsPenjualan", Storage="_MsPenjualans", ThisKey="idCustomer", OtherKey="idCustomer")]
		public EntitySet<MsPenjualan> MsPenjualans
		{
			get
			{
				return this._MsPenjualans;
			}
			set
			{
				this._MsPenjualans.Assign(value);
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
		
		private void attach_MsPenjualans(MsPenjualan entity)
		{
			this.SendPropertyChanging();
			entity.MsCustomer = this;
		}
		
		private void detach_MsPenjualans(MsPenjualan entity)
		{
			this.SendPropertyChanging();
			entity.MsCustomer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MsPenjualan")]
	public partial class MsPenjualan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _idPenjualan;
		
		private string _idCustomer;
		
		private System.DateTime _tglTrans;
		
		private string _detail;
		
		private EntityRef<MsCustomer> _MsCustomer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidPenjualanChanging(string value);
    partial void OnidPenjualanChanged();
    partial void OnidCustomerChanging(string value);
    partial void OnidCustomerChanged();
    partial void OntglTransChanging(System.DateTime value);
    partial void OntglTransChanged();
    partial void OndetailChanging(string value);
    partial void OndetailChanged();
    #endregion
		
		public MsPenjualan()
		{
			this._MsCustomer = default(EntityRef<MsCustomer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idPenjualan", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string idPenjualan
		{
			get
			{
				return this._idPenjualan;
			}
			set
			{
				if ((this._idPenjualan != value))
				{
					this.OnidPenjualanChanging(value);
					this.SendPropertyChanging();
					this._idPenjualan = value;
					this.SendPropertyChanged("idPenjualan");
					this.OnidPenjualanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCustomer", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string idCustomer
		{
			get
			{
				return this._idCustomer;
			}
			set
			{
				if ((this._idCustomer != value))
				{
					if (this._MsCustomer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidCustomerChanging(value);
					this.SendPropertyChanging();
					this._idCustomer = value;
					this.SendPropertyChanged("idCustomer");
					this.OnidCustomerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tglTrans", DbType="DateTime NOT NULL")]
		public System.DateTime tglTrans
		{
			get
			{
				return this._tglTrans;
			}
			set
			{
				if ((this._tglTrans != value))
				{
					this.OntglTransChanging(value);
					this.SendPropertyChanging();
					this._tglTrans = value;
					this.SendPropertyChanged("tglTrans");
					this.OntglTransChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_detail", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string detail
		{
			get
			{
				return this._detail;
			}
			set
			{
				if ((this._detail != value))
				{
					this.OndetailChanging(value);
					this.SendPropertyChanging();
					this._detail = value;
					this.SendPropertyChanged("detail");
					this.OndetailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MsCustomer_MsPenjualan", Storage="_MsCustomer", ThisKey="idCustomer", OtherKey="idCustomer", IsForeignKey=true)]
		public MsCustomer MsCustomer
		{
			get
			{
				return this._MsCustomer.Entity;
			}
			set
			{
				MsCustomer previousValue = this._MsCustomer.Entity;
				if (((previousValue != value) 
							|| (this._MsCustomer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._MsCustomer.Entity = null;
						previousValue.MsPenjualans.Remove(this);
					}
					this._MsCustomer.Entity = value;
					if ((value != null))
					{
						value.MsPenjualans.Add(this);
						this._idCustomer = value.idCustomer;
					}
					else
					{
						this._idCustomer = default(string);
					}
					this.SendPropertyChanged("MsCustomer");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MsProgram")]
	public partial class MsProgram : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _idProgram;
		
		private string _title;
		
		private string _descr;
		
		private int _size;
		
		private System.Nullable<int> _rating;
		
		private string _img;
		
		private string _technology;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidProgramChanging(string value);
    partial void OnidProgramChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OndescrChanging(string value);
    partial void OndescrChanged();
    partial void OnsizeChanging(int value);
    partial void OnsizeChanged();
    partial void OnratingChanging(System.Nullable<int> value);
    partial void OnratingChanged();
    partial void OnimgChanging(string value);
    partial void OnimgChanged();
    partial void OntechnologyChanging(string value);
    partial void OntechnologyChanged();
    #endregion
		
		public MsProgram()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idProgram", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string idProgram
		{
			get
			{
				return this._idProgram;
			}
			set
			{
				if ((this._idProgram != value))
				{
					this.OnidProgramChanging(value);
					this.SendPropertyChanging();
					this._idProgram = value;
					this.SendPropertyChanged("idProgram");
					this.OnidProgramChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descr", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string descr
		{
			get
			{
				return this._descr;
			}
			set
			{
				if ((this._descr != value))
				{
					this.OndescrChanging(value);
					this.SendPropertyChanging();
					this._descr = value;
					this.SendPropertyChanged("descr");
					this.OndescrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_size", DbType="Int NOT NULL")]
		public int size
		{
			get
			{
				return this._size;
			}
			set
			{
				if ((this._size != value))
				{
					this.OnsizeChanging(value);
					this.SendPropertyChanging();
					this._size = value;
					this.SendPropertyChanged("size");
					this.OnsizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rating", DbType="Int")]
		public System.Nullable<int> rating
		{
			get
			{
				return this._rating;
			}
			set
			{
				if ((this._rating != value))
				{
					this.OnratingChanging(value);
					this.SendPropertyChanging();
					this._rating = value;
					this.SendPropertyChanged("rating");
					this.OnratingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_img", DbType="VarChar(MAX)")]
		public string img
		{
			get
			{
				return this._img;
			}
			set
			{
				if ((this._img != value))
				{
					this.OnimgChanging(value);
					this.SendPropertyChanging();
					this._img = value;
					this.SendPropertyChanged("img");
					this.OnimgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_technology", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string technology
		{
			get
			{
				return this._technology;
			}
			set
			{
				if ((this._technology != value))
				{
					this.OntechnologyChanging(value);
					this.SendPropertyChanging();
					this._technology = value;
					this.SendPropertyChanged("technology");
					this.OntechnologyChanged();
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
