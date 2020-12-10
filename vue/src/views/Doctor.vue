<template>
  <div class="doctor">
    <div v-for="doctor in doctors" v-bind:key="doctor.id"></div>
    <button class="appointment" v-on:click="appointments">Appointment Requests</button>
    <button class="office" v-on:click="officeInfo">Office Info</button>
    <button class="reviews" v-on:click="reviews">Reviews</button>
    <button class="schedule" v-on:click="schedule">View Schedule</button>
  </div>
</template>

<script>
export default {
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