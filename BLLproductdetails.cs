using System;
using System.Collections.Generic;
using System.Data;

/// <summary>
/// Generated Class for Table : BLLproductdetails.
/// </summary>

public class BLLproductdetails
{
	private static BLLproductdetails defaultInstance = new BLLproductdetails();

	public static BLLproductdetails Default 
	{
		get { return defaultInstance; }
	}

	public BLLproductdetails()
	{

	}

	public List<OBJproductdetails> Select()
	{
		try
		{
			string query = "SELECT * FROM productdetails";
			DataTable dt = DAL.Default.Select(query);
			List<OBJproductdetails> ObjList = new List<OBJproductdetails>();
			foreach (DataRow dr in dt.Rows)
			{
				OBJproductdetails obj_OBJproductdetails = new OBJproductdetails();
				obj_OBJproductdetails.PID = Convert.ToInt32(dr["PID"]);
				obj_OBJproductdetails.PNAME = (dr["PNAME"]).ToString();
				obj_OBJproductdetails.Tax = String.IsNullOrEmpty((dr["Tax"]).ToString()) ? null : (double?)(dr["Tax"]);
				obj_OBJproductdetails.Description = (dr["Description"]).ToString();
				obj_OBJproductdetails.UnitPrice = (dr["UnitPrice"]).ToString();
				obj_OBJproductdetails.Category_CID = Convert.ToInt32(dr["Category_CID"]);
				ObjList.Add(obj_OBJproductdetails);
			}
			return ObjList;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJproductdetails> Select(string orderby, string orderparam)
	{
		try
		{
			string query = "SELECT * FROM productdetails ORDER BY " + orderby + " " + orderparam;
			DataTable dt = DAL.Default.Select(query);
			List<OBJproductdetails> ObjList = new List<OBJproductdetails>();
			foreach (DataRow dr in dt.Rows)
			{
				OBJproductdetails obj_OBJproductdetails = new OBJproductdetails();
				obj_OBJproductdetails.PID = Convert.ToInt32(dr["PID"]);
				obj_OBJproductdetails.PNAME = (dr["PNAME"]).ToString();
				obj_OBJproductdetails.Tax = String.IsNullOrEmpty((dr["Tax"]).ToString()) ? null : (double?)(dr["Tax"]);
				obj_OBJproductdetails.Description = (dr["Description"]).ToString();
				obj_OBJproductdetails.UnitPrice = (dr["UnitPrice"]).ToString();
				obj_OBJproductdetails.Category_CID = Convert.ToInt32(dr["Category_CID"]);
				ObjList.Add(obj_OBJproductdetails);
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
			string query = "SELECT * FROM productdetails";
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
			string query = "SELECT * FROM productdetails ORDER BY " + orderby + " " + orderparam;
			return DAL.Default.Select(query);
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public OBJproductdetails Select(int PID)
	{
		try
		{
			string query = "SELECT * FROM productdetails WHERE PID = " + PID;
			DataTable dt = DAL.Default.Select(query);
			OBJproductdetails obj_OBJproductdetails = new OBJproductdetails();
			DataRow dr = dt.Rows[0];
			obj_OBJproductdetails.PID = Convert.ToInt32(dr["PID"]);
			obj_OBJproductdetails.PNAME = (dr["PNAME"]).ToString();
			obj_OBJproductdetails.Tax = String.IsNullOrEmpty((dr["Tax"]).ToString()) ? null : (double?)(dr["Tax"]);
			obj_OBJproductdetails.Description = (dr["Description"]).ToString();
			obj_OBJproductdetails.UnitPrice = (dr["UnitPrice"]).ToString();
			obj_OBJproductdetails.Category_CID = Convert.ToInt32(dr["Category_CID"]);
			return obj_OBJproductdetails;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJproductdetails> Select(string nextPart)
	{
		try
		{
			string query = "SELECT * FROM productdetails WHERE " + nextPart;
			DataTable dt = DAL.Default.Select(query);
			List<OBJproductdetails> ObjList = new List<OBJproductdetails>();
			foreach (DataRow dr in dt.Rows)
			{
				OBJproductdetails obj_OBJproductdetails = new OBJproductdetails();
				obj_OBJproductdetails.PID = Convert.ToInt32(dr["PID"]);
				obj_OBJproductdetails.PNAME = (dr["PNAME"]).ToString();
				obj_OBJproductdetails.Tax = String.IsNullOrEmpty((dr["Tax"]).ToString()) ? null : (double?)(dr["Tax"]);
				obj_OBJproductdetails.Description = (dr["Description"]).ToString();
				obj_OBJproductdetails.UnitPrice = (dr["UnitPrice"]).ToString();
				obj_OBJproductdetails.Category_CID = Convert.ToInt32(dr["Category_CID"]);
				ObjList.Add(obj_OBJproductdetails);
			}
			return ObjList;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public List<OBJproductdetails> Select(OBJproductdetails obj_OBJproductdetails)
	{
		try
		{
			if (obj_OBJproductdetails.IsFiltered)
			{
				string nextPart = "";
				foreach (FilteredItems filtereditems in obj_OBJproductdetails.FilterList)
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

	public List<OBJproductdetails> Select(OBJproductdetails obj_OBJproductdetails, string orderby, string orderparam)
	{
		try
		{
			if (obj_OBJproductdetails.IsFiltered)
			{
				string nextPart = "";
				foreach (FilteredItems filtereditems in obj_OBJproductdetails.FilterList)
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

	public List<OBJproductdetails> Select(List<OBJproductdetails> list_obj_OBJproductdetails)
	{
		try
		{
			string nextPart = "";
			foreach (OBJproductdetails obj_OBJproductdetails in list_obj_OBJproductdetails)
			{
				if (obj_OBJproductdetails.IsFiltered)
				{
					nextPart += (nextPart.Length > 0 ? " OR " : "") + "(";
					foreach (FilteredItems filtereditems in obj_OBJproductdetails.FilterList)
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

	public List<OBJproductdetails> Select(List<OBJproductdetails> list_obj_OBJproductdetails, string orderby, string orderparam)
	{
		try
		{
			string nextPart = "";
			foreach (OBJproductdetails obj_OBJproductdetails in list_obj_OBJproductdetails)
			{
				if (obj_OBJproductdetails.IsFiltered)
				{
					nextPart += (nextPart.Length > 0 ? " OR " : "") + "(";
					foreach (FilteredItems filtereditems in obj_OBJproductdetails.FilterList)
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

	public bool Insert(OBJproductdetails obj_OBJproductdetails)
	{
		try
		{
			string query = "INSERT INTO productdetails (PNAME, Tax, Description, UnitPrice, Category_CID) VALUES ("
							+ (obj_OBJproductdetails.PNAME == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJproductdetails.PNAME) + "'")
							+ ", " + (obj_OBJproductdetails.Tax == null ? "null" : "'" + GeneralMethods.Default.doubleforDB(obj_OBJproductdetails.Tax.Value.ToString()) + "'")
							+ ", " + (obj_OBJproductdetails.Description == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJproductdetails.Description) + "'")
							+ ", " + (obj_OBJproductdetails.UnitPrice == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJproductdetails.UnitPrice) + "'")
							+ ", " + (obj_OBJproductdetails.Category_CID == 0 ? "0" : "'" + obj_OBJproductdetails.Category_CID + "'") + ")";
			DAL.Default.Execute(query);
			return true;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}

	public bool Insert(List<OBJproductdetails> listobj_OBJproductdetails)
	{
	bool ret = false;
	 foreach(OBJproductdetails obj_OBJproductdetails in listobj_OBJproductdetails)
	{
		try
		{
			string query = "INSERT INTO productdetails (PNAME, Tax, Description, UnitPrice, Category_CID) VALUES ("
							+ (obj_OBJproductdetails.PNAME == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJproductdetails.PNAME) + "'")
							+ ", " + (obj_OBJproductdetails.Tax == null ? "null" : "'" + GeneralMethods.Default.doubleforDB(obj_OBJproductdetails.Tax.Value.ToString()) + "'")
							+ ", " + (obj_OBJproductdetails.Description == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJproductdetails.Description) + "'")
							+ ", " + (obj_OBJproductdetails.UnitPrice == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJproductdetails.UnitPrice) + "'")
							+ ", " + (obj_OBJproductdetails.Category_CID == 0 ? "0" : "'" + obj_OBJproductdetails.Category_CID + "'") + ")"
							
							
							
							
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

	public OBJproductdetails Insert_Return(OBJproductdetails obj_OBJproductdetails)
	{
		try
		{
			string query = "INSERT INTO productdetails (PNAME, Tax, Description, UnitPrice, Category_CID) VALUES ("
							+ (obj_OBJproductdetails.PNAME == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJproductdetails.PNAME) + "'")
							+ ", " + (obj_OBJproductdetails.Tax == null ? "null" : "'" + GeneralMethods.Default.doubleforDB(obj_OBJproductdetails.Tax.Value.ToString()) + "'")
							+ ", " + (obj_OBJproductdetails.Description == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJproductdetails.Description) + "'")
							+ ", " + (obj_OBJproductdetails.UnitPrice == null ? "null" : "'" + GeneralMethods.Default.stringforDB(obj_OBJproductdetails.UnitPrice) + "'")
							+ ", " + (obj_OBJproductdetails.Category_CID == 0 ? "0" : "'" + obj_OBJproductdetails.Category_CID + "'") + ")"
							
							
							
							
							
							+ "; SELECT PID FROM productdetails ORDER BY PID DESC LIMIT 1";
			DataTable dt= DAL.Default.Select(query);
			DataRow dr = dt.Rows[0];
			obj_OBJproductdetails.PID = Convert.ToInt32(dr["PID"]);
			return obj_OBJproductdetails;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return null;
		}
	}

	public bool Update(OBJproductdetails updateObject) 
	{
		try
		{
			if (updateObject.IsFiltered)
			{
				string query = "UPDATE productdetails SET ";
				string queryWhere = "";
				bool counter = false;
				foreach (FilteredItems filtereditems in updateObject.FilterList)
				{
					if (filtereditems.FilterAttribute == "PID")
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
				if (updateObject.PID != 0)
				{
					string query = "UPDATE productdetails SET ";
					int sqlCount = 0;
					query += (sqlCount > 0 ? ", " : "");
					query += "PNAME" + GeneralMethods.Default.comparestringforDB(updateObject.PNAME);
					sqlCount++;
					if (updateObject.Tax.HasValue)
					{
						query += (sqlCount > 0 ? ", " : "");
						query += "Tax" + GeneralMethods.Default.comparedoubleforDB(updateObject.Tax.Value);
						sqlCount++;
					}
					query += (sqlCount > 0 ? ", " : "");
					query += "Description" + GeneralMethods.Default.comparestringforDB(updateObject.Description);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "UnitPrice" + GeneralMethods.Default.comparestringforDB(updateObject.UnitPrice);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "Category_CID" + GeneralMethods.Default.compareintforDB(updateObject.Category_CID);
					sqlCount++;
					query += " WHERE PID = " + updateObject.PID;
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

	public bool UpdateWot(OBJproductdetails updateObject) 
	{
		try
		{
			if (updateObject.IsFiltered)
			{
				string query = "UPDATE productdetails SET ";
				string queryWhere = "";
				bool counter = false;
				foreach (FilteredItems filtereditems in updateObject.FilterList)
				{
					if (filtereditems.FilterAttribute == "PID")
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
				if (updateObject.PID != 0)
				{
					string query = "UPDATE productdetails SET ";
					int sqlCount = 0;
					query += (sqlCount > 0 ? ", " : "");
					query += "PNAME" + GeneralMethods.Default.comparestringforDB(updateObject.PNAME);
					sqlCount++;
					if (updateObject.Tax.HasValue)
					{
						query += (sqlCount > 0 ? ", " : "");
						query += "Tax" + GeneralMethods.Default.comparedoubleforDB(updateObject.Tax.Value);
						sqlCount++;
					}
					query += (sqlCount > 0 ? ", " : "");
					query += "Description" + GeneralMethods.Default.comparestringforDB(updateObject.Description);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "UnitPrice" + GeneralMethods.Default.comparestringforDB(updateObject.UnitPrice);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "Category_CID" + GeneralMethods.Default.compareintforDB(updateObject.Category_CID);
					sqlCount++;
					query += " WHERE PID = " + updateObject.PID;
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

	public bool Update(List<OBJproductdetails> listupdateObject)
	{
	bool ret = false;
	 foreach(OBJproductdetails updateObject in listupdateObject)
	{
		try
		{
			if (updateObject.IsFiltered)
			{
				string query = "UPDATE productdetails SET ";
				string queryWhere = "";
				bool counter = false;
				foreach (FilteredItems filtereditems in updateObject.FilterList)
				{
					if (filtereditems.FilterAttribute == "PID")
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
				if (updateObject.PID != 0)
				{
					string query = "UPDATE productdetails SET ";
					int sqlCount = 0;
					query += (sqlCount > 0 ? ", " : "");
					query += "PNAME" + GeneralMethods.Default.comparestringforDB(updateObject.PNAME);
					sqlCount++;
					if (updateObject.Tax.HasValue)
					{
						query += (sqlCount > 0 ? ", " : "");
						query += "Tax" + GeneralMethods.Default.comparedoubleforDB(updateObject.Tax.Value);
						sqlCount++;
					}
					query += (sqlCount > 0 ? ", " : "");
					query += "Description" + GeneralMethods.Default.comparestringforDB(updateObject.Description);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "UnitPrice" + GeneralMethods.Default.comparestringforDB(updateObject.UnitPrice);
					sqlCount++;
					query += (sqlCount > 0 ? ", " : "");
					query += "Category_CID" + GeneralMethods.Default.compareintforDB(updateObject.Category_CID);
					sqlCount++;
					query += " WHERE PID = " + updateObject.PID;
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

	public bool Delete(int PID)
	{
		try
		{
			string query= "DELETE FROM productdetails WHERE PID = " + PID;
			return DAL.Default.Execute(query);
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}

	public bool Delete(OBJproductdetails deleteObject)
	{
		try
		{
			List<OBJproductdetails> objList = this.Select(deleteObject);
			foreach (OBJproductdetails obj_OBJproductdetails in objList)
				this.Delete(obj_OBJproductdetails.PID);
			return true;
		}
		catch (Exception ex)
		{
			ErrorLogHelper.Default.LogException(ex);
			return false;
		}
	}

	public bool Delete(List<OBJproductdetails> listdeleteObject)
	{
	bool ret = false;
	foreach(OBJproductdetails deleteObject in listdeleteObject)
		{
		try
		{
			List<OBJproductdetails> objList = this.Select(deleteObject);
			foreach (OBJproductdetails obj_OBJproductdetails in objList)
				this.Delete(obj_OBJproductdetails.PID);
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
