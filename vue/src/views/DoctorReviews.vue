<template>
  <div class="doctorReviewBackground">
    
    
    <h1 class="doctorAppointmentTitle"></h1>
    <router-link v-bind:to="{name: 'doctor'}"><button class="doctorAppointment" id="doctorAppointmentButton" v-on:click="doctor"></button></router-link>
    <router-link v-bind:to="{name: 'officeInfo'}"><button class="appointmentOffice" v-on:click="officeInfo"></button></router-link>
    <router-link v-bind:to="{name: 'appointmentRequest'}"><button  class="doctorAppointmentRequestBtn" v-on:click="appointmentRequest"></button></router-link>
    <router-link v-bind:to="{name: 'viewSchedule'}"><button class="appointmentViewSchedule" v-on:click="viewSchedule"></button></router-link>
    
  </div>
</template>

<script>
import doctorService from '../services/DoctorService';

export default {
 
  data() {
    return {
      pendingAppointments: []
    };
  },

  created: {
    pendingAppointments() {
      doctorService.GetAppointments()
      .then((response) => {
        this.pendingAppointments = response.data.filter(appt => {
          return appt.status == 'pending';
        });
      });
    }
  }
};
</script>

<style >


.doctorAppointmentTitle {
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
  top:8.7%;
  left:20.8%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
 
}
.doctorAppointmentTitle:before {
  content: "Reviews Page";
 
  padding-left:25px ;
  width: 650px;
    top:50%;
  left:75%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.doctorAppointmentTitle:after {
  content: "レビューページ";
   padding-top:10px ;
  padding-left:110px ;
  width: 650px;
    top:50%;
  left:61.5%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.doctorAppointmentTitle:hover:before {
  top: -50%;
}
.doctorAppointmentTitle:hover:after {
  top: 50%;
}

.doctorReviewBackground{
  background-image: url("../img/drmario4.jpg");
  background-size: cover;
  background-attachment: fixed;
  background-repeat: no-repeat;
  height: 1100px;
}

#doctorAppointmentButton {
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill3.jpg");
       background-size:cover;
        background-repeat: no-repeat;
        
  height: 35px;
  width: 220px;
  top:16.5%;
  left:9.5%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
 
}
#doctorAppointmentButton:before {
  content: "Doctor Home Page";
 
  padding-left:1px ;
  width: 250px;
    top:50%;
  left:48%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
#doctorAppointmentButton:after {
  content: "ドクターホームページ";
   padding-top:3px ;
  padding-left:1px ;
  width: 250px;
    top:50%;
  left:50%;
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
.appointmentOffice{
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill1.jpg");
       background-size:cover;
        background-repeat: no-repeat;
        
  height: 35px;
  width: 220px;
  top:21.8%;
  left:9.5%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.appointmentOffice:before {
  content: "Office Info";
  padding-top: 2px;
  padding-left:4px ;
  width: 250px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.appointmentOffice:after {
  content: "オフィス情報";
  padding-left:50px;
  padding-top: 4px;
  width: 250px;
    top:50%;
  left:40%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.appointmentOffice:hover:before {
  top: -50%;
}
.appointmentOffice:hover:after {
  top: 50%;
}

.doctorAppointmentRequestBtn{
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill4.jpg");
       background-size:cover;
        background-repeat: no-repeat;
        
  height: 35px;
  width: 220px;
  top:27.1%;
  left:9.5%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.doctorAppointmentRequestBtn:before {
  content: "Appointment Request";
  padding-top: 2px;
  padding-left:4px ;
  width: 250px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.doctorAppointmentRequestBtn:after {
  content: "予定のリクエスト";
  padding-left:50px;
  padding-top: 4px;
  width: 250px;
    top:50%;
  left:40%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.doctorAppointmentRequestBtn:hover:before {
  top: -50%;
}
.doctorAppointmentRequestBtn\:hover:after {
  top: 50%;
}

.appointmentViewSchedule{
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill1.jpg");
       background-size:cover;
        background-repeat: no-repeat;
        
  height: 35px;
  width: 220px;
  top:32.4%;
  left:9.5%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.appointmentViewSchedule:before {
  content: "View Schedule";
  padding-top: 2px;
  padding-left:4px ;
  width: 250px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.appointmentViewSchedule:after {
  content: "スケジュールを見る";
  padding-left:50px;
  padding-top: 4px;
  width: 250px;
    top:50%;
  left:40%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.appointmentViewSchedule:hover:before {
  top: -50%;
}
.appointmentViewSchedule:hover:after {
  top: 50%;
}

.doctor-appointment-requests{
        background-image:url("../img/drmario3.jpg");
       background-size:cover;
        background-attachment: fixed;
        background-repeat: no-repeat;
        padding:25px ;
        height: 1500px;
}
</style>