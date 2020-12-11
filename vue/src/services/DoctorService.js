import axios from 'axios';

export default {
    
  getDoctorAppointments(){
        return axios.get('/doctor/getAppointments');
      },
    
      
      createNewSchedule(doctor) {
        return axios.post('/doctor/createNewSchedule', doctor);
      }
}
