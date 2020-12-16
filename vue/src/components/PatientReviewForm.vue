<template>
  <div>
      <form v-on:submit.prevent="PostNewReview()" class="reviewForm">
     
      <label for="office">Office: </label>
      <select name="office" v-model="officeName">
        <option v-for="office in offices" v-bind:key="office.Id">
          {{office.name}}
        </option></select
      ><br />
     
      <label for="rating">Rating (between 1 and 5): </label>
      <input type="number" min="1" max="5" v-model="review.rating" /> <br />

      <label for="message">Message: </label>
      <textarea rows="10" cols="40" v-model="review.message"></textarea><br />

      <label for="anonymous">Do you want this review to be anonymous?</label>
      <select name="anonymous" v-model="review.anonymous">
        <option>true</option>
        <option>false</option></select><br />

      <button type="submit">Post Review</button>
    </form>
  </div>
</template>

<script>
import patientService from "../services/PatientService";

export default {
  data() {
    return {
        officeName:"", 
      offices: [],
      review: {
        officeId: "",
        message: "",
        rating: "",
        anonymous: "",
        userId:""
      },
    };
  },

  created() {
    patientService.GetAllOffices().then((response) => {
      this.offices = response.data;
    });
  },

  methods: {
      getUserId(){
                return this.$store.state.user.userId
        },

      getOfficeIdByName(name){
          let selectedOffices = this.offices.filter(office =>{
              return office.name==name;
          });
          return selectedOffices[0].officeId;
      },

    PostNewReview() {
        this.review.officeId = this.getOfficeIdByName(this.officeName);
        this.review.userId = this.getUserId();
      patientService
        .PostNewReview(this.review)
        .then((response) => {
          if (response.status === 200 || response.status === 201 ) {
              alert("Review Submitted")
            this.review = {}
            this.officeName = ""
          }
        })
        .catch((error) => {
          error.status;
        });
    },
  },
};
</script>

<style>
.reviewForm{
    border: 2px solid black;
    border-radius: 10px;
    font-family: 'Courier New', Courier, monospace;
    background-image: linear-gradient(to bottom right,rgb(218, 236, 53), rgb(255, 255, 255));
       background-size:150%;
        background-repeat: no-repeat;
        background-image: fixed;
        height: 670px;
        width: 470px;
        margin: 50px;
        padding:10px;
        padding-top: 20px;
        margin-left:270px;
        margin-top:125px ;

}
</style>
