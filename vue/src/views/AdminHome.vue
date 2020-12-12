<template>
  <div class="admin-view-container">
      <h1>Home</h1>
      <div class="office-info-container">
      <new-office-form/>
    
      <div v-for="doctor in doctors" v-bind:key="doctor.id">
          
          {{doctor.username}}
          <!-- {{doctor.status}} -->
          </div>
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
  .admin-view-container {
    display: grid;
    grid-template-columns: 2fr, 1fr;
    grid-template-areas: 
      "office-info register-doctor";
  }
  .office-info-container {
    grid-area: "office-info"
  }
  .register-doctor-container {
    grid-area: "register-doctor"
  }
</style>