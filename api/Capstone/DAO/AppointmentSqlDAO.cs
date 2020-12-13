﻿using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class AppointmentSqlDAO : IAppointmentDAO
    {
        private readonly string connectionString;
        public AppointmentSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public bool CreateAppointmentRequest(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetAppointmentsByDoctor(int userId)
        {
            try
            {
                List<Appointment> appts = new List<Appointment>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        @"select apptId, patients.patientId, doctorId, officeId, date, time, message, virtual, status,
                        patients.firstName as 'patientFirstName', patients.lastName as 'patientLastName',
                        patients.phone as 'patientPhone', patients.email as 'patientEmail', patients.dateOfBirth as 'patientDoB'
                        from appointments
                        join patients on patients.patientId=appointments.patientId
                        join doctor on doctor.userId=appointments.doctorId
                        join users on users.user_id=doctor.userId
                        join office on office.id=appointments.officeId
                        where user_id=@user_id", conn);   
                    cmd.Parameters.AddWithValue("@user_id", userId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        Appointment a = new Appointment();
                        a.AppointmentId = Convert.ToInt32(reader["apptId"]);
                        a.PatientId = Convert.ToInt32(reader["patientId"]);
                        a.DoctorId = Convert.ToInt32(reader["doctorId"]);
                        a.OfficeId = Convert.ToInt32(reader["officeId"]);
                        a.Date = Convert.ToDateTime(reader["date"]);
                        a.Time = reader.GetTimeSpan(5);
                        a.Message = Convert.ToString(reader["message"]);
                        a.Virtual = Convert.ToBoolean(reader["virtual"]);
                        a.Status = Convert.ToString(reader["status"]);
                        a.PatientFirstName = Convert.ToString(reader["patientFirstName"]);
                        a.PatientLastName = Convert.ToString(reader["patientLastName"]);
                        a.PatientPhone = Convert.ToString(reader["patientPhone"]);
                        a.PatientEmail = Convert.ToString(reader["patientEmail"]);
                        a.PatientDoB = Convert.ToDateTime(reader["patientDoB"]);
                        appts.Add(a);
                    }

                    return appts;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public bool RespondToPendingAppointment(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetAppointmentsByPatient(int userId)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}