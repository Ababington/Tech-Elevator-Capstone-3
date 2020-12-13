<template>
  <div class="Office-Info"> 
<h1 class="officeCardTitle">Office Locations Info</h1>
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
  font-family: 'Super Mario Brothers', Courier, monospace;
}
.Office-Info{
        background-image:url("../img/drmario2.jpg");
       background-size:cover;
        background-attachment: fixed;
        background-repeat: no-repeat;
        padding: 50px;
}
</style>