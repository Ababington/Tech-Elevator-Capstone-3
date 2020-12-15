<template>
  <div>
<router-link v-bind:to="{name: 'writeAReview'}"><button>Write A Review</button></router-link>
<router-link v-bind:to="{name: 'allDoctorPatient'}" v-on:click="allDoctorPatient"><button>View All Doctors</button></router-link>
<router-link v-bind:to="{name: 'patient'}"><button>Book An Appointment</button></router-link>


    </div>
</template>

<script>
export default {

}
</script>
 
<style >

</style>