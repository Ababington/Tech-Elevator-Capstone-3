<template>
  <div class="reviews-img">
    <router-link v-bind:to="{name: 'doctor'}"><button class="doctorReviews" id="doctorReviewsButton" v-on:click="doctor">Home Page</button></router-link>
    <h1 class="reviewsTitle"></h1>

  </div>
</template>

<script>

export default {
  
  data() {
    return {};
  },
};
</script>

<style scoped>

</style>