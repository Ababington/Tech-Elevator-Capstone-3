<template>
<div>
<form v-on:submit.prevent="postReview">

<label for="yourname" v-if="review.anonymous === No">Please enter your name: </label>
<input type="text" v-model="review.name" v-if="review.anonymous === No"><br>

<label for="office">Office: </label>
<select name="office" v-model="review.office">
    <option v-for="office in offices" v-bind:key="office.Id">{{office.name}}</option>
</select><br>
<label for="rating">Rating (between 1 and 5): </label>
<input type="number" min="1" max="5" v-model="review.rating"> <br>

<label for="message">Message: </label>
<textarea rows="10" cols="50" v-model="office.message"></textarea><br>

<label for="anonymous">Do you want this review to be anonymous?</label>
<select name="anonymous" v-model="review.anonymous">
    <option>Yes</option>
    <option>No</option>
</select><br>

<button type=submit>Post Review</button>





</form>
  </div>
</template>

<script>
import patientService from '../services/PatientService.js'

export default {

    data(){
        return{
            offices: [],
            review:{
                office: "",
                message: "",
                rating: "",
                anonymous: "",
                name: ""
            }
        }
    },

    created() {
patientService.getAllOffices().then((response) => {
    this.offices = response.data;
})
    },

    methods: {
        postReview(){
            patientService.PostNewReview(this.review).then((response) => {
                if(response.status === 201){
                    this.review = [];
                }
            }).catch((error) => {
                error.status;
            })
        }
    }

}
</script>

<style >

</style>