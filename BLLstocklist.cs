using System;
using System.Collections.Generic;
using System.Data;

/// <summary>
/// Generated Class for Table : BLLstocklist.
/// </summary>

public class BLLstocklist
{
	private static BLLstocklist defaultInstance = new BLLstocklist();

	public static BLLstocklist Default 
	{
		get { return defaultInstance; }
	}

	public BLLstocklist()
	{

	}

	public List<OBJstocklist> Select()
	{
		try
		{
			string query = "SELECT * FROM stocklist";
			DataTable dt = DAL.Default.Select(query);
			List<OBJstocklist> ObjList = new List<OBJstocklist>();
			foreach (DataRow dr in dt.Rows)
			{
				OBJstocklist obj_OBJstocklist = new OBJstocklist();
				obj_OBJstocklist.SLID = Convert.ToInt32(dr["SLID"]);
				obj_OBJstocklist.LogisticManager_LMID = Convert.ToInt32(dr["LogisticManager_LMID"]);
				obj_OBJstocklist.BranchStockManagers_BSTMID = Convert.ToInt32(dr["BranchStockManagers_BSTMID"]);
				obj_OBJstocklist.StoreDemandList_SDID = Convert.ToInt32(dr["StoreDemandList_SDID"]);
				ObjList.Add(obj_OBJstocklist);
			}
			return ObjList;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJstocklist> Select(string orderby, string orderparam)
	{
		try
		{
			string query = "SELECT * FROM stocklist ORDER BY " + orderby + " " + orderparam;
			DataTable dt = DAL.Default.Select(query);
			List<OBJstocklist> ObjList = new List<OBJstocklist>();
			foreach (DataRow dr in dt.Rows)
			{
				OBJstocklist obj_OBJstocklist = new OBJstocklist();
				obj_OBJstocklist.SLID = Convert.ToInt32(dr["SLID"]);
				obj_OBJstocklist.LogisticManager_LMID = Convert.ToInt32(dr["LogisticManager_LMID"]);
				obj_OBJstocklist.BranchStockManagers_BSTMID = Convert.ToInt32(dr["BranchStockManagers_BSTMID"]);
				obj_OBJstocklist.StoreDemandList_SDID = Convert.ToInt32(dr["StoreDemandList_SDID"]);
				ObjList.Add(obj_OBJstocklist);
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
			string query = "SELECT * FROM stocklist";
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
			string query = "SELECT * FROM stocklist ORDER BY " + orderby + " " + orderparam;
			return DAL.Default.Select(query);
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public OBJstocklist Select(int SLID)
	{
		try
		{
			string query = "SELECT * FROM stocklist WHERE SLID = " + SLID;
			DataTable dt = DAL.Default.Select(query);
			OBJstocklist obj_OBJstocklist = new OBJstocklist();
			DataRow dr = dt.Rows[0];
			obj_OBJstocklist.SLID = Convert.ToInt32(dr["SLID"]);
			obj_OBJstocklist.LogisticManager_LMID = Convert.ToInt32(dr["LogisticManager_LMID"]);
			obj_OBJstocklist.BranchStockManagers_BSTMID = Convert.ToInt32(dr["BranchStockManagers_BSTMID"]);
			obj_OBJstocklist.StoreDemandList_SDID = Convert.ToInt32(dr["StoreDemandList_SDID"]);
			return obj_OBJstocklist;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJstocklist> Select(string nextPart)
	{
		try
		{
			string query = "SELECT * FROM stocklist WHERE " + nextPart;
			DataTable dt = DAL.Default.Select(query);
			List<OBJstocklist> ObjList = new List<OBJstocklist>();
			foreach (DataRow dr in dt.Rows)
			{
				OBJstocklist obj_OBJstocklist = new OBJstocklist();
				obj_OBJstocklist.SLID = Convert.ToInt32(dr["SLID"]);
				obj_OBJstocklist.LogisticManager_LMID = Convert.ToInt32(dr["LogisticManager_LMID"]);
				obj_OBJstocklist.BranchStockManagers_BSTMID = Convert.ToInt32(dr["BranchStockManagers_BSTMID"]);
				obj_OBJstocklist.StoreDemandList_SDID = Convert.ToInt32(dr["StoreDemandList_SDID"]);
				ObjList.Add(obj_OBJstocklist);
			}
			return ObjList;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJstocklist> Select(OBJstocklist obj_OBJstocklist)
	{
		try
		{
			if (obj_OBJstocklist.IsFiltered)
			{
				string nextPart = "";
				foreach (FilteredItems filtereditems in obj_OBJstocklist.FilterList)
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

	public List<OBJstocklist> Select(OBJstocklist obj_OBJstocklist, string orderby, string orderparam)
	{
		try
		{
			if (obj_OBJstocklist.IsFiltered)
			{
				string nextPart = "";
				foreach (FilteredItems filtereditems in obj_OBJstocklist.FilterList)
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

	public List<OBJstocklist> Select(List<OBJstocklist> list_obj_OBJstocklist)
	{
		try
		{
			string nextPart = "";
			foreach (OBJstocklist obj_OBJstocklist in list_obj_OBJstocklist)
			{
				if (obj_OBJstocklist.IsFiltered)
				{
					nextPart += (nextPart.Length > 0 ? " OR " : "") + "(";
					foreach (FilteredItems filtereditems in obj_OBJstocklist.FilterList)
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

	public List<OBJstocklist> Select(List<OBJstocklist> list_obj_OBJstocklist, string orderby, string orderparam)
	{
		try
		{
			string nextPart = "";
			foreach (OBJstocklist obj_OBJstocklist in list_obj_OBJstocklist)
			{
				if (obj_OBJstocklist.IsFiltered)
				{
					nextPart += (nextPart.Length > 0 ? " OR " : "") + "(";
					foreach (FilteredItems filtereditems in obj_OBJstocklist.FilterList)
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

	public bool Insert(OBJstocklist obj_OBJstocklist)
	{
		try
		{
			string query = "INSERT INTO stocklist (LogisticManager_LMID, BranchStockManagers_BSTMID, StoreDemandList_SDID) VALUES ("
							+ (obj_OBJstocklist.LogisticManager_LMID == 0 ? "0" : "'" + obj_OBJstocklist.LogisticManager_LMID + "'")
							+ ", " + (obj_OBJstocklist.BranchStockManagers_BSTMID == 0 ? "0" : "'" + obj_OBJstocklist.BranchStockManagers_BSTMID + "'")
							+ ", " + (obj_OBJstocklist.StoreDemandList_SDID == 0 ? "0" : "'" + obj_OBJstocklist.StoreDemandList_SDID + "'") + ")";
			DAL.Default.Execute(query);
			return true;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}

	public bool Insert(List<OBJstocklist> listobj_OBJstocklist)
	{
	bool ret = false;
	 foreach(OBJstocklist obj_OBJstocklist in listobj_OBJstocklist)
	{
		try
		{
			string query = "INSERT INTO stocklist (LogisticManager_LMID, BranchStockManagers_BSTMID, StoreDemandList_SDID) VALUES ("
							+ (obj_OBJstocklist.LogisticManager_LMID == 0 ? "0" : "'" + obj_OBJstocklist.LogisticManager_LMID + "'")
							+ ", " + (obj_OBJstocklist.BranchStockManagers_BSTMID == 0 ? "0" : "'" + obj_OBJstocklist.BranchStockManagers_BSTMID + "'")
							+ ", " + (obj_OBJstocklist.StoreDemandList_SDID == 0 ? "0" : "'" + obj_OBJstocklist.StoreDemandList_SDID + "'") + ")"
							
							
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

	public OBJstocklist Insert_Return(OBJstocklist obj_OBJstocklist)
	{
		try
		{
			string query = "INSERT INTO stocklist (LogisticManager_LMID, BranchStockManagers_BSTMID, StoreDemandList_SDID) VALUES ("
							+ (obj_OBJstocklist.LogisticManager_LMID == 0 ? "0" : "'" + obj_OBJstocklist.LogisticManager_LMID + "'")
							+ ", " + (obj_OBJstocklist.BranchStockManagers_BSTMID == 0 ? "0" : "'" + obj_OBJstocklist.BranchStockManagers_BSTMID + "'")
							+ ", " + (obj_OBJstocklist.StoreDemandList_SDID == 0 ? "0" : "'" + obj_OBJstocklist.StoreDemandList_SDID + "'") + ")"
							
							
							
							+ "; SELECT SLID FROM stocklist ORDER BY SLID DESC LIMIT 1";
			DataTable dt= DAL.Default.Select(query);
			DataRow dr = dt.Rows[0];
			obj_OBJstocklist.SLID = Convert.ToInt32(dr["SLID"]);
			return obj_OBJstocklist;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public bool Update(OBJstocklist updateObject) 
	{
		try
		{
			if (updateObject.IsFiltered)
			{
				string query = "UPDATE stocklist SET ";
				string queryWhere = "";
				bool counter = false;
				foreach (FilteredItems filtereditems in updateObject.FilterList)
				{
					if (filtereditems.FilterAttribute == "SLID")
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
				if (updateObject.SLID != 0)
				{
					string query = "UPDATE stocklist SET ";
					int sqlCount = 0;
					query += (sqlCount > 0 ? ", " : "");
					query += "LogisticManager_LMID" + GeneralMethods.Default.compareintforDB(updateObject.LogisticManager_LMID);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "BranchStockManagers_BSTMID" + GeneralMethods.Default.compareintforDB(updateObject.BranchStockManagers_BSTMID);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "StoreDemandList_SDID" + GeneralMethods.Default.compareintforDB(updateObject.StoreDemandList_SDID);
					sqlCount++;
					query += " WHERE SLID = " + updateObject.SLID;
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

	public bool UpdateWot(OBJstocklist updateObject) 
	{
		try
		{
			if (updateObject.IsFiltered)
			{
				string query = "UPDATE stocklist SET ";
				string queryWhere = "";
				bool counter = false;
				foreach (FilteredItems filtereditems in updateObject.FilterList)
				{
					if (filtereditems.FilterAttribute == "SLID")
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
				if (updateObject.SLID != 0)
				{
					string query = "UPDATE stocklist SET ";
					int sqlCount = 0;
					query += (sqlCount > 0 ? ", " : "");
					query += "LogisticManager_LMID" + GeneralMethods.Default.compareintforDB(updateObject.LogisticManager_LMID);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "BranchStockManagers_BSTMID" + GeneralMethods.Default.compareintforDB(updateObject.BranchStockManagers_BSTMID);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "StoreDemandList_SDID" + GeneralMethods.Default.compareintforDB(updateObject.StoreDemandList_SDID);
					sqlCount++;
					query += " WHERE SLID = " + updateObject.SLID;
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

	public bool Update(List<OBJstocklist> listupdateObject)
	{
	bool ret = false;
	 foreach(OBJstocklist updateObject in listupdateObject)
	{
		try
		{
			if (updateObject.IsFiltered)
			{
				string query = "UPDATE stocklist SET ";
				string queryWhere = "";
				bool counter = false;
				foreach (FilteredItems filtereditems in updateObject.FilterList)
				{
					if (filtereditems.FilterAttribute == "SLID")
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
				if (updateObject.SLID != 0)
				{
					string query = "UPDATE stocklist SET ";
					int sqlCount = 0;
					query += (sqlCount > 0 ? ", " : "");
					query += "LogisticManager_LMID" + GeneralMethods.Default.compareintforDB(updateObject.LogisticManager_LMID);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "BranchStockManagers_BSTMID" + GeneralMethods.Default.compareintforDB(updateObject.BranchStockManagers_BSTMID);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "StoreDemandList_SDID" + GeneralMethods.Default.compareintforDB(updateObject.StoreDemandList_SDID);
					sqlCount++;
					query += " WHERE SLID = " + updateObject.SLID;
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

	public bool Delete(int SLID)
	{
		try
		{
			string query= "DELETE FROM stocklist WHERE SLID = " + SLID;
			return DAL.Default.Execute(query);
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}

	public bool Delete(OBJstocklist deleteObject)
	{
		try
		{
			List<OBJstocklist> objList = this.Select(deleteObject);
			foreach (OBJstocklist obj_OBJstocklist in objList)
				this.Delete(obj_OBJstocklist.SLID);
			return true;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}

	public bool Delete(List<OBJstocklist> listdeleteObject)
	{
	bool ret = false;
	foreach(OBJstocklist deleteObject in listdeleteObject)
		{
		try
		{
			List<OBJstocklist> objList = this.Select(deleteObject);
			foreach (OBJstocklist obj_OBJstocklist in objList)
				this.Delete(obj_OBJstocklist.SLID);
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
