<template>
  <div class="doctor">
   <doctor-buttons/>
  </div>
</template>

<script>

import doctorButtons from '../components/DoctorButtons.vue';

export default {
  components:{
        doctorButtons,
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

.doctor{
        background-image:url("../img/drmario.jpg");
        background-repeat: no-repeat;
        height: cover;
        padding: 50px;
        
}

</style>