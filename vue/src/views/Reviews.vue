<template>
  <div class="reviews-img">
            <router-link v-bind:to="{name: 'patient'}"><button v-on:click="patient">Home Page</button></router-link>
    <router-link v-bind:to="{name: 'patientOfficeInfo'}"><button v-on:click="patientOfficeInfo">Office Info</button></router-link>

    <h1 class="reviewsTitle"></h1>
  <review-card/>
  </div>
</template>

<script>
import reviewCard from '../components/ReviewCard'
export default {
components: {
  reviewCard

},
  data() {
    return {};
  },
};
</script>

<style scoped>
.reviews-img{
        background-image:url("../img/chansey5.jpg");
        padding: 50px;
       background-size:cover;
        background-attachment: fixed;
        background-repeat: no-repeat;
        height: 945px;
        }
</style>