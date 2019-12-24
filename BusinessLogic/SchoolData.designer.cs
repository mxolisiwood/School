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

namespace BusinessLogic
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SchoolSystem")]
	public partial class SchoolDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertregistration_t(registration_t instance);
    partial void Updateregistration_t(registration_t instance);
    partial void Deleteregistration_t(registration_t instance);
    partial void Insertstudent_t(student_t instance);
    partial void Updatestudent_t(student_t instance);
    partial void Deletestudent_t(student_t instance);
    partial void Insertsubject_t(subject_t instance);
    partial void Updatesubject_t(subject_t instance);
    partial void Deletesubject_t(subject_t instance);
    #endregion
		
		public SchoolDataDataContext() : 
				base(global::BusinessLogic.Properties.Settings.Default.SchoolSystemConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SchoolDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SchoolDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SchoolDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SchoolDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<registration_t> registration_ts
		{
			get
			{
				return this.GetTable<registration_t>();
			}
		}
		
		public System.Data.Linq.Table<student_t> student_ts
		{
			get
			{
				return this.GetTable<student_t>();
			}
		}
		
		public System.Data.Linq.Table<subject_t> subject_ts
		{
			get
			{
				return this.GetTable<subject_t>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.registration_t")]
	public partial class registration_t : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _registrationID;
		
		private int _studentID;
		
		private int _subjectID;
		
		private string _grade;
		
		private string _status;
		
		private System.DateTime _date;
		
		private EntityRef<student_t> _student_t;
		
		private EntityRef<subject_t> _subject_t;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnregistrationIDChanging(int value);
    partial void OnregistrationIDChanged();
    partial void OnstudentIDChanging(int value);
    partial void OnstudentIDChanged();
    partial void OnsubjectIDChanging(int value);
    partial void OnsubjectIDChanged();
    partial void OngradeChanging(string value);
    partial void OngradeChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    partial void OndateChanging(System.DateTime value);
    partial void OndateChanged();
    #endregion
		
		public registration_t()
		{
			this._student_t = default(EntityRef<student_t>);
			this._subject_t = default(EntityRef<subject_t>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_registrationID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int registrationID
		{
			get
			{
				return this._registrationID;
			}
			set
			{
				if ((this._registrationID != value))
				{
					this.OnregistrationIDChanging(value);
					this.SendPropertyChanging();
					this._registrationID = value;
					this.SendPropertyChanged("registrationID");
					this.OnregistrationIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_studentID", DbType="Int NOT NULL")]
		public int studentID
		{
			get
			{
				return this._studentID;
			}
			set
			{
				if ((this._studentID != value))
				{
					if (this._student_t.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnstudentIDChanging(value);
					this.SendPropertyChanging();
					this._studentID = value;
					this.SendPropertyChanged("studentID");
					this.OnstudentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subjectID", DbType="Int NOT NULL")]
		public int subjectID
		{
			get
			{
				return this._subjectID;
			}
			set
			{
				if ((this._subjectID != value))
				{
					if (this._subject_t.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnsubjectIDChanging(value);
					this.SendPropertyChanging();
					this._subjectID = value;
					this.SendPropertyChanged("subjectID");
					this.OnsubjectIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grade", DbType="VarChar(2)")]
		public string grade
		{
			get
			{
				return this._grade;
			}
			set
			{
				if ((this._grade != value))
				{
					this.OngradeChanging(value);
					this.SendPropertyChanging();
					this._grade = value;
					this.SendPropertyChanged("grade");
					this.OngradeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="VarChar(1) NOT NULL", CanBeNull=false)]
		public string status
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="DateTime NOT NULL")]
		public System.DateTime date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="student_t_registration_t", Storage="_student_t", ThisKey="studentID", OtherKey="studentID", IsForeignKey=true)]
		public student_t student_t
		{
			get
			{
				return this._student_t.Entity;
			}
			set
			{
				student_t previousValue = this._student_t.Entity;
				if (((previousValue != value) 
							|| (this._student_t.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._student_t.Entity = null;
						previousValue.registration_ts.Remove(this);
					}
					this._student_t.Entity = value;
					if ((value != null))
					{
						value.registration_ts.Add(this);
						this._studentID = value.studentID;
					}
					else
					{
						this._studentID = default(int);
					}
					this.SendPropertyChanged("student_t");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="subject_t_registration_t", Storage="_subject_t", ThisKey="subjectID", OtherKey="subjectID", IsForeignKey=true)]
		public subject_t subject_t
		{
			get
			{
				return this._subject_t.Entity;
			}
			set
			{
				subject_t previousValue = this._subject_t.Entity;
				if (((previousValue != value) 
							|| (this._subject_t.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._subject_t.Entity = null;
						previousValue.registration_ts.Remove(this);
					}
					this._subject_t.Entity = value;
					if ((value != null))
					{
						value.registration_ts.Add(this);
						this._subjectID = value.subjectID;
					}
					else
					{
						this._subjectID = default(int);
					}
					this.SendPropertyChanged("subject_t");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.student_t")]
	public partial class student_t : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _studentID;
		
		private string _first_name;
		
		private string _last_name;
		
		private string _gender;
		
		private System.Nullable<double> _gpa;
		
		private EntitySet<registration_t> _registration_ts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnstudentIDChanging(int value);
    partial void OnstudentIDChanged();
    partial void Onfirst_nameChanging(string value);
    partial void Onfirst_nameChanged();
    partial void Onlast_nameChanging(string value);
    partial void Onlast_nameChanged();
    partial void OngenderChanging(string value);
    partial void OngenderChanged();
    partial void OngpaChanging(System.Nullable<double> value);
    partial void OngpaChanged();
    #endregion
		
		public student_t()
		{
			this._registration_ts = new EntitySet<registration_t>(new Action<registration_t>(this.attach_registration_ts), new Action<registration_t>(this.detach_registration_ts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_studentID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int studentID
		{
			get
			{
				return this._studentID;
			}
			set
			{
				if ((this._studentID != value))
				{
					this.OnstudentIDChanging(value);
					this.SendPropertyChanging();
					this._studentID = value;
					this.SendPropertyChanged("studentID");
					this.OnstudentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_first_name", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string first_name
		{
			get
			{
				return this._first_name;
			}
			set
			{
				if ((this._first_name != value))
				{
					this.Onfirst_nameChanging(value);
					this.SendPropertyChanging();
					this._first_name = value;
					this.SendPropertyChanged("first_name");
					this.Onfirst_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_last_name", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string last_name
		{
			get
			{
				return this._last_name;
			}
			set
			{
				if ((this._last_name != value))
				{
					this.Onlast_nameChanging(value);
					this.SendPropertyChanging();
					this._last_name = value;
					this.SendPropertyChanged("last_name");
					this.Onlast_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="VarChar(1) NOT NULL", CanBeNull=false)]
		public string gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this.OngenderChanging(value);
					this.SendPropertyChanging();
					this._gender = value;
					this.SendPropertyChanged("gender");
					this.OngenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gpa", DbType="Float")]
		public System.Nullable<double> gpa
		{
			get
			{
				return this._gpa;
			}
			set
			{
				if ((this._gpa != value))
				{
					this.OngpaChanging(value);
					this.SendPropertyChanging();
					this._gpa = value;
					this.SendPropertyChanged("gpa");
					this.OngpaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="student_t_registration_t", Storage="_registration_ts", ThisKey="studentID", OtherKey="studentID")]
		public EntitySet<registration_t> registration_ts
		{
			get
			{
				return this._registration_ts;
			}
			set
			{
				this._registration_ts.Assign(value);
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
		
		private void attach_registration_ts(registration_t entity)
		{
			this.SendPropertyChanging();
			entity.student_t = this;
		}
		
		private void detach_registration_ts(registration_t entity)
		{
			this.SendPropertyChanging();
			entity.student_t = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.subject_t")]
	public partial class subject_t : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _subjectID;
		
		private string _subject_name;
		
		private string _subject_desctiption;
		
		private int _subject_credits;
		
		private EntitySet<registration_t> _registration_ts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnsubjectIDChanging(int value);
    partial void OnsubjectIDChanged();
    partial void Onsubject_nameChanging(string value);
    partial void Onsubject_nameChanged();
    partial void Onsubject_desctiptionChanging(string value);
    partial void Onsubject_desctiptionChanged();
    partial void Onsubject_creditsChanging(int value);
    partial void Onsubject_creditsChanged();
    #endregion
		
		public subject_t()
		{
			this._registration_ts = new EntitySet<registration_t>(new Action<registration_t>(this.attach_registration_ts), new Action<registration_t>(this.detach_registration_ts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subjectID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int subjectID
		{
			get
			{
				return this._subjectID;
			}
			set
			{
				if ((this._subjectID != value))
				{
					this.OnsubjectIDChanging(value);
					this.SendPropertyChanging();
					this._subjectID = value;
					this.SendPropertyChanged("subjectID");
					this.OnsubjectIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subject_name", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string subject_name
		{
			get
			{
				return this._subject_name;
			}
			set
			{
				if ((this._subject_name != value))
				{
					this.Onsubject_nameChanging(value);
					this.SendPropertyChanging();
					this._subject_name = value;
					this.SendPropertyChanged("subject_name");
					this.Onsubject_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subject_desctiption", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string subject_desctiption
		{
			get
			{
				return this._subject_desctiption;
			}
			set
			{
				if ((this._subject_desctiption != value))
				{
					this.Onsubject_desctiptionChanging(value);
					this.SendPropertyChanging();
					this._subject_desctiption = value;
					this.SendPropertyChanged("subject_desctiption");
					this.Onsubject_desctiptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subject_credits", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int subject_credits
		{
			get
			{
				return this._subject_credits;
			}
			set
			{
				if ((this._subject_credits != value))
				{
					this.Onsubject_creditsChanging(value);
					this.SendPropertyChanging();
					this._subject_credits = value;
					this.SendPropertyChanged("subject_credits");
					this.Onsubject_creditsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="subject_t_registration_t", Storage="_registration_ts", ThisKey="subjectID", OtherKey="subjectID")]
		public EntitySet<registration_t> registration_ts
		{
			get
			{
				return this._registration_ts;
			}
			set
			{
				this._registration_ts.Assign(value);
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
		
		private void attach_registration_ts(registration_t entity)
		{
			this.SendPropertyChanging();
			entity.subject_t = this;
		}
		
		private void detach_registration_ts(registration_t entity)
		{
			this.SendPropertyChanging();
			entity.subject_t = null;
		}
	}
}
#pragma warning restore 1591