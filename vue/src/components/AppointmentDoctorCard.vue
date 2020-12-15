<template>
<div>
    

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



<style >
.appointmentCard {

    border: 2px solid black;
    border-radius: 10px;
    width: 275px;
    background-image: linear-gradient(to bottom right, rgb(255, 255, 255), rgb(218, 236, 53));
    height: cover;
    padding: 10px;
    margin: 50px;
    margin-left: 250px;
}

.appointmentTitle {
  margin: 50px;
}

</style>