<template>
<div>
  <div>Hello</div>
  
  <label for="name">Name: </label>
  <input type="text" required v-model="this.office.name"/><br>

  <label for="streetAddress" >Street Address: </label>
<input id="streetAddress" required v-model="this.office.streetAddress"/><br>

<label for="streetAddress2">Street Address 2: </label>
<input id="streetAddress2" v-model="this.office.streetAddress2"/><br>

<label for="City" >City: </label>
<input id="City" required v-model="this.office.City"/><br>

<label for="state" >State: </label>
<input id="state" required v-model="this.office.state"/><br>

<label for="zip" >Zip: </label>
<input id="zip" required v-model="this.office.zip"/><br>

<label for="phoneNumber" >Phone Number: </label>
<input id="phoneNumber" required v-model="this.office.phoneNumber"/><br>

<div for="officeHours">Office Hours: </div><br>
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

<button type="submit" v-on:click="createNewOffice()">Create Office</button>

</div>

</template>

<script>
import adminService from '../services/AdminService';

export default {
  data() {
    return {
      office: {
        name: "",
        streetAddress: "",
        streetAddress2: "",
        city: "",
        state: "",
        zip: "",
        phoneNumber: "",
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
    createNewOffice(){
      adminService.createNewOffice(this.office)
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