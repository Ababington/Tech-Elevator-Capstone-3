<template>
  <div>
    <h2 class="doctorsList">Doctors List:</h2>
    <!--v-on:submit.prevent="ApproveDoctorUser()"-->
   
      <div v-for="doctor in doctors" v-bind:key="doctor.id">
        <label class="doctorUserName">{{ doctor.username }}</label>
        <label class="doctorStatus">{{returnDoctorStatus(doctor)}}</label>
        <button>Status</button>
       
        
      </div>
   

  </div>
</template>

<script>
import adminService from "../services/AdminService";

export default {
 
  data() {
    return {
      doctors: [],
    }
  },
  created() {
      adminService.GetPendingDoctors().then((response) => {
        this.doctors = response.data;
      })
    },
  methods: {
    returnDoctorStatus(doctor){
      if(doctor.role == "doctor"){
        return "Not Activated"
      }
      else if(doctor.role == "doctorVerified")
    {
      return "Activated"
    }
    else{
      return "Check Me"
    }
    
    },
    
    // ApproveDoctorUser() {
    //   adminService.ApproveDoctorUser(this.doctor).then((response) => {
    //     if (response.status === 200 || response.status === 201) {
    //       alert("Doctor Status Confirmed");
    //       this.$router.push("adminHome");
    //     }
    //   });
    // }, 
    
  },
};
</script>

<style >
.statusBtn{
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
}
.doctorsList{
  margin-left: 10px;
}
.doctorUserName{
  border: 2px solid black;
  padding: 2px;
  margin: 2px;
  margin-left: 10px;
}
.doctorStatus{
  border: 2px solid black;
  padding: 2px;
  margin: 2px;
}
</style>