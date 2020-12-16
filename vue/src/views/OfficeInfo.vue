<template>
  <div class="Office-Info"> 
    <router-link v-bind:to="{name: 'doctor'}"><button class="doctorAppointment" id="doctorAppointmentButton" v-on:click="doctor"></button></router-link>
    <router-link v-bind:to="{name: 'appointmentRequest'}"><button  class="infoOffice" v-on:click="appointmentRequests"></button></router-link>
    <router-link v-bind:to="{name: 'doctorReviews'}"><button class="appointmentReviewsQ" v-on:click="doctorReviews"></button></router-link>
    <router-link v-bind:to="{name: 'viewSchedule'}"><button class="appointmentViewSchedule" v-on:click="viewSchedule"></button></router-link>
    
<h1 class="officeCardTitle"></h1>

    <office-card v-bind:office="office" v-bind:key='office.id' v-for="office in $store.state.officesStatic">
    <router-link v-bind:to="{name: 'officeInfo', params: {id:office.id}}"></router-link>
    
    </office-card>

     </div>

</template>

<script>
import officeCard from '../components/OfficeCard';

export default {
  components:{
    officeCard
  },
  data(){
    return{

    }
  }

}
</script>

<style >

.doctorOffice{
  font-family:"Courier", impact, monospace ;
  margin-top: 60px;
  padding-left:75px;
}

.officeCardTitle {
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
  left:16%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
 
}
.officeCardTitle:before {
  content: "Office Locations Info";
 
  padding-left:55px ;
  width: 650px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.officeCardTitle:after {
  content: "オフィスの場所情報";
   padding-top:10px ;
  padding-left:130px ;
  width: 650px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.officeCardTitle:hover:before {
  top: -50%;
}
.officeCardTitle:hover:after {
  top: 50%;
}

#doctorButton {
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
#doctorButton:before {
  content: "Doctor";
 
  padding-left:1px ;
  width: 150px;
    top:50%;
  left:25%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
#doctorButton:after {
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
#doctorButton:hover:before {
  top: -50%;
}
#doctorButton:hover:after {
  top: 50%;
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
.infoOffice{
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
.infoOffice:before {
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
.infoOffice:after {
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
.infoOffice:hover:before {
  top: -50%;
}
.infoOffice:hover:after {
  top: 50%;
}

.appointmentReviewsQ{
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
.appointmentReviewsQ:before {
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
.appointmentReviewsQ:after {
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
.appointmentReviewsQ:hover:before {
  top: -50%;
}
.appointmentReviewsQ:hover:after {
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

.Office-Info{
        background-image:url("../img/drmario2.jpg");
       background-size:cover;
        background-attachment: fixed;
        background-repeat: no-repeat;
        padding: 50px;
}
</style>