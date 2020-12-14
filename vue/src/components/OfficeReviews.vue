<template>
<div>
<div v-for="review in reviews" v-bind:key="review.reviewId" v-bind:review="review">
<review-card/>

</div>
</template>

<script>
import Review from "../components/ReviewCard"
export default {

    components: ReviewCard,

    data(){
        return{
            reviews: []
        }
    }

}
</script>

<style>

</style>