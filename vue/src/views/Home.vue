<template>
  <div class="home">
    <h1>Home</h1>
    <p>You must be authenticated to see this</p>
    <dr-mario-img/>
  </div>
  
</template>

<script>
import drMarioImg from '../components/DrMarioImg.vue'
export default {
  components:{
    drMarioImg
  },
  name: "home"
};
</script>
