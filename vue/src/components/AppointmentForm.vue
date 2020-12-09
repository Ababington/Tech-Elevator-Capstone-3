<template>
<Form v-on="submit" >
<label for="name">Name: </label>
<input type="text" v-model="this.appointment.Patient"/><br>
<label for="reasonForVisit">Reason for visit: </label>
<textarea cols=50 rows=10 v-model="this.appointment.ReasonForVisit"></textarea><br>
<label for="visitTime">Time of visit (date and time)</label>
<input type = "datetime-local" v-model="this.appointment.DateTime"/>

<button type="submit">Submit Appointment Request</button>

</Form>
</template>

<script>
import authService from '../services/AuthService'
export default {

    data(){
        return{
            appointment: {
                Patient: '',
                ReasonForVisit: '',
                DateTime: '',
                Status: "Needs Approved"
            }
        }
    },

    methods: {
        backHome(){
            this.$router.push('/');

        }
    },
created(){
    
    Authservice.PostAptRequest(this.appointment).then(response => {
        if(response.status == 201){
            backHome;
        }
    }).catch(error => {
        error.status;
    })
    }

}
</script>

<style>

</style>