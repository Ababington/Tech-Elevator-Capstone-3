<template>
  <div class="marioToad">
    <h1 class="patientOfficeInfoReviews"></h1>

    <patient-buttons/>
  </div>
</template>

<script>
import patientButtons from '../components/PatientButtons';

export default {
    components:{
        patientButtons
    }
}
</script>

<style>
.marioToad{
        background-image:url("../img/marioToad.jpg");
        background-size:cover;
        background-attachment: fixed;
        background-repeat: no-repeat;
        background-color: #ecccff;
        padding:25px ;
        height: 1500px;
}

.doctorAppointmentTitleHere {
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
  width: 730px;
  top: 10.5%;
  left: 23.4%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.doctorAppointmentTitleHere:before {
  content: "Reviews Page";

  padding-left: 25px;
  width: 650px;
  top: 50%;
  left: 75%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.doctorAppointmentTitleHere:after {
  content: "レビューページ";
  padding-top: 10px;
  padding-left: 110px;
  width: 650px;
  top: 50%;
  left: 61.5%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.doctorAppointmentTitleHere:hover:before {
  top: -50%;
}
.doctorAppointmentTitleHere:hover:after {
  top: 50%;
}
</style>