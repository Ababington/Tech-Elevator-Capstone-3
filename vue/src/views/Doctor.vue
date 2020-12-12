<template>
  <div class="doctor">
    <router-link v-bind:to="{name: 'appointmentRequests'}"><button class="appointmentRequests" v-on:click="appointmentRequests">Appointment Requests</button></router-link>
     <router-link v-bind:to="{name: 'officeInfo'}"><button class="office" v-on:click="officeInfo">Office Info</button></router-link>
    <button class="reviews" v-on:click="reviews">Reviews</button>
    <button class="schedule" v-on:click="schedule">View Schedule</button>

  <doctor-info/>

  </div>
</template>

<script>

import doctorInfo from '../components/DoctorInfo';

export default {
  components:{
        doctorInfo
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

<style>
</style>