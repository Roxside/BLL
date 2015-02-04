using System;
using System.Collections.Generic;
using System.Data;

/// <summary>
/// Generated Class for Table : BLLstorageproduct.
/// </summary>

public class BLLstorageproduct
{
	private static BLLstorageproduct defaultInstance = new BLLstorageproduct();

	public static BLLstorageproduct Default 
	{
		get { return defaultInstance; }
	}

	public BLLstorageproduct()
	{

	}

	public List<OBJstorageproduct> Select()
	{
		try
		{
			string query = "SELECT * FROM storageproduct";
			DataTable dt = DAL.Default.Select(query);
			List<OBJstorageproduct> ObjList = new List<OBJstorageproduct>();
			foreach (DataRow dr in dt.Rows)
			{
				OBJstorageproduct obj_OBJstorageproduct = new OBJstorageproduct();
				obj_OBJstorageproduct.STPID = Convert.ToInt32(dr["STPID"]);
				obj_OBJstorageproduct.STPQuantity = (dr["STPQuantity"]).ToString();
				obj_OBJstorageproduct.ProductDetails_PID = Convert.ToInt32(dr["ProductDetails_PID"]);
				obj_OBJstorageproduct.Storage_STID = Convert.ToInt32(dr["Storage_STID"]);
				ObjList.Add(obj_OBJstorageproduct);
			}
			return ObjList;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJstorageproduct> Select(string orderby, string orderparam)
	{
		try
		{
			string query = "SELECT * FROM storageproduct ORDER BY " + orderby + " " + orderparam;
			DataTable dt = DAL.Default.Select(query);
			List<OBJstorageproduct> ObjList = new List<OBJstorageproduct>();
			foreach (DataRow dr in dt.Rows)
			{
				OBJstorageproduct obj_OBJstorageproduct = new OBJstorageproduct();
				obj_OBJstorageproduct.STPID = Convert.ToInt32(dr["STPID"]);
				obj_OBJstorageproduct.STPQuantity = (dr["STPQuantity"]).ToString();
				obj_OBJstorageproduct.ProductDetails_PID = Convert.ToInt32(dr["ProductDetails_PID"]);
				obj_OBJstorageproduct.Storage_STID = Convert.ToInt32(dr["Storage_STID"]);
				ObjList.Add(obj_OBJstorageproduct);
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
			string query = "SELECT * FROM storageproduct";
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
			string query = "SELECT * FROM storageproduct ORDER BY " + orderby + " " + orderparam;
			return DAL.Default.Select(query);
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public OBJstorageproduct Select(int STPID)
	{
		try
		{
			string query = "SELECT * FROM storageproduct WHERE STPID = " + STPID;
			DataTable dt = DAL.Default.Select(query);
			OBJstorageproduct obj_OBJstorageproduct = new OBJstorageproduct();
			DataRow dr = dt.Rows[0];
			obj_OBJstorageproduct.STPID = Convert.ToInt32(dr["STPID"]);
			obj_OBJstorageproduct.STPQuantity = (dr["STPQuantity"]).ToString();
			obj_OBJstorageproduct.ProductDetails_PID = Convert.ToInt32(dr["ProductDetails_PID"]);
			obj_OBJstorageproduct.Storage_STID = Convert.ToInt32(dr["Storage_STID"]);
			return obj_OBJstorageproduct;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJstorageproduct> Select(string nextPart)
	{
		try
		{
			string query = "SELECT * FROM storageproduct WHERE " + nextPart;
			DataTable dt = DAL.Default.Select(query);
			List<OBJstorageproduct> ObjList = new List<OBJstorageproduct>();
			foreach (DataRow dr in dt.Rows)
			{
				OBJstorageproduct obj_OBJstorageproduct = new OBJstorageproduct();
				obj_OBJstorageproduct.STPID = Convert.ToInt32(dr["STPID"]);
				obj_OBJstorageproduct.STPQuantity = (dr["STPQuantity"]).ToString();
				obj_OBJstorageproduct.ProductDetails_PID = Convert.ToInt32(dr["ProductDetails_PID"]);
				obj_OBJstorageproduct.Storage_STID = Convert.ToInt32(dr["Storage_STID"]);
				ObjList.Add(obj_OBJstorageproduct);
			}
			return ObjList;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJstorageproduct> Select(OBJstorageproduct obj_OBJstorageproduct)
	{
		try
		{
			if (obj_OBJstorageproduct.IsFiltered)
			{
				string nextPart = "";
				foreach (FilteredItems filtereditems in obj_OBJstorageproduct.FilterList)
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

	public List<OBJstorageproduct> Select(OBJstorageproduct obj_OBJstorageproduct, string orderby, string orderparam)
	{
		try
		{
			if (obj_OBJstorageproduct.IsFiltered)
			{
				string nextPart = "";
				foreach (FilteredItems filtereditems in obj_OBJstorageproduct.FilterList)
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

	public List<OBJstorageproduct> Select(List<OBJstorageproduct> list_obj_OBJstorageproduct)
	{
		try
		{
			string nextPart = "";
			foreach (OBJstorageproduct obj_OBJstorageproduct in list_obj_OBJstorageproduct)
			{
				if (obj_OBJstorageproduct.IsFiltered)
				{
					nextPart += (nextPart.Length > 0 ? " OR " : "") + "(";
					foreach (FilteredItems filtereditems in obj_OBJstorageproduct.FilterList)
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

	public List<OBJstorageproduct> Select(List<OBJstorageproduct> list_obj_OBJstorageproduct, string orderby, string orderparam)
	{
		try
		{
			string nextPart = "";
			foreach (OBJstorageproduct obj_OBJstorageproduct in list_obj_OBJstorageproduct)
			{
				if (obj_OBJstorageproduct.IsFiltered)
				{
					nextPart += (nextPart.Length > 0 ? " OR " : "") + "(";
					foreach (FilteredItems filtereditems in obj_OBJstorageproduct.FilterList)
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

	public bool Insert(OBJstorageproduct obj_OBJstorageproduct)
	{
		try
		{
			string query = "INSERT INTO storageproduct (STPQuantity, ProductDetails_PID, Storage_STID) VALUES ("
							+ (obj_OBJstorageproduct.STPQuantity == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJstorageproduct.STPQuantity) + "'")
							+ ", " + (obj_OBJstorageproduct.ProductDetails_PID == 0 ? "0" : "'" + obj_OBJstorageproduct.ProductDetails_PID + "'")
							+ ", " + (obj_OBJstorageproduct.Storage_STID == 0 ? "0" : "'" + obj_OBJstorageproduct.Storage_STID + "'") + ")";
			DAL.Default.Execute(query);
			return true;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}

	public bool Insert(List<OBJstorageproduct> listobj_OBJstorageproduct)
	{
	bool ret = false;
	 foreach(OBJstorageproduct obj_OBJstorageproduct in listobj_OBJstorageproduct)
	{
		try
		{
			string query = "INSERT INTO storageproduct (STPQuantity, ProductDetails_PID, Storage_STID) VALUES ("
							+ (obj_OBJstorageproduct.STPQuantity == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJstorageproduct.STPQuantity) + "'")
							+ ", " + (obj_OBJstorageproduct.ProductDetails_PID == 0 ? "0" : "'" + obj_OBJstorageproduct.ProductDetails_PID + "'")
							+ ", " + (obj_OBJstorageproduct.Storage_STID == 0 ? "0" : "'" + obj_OBJstorageproduct.Storage_STID + "'") + ")"
							
							
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

	public OBJstorageproduct Insert_Return(OBJstorageproduct obj_OBJstorageproduct)
	{
		try
		{
			string query = "INSERT INTO storageproduct (STPQuantity, ProductDetails_PID, Storage_STID) VALUES ("
							+ (obj_OBJstorageproduct.STPQuantity == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJstorageproduct.STPQuantity) + "'")
							+ ", " + (obj_OBJstorageproduct.ProductDetails_PID == 0 ? "0" : "'" + obj_OBJstorageproduct.ProductDetails_PID + "'")
							+ ", " + (obj_OBJstorageproduct.Storage_STID == 0 ? "0" : "'" + obj_OBJstorageproduct.Storage_STID + "'") + ")"
							
							
							
							+ "; SELECT STPID FROM storageproduct ORDER BY STPID DESC LIMIT 1";
			DataTable dt= DAL.Default.Select(query);
			DataRow dr = dt.Rows[0];
			obj_OBJstorageproduct.STPID = Convert.ToInt32(dr["STPID"]);
			return obj_OBJstorageproduct;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public bool Update(OBJstorageproduct updateObject) 
	{
		try
		{
			if (updateObject.IsFiltered)
			{
				string query = "UPDATE storageproduct SET ";
				string queryWhere = "";
				bool counter = false;
				foreach (FilteredItems filtereditems in updateObject.FilterList)
				{
					if (filtereditems.FilterAttribute == "STPID")
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
				if (updateObject.STPID != 0)
				{
					string query = "UPDATE storageproduct SET ";
					int sqlCount = 0;
					query += (sqlCount > 0 ? ", " : "");
					query += "STPQuantity" + GeneralMethods.Default.comparestringforDB(updateObject.STPQuantity);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "ProductDetails_PID" + GeneralMethods.Default.compareintforDB(updateObject.ProductDetails_PID);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "Storage_STID" + GeneralMethods.Default.compareintforDB(updateObject.Storage_STID);
					sqlCount++;
					query += " WHERE STPID = " + updateObject.STPID;
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

	public bool UpdateWot(OBJstorageproduct updateObject) 
	{
		try
		{
			if (updateObject.IsFiltered)
			{
				string query = "UPDATE storageproduct SET ";
				string queryWhere = "";
				bool counter = false;
				foreach (FilteredItems filtereditems in updateObject.FilterList)
				{
					if (filtereditems.FilterAttribute == "STPID")
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
				if (updateObject.STPID != 0)
				{
					string query = "UPDATE storageproduct SET ";
					int sqlCount = 0;
					query += (sqlCount > 0 ? ", " : "");
					query += "STPQuantity" + GeneralMethods.Default.comparestringforDB(updateObject.STPQuantity);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "ProductDetails_PID" + GeneralMethods.Default.compareintforDB(updateObject.ProductDetails_PID);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "Storage_STID" + GeneralMethods.Default.compareintforDB(updateObject.Storage_STID);
					sqlCount++;
					query += " WHERE STPID = " + updateObject.STPID;
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

	public bool Update(List<OBJstorageproduct> listupdateObject)
	{
	bool ret = false;
	 foreach(OBJstorageproduct updateObject in listupdateObject)
	{
		try
		{
			if (updateObject.IsFiltered)
			{
				string query = "UPDATE storageproduct SET ";
				string queryWhere = "";
				bool counter = false;
				foreach (FilteredItems filtereditems in updateObject.FilterList)
				{
					if (filtereditems.FilterAttribute == "STPID")
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
				if (updateObject.STPID != 0)
				{
					string query = "UPDATE storageproduct SET ";
					int sqlCount = 0;
					query += (sqlCount > 0 ? ", " : "");
					query += "STPQuantity" + GeneralMethods.Default.comparestringforDB(updateObject.STPQuantity);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "ProductDetails_PID" + GeneralMethods.Default.compareintforDB(updateObject.ProductDetails_PID);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "Storage_STID" + GeneralMethods.Default.compareintforDB(updateObject.Storage_STID);
					sqlCount++;
					query += " WHERE STPID = " + updateObject.STPID;
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

	public bool Delete(int STPID)
	{
		try
		{
			string query= "DELETE FROM storageproduct WHERE STPID = " + STPID;
			return DAL.Default.Execute(query);
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}

	public bool Delete(OBJstorageproduct deleteObject)
	{
		try
		{
			List<OBJstorageproduct> objList = this.Select(deleteObject);
			foreach (OBJstorageproduct obj_OBJstorageproduct in objList)
				this.Delete(obj_OBJstorageproduct.STPID);
			return true;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}

	public bool Delete(List<OBJstorageproduct> listdeleteObject)
	{
	bool ret = false;
	foreach(OBJstorageproduct deleteObject in listdeleteObject)
		{
		try
		{
			List<OBJstorageproduct> objList = this.Select(deleteObject);
			foreach (OBJstorageproduct obj_OBJstorageproduct in objList)
				this.Delete(obj_OBJstorageproduct.STPID);
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
