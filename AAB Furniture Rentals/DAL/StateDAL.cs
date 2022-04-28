using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AAB_Furniture_Rentals.DAL
{
    class StateDAL
    {
        public List<State> GetAllStates()
        {

            List<State> StateList = new List<State>();

            string selectStatement = "SELECT * FROM state";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {

                        var stateID = reader.GetOrdinal("stateID");
                        var stateCode = reader.GetOrdinal("stateCode");
                        var stateName = reader.GetOrdinal("stateName");


                        while (reader.Read())
                        {
                            int _stateID = reader.GetInt32(stateID);
                            string _stateCode = reader.GetString(stateCode);
                            string _stateName = reader.GetString(stateName);

                            State newState = new State(_stateID, _stateCode, _stateName);

                            StateList.Add(newState);


                        }
                    }
                }
            }

            return StateList;
        }
    }
}
