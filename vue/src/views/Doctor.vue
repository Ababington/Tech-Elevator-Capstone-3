<template>
  <div class="doctor">
    <router-link v-bind:to="{name: 'appointmentRequest'}"><button class="appointmentRequest" v-on:click="appointmentRequests">Appointment Requests</button></router-link>
     <router-link v-bind:to="{name: 'officeInfo'}"><button class="office" v-on:click="officeInfo">Office Info</button></router-link>
    <router-link v-bind:to="{name: 'reviews'}"><button class="reviews" v-on:click="reviews">Reviews</button></router-link>
    <router-link v-bind:to="{name: 'viewSchedule'}"><button class="viewSchedule" v-on:click="viewSchedule">Views Schedule</button></router-link>

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