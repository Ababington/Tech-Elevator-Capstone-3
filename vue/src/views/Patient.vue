<template>
<div class='patient'>
     <div v-for="patient in patient" v-bind:key="patient.id"></div>
    <button class="appointment" v-on:click="appointments">Request appointment</button>
    <router-link v-bind:to="{name: 'patientofficeInfo'}"><button class="patientOfficeInfo" v-on:click="patientOfficeInfo">Office Info</button></router-link>
    <button class="reviews" v-on:click="reviews">Reviews</button>

    <appointment-form/>
</div>
</template>

<script>
import appointmentForm from '../components/AppointmentForm';

export default {
    components:{
        appointmentForm
    }

}
</script>

<style>

</style>