<template>
  <div>
      <div class="card">
        <h2>{{office.name}}</h2>
        <div>
          {{office.address}}<br/>
          {{office.address2}}<br/>
          {{office.city}}<br/>
          {{office.state}}<br/>
          {{office.zip}}<br/>
          Phone: {{office.phone}}<br/>
          </div>
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
    height: 250px;
    margin: 20px;
}

</style>