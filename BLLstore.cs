using System;
using System.Collections.Generic;
using System.Data;

/// <summary>
/// Generated Class for Table : BLLstore.
/// </summary>

public class BLLstore
{
	private static BLLstore defaultInstance = new BLLstore();

	public static BLLstore Default 
	{
		get { return defaultInstance; }
	}

	public BLLstore()
	{

	}

	public List<OBJstore> Select()
	{
		try
		{
			string query = "SELECT * FROM store";
			DataTable dt = DAL.Default.Select(query);
			List<OBJstore> ObjList = new List<OBJstore>();
			foreach (DataRow dr in dt.Rows)
			{
				OBJstore obj_OBJstore = new OBJstore();
				obj_OBJstore.SID = Convert.ToInt32(dr["SID"]);
				obj_OBJstore.SName = (dr["SName"]).ToString();
				obj_OBJstore.Address_AID1 = Convert.ToInt32(dr["Address_AID1"]);
				ObjList.Add(obj_OBJstore);
			}
			return ObjList;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJstore> Select(string orderby, string orderparam)
	{
		try
		{
			string query = "SELECT * FROM store ORDER BY " + orderby + " " + orderparam;
			DataTable dt = DAL.Default.Select(query);
			List<OBJstore> ObjList = new List<OBJstore>();
			foreach (DataRow dr in dt.Rows)
			{
				OBJstore obj_OBJstore = new OBJstore();
				obj_OBJstore.SID = Convert.ToInt32(dr["SID"]);
				obj_OBJstore.SName = (dr["SName"]).ToString();
				obj_OBJstore.Address_AID1 = Convert.ToInt32(dr["Address_AID1"]);
				ObjList.Add(obj_OBJstore);
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
			string query = "SELECT * FROM store";
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
			string query = "SELECT * FROM store ORDER BY " + orderby + " " + orderparam;
			return DAL.Default.Select(query);
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public OBJstore Select(int SID)
	{
		try
		{
			string query = "SELECT * FROM store WHERE SID = " + SID;
			DataTable dt = DAL.Default.Select(query);
			OBJstore obj_OBJstore = new OBJstore();
			DataRow dr = dt.Rows[0];
			obj_OBJstore.SID = Convert.ToInt32(dr["SID"]);
			obj_OBJstore.SName = (dr["SName"]).ToString();
			obj_OBJstore.Address_AID1 = Convert.ToInt32(dr["Address_AID1"]);
			return obj_OBJstore;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJstore> Select(string nextPart)
	{
		try
		{
			string query = "SELECT * FROM store WHERE " + nextPart;
			DataTable dt = DAL.Default.Select(query);
			List<OBJstore> ObjList = new List<OBJstore>();
			foreach (DataRow dr in dt.Rows)
			{
				OBJstore obj_OBJstore = new OBJstore();
				obj_OBJstore.SID = Convert.ToInt32(dr["SID"]);
				obj_OBJstore.SName = (dr["SName"]).ToString();
				obj_OBJstore.Address_AID1 = Convert.ToInt32(dr["Address_AID1"]);
				ObjList.Add(obj_OBJstore);
			}
			return ObjList;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJstore> Select(OBJstore obj_OBJstore)
	{
		try
		{
			if (obj_OBJstore.IsFiltered)
			{
				string nextPart = "";
				foreach (FilteredItems filtereditems in obj_OBJstore.FilterList)
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

	public List<OBJstore> Select(OBJstore obj_OBJstore, string orderby, string orderparam)
	{
		try
		{
			if (obj_OBJstore.IsFiltered)
			{
				string nextPart = "";
				foreach (FilteredItems filtereditems in obj_OBJstore.FilterList)
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

	public List<OBJstore> Select(List<OBJstore> list_obj_OBJstore)
	{
		try
		{
			string nextPart = "";
			foreach (OBJstore obj_OBJstore in list_obj_OBJstore)
			{
				if (obj_OBJstore.IsFiltered)
				{
					nextPart += (nextPart.Length > 0 ? " OR " : "") + "(";
					foreach (FilteredItems filtereditems in obj_OBJstore.FilterList)
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

	public List<OBJstore> Select(List<OBJstore> list_obj_OBJstore, string orderby, string orderparam)
	{
		try
		{
			string nextPart = "";
			foreach (OBJstore obj_OBJstore in list_obj_OBJstore)
			{
				if (obj_OBJstore.IsFiltered)
				{
					nextPart += (nextPart.Length > 0 ? " OR " : "") + "(";
					foreach (FilteredItems filtereditems in obj_OBJstore.FilterList)
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

	public bool Insert(OBJstore obj_OBJstore)
	{
		try
		{
			string query = "INSERT INTO store (SName, Address_AID1) VALUES ("
							+ (obj_OBJstore.SName == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJstore.SName) + "'")
							+ ", " + (obj_OBJstore.Address_AID1 == 0 ? "0" : "'" + obj_OBJstore.Address_AID1 + "'") + ")";
			DAL.Default.Execute(query);
			return true;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}

	public bool Insert(List<OBJstore> listobj_OBJstore)
	{
	bool ret = false;
	 foreach(OBJstore obj_OBJstore in listobj_OBJstore)
	{
		try
		{
			string query = "INSERT INTO store (SName, Address_AID1) VALUES ("
							+ (obj_OBJstore.SName == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJstore.SName) + "'")
							+ ", " + (obj_OBJstore.Address_AID1 == 0 ? "0" : "'" + obj_OBJstore.Address_AID1 + "'") + ")"
							
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

	public OBJstore Insert_Return(OBJstore obj_OBJstore)
	{
		try
		{
			string query = "INSERT INTO store (SName, Address_AID1) VALUES ("
							+ (obj_OBJstore.SName == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJstore.SName) + "'")
							+ ", " + (obj_OBJstore.Address_AID1 == 0 ? "0" : "'" + obj_OBJstore.Address_AID1 + "'") + ")"
							
							
							+ "; SELECT SID FROM store ORDER BY SID DESC LIMIT 1";
			DataTable dt= DAL.Default.Select(query);
			DataRow dr = dt.Rows[0];
			obj_OBJstore.SID = Convert.ToInt32(dr["SID"]);
			return obj_OBJstore;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public bool Update(OBJstore updateObject) 
	{
		try
		{
			if (updateObject.IsFiltered)
			{
				string query = "UPDATE store SET ";
				string queryWhere = "";
				bool counter = false;
				foreach (FilteredItems filtereditems in updateObject.FilterList)
				{
					if (filtereditems.FilterAttribute == "SID")
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
				if (updateObject.SID != 0)
				{
					string query = "UPDATE store SET ";
					int sqlCount = 0;
					query += (sqlCount > 0 ? ", " : "");
					query += "SName" + GeneralMethods.Default.comparestringforDB(updateObject.SName);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "Address_AID1" + GeneralMethods.Default.compareintforDB(updateObject.Address_AID1);
					sqlCount++;
					query += " WHERE SID = " + updateObject.SID;
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

	public bool UpdateWot(OBJstore updateObject) 
	{
		try
		{
			if (updateObject.IsFiltered)
			{
				string query = "UPDATE store SET ";
				string queryWhere = "";
				bool counter = false;
				foreach (FilteredItems filtereditems in updateObject.FilterList)
				{
					if (filtereditems.FilterAttribute == "SID")
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
				if (updateObject.SID != 0)
				{
					string query = "UPDATE store SET ";
					int sqlCount = 0;
					query += (sqlCount > 0 ? ", " : "");
					query += "SName" + GeneralMethods.Default.comparestringforDB(updateObject.SName);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "Address_AID1" + GeneralMethods.Default.compareintforDB(updateObject.Address_AID1);
					sqlCount++;
					query += " WHERE SID = " + updateObject.SID;
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

	public bool Update(List<OBJstore> listupdateObject)
	{
	bool ret = false;
	 foreach(OBJstore updateObject in listupdateObject)
	{
		try
		{
			if (updateObject.IsFiltered)
			{
				string query = "UPDATE store SET ";
				string queryWhere = "";
				bool counter = false;
				foreach (FilteredItems filtereditems in updateObject.FilterList)
				{
					if (filtereditems.FilterAttribute == "SID")
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
				if (updateObject.SID != 0)
				{
					string query = "UPDATE store SET ";
					int sqlCount = 0;
					query += (sqlCount > 0 ? ", " : "");
					query += "SName" + GeneralMethods.Default.comparestringforDB(updateObject.SName);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "Address_AID1" + GeneralMethods.Default.compareintforDB(updateObject.Address_AID1);
					sqlCount++;
					query += " WHERE SID = " + updateObject.SID;
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

	public bool Delete(int SID)
	{
		try
		{
			string query= "DELETE FROM store WHERE SID = " + SID;
			return DAL.Default.Execute(query);
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}

	public bool Delete(OBJstore deleteObject)
	{
		try
		{
			List<OBJstore> objList = this.Select(deleteObject);
			foreach (OBJstore obj_OBJstore in objList)
				this.Delete(obj_OBJstore.SID);
			return true;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}

	public bool Delete(List<OBJstore> listdeleteObject)
	{
	bool ret = false;
	foreach(OBJstore deleteObject in listdeleteObject)
		{
		try
		{
			List<OBJstore> objList = this.Select(deleteObject);
			foreach (OBJstore obj_OBJstore in objList)
				this.Delete(obj_OBJstore.SID);
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
