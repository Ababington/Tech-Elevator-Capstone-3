import axios from 'axios';

export default {
    
  getDoctorAppointments(){
        return axios.get('/doctor/getAppointments');
      },

      //getDoctor(userId){
        //return axios.get(`/doctor/getDoctor/${userId}`);
      //},
    
      createSchedule(doctor) {
        return axios.post('/doctor/createSchedule', doctor);
      },

      updateHourlyRate(doctor){
        return axios.put('/doctor/hourlyRate', doctor)
      }
}
