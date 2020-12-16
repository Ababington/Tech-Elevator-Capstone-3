<template>
<div class="hours">
  <form v-on:submit.prevent="updateInfo()">
  <h2 for="officeHours">Doctors Available Hours</h2>
  <label>医師の利用可能時間</label><br>
  <label>______________________________________________</label><br>
        <label>______________________________________________</label><br><br>
        <div class="hourSchedule">

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

        </div>
        <label>______________________________________________</label><br>
        <label>______________________________________________</label><br><br>

        
<div class="costPerHourBtnFull">
<div for="costPerHour" class="costPerHourBtn"><b>Cost Per Hour</b> | 時間あたりのコスト:</div>
<input type="number" v-model="this.doctor.hourlyRate"/><br>


<button class="updatemyinfo" type="submit">Update My Information</button>


</div>
  </form>
</div>


</template>

<script>
import doctorService from '../services/DoctorService';
// import patientService from '../services/PatientService';

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
    GetAllOffices(){

    },
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
.costPerHourBtnFull{
  margin-bottom: 20px;
}
.costPerHourBtn{
  margin-bottom:20px ;
}
.submitSchedule{
  margin-top: 20px;
}
.hourSchedule{
  text-align: right;
}
.hours{
  border: 2px solid black;
   border-radius: 10px;
  background-image: linear-gradient(to bottom right,rgb(218, 236, 53), rgb(255, 255, 255));
  font-family: 'Courier New', Courier, monospace;
  width: 490px;
  margin-left: 245px;
  margin-top: 150px;
  padding: 20px;
}
.updatemyinfo{
  margin-top:15px;
  margin-bottom:5px;
}
[class="updatemyinfo"] {
  font-family: 'Montserrat', Arial, Helvetica, sans-serif;
  width: 100%;
  background:#CC6666;
  border-radius:5px;
  border:0;
  cursor:pointer;
  color:white;
  font-size:24px;
  padding-top:10px;
  padding-bottom:10px;
  transition: all 0.3s;
  margin-top:20px;
  font-weight:700;
}
[class="updatemyinfo"]:hover { background:#CC4949; }
</style>