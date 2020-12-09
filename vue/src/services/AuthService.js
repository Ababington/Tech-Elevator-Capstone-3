import axios from 'axios';

export default {

  login(user) {
    return axios.post('/login', user);
  },

  register(user) {
    return axios.post('/register', user);
  },

  getPendingDoctors() {
    return axios.get('/getPendingDoctors');
  },
  getAppointmentRequests(){
    return axios.get('/getAppointmentRequests');
  },

  postAptRequest(appointment){
    return axios.post('/postAppointmentRequest', appointment);
  }
}
