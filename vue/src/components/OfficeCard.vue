<template>
  <div>
      
      <h1 class="officeCardTitle">Office Location Info</h1>
      <div class="officeCard">
        <h2>{{office.name}}</h2>
        <img class="hospital-image" :src='office.image'/>
        <div class="block-border">
            <span class="inline-border">
          Address: {{office.address}}<br/>
          {{office.address2}}<br/>
          City: {{office.city}}<br/>
          State: {{office.state}}<br/>
          Zip: {{office.zip}}<br/>
          Phone: {{office.phone}}<br/>
          </span>
          </div>
      </div>

      
    
  </div>
  
</template>

<script>
export default {
    props: {
        office: Object,
    },
    
}
</script>

<style>

.officeCard {
    border: 2px solid black;
    border-radius: 10px;
    width: 275px;
    background-image: linear-gradient(to bottom right, red, yellow);
    background-color: rgb(219, 219, 219);
    height: cover;
    padding: 10px;
    margin: 50px;
    margin-left: 150px;
}

.officeCardTitle {
  margin: 50px;
}

.block-border{
    display: block; 
	padding: 5px; 
}

.inline-border{
    border: 1px
}

.hospital-image {
  border: 2px solid rgb(51, 51, 51);
  width: 250px;
}

</style>