﻿using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class PatientsSqlDAO : IPatientsDAO
    {
        private readonly string connectionString;

        public PatientsSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public Patients GetMyAppointments(Patients patients)
        {
            throw new NotImplementedException();
        }

        public Patients GetMyInfo(Patients patients)
        {
            throw new NotImplementedException();
        }

        public Patients UpdateMyInfo(Patients patients)
        {
            throw new NotImplementedException();
        }
    }
}
