<template>
  <div class="appointment-requests"> 

    <appointment-requests-card v-bind:appointment="appointment" v-bind:key='appointment.appointmentId' v-for="appointment in $store.state.pendingAppointmentsStatic">
    <router-link v-bind:to="{name: 'appointmentRequest', params: {id:appointment.appointmentId}}"></router-link>
    </appointment-requests-card>

     </div>

</template>

<script>
import appointmentRequestsCard from '../components/AppointmentRequestsCard';

export default {
  components:{
    appointmentRequestsCard
  },
  data(){
    return{

    }
  }

}
</script>

<style>

</style>