<template>
  <div class="admin-view-container">
      <h1>Home</h1>
      <div class="office-info-container">
        <new-office-form/>
      </div>
      <div class="register-doctor-container">
        <admin-pending-doctors/>
      </div>
  </div>
</template>

<script>
import newOfficeForm from'../components/NewOfficeForm';
import adminPendingDoctors from '../components/AdminPendingDoctors';

export default {
    components:{
        newOfficeForm,
        adminPendingDoctors
    }
}
</script>

<style >
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