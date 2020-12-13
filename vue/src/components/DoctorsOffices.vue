<template>
<div>
<div v-for="office in office" v-bind:key="office.id">
    {{office.name}}
    {{'info to display'}}

</div>

</template>

<script>
export default {
data(){
    return{
        offices: []
    }
}

}
</script>

<style>

</style>