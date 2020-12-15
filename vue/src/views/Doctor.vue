<template>
  <div class="doctorPage">
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

<style >
.doctorPage{
        background-image:url("../img/drmario5.jpg");
       background-size:cover;
        background-attachment: fixed;
        background-repeat: no-repeat;
        padding:25px ;
        height: 1500px;
}
</style>