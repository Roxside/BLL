using System;
using System.Collections.Generic;
using System.Data;

/// <summary>
/// Generated Class for Table : BLLstoredemandlist.
/// </summary>

public class BLLstoredemandlist
{
	private static BLLstoredemandlist defaultInstance = new BLLstoredemandlist();

	public static BLLstoredemandlist Default 
	{
		get { return defaultInstance; }
	}

	public BLLstoredemandlist()
	{

	}

	public List<OBJstoredemandlist> Select()
	{
		try
		{
			string query = "SELECT * FROM storedemandlist";
			DataTable dt = DAL.Default.Select(query);
			List<OBJstoredemandlist> ObjList = new List<OBJstoredemandlist>();
			foreach (DataRow dr in dt.Rows)
			{
				OBJstoredemandlist obj_OBJstoredemandlist = new OBJstoredemandlist();
				obj_OBJstoredemandlist.SDID = Convert.ToInt32(dr["SDID"]);
				obj_OBJstoredemandlist.Quantity = String.IsNullOrEmpty((dr["Quantity"]).ToString()) ? null : (int?)(dr["Quantity"]);
				obj_OBJstoredemandlist.Date = String.IsNullOrEmpty((dr["Date"]).ToString()) ? null : (DateTime?)(dr["Date"]);
				obj_OBJstoredemandlist.Active = (dr["Active"]).ToString();
				obj_OBJstoredemandlist.BranchStoreManagers_BSMID = Convert.ToInt32(dr["BranchStoreManagers_BSMID"]);
				obj_OBJstoredemandlist.Shelf_SHEID = Convert.ToInt32(dr["Shelf_SHEID"]);
				obj_OBJstoredemandlist.ProductDetails_PID = Convert.ToInt32(dr["ProductDetails_PID"]);
				ObjList.Add(obj_OBJstoredemandlist);
			}
			return ObjList;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJstoredemandlist> Select(string orderby, string orderparam)
	{
		try
		{
			string query = "SELECT * FROM storedemandlist ORDER BY " + orderby + " " + orderparam;
			DataTable dt = DAL.Default.Select(query);
			List<OBJstoredemandlist> ObjList = new List<OBJstoredemandlist>();
			foreach (DataRow dr in dt.Rows)
			{
				OBJstoredemandlist obj_OBJstoredemandlist = new OBJstoredemandlist();
				obj_OBJstoredemandlist.SDID = Convert.ToInt32(dr["SDID"]);
				obj_OBJstoredemandlist.Quantity = String.IsNullOrEmpty((dr["Quantity"]).ToString()) ? null : (int?)(dr["Quantity"]);
				obj_OBJstoredemandlist.Date = String.IsNullOrEmpty((dr["Date"]).ToString()) ? null : (DateTime?)(dr["Date"]);
				obj_OBJstoredemandlist.Active = (dr["Active"]).ToString();
				obj_OBJstoredemandlist.BranchStoreManagers_BSMID = Convert.ToInt32(dr["BranchStoreManagers_BSMID"]);
				obj_OBJstoredemandlist.Shelf_SHEID = Convert.ToInt32(dr["Shelf_SHEID"]);
				obj_OBJstoredemandlist.ProductDetails_PID = Convert.ToInt32(dr["ProductDetails_PID"]);
				ObjList.Add(obj_OBJstoredemandlist);
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
			string query = "SELECT * FROM storedemandlist";
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
			string query = "SELECT * FROM storedemandlist ORDER BY " + orderby + " " + orderparam;
			return DAL.Default.Select(query);
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public OBJstoredemandlist Select(int SDID)
	{
		try
		{
			string query = "SELECT * FROM storedemandlist WHERE SDID = " + SDID;
			DataTable dt = DAL.Default.Select(query);
			OBJstoredemandlist obj_OBJstoredemandlist = new OBJstoredemandlist();
			DataRow dr = dt.Rows[0];
			obj_OBJstoredemandlist.SDID = Convert.ToInt32(dr["SDID"]);
			obj_OBJstoredemandlist.Quantity = String.IsNullOrEmpty((dr["Quantity"]).ToString()) ? null : (int?)(dr["Quantity"]);
			obj_OBJstoredemandlist.Date = String.IsNullOrEmpty((dr["Date"]).ToString()) ? null : (DateTime?)(dr["Date"]);
			obj_OBJstoredemandlist.Active = (dr["Active"]).ToString();
			obj_OBJstoredemandlist.BranchStoreManagers_BSMID = Convert.ToInt32(dr["BranchStoreManagers_BSMID"]);
			obj_OBJstoredemandlist.Shelf_SHEID = Convert.ToInt32(dr["Shelf_SHEID"]);
			obj_OBJstoredemandlist.ProductDetails_PID = Convert.ToInt32(dr["ProductDetails_PID"]);
			return obj_OBJstoredemandlist;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJstoredemandlist> Select(string nextPart)
	{
		try
		{
			string query = "SELECT * FROM storedemandlist WHERE " + nextPart;
			DataTable dt = DAL.Default.Select(query);
			List<OBJstoredemandlist> ObjList = new List<OBJstoredemandlist>();
			foreach (DataRow dr in dt.Rows)
			{
				OBJstoredemandlist obj_OBJstoredemandlist = new OBJstoredemandlist();
				obj_OBJstoredemandlist.SDID = Convert.ToInt32(dr["SDID"]);
				obj_OBJstoredemandlist.Quantity = String.IsNullOrEmpty((dr["Quantity"]).ToString()) ? null : (int?)(dr["Quantity"]);
				obj_OBJstoredemandlist.Date = String.IsNullOrEmpty((dr["Date"]).ToString()) ? null : (DateTime?)(dr["Date"]);
				obj_OBJstoredemandlist.Active = (dr["Active"]).ToString();
				obj_OBJstoredemandlist.BranchStoreManagers_BSMID = Convert.ToInt32(dr["BranchStoreManagers_BSMID"]);
				obj_OBJstoredemandlist.Shelf_SHEID = Convert.ToInt32(dr["Shelf_SHEID"]);
				obj_OBJstoredemandlist.ProductDetails_PID = Convert.ToInt32(dr["ProductDetails_PID"]);
				ObjList.Add(obj_OBJstoredemandlist);
			}
			return ObjList;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJstoredemandlist> Select(OBJstoredemandlist obj_OBJstoredemandlist)
	{
		try
		{
			if (obj_OBJstoredemandlist.IsFiltered)
			{
				string nextPart = "";
				foreach (FilteredItems filtereditems in obj_OBJstoredemandlist.FilterList)
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

	public List<OBJstoredemandlist> Select(OBJstoredemandlist obj_OBJstoredemandlist, string orderby, string orderparam)
	{
		try
		{
			if (obj_OBJstoredemandlist.IsFiltered)
			{
				string nextPart = "";
				foreach (FilteredItems filtereditems in obj_OBJstoredemandlist.FilterList)
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

	public List<OBJstoredemandlist> Select(List<OBJstoredemandlist> list_obj_OBJstoredemandlist)
	{
		try
		{
			string nextPart = "";
			foreach (OBJstoredemandlist obj_OBJstoredemandlist in list_obj_OBJstoredemandlist)
			{
				if (obj_OBJstoredemandlist.IsFiltered)
				{
					nextPart += (nextPart.Length > 0 ? " OR " : "") + "(";
					foreach (FilteredItems filtereditems in obj_OBJstoredemandlist.FilterList)
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

	public List<OBJstoredemandlist> Select(List<OBJstoredemandlist> list_obj_OBJstoredemandlist, string orderby, string orderparam)
	{
		try
		{
			string nextPart = "";
			foreach (OBJstoredemandlist obj_OBJstoredemandlist in list_obj_OBJstoredemandlist)
			{
				if (obj_OBJstoredemandlist.IsFiltered)
				{
					nextPart += (nextPart.Length > 0 ? " OR " : "") + "(";
					foreach (FilteredItems filtereditems in obj_OBJstoredemandlist.FilterList)
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

	public bool Insert(OBJstoredemandlist obj_OBJstoredemandlist)
	{
		try
		{
			string query = "INSERT INTO storedemandlist (Quantity, Date, Active, BranchStoreManagers_BSMID, Shelf_SHEID, ProductDetails_PID) VALUES ("
							+ (obj_OBJstoredemandlist.Quantity == null ? "null" : "'" + obj_OBJstoredemandlist.Quantity + "'")
							+ ", " + (obj_OBJstoredemandlist.Date == null ? "null" : "'" + String.Format("{0:yyyy-MM-dd}", obj_OBJstoredemandlist.Date) + "'")
							+ ", " + (obj_OBJstoredemandlist.Active == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJstoredemandlist.Active) + "'")
							+ ", " + (obj_OBJstoredemandlist.BranchStoreManagers_BSMID == 0 ? "0" : "'" + obj_OBJstoredemandlist.BranchStoreManagers_BSMID + "'")
							+ ", " + (obj_OBJstoredemandlist.Shelf_SHEID == 0 ? "0" : "'" + obj_OBJstoredemandlist.Shelf_SHEID + "'")
							+ ", " + (obj_OBJstoredemandlist.ProductDetails_PID == 0 ? "0" : "'" + obj_OBJstoredemandlist.ProductDetails_PID + "'") + ")";
			DAL.Default.Execute(query);
			return true;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}

	public bool Insert(List<OBJstoredemandlist> listobj_OBJstoredemandlist)
	{
	bool ret = false;
	 foreach(OBJstoredemandlist obj_OBJstoredemandlist in listobj_OBJstoredemandlist)
	{
		try
		{
			string query = "INSERT INTO storedemandlist (Quantity, Date, Active, BranchStoreManagers_BSMID, Shelf_SHEID, ProductDetails_PID) VALUES ("
							+ (obj_OBJstoredemandlist.Quantity == null ? "null" : "'" + obj_OBJstoredemandlist.Quantity + "'")
							+ ", " + (obj_OBJstoredemandlist.Date == null ? "null" : "'" + String.Format("{0:yyyy-MM-dd}", obj_OBJstoredemandlist.Date) + "'")
							+ ", " + (obj_OBJstoredemandlist.Active == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJstoredemandlist.Active) + "'")
							+ ", " + (obj_OBJstoredemandlist.BranchStoreManagers_BSMID == 0 ? "0" : "'" + obj_OBJstoredemandlist.BranchStoreManagers_BSMID + "'")
							+ ", " + (obj_OBJstoredemandlist.Shelf_SHEID == 0 ? "0" : "'" + obj_OBJstoredemandlist.Shelf_SHEID + "'")
							+ ", " + (obj_OBJstoredemandlist.ProductDetails_PID == 0 ? "0" : "'" + obj_OBJstoredemandlist.ProductDetails_PID + "'") + ")"
							
							
							
							
							
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

	public OBJstoredemandlist Insert_Return(OBJstoredemandlist obj_OBJstoredemandlist)
	{
		try
		{
			string query = "INSERT INTO storedemandlist (Quantity, Date, Active, BranchStoreManagers_BSMID, Shelf_SHEID, ProductDetails_PID) VALUES ("
							+ (obj_OBJstoredemandlist.Quantity == null ? "null" : "'" + obj_OBJstoredemandlist.Quantity + "'")
							+ ", " + (obj_OBJstoredemandlist.Date == null ? "null" : "'" + String.Format("{0:yyyy-MM-dd}", obj_OBJstoredemandlist.Date) + "'")
							+ ", " + (obj_OBJstoredemandlist.Active == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJstoredemandlist.Active) + "'")
							+ ", " + (obj_OBJstoredemandlist.BranchStoreManagers_BSMID == 0 ? "0" : "'" + obj_OBJstoredemandlist.BranchStoreManagers_BSMID + "'")
							+ ", " + (obj_OBJstoredemandlist.Shelf_SHEID == 0 ? "0" : "'" + obj_OBJstoredemandlist.Shelf_SHEID + "'")
							+ ", " + (obj_OBJstoredemandlist.ProductDetails_PID == 0 ? "0" : "'" + obj_OBJstoredemandlist.ProductDetails_PID + "'") + ")"
							
							
							
							
							
							
							+ "; SELECT SDID FROM storedemandlist ORDER BY SDID DESC LIMIT 1";
			DataTable dt= DAL.Default.Select(query);
			DataRow dr = dt.Rows[0];
			obj_OBJstoredemandlist.SDID = Convert.ToInt32(dr["SDID"]);
			return obj_OBJstoredemandlist;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public bool Update(OBJstoredemandlist updateObject) 
	{
		try
		{
			if (updateObject.IsFiltered)
			{
				string query = "UPDATE storedemandlist SET ";
				string queryWhere = "";
				bool counter = false;
				foreach (FilteredItems filtereditems in updateObject.FilterList)
				{
					if (filtereditems.FilterAttribute == "SDID")
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
				if (updateObject.SDID != 0)
				{
					string query = "UPDATE storedemandlist SET ";
					int sqlCount = 0;
					if (updateObject.Quantity.HasValue)
					{
						query += (sqlCount > 0 ? ", " : "");
						query += "Quantity" + GeneralMethods.Default.compareintforDB(updateObject.Quantity.Value);
						sqlCount++;
					}
					if (updateObject.Date.HasValue)
					{
						query += (sqlCount > 0 ? ", " : "");
						query += "Date" + " = '" + String.Format("{0:yyyy-MM-dd}", updateObject.Date.Value) + "'";
						sqlCount++;
					}
					query += (sqlCount > 0 ? ", " : "");
					query += "Active" + GeneralMethods.Default.comparestringforDB(updateObject.Active);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "BranchStoreManagers_BSMID" + GeneralMethods.Default.compareintforDB(updateObject.BranchStoreManagers_BSMID);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "Shelf_SHEID" + GeneralMethods.Default.compareintforDB(updateObject.Shelf_SHEID);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "ProductDetails_PID" + GeneralMethods.Default.compareintforDB(updateObject.ProductDetails_PID);
					sqlCount++;
					query += " WHERE SDID = " + updateObject.SDID;
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

	public bool UpdateWot(OBJstoredemandlist updateObject) 
	{
		try
		{
			if (updateObject.IsFiltered)
			{
				string query = "UPDATE storedemandlist SET ";
				string queryWhere = "";
				bool counter = false;
				foreach (FilteredItems filtereditems in updateObject.FilterList)
				{
					if (filtereditems.FilterAttribute == "SDID")
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
				if (updateObject.SDID != 0)
				{
					string query = "UPDATE storedemandlist SET ";
					int sqlCount = 0;
					if (updateObject.Quantity.HasValue)
					{
						query += (sqlCount > 0 ? ", " : "");
						query += "Quantity" + GeneralMethods.Default.compareintforDB(updateObject.Quantity.Value);
						sqlCount++;
					}
					if (updateObject.Date.HasValue)
					{
						query += (sqlCount > 0 ? ", " : "");
						query += "Date" + " = '" + String.Format("{0:yyyy-MM-dd}", updateObject.Date.Value) + "'";
						sqlCount++;
					}
					query += (sqlCount > 0 ? ", " : "");
					query += "Active" + GeneralMethods.Default.comparestringforDB(updateObject.Active);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "BranchStoreManagers_BSMID" + GeneralMethods.Default.compareintforDB(updateObject.BranchStoreManagers_BSMID);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "Shelf_SHEID" + GeneralMethods.Default.compareintforDB(updateObject.Shelf_SHEID);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "ProductDetails_PID" + GeneralMethods.Default.compareintforDB(updateObject.ProductDetails_PID);
					sqlCount++;
					query += " WHERE SDID = " + updateObject.SDID;
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

	public bool Update(List<OBJstoredemandlist> listupdateObject)
	{
	bool ret = false;
	 foreach(OBJstoredemandlist updateObject in listupdateObject)
	{
		try
		{
			if (updateObject.IsFiltered)
			{
				string query = "UPDATE storedemandlist SET ";
				string queryWhere = "";
				bool counter = false;
				foreach (FilteredItems filtereditems in updateObject.FilterList)
				{
					if (filtereditems.FilterAttribute == "SDID")
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
				if (updateObject.SDID != 0)
				{
					string query = "UPDATE storedemandlist SET ";
					int sqlCount = 0;
					if (updateObject.Quantity.HasValue)
					{
						query += (sqlCount > 0 ? ", " : "");
						query += "Quantity" + GeneralMethods.Default.compareintforDB(updateObject.Quantity.Value);
						sqlCount++;
					}
					if (updateObject.Date.HasValue)
					{
						query += (sqlCount > 0 ? ", " : "");
						query += "Date" + " = '" + String.Format("{0:yyyy-MM-dd}", updateObject.Date.Value) + "'";
						sqlCount++;
					}
					query += (sqlCount > 0 ? ", " : "");
					query += "Active" + GeneralMethods.Default.comparestringforDB(updateObject.Active);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "BranchStoreManagers_BSMID" + GeneralMethods.Default.compareintforDB(updateObject.BranchStoreManagers_BSMID);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "Shelf_SHEID" + GeneralMethods.Default.compareintforDB(updateObject.Shelf_SHEID);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "ProductDetails_PID" + GeneralMethods.Default.compareintforDB(updateObject.ProductDetails_PID);
					sqlCount++;
					query += " WHERE SDID = " + updateObject.SDID;
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

	public bool Delete(int SDID)
	{
		try
		{
			string query= "DELETE FROM storedemandlist WHERE SDID = " + SDID;
			return DAL.Default.Execute(query);
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}

	public bool Delete(OBJstoredemandlist deleteObject)
	{
		try
		{
			List<OBJstoredemandlist> objList = this.Select(deleteObject);
			foreach (OBJstoredemandlist obj_OBJstoredemandlist in objList)
				this.Delete(obj_OBJstoredemandlist.SDID);
			return true;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}

	public bool Delete(List<OBJstoredemandlist> listdeleteObject)
	{
	bool ret = false;
	foreach(OBJstoredemandlist deleteObject in listdeleteObject)
		{
		try
		{
			List<OBJstoredemandlist> objList = this.Select(deleteObject);
			foreach (OBJstoredemandlist obj_OBJstoredemandlist in objList)
				this.Delete(obj_OBJstoredemandlist.SDID);
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
