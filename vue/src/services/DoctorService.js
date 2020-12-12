import axios from 'axios';

export default {
  GetMyInfo() {
    return axios.get('/doctor/myInfo'); //returns a doctor
  },

  UpdateMyInfo(doctor) {
    return axios.put('/doctor/myInfo/update', doctor)
  },

  GetMyOffices() {
    return axios.get('/doctor/myOffices'); //returns array of offices
  },

  GetMyOfficesReviews() {
    return axios.get('/doctor/myOffices/reviews') //returns array of reviews
  },

  GetReviewResponses() {
    return axios.get('/doctor/myOffices/reviews/responses') //returns array of responses
  },

  GetAppointments() {
    return axios.get('/doctor/getAppointments'); //returns array of appointments (pending && approved --maybe split up?)
  },

  RespondToPendingAppointment(appointment) {
    return axios.put('/doctor/getAppointments/respondToPending', appointment); //(3 statuses: pending/approved/denied)
  },
}
