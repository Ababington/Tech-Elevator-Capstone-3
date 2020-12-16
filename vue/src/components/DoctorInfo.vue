<template>
<div class="hours">
<form v-on:submit.prevent="updateInfo()">
  <div for="officeHours">Doctors Available Hours: </div><br>
<label for="monday">Monday</label>
<input for="monday" type ="time" v-model="doctor.weeklyHours.monday.start"/>
<input for="monday" type ="time" v-model="doctor.weeklyHours.monday.end"/><br>
<label for="tuesday">Tuesday</label>
<input for="tueday" type ="time" v-model="doctor.weeklyHours.tuesday.start"/>
<input for="tueday" type ="time" v-model="doctor.weeklyHours.tuesday.end"/><br>
<label for="wednesday">Wednesday</label>
<input for="wednesday" type ="time" v-model="doctor.weeklyHours.wednesday.start"/>
<input for="wednesday" type ="time" v-model="doctor.weeklyHours.wednesday.end"/><br>
<label for="thursday">Thursday</label>
<input for="thursday" type ="time" v-model="doctor.weeklyHours.thursday.start"/>
<input for="thursday" type ="time" v-model="doctor.weeklyHours.thursday.end"/><br>
<label for="friday">Friday</label>
<input for="friday" type ="time" v-model="doctor.weeklyHours.friday.start"/>
<input for="friday" type ="time" v-model="doctor.weeklyHours.friday.end"/><br>
<label for="saturday">Saturday</label>
<input for="saturday" type ="time" v-model="doctor.weeklyHours.saturday.start"/>
<input for="saturday" type ="time" v-model="doctor.weeklyHours.saturday.end"/><br>
<label for="sunday">Sunday</label>
<input for="sunday" type ="time" v-model="doctor.weeklyHours.sunday.start"/>
<input for="sunday" type ="time" v-model="doctor.weeklyHours.sunday.end"/><br>


<div for="costPerHour"><b>Cost Per Hour:</b></div>
<input type="number" v-model="this.doctor.hourlyRate"/>


<button class="updatemyinfo" type="submit">Update My Information</button>
</form>
</div>


</template>

<script>
import doctorService from '../services/DoctorService';

export default {
  data() {
    return {
      doctor:{

      
      weeklyHours: {
      
        monday: {
          start: "",
          end: "",
        },

        tuesday: {
          start: "",
          end: "",
        },

        wednesday: {
          start: "",
          end: "",
        },

        thursday: {
          start: "",
          end: "",
        },

        friday: {
          start: "",
          end: "",
        },

        saturday: {
          start: "",
          end: "",
        },

        sunday: {
          start: "",
          end: "",
        },
      },

      UserId: "",
      HourlyRate: "",
      FirstName: "",
      LastName: "",
      user_Role: "",
      
      }
      
    };
  },
  methods:{
    createSchedule(){
      doctorService.createNewOffice(this.office)
      .then(response => {
        if(response.status === 201)
        {
          this.office = [];
        }
      }) 
    },
    updateInfo(){
      doctorService.UpdateMyInfo(this.doctor)
      .then(response => {
        if(response.status === 200)
        {
        doctorService.GetMyInfo(this.$store.state.user.userId).then((response) => {
        this.doctor = response.data;
        alert("Your information has been updated!");
      });
        }
      })
    }
   
  },

  created(){
      doctorService.GetMyInfo(this.$store.state.user.userId).then((response) => {
        this.doctor = response.data;
      })
    }
};
</script>

<style >
.hours{
  border: 2px solid black;
  background-image: linear-gradient(to bottom right,rgb(218, 236, 53), rgb(255, 255, 255));
  font-weight:bold;
  text-align: right;
  width: 380px;
  margin-left: 200px;
  margin-top: 150px;
  padding: 20px;
}
.updatemyinfo{
  margin-top:15px;
  margin-bottom:5px;
}

</style>