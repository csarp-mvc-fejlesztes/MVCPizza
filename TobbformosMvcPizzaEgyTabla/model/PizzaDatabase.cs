﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobbbformosPizzaAlkalmazasEgyTabla.Model
{
    partial class Pizza
    {
        public string getInsert()
        {
            return
                "INSERT INTO `ppizza` (`pazon`, `pnev`, `par`) " +
                "VALUES ('" +
                id +
                "', '" +
                getNeme() +
                "', '" +
                getPrice() +
                "');";
        }

        public static string getSQLCommandDeleteAllRecord()
        {
            return "DELETE FROM ppizza";
        }

        public static string getSQLCommandGetAllRecord()
        {
            return "SELECT * FROM ppizza";
        }
    }
}
