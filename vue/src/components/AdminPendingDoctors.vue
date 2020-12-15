<template>
  <div>
    <h2>Doctors should appear here</h2>
    <!--v-on:submit.prevent="ApproveDoctorUser()"-->
   
      <div v-for="doctor in doctors" v-bind:key="doctor.id">
        {{ doctor.username }}
       
        
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
</style>