<template>
  <div class="home">
      <h1>Home</h1>
      <new-office-form/>
    
      <div v-for="doctor in doctors" v-bind:key="doctor.id">
          
          {{doctor.username}}
          <!-- {{doctor.status}} -->
      </div>
  </div>
</template>

<script>
import adminService from '../services/AdminService';
import newOfficeForm from'../components/NewOfficeForm';

export default {
    components:{
        newOfficeForm
    },
    data() {
        return {
          doctors:[]
        }
    },
    created() {
        adminService.getPendingDoctors()
        .then(response => {
            this.doctors=response.data;
        })
    }
}
</script>

<style>

</style>