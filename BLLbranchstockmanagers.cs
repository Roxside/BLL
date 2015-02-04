using System;
using System.Collections.Generic;
using System.Data;

/// <summary>
/// Generated Class for Table : BLLbranchstockmanagers.
/// </summary>

public class BLLbranchstockmanagers
{
	private static BLLbranchstockmanagers defaultInstance = new BLLbranchstockmanagers();

	public static BLLbranchstockmanagers Default 
	{
		get { return defaultInstance; }
	}

	public BLLbranchstockmanagers()
	{

	}

	public List<OBJbranchstockmanagers> Select()
	{
		try
		{
			string query = "SELECT * FROM branchstockmanagers";
			DataTable dt = DAL.Default.Select(query);
			List<OBJbranchstockmanagers> ObjList = new List<OBJbranchstockmanagers>();
			foreach (DataRow dr in dt.Rows)
			{
				OBJbranchstockmanagers obj_OBJbranchstockmanagers = new OBJbranchstockmanagers();
				obj_OBJbranchstockmanagers.BSTMID = Convert.ToInt32(dr["BSTMID"]);
				obj_OBJbranchstockmanagers.Employee_EID = Convert.ToInt32(dr["Employee_EID"]);
				obj_OBJbranchstockmanagers.Storage_STID = Convert.ToInt32(dr["Storage_STID"]);
				obj_OBJbranchstockmanagers.LogisticManager_LMID = Convert.ToInt32(dr["LogisticManager_LMID"]);
				ObjList.Add(obj_OBJbranchstockmanagers);
			}
			return ObjList;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJbranchstockmanagers> Select(string orderby, string orderparam)
	{
		try
		{
			string query = "SELECT * FROM branchstockmanagers ORDER BY " + orderby + " " + orderparam;
			DataTable dt = DAL.Default.Select(query);
			List<OBJbranchstockmanagers> ObjList = new List<OBJbranchstockmanagers>();
			foreach (DataRow dr in dt.Rows)
			{
				OBJbranchstockmanagers obj_OBJbranchstockmanagers = new OBJbranchstockmanagers();
				obj_OBJbranchstockmanagers.BSTMID = Convert.ToInt32(dr["BSTMID"]);
				obj_OBJbranchstockmanagers.Employee_EID = Convert.ToInt32(dr["Employee_EID"]);
				obj_OBJbranchstockmanagers.Storage_STID = Convert.ToInt32(dr["Storage_STID"]);
				obj_OBJbranchstockmanagers.LogisticManager_LMID = Convert.ToInt32(dr["LogisticManager_LMID"]);
				ObjList.Add(obj_OBJbranchstockmanagers);
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
			string query = "SELECT * FROM branchstockmanagers";
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
			string query = "SELECT * FROM branchstockmanagers ORDER BY " + orderby + " " + orderparam;
			return DAL.Default.Select(query);
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public OBJbranchstockmanagers Select(int BSTMID)
	{
		try
		{
			string query = "SELECT * FROM branchstockmanagers WHERE BSTMID = " + BSTMID;
			DataTable dt = DAL.Default.Select(query);
			OBJbranchstockmanagers obj_OBJbranchstockmanagers = new OBJbranchstockmanagers();
			DataRow dr = dt.Rows[0];
			obj_OBJbranchstockmanagers.BSTMID = Convert.ToInt32(dr["BSTMID"]);
			obj_OBJbranchstockmanagers.Employee_EID = Convert.ToInt32(dr["Employee_EID"]);
			obj_OBJbranchstockmanagers.Storage_STID = Convert.ToInt32(dr["Storage_STID"]);
			obj_OBJbranchstockmanagers.LogisticManager_LMID = Convert.ToInt32(dr["LogisticManager_LMID"]);
			return obj_OBJbranchstockmanagers;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJbranchstockmanagers> Select(string nextPart)
	{
		try
		{
			string query = "SELECT * FROM branchstockmanagers WHERE " + nextPart;
			DataTable dt = DAL.Default.Select(query);
			List<OBJbranchstockmanagers> ObjList = new List<OBJbranchstockmanagers>();
			foreach (DataRow dr in dt.Rows)
			{
				OBJbranchstockmanagers obj_OBJbranchstockmanagers = new OBJbranchstockmanagers();
				obj_OBJbranchstockmanagers.BSTMID = Convert.ToInt32(dr["BSTMID"]);
				obj_OBJbranchstockmanagers.Employee_EID = Convert.ToInt32(dr["Employee_EID"]);
				obj_OBJbranchstockmanagers.Storage_STID = Convert.ToInt32(dr["Storage_STID"]);
				obj_OBJbranchstockmanagers.LogisticManager_LMID = Convert.ToInt32(dr["LogisticManager_LMID"]);
				ObjList.Add(obj_OBJbranchstockmanagers);
			}
			return ObjList;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJbranchstockmanagers> Select(OBJbranchstockmanagers obj_OBJbranchstockmanagers)
	{
		try
		{
			if (obj_OBJbranchstockmanagers.IsFiltered)
			{
				string nextPart = "";
				foreach (FilteredItems filtereditems in obj_OBJbranchstockmanagers.FilterList)
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

	public List<OBJbranchstockmanagers> Select(OBJbranchstockmanagers obj_OBJbranchstockmanagers, string orderby, string orderparam)
	{
		try
		{
			if (obj_OBJbranchstockmanagers.IsFiltered)
			{
				string nextPart = "";
				foreach (FilteredItems filtereditems in obj_OBJbranchstockmanagers.FilterList)
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

	public List<OBJbranchstockmanagers> Select(List<OBJbranchstockmanagers> list_obj_OBJbranchstockmanagers)
	{
		try
		{
			string nextPart = "";
			foreach (OBJbranchstockmanagers obj_OBJbranchstockmanagers in list_obj_OBJbranchstockmanagers)
			{
				if (obj_OBJbranchstockmanagers.IsFiltered)
				{
					nextPart += (nextPart.Length > 0 ? " OR " : "") + "(";
					foreach (FilteredItems filtereditems in obj_OBJbranchstockmanagers.FilterList)
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

	public List<OBJbranchstockmanagers> Select(List<OBJbranchstockmanagers> list_obj_OBJbranchstockmanagers, string orderby, string orderparam)
	{
		try
		{
			string nextPart = "";
			foreach (OBJbranchstockmanagers obj_OBJbranchstockmanagers in list_obj_OBJbranchstockmanagers)
			{
				if (obj_OBJbranchstockmanagers.IsFiltered)
				{
					nextPart += (nextPart.Length > 0 ? " OR " : "") + "(";
					foreach (FilteredItems filtereditems in obj_OBJbranchstockmanagers.FilterList)
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

	public bool Insert(OBJbranchstockmanagers obj_OBJbranchstockmanagers)
	{
		try
		{
			string query = "INSERT INTO branchstockmanagers (Employee_EID, Storage_STID, LogisticManager_LMID) VALUES ("
							+ (obj_OBJbranchstockmanagers.Employee_EID == 0 ? "0" : "'" + obj_OBJbranchstockmanagers.Employee_EID + "'")
							+ ", " + (obj_OBJbranchstockmanagers.Storage_STID == 0 ? "0" : "'" + obj_OBJbranchstockmanagers.Storage_STID + "'")
							+ ", " + (obj_OBJbranchstockmanagers.LogisticManager_LMID == 0 ? "0" : "'" + obj_OBJbranchstockmanagers.LogisticManager_LMID + "'") + ")";
			DAL.Default.Execute(query);
			return true;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}

	public bool Insert(List<OBJbranchstockmanagers> listobj_OBJbranchstockmanagers)
	{
	bool ret = false;
	 foreach(OBJbranchstockmanagers obj_OBJbranchstockmanagers in listobj_OBJbranchstockmanagers)
	{
		try
		{
			string query = "INSERT INTO branchstockmanagers (Employee_EID, Storage_STID, LogisticManager_LMID) VALUES ("
							+ (obj_OBJbranchstockmanagers.Employee_EID == 0 ? "0" : "'" + obj_OBJbranchstockmanagers.Employee_EID + "'")
							+ ", " + (obj_OBJbranchstockmanagers.Storage_STID == 0 ? "0" : "'" + obj_OBJbranchstockmanagers.Storage_STID + "'")
							+ ", " + (obj_OBJbranchstockmanagers.LogisticManager_LMID == 0 ? "0" : "'" + obj_OBJbranchstockmanagers.LogisticManager_LMID + "'") + ")"
							
							
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

	public OBJbranchstockmanagers Insert_Return(OBJbranchstockmanagers obj_OBJbranchstockmanagers)
	{
		try
		{
			string query = "INSERT INTO branchstockmanagers (Employee_EID, Storage_STID, LogisticManager_LMID) VALUES ("
							+ (obj_OBJbranchstockmanagers.Employee_EID == 0 ? "0" : "'" + obj_OBJbranchstockmanagers.Employee_EID + "'")
							+ ", " + (obj_OBJbranchstockmanagers.Storage_STID == 0 ? "0" : "'" + obj_OBJbranchstockmanagers.Storage_STID + "'")
							+ ", " + (obj_OBJbranchstockmanagers.LogisticManager_LMID == 0 ? "0" : "'" + obj_OBJbranchstockmanagers.LogisticManager_LMID + "'") + ")"
							
							
							
							+ "; SELECT BSTMID FROM branchstockmanagers ORDER BY BSTMID DESC LIMIT 1";
			DataTable dt= DAL.Default.Select(query);
			DataRow dr = dt.Rows[0];
			obj_OBJbranchstockmanagers.BSTMID = Convert.ToInt32(dr["BSTMID"]);
			return obj_OBJbranchstockmanagers;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public bool Update(OBJbranchstockmanagers updateObject) 
	{
		try
		{
			if (updateObject.IsFiltered)
			{
				string query = "UPDATE branchstockmanagers SET ";
				string queryWhere = "";
				bool counter = false;
				foreach (FilteredItems filtereditems in updateObject.FilterList)
				{
					if (filtereditems.FilterAttribute == "BSTMID")
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
				if (updateObject.BSTMID != 0)
				{
					string query = "UPDATE branchstockmanagers SET ";
					int sqlCount = 0;
					query += (sqlCount > 0 ? ", " : "");
					query += "Employee_EID" + GeneralMethods.Default.compareintforDB(updateObject.Employee_EID);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "Storage_STID" + GeneralMethods.Default.compareintforDB(updateObject.Storage_STID);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "LogisticManager_LMID" + GeneralMethods.Default.compareintforDB(updateObject.LogisticManager_LMID);
					sqlCount++;
					query += " WHERE BSTMID = " + updateObject.BSTMID;
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

	public bool UpdateWot(OBJbranchstockmanagers updateObject) 
	{
		try
		{
			if (updateObject.IsFiltered)
			{
				string query = "UPDATE branchstockmanagers SET ";
				string queryWhere = "";
				bool counter = false;
				foreach (FilteredItems filtereditems in updateObject.FilterList)
				{
					if (filtereditems.FilterAttribute == "BSTMID")
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
				if (updateObject.BSTMID != 0)
				{
					string query = "UPDATE branchstockmanagers SET ";
					int sqlCount = 0;
					query += (sqlCount > 0 ? ", " : "");
					query += "Employee_EID" + GeneralMethods.Default.compareintforDB(updateObject.Employee_EID);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "Storage_STID" + GeneralMethods.Default.compareintforDB(updateObject.Storage_STID);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "LogisticManager_LMID" + GeneralMethods.Default.compareintforDB(updateObject.LogisticManager_LMID);
					sqlCount++;
					query += " WHERE BSTMID = " + updateObject.BSTMID;
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

	public bool Update(List<OBJbranchstockmanagers> listupdateObject)
	{
	bool ret = false;
	 foreach(OBJbranchstockmanagers updateObject in listupdateObject)
	{
		try
		{
			if (updateObject.IsFiltered)
			{
				string query = "UPDATE branchstockmanagers SET ";
				string queryWhere = "";
				bool counter = false;
				foreach (FilteredItems filtereditems in updateObject.FilterList)
				{
					if (filtereditems.FilterAttribute == "BSTMID")
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
				if (updateObject.BSTMID != 0)
				{
					string query = "UPDATE branchstockmanagers SET ";
					int sqlCount = 0;
					query += (sqlCount > 0 ? ", " : "");
					query += "Employee_EID" + GeneralMethods.Default.compareintforDB(updateObject.Employee_EID);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "Storage_STID" + GeneralMethods.Default.compareintforDB(updateObject.Storage_STID);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "LogisticManager_LMID" + GeneralMethods.Default.compareintforDB(updateObject.LogisticManager_LMID);
					sqlCount++;
					query += " WHERE BSTMID = " + updateObject.BSTMID;
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

	public bool Delete(int BSTMID)
	{
		try
		{
			string query= "DELETE FROM branchstockmanagers WHERE BSTMID = " + BSTMID;
			return DAL.Default.Execute(query);
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}

	public bool Delete(OBJbranchstockmanagers deleteObject)
	{
		try
		{
			List<OBJbranchstockmanagers> objList = this.Select(deleteObject);
			foreach (OBJbranchstockmanagers obj_OBJbranchstockmanagers in objList)
				this.Delete(obj_OBJbranchstockmanagers.BSTMID);
			return true;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}

	public bool Delete(List<OBJbranchstockmanagers> listdeleteObject)
	{
	bool ret = false;
	foreach(OBJbranchstockmanagers deleteObject in listdeleteObject)
		{
		try
		{
			List<OBJbranchstockmanagers> objList = this.Select(deleteObject);
			foreach (OBJbranchstockmanagers obj_OBJbranchstockmanagers in objList)
				this.Delete(obj_OBJbranchstockmanagers.BSTMID);
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
