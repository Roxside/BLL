using System;
using System.Collections.Generic;
using System.Data;

/// <summary>
/// Generated Class for Table : BLLemployee.
/// </summary>

public class BLLemployee
{
	private static BLLemployee defaultInstance = new BLLemployee();

	public static BLLemployee Default 
	{
		get { return defaultInstance; }
	}

	public BLLemployee()
	{

	}

	public List<OBJemployee> Select()
	{
		try
		{
			string query = "SELECT * FROM employee";
			DataTable dt = DAL.Default.Select(query);
			List<OBJemployee> ObjList = new List<OBJemployee>();
			foreach (DataRow dr in dt.Rows)
			{
				OBJemployee obj_OBJemployee = new OBJemployee();
				obj_OBJemployee.EID = Convert.ToInt32(dr["EID"]);
				obj_OBJemployee.EFirstName = (dr["EFirstName"]).ToString();
				obj_OBJemployee.ESurName = (dr["ESurName"]).ToString();
				obj_OBJemployee.EBirthDate = (dr["EBirthDate"]).ToString();
				obj_OBJemployee.EGender = (dr["EGender"]).ToString();
				obj_OBJemployee.EPassword = (dr["EPassword"]).ToString();
				obj_OBJemployee.ERole = String.IsNullOrEmpty((dr["ERole"]).ToString()) ? null : (int?)(dr["ERole"]);
				ObjList.Add(obj_OBJemployee);
			}
			return ObjList;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJemployee> Select(string orderby, string orderparam)
	{
		try
		{
			string query = "SELECT * FROM employee ORDER BY " + orderby + " " + orderparam;
			DataTable dt = DAL.Default.Select(query);
			List<OBJemployee> ObjList = new List<OBJemployee>();
			foreach (DataRow dr in dt.Rows)
			{
				OBJemployee obj_OBJemployee = new OBJemployee();
				obj_OBJemployee.EID = Convert.ToInt32(dr["EID"]);
				obj_OBJemployee.EFirstName = (dr["EFirstName"]).ToString();
				obj_OBJemployee.ESurName = (dr["ESurName"]).ToString();
				obj_OBJemployee.EBirthDate = (dr["EBirthDate"]).ToString();
				obj_OBJemployee.EGender = (dr["EGender"]).ToString();
				obj_OBJemployee.EPassword = (dr["EPassword"]).ToString();
				obj_OBJemployee.ERole = String.IsNullOrEmpty((dr["ERole"]).ToString()) ? null : (int?)(dr["ERole"]);
				ObjList.Add(obj_OBJemployee);
			}
			return ObjList;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public DataTable SelectasDataTable()
	{
		try
		{
			string query = "SELECT * FROM employee";
			return DAL.Default.Select(query);
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public DataTable SelectasDataTable(string orderby, string orderparam)
	{
		try
		{
			string query = "SELECT * FROM employee ORDER BY " + orderby + " " + orderparam;
			return DAL.Default.Select(query);
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public OBJemployee Select(int EID)
	{
		try
		{
			string query = "SELECT * FROM employee WHERE EID = " + EID;
			DataTable dt = DAL.Default.Select(query);
			OBJemployee obj_OBJemployee = new OBJemployee();
			DataRow dr = dt.Rows[0];
			obj_OBJemployee.EID = Convert.ToInt32(dr["EID"]);
			obj_OBJemployee.EFirstName = (dr["EFirstName"]).ToString();
			obj_OBJemployee.ESurName = (dr["ESurName"]).ToString();
			obj_OBJemployee.EBirthDate = (dr["EBirthDate"]).ToString();
			obj_OBJemployee.EGender = (dr["EGender"]).ToString();
			obj_OBJemployee.EPassword = (dr["EPassword"]).ToString();
			obj_OBJemployee.ERole = String.IsNullOrEmpty((dr["ERole"]).ToString()) ? null : (int?)(dr["ERole"]);
			return obj_OBJemployee;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJemployee> Select(string nextPart)
	{
		try
		{
			string query = "SELECT * FROM employee WHERE " + nextPart;
			DataTable dt = DAL.Default.Select(query);
			List<OBJemployee> ObjList = new List<OBJemployee>();
			foreach (DataRow dr in dt.Rows)
			{
				OBJemployee obj_OBJemployee = new OBJemployee();
				obj_OBJemployee.EID = Convert.ToInt32(dr["EID"]);
				obj_OBJemployee.EFirstName = (dr["EFirstName"]).ToString();
				obj_OBJemployee.ESurName = (dr["ESurName"]).ToString();
				obj_OBJemployee.EBirthDate = (dr["EBirthDate"]).ToString();
				obj_OBJemployee.EGender = (dr["EGender"]).ToString();
				obj_OBJemployee.EPassword = (dr["EPassword"]).ToString();
				obj_OBJemployee.ERole = String.IsNullOrEmpty((dr["ERole"]).ToString()) ? null : (int?)(dr["ERole"]);
				ObjList.Add(obj_OBJemployee);
			}
			return ObjList;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJemployee> Select(OBJemployee obj_OBJemployee)
	{
		try
		{
			if (obj_OBJemployee.IsFiltered)
			{
				string nextPart = "";
				foreach (FilteredItems filtereditems in obj_OBJemployee.FilterList)
				{
					if (filtereditems.DatabaseType.Contains("varchar"))
						nextPart += (nextPart.Length > 0 ? " AND " : " ") + filtereditems.FilterAttribute + GeneralMethods.Default.comparestringforDB(filtereditems.FilterValue);
					else if (filtereditems.DatabaseType.Contains("bit"))
						nextPart += (nextPart.Length > 0 ? " AND " : " ") + filtereditems.FilterAttribute + GeneralMethods.Default.compareboolforDB(filtereditems.FilterValue);
					else if (filtereditems.DatabaseType.Contains("int"))
						nextPart += (nextPart.Length > 0 ? " AND " : " ") + filtereditems.FilterAttribute + GeneralMethods.Default.compareintforDB(filtereditems.FilterValue);
					else if (filtereditems.DatabaseType.Contains("decimal")  || filtereditems.DatabaseType.Contains("double") || filtereditems.DatabaseType.Contains("float"))
						nextPart += (nextPart.Length > 0 ? " AND " : " ") + filtereditems.FilterAttribute + GeneralMethods.Default.comparedoubleforDB(filtereditems.FilterValue);
					else if (filtereditems.DatabaseType.Contains("timestamp"))
						nextPart += (nextPart.Length > 0 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy-MM-dd HH:mm:ss}", filtereditems.FilterValue) + "'";
					else if (filtereditems.DatabaseType.Contains("datetime"))
						nextPart += (nextPart.Length > 0 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy-MM-dd HH:mm:ss}", filtereditems.FilterValue) + "'";
					else if (filtereditems.DatabaseType.Contains("date"))
						nextPart += (nextPart.Length > 0 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy-MM-dd}", filtereditems.FilterValue) + "'";
					else if (filtereditems.DatabaseType.Contains("time"))
						nextPart += (nextPart.Length > 0 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + String.Format("{0:HH:mm:ss}", filtereditems.FilterValue) + "'";
					else if (filtereditems.DatabaseType.Contains("year"))
						nextPart += (nextPart.Length > 0 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy}", filtereditems.FilterValue) + "'";
					else
						nextPart += (nextPart.Length > 0 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + filtereditems.FilterValue.ToString() + "'";
				}
				if(string.IsNullOrEmpty(nextPart))
				{
					return this.Select();
				}
				else
				{
					return this.Select(nextPart);
				}
			}
			else throw new Exception("Filter is required.");
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJemployee> Select(OBJemployee obj_OBJemployee, string orderby, string orderparam)
	{
		try
		{
			if (obj_OBJemployee.IsFiltered)
			{
				string nextPart = "";
				foreach (FilteredItems filtereditems in obj_OBJemployee.FilterList)
				{
					if (filtereditems.DatabaseType.Contains("varchar"))
						nextPart += (nextPart.Length > 0 ? " AND " : " ") + filtereditems.FilterAttribute + GeneralMethods.Default.comparestringforDB(filtereditems.FilterValue);
					else if (filtereditems.DatabaseType.Contains("bit"))
						nextPart += (nextPart.Length > 0 ? " AND " : " ") + filtereditems.FilterAttribute + GeneralMethods.Default.compareboolforDB(filtereditems.FilterValue);
					else if (filtereditems.DatabaseType.Contains("int"))
						nextPart += (nextPart.Length > 0 ? " AND " : " ") + filtereditems.FilterAttribute + GeneralMethods.Default.compareintforDB(filtereditems.FilterValue);
					else if (filtereditems.DatabaseType.Contains("decimal")  || filtereditems.DatabaseType.Contains("double") || filtereditems.DatabaseType.Contains("float"))
						nextPart += (nextPart.Length > 0 ? " AND " : " ") + filtereditems.FilterAttribute + GeneralMethods.Default.comparedoubleforDB(filtereditems.FilterValue);
					else if (filtereditems.DatabaseType.Contains("timestamp"))
						nextPart += (nextPart.Length > 0 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy-MM-dd HH:mm:ss}", filtereditems.FilterValue) + "'";
					else if (filtereditems.DatabaseType.Contains("datetime"))
						nextPart += (nextPart.Length > 0 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy-MM-dd HH:mm:ss}", filtereditems.FilterValue) + "'";
					else if (filtereditems.DatabaseType.Contains("date"))
						nextPart += (nextPart.Length > 0 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy-MM-dd}", filtereditems.FilterValue) + "'";
					else if (filtereditems.DatabaseType.Contains("time"))
						nextPart += (nextPart.Length > 0 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + String.Format("{0:HH:mm:ss}", filtereditems.FilterValue) + "'";
					else if (filtereditems.DatabaseType.Contains("year"))
						nextPart += (nextPart.Length > 0 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy}", filtereditems.FilterValue) + "'";
					else
						nextPart += (nextPart.Length > 0 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + filtereditems.FilterValue.ToString() + "'";
				}
				if(string.IsNullOrEmpty(nextPart))
				{
					return this.Select(" ORDER BY " + orderby + " " + orderparam);
				}
				else
				{
					return this.Select(nextPart + " ORDER BY "+ orderby + " " + orderparam);
				}
			}
			else throw new Exception("Filter is required.");
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJemployee> Select(List<OBJemployee> list_obj_OBJemployee)
	{
		try
		{
			string nextPart = "";
			foreach (OBJemployee obj_OBJemployee in list_obj_OBJemployee)
			{
				if (obj_OBJemployee.IsFiltered)
				{
					nextPart += (nextPart.Length > 0 ? " OR " : "") + "(";
					foreach (FilteredItems filtereditems in obj_OBJemployee.FilterList)
					{
						if (filtereditems.DatabaseType.Contains("varchar"))
							nextPart += (nextPart.Length > 2 ? " AND " : " ") + filtereditems.FilterAttribute + GeneralMethods.Default.comparestringforDB(filtereditems.FilterValue);
						else if (filtereditems.DatabaseType.Contains("int"))
							nextPart += (nextPart.Length > 2 ? " AND " : " ") + filtereditems.FilterAttribute + GeneralMethods.Default.compareintforDB(filtereditems.FilterValue);
						else if (filtereditems.DatabaseType.Contains("bit"))
							nextPart += (nextPart.Length > 2 ? " AND " : " ") + filtereditems.FilterAttribute + GeneralMethods.Default.compareboolforDB(filtereditems.FilterValue);
						else if (filtereditems.DatabaseType.Contains("decimal")  || filtereditems.DatabaseType.Contains("double") || filtereditems.DatabaseType.Contains("float"))
							nextPart += (nextPart.Length > 2 ? " AND " : " ") + filtereditems.FilterAttribute + GeneralMethods.Default.comparedoubleforDB(filtereditems.FilterValue);
						else if (filtereditems.DatabaseType.Contains("timestamp"))
							nextPart += (nextPart.Length > 2 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy-MM-dd HH:mm:ss}", filtereditems.FilterValue) + "'";
						else if (filtereditems.DatabaseType.Contains("datetime"))
							nextPart += (nextPart.Length > 2 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy-MM-dd HH:mm:ss}", filtereditems.FilterValue) + "'";
						else if (filtereditems.DatabaseType.Contains("date"))
							nextPart += (nextPart.Length > 2 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy-MM-dd}", filtereditems.FilterValue) + "'";
						else if (filtereditems.DatabaseType.Contains("time"))
							nextPart += (nextPart.Length > 2 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + String.Format("{0:HH:mm:ss}", filtereditems.FilterValue) + "'";
						else if (filtereditems.DatabaseType.Contains("year"))
							nextPart += (nextPart.Length > 2 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy}", filtereditems.FilterValue) + "'";
						else
							nextPart += (nextPart.Length > 2 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + filtereditems.FilterValue.ToString() + "'";
					}
					nextPart += ")";
				}
				else throw new Exception("Filter is required.");
			}
			if(string.IsNullOrEmpty(nextPart))
			{
				return this.Select();
			}
			else
			{
				return this.Select(nextPart);
			}
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJemployee> Select(List<OBJemployee> list_obj_OBJemployee, string orderby, string orderparam)
	{
		try
		{
			string nextPart = "";
			foreach (OBJemployee obj_OBJemployee in list_obj_OBJemployee)
			{
				if (obj_OBJemployee.IsFiltered)
				{
					nextPart += (nextPart.Length > 0 ? " OR " : "") + "(";
					foreach (FilteredItems filtereditems in obj_OBJemployee.FilterList)
					{
						if (filtereditems.DatabaseType.Contains("varchar"))
							nextPart += (nextPart.Length > 2 ? " AND " : " ") + filtereditems.FilterAttribute + GeneralMethods.Default.comparestringforDB(filtereditems.FilterValue);
						else if (filtereditems.DatabaseType.Contains("int"))
							nextPart += (nextPart.Length > 2 ? " AND " : " ") + filtereditems.FilterAttribute + GeneralMethods.Default.compareintforDB(filtereditems.FilterValue);
						else if (filtereditems.DatabaseType.Contains("bit"))
							nextPart += (nextPart.Length > 2 ? " AND " : " ") + filtereditems.FilterAttribute + GeneralMethods.Default.compareboolforDB(filtereditems.FilterValue);
						else if (filtereditems.DatabaseType.Contains("decimal")  || filtereditems.DatabaseType.Contains("double") || filtereditems.DatabaseType.Contains("float"))
							nextPart += (nextPart.Length > 2 ? " AND " : " ") + filtereditems.FilterAttribute + GeneralMethods.Default.comparedoubleforDB(filtereditems.FilterValue);
						else if (filtereditems.DatabaseType.Contains("timestamp"))
							nextPart += (nextPart.Length > 2 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy-MM-dd HH:mm:ss}", filtereditems.FilterValue) + "'";
						else if (filtereditems.DatabaseType.Contains("datetime"))
							nextPart += (nextPart.Length > 2 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy-MM-dd HH:mm:ss}", filtereditems.FilterValue) + "'";
						else if (filtereditems.DatabaseType.Contains("date"))
							nextPart += (nextPart.Length > 2 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy-MM-dd}", filtereditems.FilterValue) + "'";
						else if (filtereditems.DatabaseType.Contains("time"))
							nextPart += (nextPart.Length > 2 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + String.Format("{0:HH:mm:ss}", filtereditems.FilterValue) + "'";
						else if (filtereditems.DatabaseType.Contains("year"))
							nextPart += (nextPart.Length > 2 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy}", filtereditems.FilterValue) + "'";
						else
							nextPart += (nextPart.Length > 2 ? " AND " : " ") + filtereditems.FilterAttribute + " = '" + filtereditems.FilterValue.ToString() + "'";
					}
					nextPart += ")";
				}
				else throw new Exception("Filter is required.");
			}
			if(string.IsNullOrEmpty(nextPart))
			{
				return this.Select(" ORDER BY " + orderby + " " + orderparam);
			}
			else
			{
				return this.Select(nextPart + " ORDER BY " + orderby + " " + orderparam);
			}
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public bool Insert(OBJemployee obj_OBJemployee)
	{
		try
		{
			string query = "INSERT INTO employee (EFirstName, ESurName, EBirthDate, EGender, EPassword, ERole) VALUES ("
							+ (obj_OBJemployee.EFirstName == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJemployee.EFirstName) + "'")
							+ ", " + (obj_OBJemployee.ESurName == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJemployee.ESurName) + "'")
							+ ", " + (obj_OBJemployee.EBirthDate == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJemployee.EBirthDate) + "'")
							+ ", " + (obj_OBJemployee.EGender == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJemployee.EGender) + "'")
							+ ", " + (obj_OBJemployee.EPassword == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJemployee.EPassword) + "'")
							+ ", " + (obj_OBJemployee.ERole == null ? "null" : "'" + obj_OBJemployee.ERole + "'") + ")";
			DAL.Default.Execute(query);
			return true;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}

	public bool Insert(List<OBJemployee> listobj_OBJemployee)
	{
	bool ret = false;
	 foreach(OBJemployee obj_OBJemployee in listobj_OBJemployee)
	{
		try
		{
			string query = "INSERT INTO employee (EFirstName, ESurName, EBirthDate, EGender, EPassword, ERole) VALUES ("
							+ (obj_OBJemployee.EFirstName == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJemployee.EFirstName) + "'")
							+ ", " + (obj_OBJemployee.ESurName == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJemployee.ESurName) + "'")
							+ ", " + (obj_OBJemployee.EBirthDate == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJemployee.EBirthDate) + "'")
							+ ", " + (obj_OBJemployee.EGender == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJemployee.EGender) + "'")
							+ ", " + (obj_OBJemployee.EPassword == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJemployee.EPassword) + "'")
							+ ", " + (obj_OBJemployee.ERole == null ? "null" : "'" + obj_OBJemployee.ERole + "'") + ")"
							
							
							
							
							
							;
			DAL.Default.Execute(query);
			ret = true;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			ret = false;
		}
	}
	 return ret;
	}

	public OBJemployee Insert_Return(OBJemployee obj_OBJemployee)
	{
		try
		{
			string query = "INSERT INTO employee (EFirstName, ESurName, EBirthDate, EGender, EPassword, ERole) VALUES ("
							+ (obj_OBJemployee.EFirstName == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJemployee.EFirstName) + "'")
							+ ", " + (obj_OBJemployee.ESurName == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJemployee.ESurName) + "'")
							+ ", " + (obj_OBJemployee.EBirthDate == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJemployee.EBirthDate) + "'")
							+ ", " + (obj_OBJemployee.EGender == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJemployee.EGender) + "'")
							+ ", " + (obj_OBJemployee.EPassword == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJemployee.EPassword) + "'")
							+ ", " + (obj_OBJemployee.ERole == null ? "null" : "'" + obj_OBJemployee.ERole + "'") + ")"
							
							
							
							
							
							
							+ "; SELECT EID FROM employee ORDER BY EID DESC LIMIT 1";
			DataTable dt= DAL.Default.Select(query);
			DataRow dr = dt.Rows[0];
			obj_OBJemployee.EID = Convert.ToInt32(dr["EID"]);
			return obj_OBJemployee;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public bool Update(OBJemployee updateObject) 
	{
		try
		{
			if (updateObject.IsFiltered)
			{
				string query = "UPDATE employee SET ";
				string queryWhere = "";
				bool counter = false;
				foreach (FilteredItems filtereditems in updateObject.FilterList)
				{
					if (filtereditems.FilterAttribute == "EID")
					{
						queryWhere += " WHERE " + filtereditems.FilterAttribute + " = " + filtereditems.FilterValue;
					}
					else
					{
						if (counter)
							query += ", ";
						if (filtereditems.AttributeType.ToString().ToLowerInvariant().Contains("string"))
						{
						if (filtereditems.FilterValue != null)
						{
							query += filtereditems.FilterAttribute + GeneralMethods.Default.comparestringforDB(filtereditems.FilterValue);
						}
						else{
							query += filtereditems.FilterAttribute + " = null";
						}
							counter = true;
						}
						else if (filtereditems.AttributeType.ToString().ToLowerInvariant().Contains("int"))
						{
							query += filtereditems.FilterAttribute + GeneralMethods.Default.compareintforDB(filtereditems.FilterValue);
							counter = true;
						}
						else if (filtereditems.DatabaseType.Contains("bit"))
						{
							query += filtereditems.FilterAttribute + GeneralMethods.Default.compareboolforDB(filtereditems.FilterValue);
							counter = true;
						}
						else if (filtereditems.DatabaseType.Contains("decimal") || filtereditems.DatabaseType.Contains("double") || filtereditems.DatabaseType.Contains("float"))
						{
							query += filtereditems.FilterAttribute + GeneralMethods.Default.comparedoubleforDB(filtereditems.FilterValue);
							counter = true;
						}
						else if (filtereditems.DatabaseType.Contains("timestamp"))
						{
							query += filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy-MM-dd HH:mm:ss}", filtereditems.FilterValue) + "'";
							counter = true;
						}
						else if (filtereditems.DatabaseType.Contains("datetime"))
						{
							query += filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy-MM-dd HH:mm:ss}", filtereditems.FilterValue) + "'";
							counter = true;
						}
						else if (filtereditems.DatabaseType.Contains("date"))
						{
							query += filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy-MM-dd}", filtereditems.FilterValue) + "'";
							counter = true;
						}
						else if (filtereditems.DatabaseType.Contains("time"))
						{
							query += filtereditems.FilterAttribute + " = '" + String.Format("{0:HH:mm:ss}", filtereditems.FilterValue) + "'";
							counter = true;
						}
						else if (filtereditems.DatabaseType.Contains("year"))
						{
							query += filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy}", filtereditems.FilterValue) + "'";
							counter = true;
						}
						else
						{
							query += filtereditems.FilterAttribute + GeneralMethods.Default.comparestringforDB(filtereditems.FilterValue);
							counter = true;
						}
					}
				}
				query += queryWhere;
				return DAL.Default.Execute(query);
			}
			else
			{
				if (updateObject.EID != 0)
				{
					string query = "UPDATE employee SET ";
					int sqlCount = 0;
					query += (sqlCount > 0 ? ", " : "");
					query += "EFirstName" + GeneralMethods.Default.comparestringforDB(updateObject.EFirstName);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "ESurName" + GeneralMethods.Default.comparestringforDB(updateObject.ESurName);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "EBirthDate" + GeneralMethods.Default.comparestringforDB(updateObject.EBirthDate);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "EGender" + GeneralMethods.Default.comparestringforDB(updateObject.EGender);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "EPassword" + GeneralMethods.Default.comparestringforDB(updateObject.EPassword);
					sqlCount++;
					if (updateObject.ERole.HasValue)
					{
						query += (sqlCount > 0 ? ", " : "");
						query += "ERole" + GeneralMethods.Default.compareintforDB(updateObject.ERole.Value);
						sqlCount++;
					}
					query += " WHERE EID = " + updateObject.EID;
					return DAL.Default.Execute(query);
				}
				else
				{
					return false;
				}
			}
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}

	public bool UpdateWot(OBJemployee updateObject) 
	{
		try
		{
			if (updateObject.IsFiltered)
			{
				string query = "UPDATE employee SET ";
				string queryWhere = "";
				bool counter = false;
				foreach (FilteredItems filtereditems in updateObject.FilterList)
				{
					if (filtereditems.FilterAttribute == "EID")
					{
						queryWhere += " WHERE " + filtereditems.FilterAttribute + " = " + filtereditems.FilterValue;
					}
					else
					{
						if (counter)
							query += ", ";
						if (filtereditems.AttributeType.ToString().ToLowerInvariant().Contains("string"))
						{
							query += filtereditems.FilterAttribute + GeneralMethods.Default.comparestringforDB(filtereditems.FilterValue);
							counter = true;
						}
						else if (filtereditems.AttributeType.ToString().ToLowerInvariant().Contains("int"))
						{
							query += filtereditems.FilterAttribute + GeneralMethods.Default.compareintforDB(filtereditems.FilterValue);
							counter = true;
						}
						else if (filtereditems.DatabaseType.Contains("bit"))
						{
							query += filtereditems.FilterAttribute + GeneralMethods.Default.compareboolforDB(filtereditems.FilterValue);
							counter = true;
						}
						else if (filtereditems.DatabaseType.Contains("decimal") || filtereditems.DatabaseType.Contains("double") || filtereditems.DatabaseType.Contains("float"))
						{
							query += filtereditems.FilterAttribute + GeneralMethods.Default.comparedoubleforDB(filtereditems.FilterValue);
							counter = true;
						}
						else if (filtereditems.DatabaseType.Contains("timestamp"))
						{
							query += filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy-MM-dd HH:mm:ss}", filtereditems.FilterValue) + "'";
							counter = true;
						}
						else if (filtereditems.DatabaseType.Contains("datetime"))
						{
							query += filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy-MM-dd HH:mm:ss}", filtereditems.FilterValue) + "'";
							counter = true;
						}
						else if (filtereditems.DatabaseType.Contains("date"))
						{
							query += filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy-MM-dd}", filtereditems.FilterValue) + "'";
							counter = true;
						}
						else if (filtereditems.DatabaseType.Contains("time"))
						{
							query += filtereditems.FilterAttribute + " = '" + String.Format("{0:HH:mm:ss}", filtereditems.FilterValue) + "'";
							counter = true;
						}
						else if (filtereditems.DatabaseType.Contains("year"))
						{
							query += filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy}", filtereditems.FilterValue) + "'";
							counter = true;
						}
						else
						{
							query += filtereditems.FilterAttribute + GeneralMethods.Default.comparestringforDB(filtereditems.FilterValue);
							counter = true;
						}
					}
				}
				query += queryWhere;
				return DAL.Default.Execute(query);
			}
			else
			{
				if (updateObject.EID != 0)
				{
					string query = "UPDATE employee SET ";
					int sqlCount = 0;
					query += (sqlCount > 0 ? ", " : "");
					query += "EFirstName" + GeneralMethods.Default.comparestringforDB(updateObject.EFirstName);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "ESurName" + GeneralMethods.Default.comparestringforDB(updateObject.ESurName);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "EBirthDate" + GeneralMethods.Default.comparestringforDB(updateObject.EBirthDate);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "EGender" + GeneralMethods.Default.comparestringforDB(updateObject.EGender);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "EPassword" + GeneralMethods.Default.comparestringforDB(updateObject.EPassword);
					sqlCount++;
					if (updateObject.ERole.HasValue)
					{
						query += (sqlCount > 0 ? ", " : "");
						query += "ERole" + GeneralMethods.Default.compareintforDB(updateObject.ERole.Value);
						sqlCount++;
					}
					query += " WHERE EID = " + updateObject.EID;
					return DAL.Default.Execute(query);
				}
				else
				{
					return false;
				}
			}
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}

	public bool Update(List<OBJemployee> listupdateObject)
	{
	bool ret = false;
	 foreach(OBJemployee updateObject in listupdateObject)
	{
		try
		{
			if (updateObject.IsFiltered)
			{
				string query = "UPDATE employee SET ";
				string queryWhere = "";
				bool counter = false;
				foreach (FilteredItems filtereditems in updateObject.FilterList)
				{
					if (filtereditems.FilterAttribute == "EID")
					{
						queryWhere += " WHERE " + filtereditems.FilterAttribute + " = " + filtereditems.FilterValue;
					}
					else
					{
						if (counter)
							query += ", ";
						if (filtereditems.AttributeType.ToString().ToLowerInvariant().Contains("string"))
						{
							query += filtereditems.FilterAttribute + GeneralMethods.Default.comparestringforDB(filtereditems.FilterValue);
							counter = true;
						}
						else if (filtereditems.AttributeType.ToString().ToLowerInvariant().Contains("int"))
						{
							query += filtereditems.FilterAttribute + GeneralMethods.Default.compareintforDB(filtereditems.FilterValue);
							counter = true;
						}
						else if (filtereditems.DatabaseType.Contains("bit"))
						{
							query += filtereditems.FilterAttribute + GeneralMethods.Default.compareboolforDB(filtereditems.FilterValue);
							counter = true;
						}
						else if (filtereditems.DatabaseType.Contains("decimal") || filtereditems.DatabaseType.Contains("double") || filtereditems.DatabaseType.Contains("float"))
						{
							query += filtereditems.FilterAttribute + GeneralMethods.Default.comparedoubleforDB(filtereditems.FilterValue);
							counter = true;
						}
						else if (filtereditems.DatabaseType.Contains("timestamp"))
						{
							query += filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy-MM-dd HH:mm:ss}", filtereditems.FilterValue) + "'";
							counter = true;
						}
						else if (filtereditems.DatabaseType.Contains("datetime"))
						{
							query += filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy-MM-dd HH:mm:ss}", filtereditems.FilterValue) + "'";
							counter = true;
						}
						else if (filtereditems.DatabaseType.Contains("date"))
						{
							query += filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy-MM-dd}", filtereditems.FilterValue) + "'";
							counter = true;
						}
						else if (filtereditems.DatabaseType.Contains("time"))
						{
							query += filtereditems.FilterAttribute + " = '" + String.Format("{0:HH:mm:ss}", filtereditems.FilterValue) + "'";
							counter = true;
						}
						else if (filtereditems.DatabaseType.Contains("year"))
						{
							query += filtereditems.FilterAttribute + " = '" + String.Format("{0:yyyy}", filtereditems.FilterValue) + "'";
							counter = true;
						}
						else
						{
							query += filtereditems.FilterAttribute + GeneralMethods.Default.comparestringforDB(filtereditems.FilterValue);
							counter = true;
						}
					}
				}
				query += queryWhere;
				ret = DAL.Default.Execute(query);
			}
			else
			{
				if (updateObject.EID != 0)
				{
					string query = "UPDATE employee SET ";
					int sqlCount = 0;
					query += (sqlCount > 0 ? ", " : "");
					query += "EFirstName" + GeneralMethods.Default.comparestringforDB(updateObject.EFirstName);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "ESurName" + GeneralMethods.Default.comparestringforDB(updateObject.ESurName);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "EBirthDate" + GeneralMethods.Default.comparestringforDB(updateObject.EBirthDate);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "EGender" + GeneralMethods.Default.comparestringforDB(updateObject.EGender);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "EPassword" + GeneralMethods.Default.comparestringforDB(updateObject.EPassword);
					sqlCount++;
					if (updateObject.ERole.HasValue)
					{
						query += (sqlCount > 0 ? ", " : "");
						query += "ERole" + GeneralMethods.Default.compareintforDB(updateObject.ERole.Value);
						sqlCount++;
					}
					query += " WHERE EID = " + updateObject.EID;
					 ret = DAL.Default.Execute(query);
				}
				else
				{
					return false;
				}
			}
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}
	return ret;
	}

	public bool Delete(int EID)
	{
		try
		{
			string query= "DELETE FROM employee WHERE EID = " + EID;
			return DAL.Default.Execute(query);
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}

	public bool Delete(OBJemployee deleteObject)
	{
		try
		{
			List<OBJemployee> objList = this.Select(deleteObject);
			foreach (OBJemployee obj_OBJemployee in objList)
				this.Delete(obj_OBJemployee.EID);
			return true;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}

	public bool Delete(List<OBJemployee> listdeleteObject)
	{
	bool ret = false;
	foreach(OBJemployee deleteObject in listdeleteObject)
		{
		try
		{
			List<OBJemployee> objList = this.Select(deleteObject);
			foreach (OBJemployee obj_OBJemployee in objList)
				this.Delete(obj_OBJemployee.EID);
			ret = true;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			ret = false;
			}
		}
	return ret;
	}

}
