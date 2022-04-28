using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAB_Furniture_Rentals.Model
{
    class State
    {
        public int StateID { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }

        public State(int stateID, string stateCode, string stateName)
        {
            this.StateID = stateID;
            this.StateCode = stateCode;
            this.StateName = stateName;
        }
    }
}
