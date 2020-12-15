<template>
  <div class="admin-view-container">
      <h1>Admin Home</h1>
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
  
  .office-info-container {
   margin:20px;
  }
</style>