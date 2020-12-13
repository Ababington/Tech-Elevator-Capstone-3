<template>
  <div class="appointment-requests"> 
    <h1 class="appointmentTitle">Appointment Requests Page</h1>

    <appointment-requests-card v-bind:appointment="appointment" v-bind:key='appointment.appointmentId' v-for="appointment in $store.state.pendingAppointmentsStatic">
    <router-link v-bind:to="{name: 'appointmentRequest', params: {id:appointment.appointmentId}}"></router-link>
    </appointment-requests-card>

     <appointment-requests-card v-bind:office="office" v-bind:key='office.id' v-for="office in $store.state.officesStatic">
    <router-link v-bind:to="{name: 'officeInfo', params: {id:office.id}}"></router-link>
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
.appointmentTitle{
  font-family: 'Courier', impact, monospace;
  border: 2px solid rgb(160, 160, 160);
    border-radius: 10px;
  background-image: linear-gradient(to bottom right, rgb(231, 231, 231), rgb(255, 255, 255));
    width: 650px;
    padding: 15px;
}
.appointment-requests{
background-image: linear-gradient(to bottom right, rgb(255, 255, 255), rgb(99, 99, 99));
 background-size:cover;
 height: 1100px;
}

</style>