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

namespace WCF.Employees.Service
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Runtime.Serialization;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WCF")]
	public partial class MvcDbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertSalaryHistory(SalaryHistory instance);
    partial void UpdateSalaryHistory(SalaryHistory instance);
    partial void DeleteSalaryHistory(SalaryHistory instance);
    #endregion
		
		public MvcDbDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["WCFConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MvcDbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MvcDbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MvcDbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MvcDbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<SalaryHistory> SalaryHistories
		{
			get
			{
				return this.GetTable<SalaryHistory>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="WCF.T_Employees")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EmpId;
		
		private string _FirstName;
		
		private string _LastName;
		
		private decimal _Salary;
		
		private EntitySet<SalaryHistory> _SalaryHistories;
		
		private bool serializing;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmpIdChanging(int value);
    partial void OnEmpIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnSalaryChanging(decimal value);
    partial void OnSalaryChanged();
    #endregion
		
		public Employee()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int EmpId
		{
			get
			{
				return this._EmpId;
			}
			set
			{
				if ((this._EmpId != value))
				{
					this.OnEmpIdChanging(value);
					this.SendPropertyChanging();
					this._EmpId = value;
					this.SendPropertyChanged("EmpId");
					this.OnEmpIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Decimal(18,0) NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public decimal Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_T_Salary_History", Storage="_SalaryHistories", ThisKey="EmpId", OtherKey="EmpId")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5, EmitDefaultValue=false)]
		public EntitySet<SalaryHistory> SalaryHistories
		{
			get
			{
				if ((this.serializing 
							&& (this._SalaryHistories.HasLoadedOrAssignedValues == false)))
				{
					return null;
				}
				return this._SalaryHistories;
			}
			set
			{
				this._SalaryHistories.Assign(value);
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
		
		private void attach_SalaryHistories(SalaryHistory entity)
		{
			this.SendPropertyChanging();
			entity.Employee = this;
		}
		
		private void detach_SalaryHistories(SalaryHistory entity)
		{
			this.SendPropertyChanging();
			entity.Employee = null;
		}
		
		private void Initialize()
		{
			this._SalaryHistories = new EntitySet<SalaryHistory>(new Action<SalaryHistory>(this.attach_SalaryHistories), new Action<SalaryHistory>(this.detach_SalaryHistories));
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
		
		[global::System.Runtime.Serialization.OnSerializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerializing(StreamingContext context)
		{
			this.serializing = true;
		}
		
		[global::System.Runtime.Serialization.OnSerializedAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerialized(StreamingContext context)
		{
			this.serializing = false;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="WCF.T_Salary_History")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class SalaryHistory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EmpId;
		
		private int _Seq;
		
		private System.DateTime _StartDate;
		
		private System.DateTime _EndDate;
		
		private decimal _Salary;
		
		private EntityRef<Employee> _Employee;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmpIdChanging(int value);
    partial void OnEmpIdChanged();
    partial void OnSeqChanging(int value);
    partial void OnSeqChanged();
    partial void OnStartDateChanging(System.DateTime value);
    partial void OnStartDateChanged();
    partial void OnEndDateChanging(System.DateTime value);
    partial void OnEndDateChanged();
    partial void OnSalaryChanging(decimal value);
    partial void OnSalaryChanged();
    #endregion
		
		public SalaryHistory()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int EmpId
		{
			get
			{
				return this._EmpId;
			}
			set
			{
				if ((this._EmpId != value))
				{
					if (this._Employee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEmpIdChanging(value);
					this.SendPropertyChanging();
					this._EmpId = value;
					this.SendPropertyChanged("EmpId");
					this.OnEmpIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Seq", DbType="Int NOT NULL", IsPrimaryKey=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public int Seq
		{
			get
			{
				return this._Seq;
			}
			set
			{
				if ((this._Seq != value))
				{
					this.OnSeqChanging(value);
					this.SendPropertyChanging();
					this._Seq = value;
					this.SendPropertyChanged("Seq");
					this.OnSeqChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartDate", DbType="Date NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public System.DateTime StartDate
		{
			get
			{
				return this._StartDate;
			}
			set
			{
				if ((this._StartDate != value))
				{
					this.OnStartDateChanging(value);
					this.SendPropertyChanging();
					this._StartDate = value;
					this.SendPropertyChanged("StartDate");
					this.OnStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndDate", DbType="Date NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public System.DateTime EndDate
		{
			get
			{
				return this._EndDate;
			}
			set
			{
				if ((this._EndDate != value))
				{
					this.OnEndDateChanging(value);
					this.SendPropertyChanging();
					this._EndDate = value;
					this.SendPropertyChanged("EndDate");
					this.OnEndDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Decimal(18,0) NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public decimal Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_T_Salary_History", Storage="_Employee", ThisKey="EmpId", OtherKey="EmpId", IsForeignKey=true)]
		public Employee Employee
		{
			get
			{
				return this._Employee.Entity;
			}
			set
			{
				Employee previousValue = this._Employee.Entity;
				if (((previousValue != value) 
							|| (this._Employee.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Employee.Entity = null;
						previousValue.SalaryHistories.Remove(this);
					}
					this._Employee.Entity = value;
					if ((value != null))
					{
						value.SalaryHistories.Add(this);
						this._EmpId = value.EmpId;
					}
					else
					{
						this._EmpId = default(int);
					}
					this.SendPropertyChanged("Employee");
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
		
		private void Initialize()
		{
			this._Employee = default(EntityRef<Employee>);
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
	}
}
#pragma warning restore 1591
