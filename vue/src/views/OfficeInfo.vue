<template>
  <div class="Office-Info"> 

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

</style>