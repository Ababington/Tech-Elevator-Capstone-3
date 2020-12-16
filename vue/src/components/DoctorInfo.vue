<template>
<div class="hours">
  <h2 for="officeHours">Doctors Available Hours</h2>
  <label>医師の利用可能時間</label><br>
  <label>______________________________________________</label><br>
        <label>______________________________________________</label><br><br>
        <div class="hourSchedule">
<label for="monday">Monday:</label>
<input for="monday" type ="time" v-model="this.doctor.weeklyHours.monday.start"/>
<input for="monday" type ="time" v-model="this.doctor.weeklyHours.monday.end"/><br>
<label for="tuesday">Tuesday:</label>
<input for="tueday" type ="time" v-model="this.doctor.weeklyHours.tuesday.start"/>
<input for="tueday" type ="time" v-model="this.doctor.weeklyHours.tuesday.end"/><br>
<label for="wednesday">Wednesday:</label>
<input for="wednesday" type ="time" v-model="this.doctor.weeklyHours.wednesday.start"/>
<input for="wednesday" type ="time" v-model="this.doctor.weeklyHours.wednesday.end"/><br>
<label for="thursday">Thursday:</label>
<input for="thursday" type ="time" v-model="this.doctor.weeklyHours.thursday.start"/>
<input for="thursday" type ="time" v-model="this.doctor.weeklyHours.thursday.end"/><br>
<label for="friday">Friday:</label>
<input for="friday" type ="time" v-model="this.doctor.weeklyHours.friday.start"/>
<input for="friday" type ="time" v-model="this.doctor.weeklyHours.friday.end"/><br>
<label for="saturday">Saturday:</label>
<input for="saturday" type ="time" v-model="this.doctor.weeklyHours.saturday.start"/>
<input for="saturday" type ="time" v-model="this.doctor.weeklyHours.saturday.end"/><br>
<label for="sunday">Sunday:</label>
<input for="sunday" type ="time" v-model="this.doctor.weeklyHours.sunday.start"/>
<input for="sunday" type ="time" v-model="this.doctor.weeklyHours.sunday.end"/><br>

<button type="submit" v-on:click="createSchedule" class="submitSchedule">Submit Schedule</button>
        </div>
        <label>______________________________________________</label><br>
        <label>______________________________________________</label><br><br>
<div class="costPerHourBtnFull">
<div class="costPerHourBtn" for="costPerHour"><b>Cost Per Hour</b> | 時間あたりのコスト:</div>
<input type="number" v-model="this.doctor.hourlyRate"/>
<button type="submit" v-on:click="updateHourlyRate">Confirm Hourly Rate</button>
</div>
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
      User_Role: "",
      
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
    updateHourlyRate(){
      doctorService.hourlyRate(this.doctor)
      .then(response => {
        if(response.status === 200)
        {
          this.doctor = [];
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
.createScheduleBtn{
  margin-top:5px;
  margin-bottom:50px;
}
.updateHourlyRateBtn{
  margin-top:5px;
}
</style>