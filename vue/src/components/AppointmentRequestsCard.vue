<template>
<div>
    <h1>Appointment Requests Page</h1>

    <div class="card">
        <h2>{{appointment.name}}</h2>
        
        <div>
          {{appointment.patientUserName}}<br/>
          {{appointment.patientFirstName}}<br/>
          {{appointment.patientLastName}}<br/>
          {{appointment.apptDate}}<br/>
          {{appointment.apptTime}}<br/>
          virtual: {{appointment.virtual}}<br/>
          {{appointment.message}}<br/>
          {{appointment.status}}<br/>
          </div>
    </div>


</div>
</template>

<script>

export default {
  props:{
    appointment: Object
  }
};
</script>



<style>
</style>