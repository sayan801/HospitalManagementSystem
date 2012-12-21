using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMSStorage
{

    public class HMSStorage
    {

        //#region database interction data fetching

        //MySql.Data.MySqlClient.MySqlConnection msqlConnection = null;

        //private void fetcheUserData()
        //{
        //    msqlConnection = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;user id=root;Password=technicise;database=sptdb;persist security info=False");
        //    try
        //    {   //define the command reference
        //        MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
        //        msqlCommand.Connection = msqlConnection;

        //        msqlConnection.Open();

        //        msqlCommand.CommandText = "Select * from Users;";
        //        MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
        //       // _UsersCollection.Clear();

        //        while (msqlReader.Read())
        //        {
        //           // UsersData UsersDataObject = new UsersData();

        //            //UsersDataObject.serialNo = msqlReader.GetString("sl_no");
        //            UsersDataObject.UserAdress = msqlReader.GetString("address");
        //            UsersDataObject.phoneNumber = msqlReader.GetString("ph_no");
        //            UsersDataObject.UserName = msqlReader.GetString("patient_name");
        //            UsersDataObject.UserVatNo = msqlReader.GetString("registration_no");
        //            UsersDataObject.UserId = msqlReader.GetString("id");
        //            UsersDataObject.UserTurnOver = msqlReader.GetString("turn_over");
        //            UsersDataObject.UserDue = msqlReader.GetString("due");
        //            _UsersCollection.Add(UsersDataObject);

        //        }

        //    }
        //    catch (Exception er)
        //    {
        //        MessageBox.Show(er.Message);
        //    }
        //    finally
        //    {
        //        //always close the connection
        //        msqlConnection.Close();
        //    }
        //}
        //#endregion

        //#region User table update

        //private void UpdateUserTable()
        //{

        //    //define the connection reference and initialize it
        //    msqlConnection = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;user id=root;Password=technicise;database=sptdb;persist security info=False");


        //    try
        //    {
        //        //define the command reference
        //        MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();

        //        //define the connection used by the command object
        //        msqlCommand.Connection = msqlConnection;

        //        double dbDue = 0.0;
        //        double dbTurnOver = 0.0;

        //        //open the connection
        //        if (msqlConnection.State != System.Data.ConnectionState.Open)
        //            msqlConnection.Open();
        //        string cusIdKey = UserInfoTb.SelectedValue.ToString();
        //        string cmdStr = "SELECT turn_over,due FROM Users WHERE id='" + cusIdKey + "';";
        //        msqlCommand.CommandText = cmdStr;


        //        MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();

        //        while (msqlReader.Read())
        //        {
        //            dbDue = double.Parse(msqlReader.GetString("due"));
        //            dbTurnOver = double.Parse(msqlReader.GetString("turn_over"));
        //        }

        //        if (msqlConnection.State == System.Data.ConnectionState.Open)
        //            msqlConnection.Close();

        //        //updating the value
        //        if (msqlConnection.State != System.Data.ConnectionState.Open)
        //            msqlConnection.Open();

        //        double totalBilledAmount = CalculateTotalAmount() + CalculateVAT();

        //        double newDueDouble = dbDue + totalBilledAmount - double.Parse(paymentAmountTB.Text);
        //        String newDue = newDueDouble.ToString();
        //        String newTurnOver = (dbTurnOver + totalBilledAmount).ToString();
        //        msqlCommand.CommandText = "UPDATE Users SET due='" + newDue + "', turn_over='" + newTurnOver + "' WHERE id='" + cusIdKey + "'; ";

        //        msqlCommand.ExecuteNonQuery();


        //    }
        //    catch (Exception er)
        //    {
        //        MessageBox.Show(er.Message);
        //    }
        //    finally
        //    {
        //        if (msqlConnection.State == System.Data.ConnectionState.Open)
        //            msqlConnection.Close();
        //    }

        //}



        //#endregion
    }

}
