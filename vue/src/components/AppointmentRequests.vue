<template>
<div>
    <div  v-for="appointment in appointmentRequests" v-bind:key="appointment.id">
        {{appointment.patient}}
        {{appointment.reason}}
        {{appointment.dateTime}}
        {{appointment.status}}
    </div>


</div>
</template>

<script>
import authService from '../services/AuthService'


export default {

    data(){
      return {
          appointmentRequests: [],
    }

},

created() {
authService.getAppointmentRequests().then(response => {
    this.appointmentRequests = response.data;
})
}
}
</script>



<style>

</style>