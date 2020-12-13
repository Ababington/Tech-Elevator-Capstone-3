<template>
  <div class="Office-Info"> 
<h1 class="officeCardTitle"><b>Office Locations Info</b></h1>
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

.officeCardTitle{
  font-family: 'Courier', impact, monospace;
  border: 2px solid rgb(160, 160, 160);
    border-radius: 10px;
    background-image: linear-gradient(to bottom right, rgb(255, 134, 154), rgb(255, 255, 255));
    width: 550px;
    padding: 15px;
}
.Office-Info{
        background-image:url("../img/drmario2.jpg");
       background-size:cover;
        background-attachment: fixed;
        background-repeat: no-repeat;
        padding: 50px;
}
</style>