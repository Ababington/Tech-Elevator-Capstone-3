<template>
    <form v-on:submit.prevent="PostNewAptRequest()">
        <br/>
        <label for="doctor">Doctor: </label>
        <select name="doctor" v-model="appointment.doctorId">
            <option v-for="doctor in doctors" v-bind:key="doctor.userId" v-bind:value="doctor.userId">
                Dr. {{doctor.firstName}} {{doctor.lastName}}
            </option>
        </select><br/>

        <label for="reasonForVisit">Reason for visit: </label><br/>
        <textarea cols=50 rows=10 v-model="appointment.message"></textarea><br>

        <label for="date">Date: </label>
        <input type = "date" v-model="appointment.date"/>

        <label for="time">Time: </label>
        <input name="time" type="time" v-model="appointment.time">
        <br/><br/>

        <button type="submit">Submit Appointment Request</button>
    </form>
</template>

<script>
import patientService from '../services/PatientService'
export default {

    data(){
        return{
            appointment: {
                userId: '',
                doctorId: '',
                message: '',
                date: '',
                time: '',
                status: "Pending"
            },
            doctors: []
        }
    },

    methods: {
        getUserId(){
            return this.$store.state.user.userId
        },

        PostNewAptRequest() {
            patientService.CreateAppointmentRequest(this.appointment)
            .then((response) => {
                if (response.status === 200 || response.status === 201 ) {
                    alert("Appointment Submitted");
                    this.appointment = {};
                }
            })
            .catch((error) => {
                error.status;
            });
        }
    },

    created(){
      this.appointment.userId = this.getUserId();
      patientService.GetAllDoctors()
      .then((response) => {
          this.doctors = response.data;
      });
    }

}
</script>

<style >

</style>