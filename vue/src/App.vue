<template>
  <div id="app">
    <div id="nav">
      <span class="homeChange" data-hover="ホーム"><router-link class="header" v-bind:to="{ name: 'home' }">Home</router-link>&nbsp;|&nbsp;</span>
      <span><router-link class="header" v-bind:to="{ name: 'logout' }" v-if="$store.state.token != ''">Logout</router-link></span>
    </div>
    <router-view />
  </div>
</template>

<style scoped>
.header{
  font-family: 'MS UI Gothic', impact, monospace;
}

.homeChange:hover{
  font-size: 20px;
}

.homeChange:hover:after{
  font-size: 20px;
  content: attr(date-hover);
}
</style>
