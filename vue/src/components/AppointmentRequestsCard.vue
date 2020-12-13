<template>
<div>
    <h1 class="appointmentTitle">Appointment Requests Page</h1>

    <div class="appointmentCard">
       
          user name: {{appointment.patientUserName}}<br/>
          First Name: {{appointment.patientFirstName}}<br/>
          Last Name: {{appointment.patientLastName}}<br/>
          Phone Number: {{appointment.patientPhone}}<br/>
          Email: {{appointment.patientEmail}}<br/>
          Date of Birth: {{appointment.patientDateOfBirth}}<br/>
          <br/>
          <p><b>Appointment Info</b></p>
          Date: {{appointment.apptDate}}<br/>
          Time: {{appointment.apptTime}}<br/>
          virtual: {{appointment.virtual}}<br/>
          Message: {{appointment.message}}<br/>
          Status: {{appointment.status}}<br/>
          
    </div>


</div>
</template>

<script>

export default {
    props: {
        appointment: Object,
    }
}
</script>



<style>
.appointmentCard {
    border: 2px solid black;
    border-radius: 10px;
    width: 275px;
    height: cover;
    padding: 10px;
    margin: 50px;
    margin-left: 150px;
}

.appointmentTitle {
  margin: 50px;
}

</style>