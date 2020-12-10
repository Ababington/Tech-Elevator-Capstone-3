<template>
<div class='patient'>
     <div v-for="patient in patient" v-bind:key="patient.id"></div>
    <button class="appointment" v-on:click="appointments">Request appointment</button>
    <button class="office" v-on:click="officeInfo">Office Info</button>
    <button class="reviews" v-on:click="reviews">Reviews</button>
</div>
</template>

<script>
export default {

}
</script>

<style>

</style>