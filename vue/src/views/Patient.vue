<template>
<div class='patient'>
    <div v-for="patient in patient" v-bind:key="patient.id"></div>
    <patient-buttons/>
    <button class="appointment" v-on:click="appointments">Request appointment</button>
    <router-link v-bind:to="{name: 'patientOfficeInfo'}"><button class="patientOfficeInfo" v-on:click="patientOfficeInfo">Office Info</button></router-link>
    <button class="reviews" v-on:click="reviews">Reviews</button>

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