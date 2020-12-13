import axios from 'axios';

export default {
    GetMyInfo(patient) {
        return axios.get(`/patient/${patient.id}`); //THIS IS PROBABLY WRONG but we need something like this
    },

    UpdateMyInfo(patient) {
        return axios.push('/patient/updateInfo', patient);
    },

    GetAllOffices() {
        return axios.get('/patient/allOffices');
    },

    GetOfficeReviews(office) {
        return axios.get(`/patient/allOffices/${office.id}/reviews`);
    },

    GetReviewResponses(office) {
        return axios.get(`/patient/allOffices/${office.id}/reviews/responses`);
    },

    PostNewReview(review) {
        return axios.post(`/patient/allOffices/postReview`, review);
    },

    GetAllDoctors() {
        return axios.get('/patient/doctorsList');
    },

    GetMyAppointments(patient) {
        return axios.get(`/patient/${patient.id}/appointments`); //THIS IS PROBABLY WRONG but we need something like this
    },

    CreateAppointmentRequest(appointment) {
        return axios.post('/patient/requestAppointment', appointment);
    },

    GetVerifiedDoctors(){
        return axios.get('/patient/getVerifiedDoctors');
    }
}