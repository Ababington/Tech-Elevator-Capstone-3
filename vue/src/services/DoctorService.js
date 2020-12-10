import axios from 'axios';

export default {
    getDoctorAppointments(){
        return axios.get('/doctor/getAppointments');
      }
}