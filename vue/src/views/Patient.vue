<template>
<div class='patient'>
    <div v-for="patient in patient" v-bind:key="patient.id"></div>
    <patient-buttons/>
    <router-link v-bind:to="{name: 'patientOfficeInfo'}"><button class="patientOfficeInfo" v-on:click="patientOfficeInfo">Office Info</button></router-link>
    <router-link v-bind:to="{name: 'reviews'}"><button class="doctorReviews" v-on:click="reviews">Office Reviews</button></router-link>

    <appointment-form/>
</div>
</template>

<script>
import appointmentForm from '../components/AppointmentForm';
import patientButtons from '../components/PatientButtons';

export default {
    components:{
        appointmentForm,
        patientButtons
    }

}
</script>

<style >
.patient{
        background-image:url("../img/chansey.jpg");
        padding: 50px;
       background-size:cover;
        background-attachment: fixed;
        background-repeat: no-repeat;
        height: 945px;
        }
</style>