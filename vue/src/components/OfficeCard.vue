<template>
  <div>
      <div class="card">
        <h2>{{office.officeOne.name}}</h2>
      </div>
      
    
  </div>
  
</template>

<script>
export default {
    props: {
        office: Object,
    }
}
</script>

<style>
.card {
    border: 2px solid black;
    border-radius: 10px;
    width: 250px;
    height: 550px;
    margin: 20px;
}

</style>