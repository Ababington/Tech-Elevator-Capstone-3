import axios from 'axios';

export default {

getPendingDoctors() {
    return axios.get('/admin/GetPendingDoctors');
  },


CreateNewOffice(office){
    return axios.post('/admin/createNewOffice', office);
}
}