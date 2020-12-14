<template>
  <div class="doctor">
    <router-link v-bind:to="{name: 'appointmentRequest'}"><button  class="doctorAppointmentRequest" v-on:click="appointmentRequests"></button></router-link>
     <router-link v-bind:to="{name: 'officeInfo'}"><button class="doctorOffice" v-on:click="officeInfo">Office Info</button></router-link>
    <router-link v-bind:to="{name: 'reviews'}"><button class="doctorReviews" v-on:click="reviews">Reviews</button></router-link>
    <router-link v-bind:to="{name: 'viewSchedule'}"><button class="doctorViewSchedule" v-on:click="viewSchedule">Views Schedule</button></router-link>

  <doctor-info/>

  

  </div>
</template>

<script>

import doctorInfo from '../components/DoctorInfo';

export default {
  components:{
        doctorInfo,
  },
  data() {
    return {
      appointment: [],
      office: [],
      review: [],
      docDay_office: [],
    };
  },
  methods:{
      appointments(){
          this.$router.push("pathgoeshere");
      },
      officeInfo(){
          this.$router.push("pathgoeshere");
      },
      reviews(){
          this.$router.push("pathgoeshere");
      },
      schedule(){
          this.$router.push("pathgoeshere");
      }
  }
};

</script>

<style scoped>
.doctor{
  margin:50px;
}
.doctorAppointmentRequest{
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill1.jpg");
       background-size:cover;
        background-repeat: no-repeat;
        
  height: 35px;
  width: 220px;
  top:12%;
  left:7%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.doctorAppointmentRequest:before {
  content: "Appointment Requests";
  padding-top: 2px;
  padding-left:4px ;
  width: 250px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.doctorAppointmentRequest:after {
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
.doctorAppointmentRequest:hover:before {
  top: -50%;
}
.doctorAppointmentRequest:hover:after {
  top: 50%;
}
</style>