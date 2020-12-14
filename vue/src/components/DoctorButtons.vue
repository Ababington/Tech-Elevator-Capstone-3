<template>
  <div class="doctor">
    <router-link v-bind:to="{name: 'appointmentRequest'}"><button  class="doctorAppointmentRequest" v-on:click="appointmentRequests"></button></router-link>
    <router-link v-bind:to="{name: 'officeInfo'}"><button class="doctorOffice" v-on:click="officeInfo"></button></router-link>
    <router-link v-bind:to="{name: 'reviews'}"><button class="doctorReviews" v-on:click="reviews"></button></router-link>
    <router-link v-bind:to="{name: 'viewSchedule'}"><button class="doctorViewSchedule" v-on:click="viewSchedule"></button></router-link>

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
  overflow: hidden;}
  /* @keyframes bounce{
    0%, 25%, 50%, 75%, 90%, 100%{
      transform: translateY(0);}
    15%,40%{
      transform: translateY(-20px);}
    65%,80%{
      transform: translateY(-15px);}
    95%{
      transform: translateY(-5px);}}
    .doctorAppointmentRequest:hover{
      animation: bounce 2s linear;} */
      
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

.doctorOffice{
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill4.jpg");
       background-size:cover;
        background-repeat: no-repeat;
        
  height: 35px;
  width: 220px;
  top:5.8%;
  left:19%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.doctorOffice:before {
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
.doctorOffice:after {
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
.doctorOffice:hover:before {
  top: -50%;
}
.doctorOffice:hover:after {
  top: 50%;
}

.doctorReviews{
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill3.jpg");
       background-size:cover;
        background-repeat: no-repeat;
        
  height: 35px;
  width: 220px;
  top:12%;
  left:31.125%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.doctorReviews:before {
  content: "Reviews";
  padding-top: 2px;
  padding-left:4px ;
  width: 250px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.doctorReviews:after {
  content: "レビュー";
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
.doctorReviews:hover:before {
  top: -50%;
}
.doctorReviews:hover:after {
  top: 50%;
}

.doctorViewSchedule{
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill7.jpg");
       background-size:cover;
        background-repeat: no-repeat;
        
  height: 35px;
  width: 220px;
  top:12%;
  left:43.3%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.doctorViewSchedule:before {
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
.doctorViewSchedule:after {
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
.doctorViewSchedule:hover:before {
  top: -50%;
}
.doctorViewSchedule:hover:after {
  top: 50%;
}
</style>