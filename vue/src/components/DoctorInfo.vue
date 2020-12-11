<template>
<div>
  <div for="officeHours">Doctors Available Hours: </div><br>
<label for="monday">Monday</label>
<input for="monday" type ="time" v-model="this.office.monday.start"/>
<input for="monday" type ="time" v-model="this.office.monday.end"/><br>
<label for="tuesday">Tuesday</label>
<input for="tueday" type ="time" v-model="this.office.tuesday.start"/>
<input for="tueday" type ="time" v-model="this.office.tuesday.end"/><br>
<label for="wednesday">Wednesday</label>
<input for="wednesday" type ="time" v-model="this.office.wednesday.start"/>
<input for="wednesday" type ="time" v-model="this.office.wednesday.end"/><br>
<label for="thursday">Thursday</label>
<input for="thursday" type ="time" v-model="this.office.thursday.start"/>
<input for="thursday" type ="time" v-model="this.office.thursday.end"/><br>
<label for="friday">Friday</label>
<input for="friday" type ="time" v-model="this.office.friday.start"/>
<input for="friday" type ="time" v-model="this.office.friday.end"/><br>
<label for="saturday">Saturday</label>
<input for="saturday" type ="time" v-model="this.office.saturday.start"/>
<input for="saturday" type ="time" v-model="this.office.saturday.end"/><br>
<label for="sunday">Sunday</label>
<input for="sunday" type ="time" v-model="this.office.sunday.start"/>
<input for="sunday" type ="time" v-model="this.office.sunday.end"/><br>

<button type="submit" v-on:click="createSchedule()">Submit Schedule</button>

</div>

</template>

<script>
import doctorService from '../services/DoctorService';

export default {
  data() {
    return {
      office: {
      
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
    }
  }
};
</script>

<style>

</style>