<template>
  <div class="schedule-Info"> 
    <router-link v-bind:to="{name: 'doctor'}"><button class="doctor" v-on:click="doctor">Doctor Home Page</button></router-link>
<h1 class="scheduleTitle"></h1>
   
     </div>

</template>

<script>

export default {
  
  data(){
    return{

    }
  }

}
</script>

<style>

.scheduleTitle {
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
  width: 350px;
  top:8%;
  left:26%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
 
}
.scheduleTitle:before {
  content: "Schedule";
 
  padding-left:75px ;
  width: 350px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.scheduleTitle:after {
  content: "スケジュール";
   padding-top:10px ;
  padding-left:100px ;
  width: 450px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.scheduleTitle:hover:before {
  top: -50%;
}
.scheduleTitle:hover:after {
  top: 50%;
}

.schedule-Info{
        background-image:url("../img/drmario2.jpg");
       background-size:cover;
        background-attachment: fixed;
        background-repeat: no-repeat;
        height:1100px;
        padding: 50px;
}
</style>