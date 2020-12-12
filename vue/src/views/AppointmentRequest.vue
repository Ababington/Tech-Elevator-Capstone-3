<template>
  <div class="appointment-requests"> 

    <appointment-requests v-bind:office="office" v-bind:key='office.id' v-for="office in $store.state.pendingAppointmentsStatic">
    <router-link v-bind:to="{name: 'appointmentRequests', params: {id:office.id}}"></router-link>
    </appointment-requests>

     </div>

</template>

<script>
import appointmentRequests from '../components/AppointmentRequests';

export default {
  components:{
    appointmentRequests
  },
  data(){
    return{

    }
  }

}
</script>

<style>

</style>