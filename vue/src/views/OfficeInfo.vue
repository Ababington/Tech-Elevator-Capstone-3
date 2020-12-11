<template>
  <div> 

     <div v-on:click='submit' v-for="office in office" v-bind:key="office.id">
          
          {{office.id}}
      

  </div>
</template>

<script>
export default {
  data(){
    return
  }

}
</script>

<style>

</style>