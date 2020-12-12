<template>
    <div>
        <div v-for="doctor in doctors" v-bind:key="doctor.id">
          {{doctor.username}}
          <!-- {{doctor.status}} -->
        </div>
    </div>
</template>

<script>
import adminService from '../services/AdminService';

export default {
  data() {
    return {
      doctors: [],
    };
  },
  created() {
        adminService.getPendingDoctors()
        .then(response => {
            this.doctors=response.data;
        })
    }
};
</script>

<style>
</style>