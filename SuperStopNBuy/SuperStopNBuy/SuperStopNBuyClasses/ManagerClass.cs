/***********************************
 * ManagerClass.cs
 * Created by The Dev Doods
***********************************/


using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperStopNBuy.SuperStopNBuyClasses
{
    public class ManagerClass
    {
        //getter & setter
        public string managerUsername { get; set; }
        public string managerPassword { get; set; }
        public string managerFName { get; set; }
        public string managerLName { get; set; }
        public int managerAccessLvl { get; set; }

        public DataTable Select()
        {
            //establish database connection
            MySqlConnection databaseConnection = new MySqlConnection(Global.ConnectionString);
            DataTable managerDataTable = new DataTable();

            try
            {
                //SQL query to get items
                string getManagerStatement = "SELECT * FROM manager";

                //execute
                MySqlCommand getManagerCommand = new MySqlCommand(getManagerStatement, databaseConnection);

                MySqlDataAdapter adapt = new MySqlDataAdapter(getManagerCommand);

                databaseConnection.Open();
                adapt.Fill(managerDataTable);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }

            return managerDataTable;
        }

        //insert data to database
        public bool InsertToDatabase(ManagerClass insertManager)
        {
            bool isValid = false;

            //establish database connection
            MySqlConnection databaseConnection = new MySqlConnection(Global.ConnectionString);

            try
            {
                //SQL query to insert items
                string insertManagerStatement = "INSERT INTO manager (username, password, firstName, lastName, accessLevel) VALUES (@username, @password, @firstName, @lastName, @accessLevel)";

                //execute
                MySqlCommand insertManagerCommand = new MySqlCommand(insertManagerStatement, databaseConnection);

                insertManagerCommand.Parameters.AddWithValue("@username", insertManager.managerUsername);
                insertManagerCommand.Parameters.AddWithValue("@password", insertManager.managerPassword);
                insertManagerCommand.Parameters.AddWithValue("@firstName", insertManager.managerFName);
                insertManagerCommand.Parameters.AddWithValue("@lastName", insertManager.managerLName);
                insertManagerCommand.Parameters.AddWithValue("@accessLevel", insertManager.managerAccessLvl);

                databaseConnection.Open();
                int rows = insertManagerCommand.ExecuteNonQuery();

                if (rows > 0)
                {
                    isValid = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }

            return isValid;
        }


        public bool UpdateDatabaseManager(ManagerClass updateManager)
        {
            bool isValid = false;

            //establish database connection
            MySqlConnection databaseConnection = new MySqlConnection(Global.ConnectionString);

            try
            {
                string updateManagerStatement = "UPDATE manager SET username=@username, password=@password, firstName=@firstName, lastName=@lastName, accessLevel=@accessLevel";
                //execute
                MySqlCommand updateManagerCommand = new MySqlCommand(updateManagerStatement, databaseConnection);
                updateManagerCommand.Parameters.AddWithValue("@username", updateManager.managerUsername);
                updateManagerCommand.Parameters.AddWithValue("@password", updateManager.managerPassword);
                updateManagerCommand.Parameters.AddWithValue("@firstName", updateManager.managerFName);
                updateManagerCommand.Parameters.AddWithValue("@lastName", updateManager.managerLName);
                updateManagerCommand.Parameters.AddWithValue("@accessLevel", updateManager.managerAccessLvl);

                databaseConnection.Open();

                int rows = updateManagerCommand.ExecuteNonQuery();
                if (rows > 0)
                {
                    isValid = true;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }

            return isValid;
        }

        public bool DeleteDatabaseManager(ManagerClass deleteManager)
        {
            bool isValid = false;

            //establish database connection
            MySqlConnection databaseConnection = new MySqlConnection(Global.ConnectionString);

            try
            {
                string deleteManagerStatement = "DELETE FROM manager WHERE username=@username";
                MySqlCommand deleteManagerCommand = new MySqlCommand(deleteManagerStatement, databaseConnection);
                deleteManagerCommand.Parameters.AddWithValue("@username", deleteManager.managerUsername);
                databaseConnection.Open();

                int rows = deleteManagerCommand.ExecuteNonQuery();
                if (rows > 0)
                {
                    isValid = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }

            return isValid;

        }
    }
}
