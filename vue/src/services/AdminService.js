import axios from 'axios';

export default {

  GetPendingDoctors() {
    return axios.get('/admin/GetPendingDoctors');
  },

  CreateNewOffice(office) {
    return axios.post('/admin/CreateNewOffice', office);
  },

  ApproveDoctorUser(doctor) {
    return axios.push('/admin/ApproveDoctorUser', doctor);
  }
}