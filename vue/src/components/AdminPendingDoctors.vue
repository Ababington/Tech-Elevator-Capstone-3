<template>
  <div>
    <form v-on:submit.prevent="ApproveDoctorUser()">
      <div
        v-for="doctor in doctors"
       
        v-bind:key="doctor.id"
      >
        {{ doctor.username }}
       
        <button type="submit" v-on:click="user.user_role = 'approve'" >Approve Doctor Status</button>
      </div>
    </form>
  </div>
</template>

<script>
import adminService from "../services/AdminService";

export default {
  data() {
    return {
      user: {
        user_role: "",
      },
      doctors: [],
    };
  },
  methods: {
    ApproveDoctorUser() {
      adminService.ApproveDoctorUser(this.doctor).then((response) => {
        if (response.status === 200 || response.status === 201) {
          alert("Doctor Status Confirmed");
          this.$router.push("adminHome");
        }
      });
    },
    created() {
      adminService.GetPendingDoctors().then((response) => {
        this.doctors = response.data;
      });
    },
  },
};
</script>

<style>
</style>