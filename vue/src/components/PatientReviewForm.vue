<template>
  <div>
      <form v-on:submit.prevent="PostNewReview()" class="reviewForm">
     
      <label for="office">Office: </label>
      <select name="office" v-model="officeName" class="feedback-input">
        <option v-for="office in offices" v-bind:key="office.Id">
          {{office.name}}
        </option></select
      ><br />
      <label for="rating">Rating (between 1 and 5): </label>
      <input type="number" min="1" max="5" v-model="review.rating" class="feedback-input"/> <br />

      <label for="message">Message: </label>
      <textarea rows="10" cols="50" v-model="review.message" placeholder="Give us your feedback here!" class="feedback-input"></textarea><br />

      <label for="anonymous">Do you want this review to be anonymous?</label>
      <select name="anonymous" v-model="review.anonymous" class="feedback-input">
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

<style scoped>
.reviewForm{
    border: 2px solid rgb(5, 7, 88);
    margin-right:1000px ;
    margin-top: 40px;
    margin-left: 10px;
    margin-bottom: 40px;
    padding: 10px;
    padding-right: 20px;
}


.feedback-input {
  color:rgb(5, 1, 1);
  font-family: Helvetica, Arial, sans-serif;
  font-weight:500;
  font-size: 18px;
  border-radius: 5px;
  line-height: 22px;
  background-color: transparent;
  border:2px solid #CC6666;
  transition: all 0.3s;
  padding: 13px;
  margin-bottom: 15px;
  width:100%;
  box-sizing: border-box;
  outline:0;
}

.feedback-input:focus { border:2px solid #CC4949; }

textarea {
  height: 150px;
  line-height: 150%;
  resize:vertical;
}

[type="submit"] {
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
  margin-top:-4px;
  font-weight:700;
}
[type="submit"]:hover { background:#CC4949; }
</style>
