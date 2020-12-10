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
  postAptRequest(appointment){
    return axios.post('/postAppointmentRequest', appointment);
  },

  getOfficeInfo(){
    return axios.get('/getOfficeInfo');
  },
  
  getReviews(){
    return axios.get('/getReviews');
  },

  postReviews(){
    return axios.post('/postReviews');
  }



}
