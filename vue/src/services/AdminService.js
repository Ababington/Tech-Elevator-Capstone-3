import axios from 'axios';

export default {

getPendingDoctors() {
    return axios.get('/admin/GetPendingDoctors');
  }
}

createNewOffice(office){
    return axios.push('/admin/createNewOffice', office);
}