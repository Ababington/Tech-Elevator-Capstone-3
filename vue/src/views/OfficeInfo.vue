<template>
  <div class="Office-Info"> 
    <router-link v-bind:to="{name: 'doctor'}"><button class="doctorOffice" id="doctorButton" v-on:click="doctor">Home Page</button></router-link>
<h1 class="officeCardTitle"></h1>

    <office-card v-bind:office="office" v-bind:key='office.id' v-for="office in $store.state.officesStatic">
    <router-link v-bind:to="{name: 'officeInfo', params: {id:office.id}}"></router-link>
    
    </office-card>

     </div>

</template>

<script>
import officeCard from '../components/OfficeCard';

export default {
  components:{
    officeCard
  },
  data(){
    return{

    }
  }

}
</script>

<style>

.doctorOffice{
  font-family:"Courier", impact, monospace ;
  margin-top: 60px;
  padding-left:75px;
}

.officeCardTitle {
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
  width: 650px;
  top:4%;
  left:16%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
 
}
.officeCardTitle:before {
  content: "Office Locations Info";
 
  padding-left:55px ;
  width: 650px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.officeCardTitle:after {
  content: "オフィスの場所情報";
   padding-top:10px ;
  padding-left:130px ;
  width: 650px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.officeCardTitle:hover:before {
  top: -50%;
}
.officeCardTitle:hover:after {
  top: 50%;
}

#doctorButton {
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
  top:8%;
  left:7%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
 
}
#doctorButton:before {
  content: "Doctor";
 
  padding-left:1px ;
  width: 150px;
    top:50%;
  left:25%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
#doctorButton:after {
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
#doctorButton:hover:before {
  top: -50%;
}
#doctorButton:hover:after {
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