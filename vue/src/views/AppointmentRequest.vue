<template>
  <div class="appointment-requests">
    <router-link v-bind:to="{name: 'doctor'}"><button class="doctorAppointment" id="doctorAppointmentButton" v-on:click="doctor">Home Page</button></router-link>
    <h1 class="appointmentTitle"></h1>

    <appointment-requests-card
      v-bind:appointment="appointment"
      v-bind:key="appointment.appointmentId"
      v-for="appointment in $store.state.pendingAppointmentsStatic"
    >
      <router-link
        v-bind:to="{
          name: 'appointmentRequest',
          params: { id: appointment.appointmentId },
        }"
      ></router-link>
    </appointment-requests-card>

    <appointment-requests-card
      v-bind:office="office"
      v-bind:key="office.id"
      v-for="office in $store.state.officesStatic"
    >
      <router-link
        v-bind:to="{ name: 'officeInfo', params: { id: office.id } }"
      ></router-link>
    </appointment-requests-card>
  </div>
</template>

<script>
import appointmentRequestsCard from "../components/AppointmentRequestsCard";

export default {
  components: {
    appointmentRequestsCard,
  },
  data() {
    return {};
  },
};
</script>

<style>
.doctorAppointment{
  font-family:"Courier", impact, monospace ;
  margin-top: 60px;
  margin-left: 40px;
  padding-left: 75px;
}

.appointmentTitle {
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image: linear-gradient(
    to bottom right,
    rgb(255, 255, 255),
    rgb(228, 228, 228)
  );
  height: 60px;
  width: 650px;
  top:4%;
  left:18%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
 
}
.appointmentTitle:before {
  content: "Appointment Requests Page";
 
  padding-left:25px ;
  width: 650px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.appointmentTitle:after {
  content: "予約リクエストページ";
   padding-top:10px ;
  padding-left:110px ;
  width: 650px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.appointmentTitle:hover:before {
  top: -50%;
}
.appointmentTitle:hover:after {
  top: 50%;
}

.appointment-requests {
  background-image: url("../img/drmario3.jpg");
  background-size: cover;
  background-attachment: fixed;
  background-repeat: no-repeat;
  padding: 50px;
}

#doctorAppointmentButton {
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image: linear-gradient(
    to bottom right,
    rgb(255, 255, 255),
    rgb(228, 228, 228)
  );
  height: 35px;
  width: 180px;
  top:8%;
  left:7%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
 
}
#doctorAppointmentButton:before {
  content: "Doctor";
 
  padding-left:1px ;
  width: 150px;
    top:50%;
  left:25%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
#doctorAppointmentButton:after {
  content: "医師";
   padding-top:3px ;
  padding-left:1px ;
  width: 150px;
    top:50%;
  left:30%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
#doctorAppointmentButton:hover:before {
  top: -50%;
}
#doctorAppointmentButton:hover:after {
  top: 50%;
}

.Office-Info{
        background-image:url("../img/drmario2.jpg");
       background-size:cover;
        background-attachment: fixed;
        background-repeat: no-repeat;
        padding: 50px;
}
</style>