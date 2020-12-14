<template>
  <div class="reviews-img">
    <router-link v-bind:to="{name: 'doctor'}"><button class="doctorReviews" id="doctorReviewsButton" v-on:click="doctor">Home Page</button></router-link>
    <h1 class="reviewsTitle"></h1>

  </div>
</template>

<script>

export default {
  
  data() {
    return {};
  },
};
</script>

<style>
.doctorReviews{
  font-family:"Courier", impact, monospace ;
  margin-top: 60px;
  margin-left: 40px;
  padding-left: 75px;
}
.reviewsTitle {
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image: linear-gradient(
    to bottom right,
    rgb(255, 255, 255),
    rgb(228, 228, 228)
  );
  height: 60px;
  width: 250px;
  top:10%;
  left:10%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
 
}
.reviewsTitle:before {
  content: "Reviews";
 
  padding-left:40px ;
  width: 250px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.reviewsTitle:after {
  content: "レビュー";
   padding-top:10px ;
  padding-left:90px ;
  width: 350px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.reviewsTitle:hover:before {
  top: -50%;
}
.reviewsTitle:hover:after {
  top: 50%;
}

.reviews-img {
  background-image: url("../img/drmario3.jpg");
  background-size: cover;
  background-attachment: fixed;
  background-repeat: no-repeat;
  height: 1100px;
  padding: 50px;
}

#doctorReviewsButton {
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image: linear-gradient(
    to bottom right,
    rgb(255, 255, 255),
    rgb(228, 228, 228)
  );
  height: 35px;
  width: 180px;
  top:10%;
  left:7%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
 
}
#doctorReviewsButton:before {
  content: "Doctor";
 
  padding-left:1px ;
  width: 150px;
    top:50%;
  left:25%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
#doctorReviewsButton:after {
  content: "医師";
   padding-top:3px ;
  padding-left:1px ;
  width: 150px;
    top:50%;
  left:30%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
#doctorReviewsButton:hover:before {
  top: -50%;
}
#doctorReviewsButton:hover:after {
  top: 50%;
}

.Office-Info{
        background-image:url("../img/drmario2.jpg");
       background-size:cover;
        background-attachment: fixed;
        background-repeat: no-repeat;
        padding: 50px;
}
</style>