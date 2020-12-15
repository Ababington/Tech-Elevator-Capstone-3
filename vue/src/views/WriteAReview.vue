<template>
<div class="writeReviewImg">
  <patient-review-form/>
</div>
</template>

<script>
import patientReviewForm from '../components/PatientReviewForm';

export default {
    components:{
        patientReviewForm
    }

}
</script>

<style >
.writeReviewImg{
        background-image:url("../img/chansey.jpg");
        padding: 50px;
       background-size:cover;
        background-attachment: fixed;
        background-repeat: no-repeat;
        height: 945px;
        }
</style>