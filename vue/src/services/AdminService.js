import axios from 'axios';

export default {

  GetPendingDoctors() {
    return axios.get('/admin/getPendingDoctors');
  },

  CreateNewOffice(office) {
    return axios.post('/admin/createNewOffice', office);
  },

  ApproveDoctorUser(doctor) {
    return axios.push('/admin/approveDoctorUser', doctor);
  }
}