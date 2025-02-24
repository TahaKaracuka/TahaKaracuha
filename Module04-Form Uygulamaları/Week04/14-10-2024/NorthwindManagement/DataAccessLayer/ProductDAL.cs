using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindManagement.DataAccessLayer
{
    internal class ProductDAL
    {
        public DataTable GetAll()
        {
            string query = @"
                    SELECT
	                    p.ProductID AS [Id],
	                    p.ProductName AS [Name],
	                    p.UnitPrice AS [Price],
	                    p.UnitsInStock AS [Stock],
	                    p.CategoryID AS [CategoryId],
	                    c.CategoryName AS [Category]
                    FROM Products p JOIN Categories c ON p.CategoryID=c.CategoryID
            ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query,Database.Connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    
        public DataTable GetAll(string searchText,bool isWithStart)
        {
            //co, ile başlar=> searchText='co%'
            //co, içerir=>searchTect='%co%'
            searchText = isWithStart
                            ? $"{searchText}%"
                            : $"%{searchText}%";
            string query = $@"
                SELECT
	                p.ProductID AS [Id],
	                p.ProductName AS [Name],
	                p.UnitPrice AS [Price],
	                p.UnitsInStock AS [Stock],
	                p.CategoryID AS [CategoryId],
	                c.CategoryName AS [Category]
                FROM Products p JOIN Categories c ON p.CategoryID=c.CategoryID
                WHERE p.ProductName LIKE '{searchText}'
            ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, Database.Connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    
        public DataTable GetAll(int categoryId)
        {
            string query = $@"
                SELECT
	                p.ProductID AS [Id],
	                p.ProductName AS [Name],
	                p.UnitPrice AS [Price],
	                p.UnitsInStock AS [Stock],
	                p.CategoryID AS [CategoryId],
	                c.CategoryName AS [Category]
                FROM Products p JOIN Categories c ON p.CategoryID=c.CategoryID
                WHERE p.CategoryID={categoryId}
            ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, Database.Connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
