using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAB_Furniture_Rentals.Model
{
    class State
    {
        public int stateID { get; set; }
        public string stateCode { get; set; }
        public string stateName { get; set; }

        public State(int stateID, string stateCode, string stateName)
        {
            this.stateID = stateID;
            this.stateCode = stateCode;
            this.stateName = stateName;
        }
    }
}
