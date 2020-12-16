<template>
    <form class="appointment-form" v-on:submit.prevent="PostNewAptRequest()">

        <h2>Submit Appointment Form</h2>
        <label>予約フォームを送信する</label>
        <br/>
        <label>______________________________________________</label><br>
        <label>______________________________________________</label><br><br>
        <label for="doctor"><b>Doctor </b>| 医師:</label>
        <select name="doctor" v-model="appointment.doctorId">
            <option v-for="doctor in doctors" v-bind:key="doctor.userId" v-bind:value="doctor.userId">
                Dr. {{doctor.firstName}} {{doctor.lastName}}
            </option>
        </select><br/>
        <div class="reasonForVisitMessage">
        <label for="reasonForVisit"><b>Reason for visit</b> | 訪問の理由: </label><br/>
        <textarea cols=40 rows=8 v-model="appointment.message"></textarea><br>
        </div>
        <div class="dateTime">
        <label for="date"><b>Date</b> | 日付: </label>
        <input type = "date" v-model="appointment.date"/>
        </div>
        <label for="time"><b>Time</b> | 時間: </label>
        <input name="time" type="time" v-model="appointment.time">
        <br/><br/>

        <button type="submit">Submit Appointment Request</button>
    </form>
</template>

<script>
import patientService from '../services/PatientService'
export default {
    data(){
        return{
            appointment: {
                patientId: '',
                doctorId: '',
                message: '',
                date: '',
                time: '',
                status: "Pending"
            },
            doctors: []
        }
    },

    methods: {
        getUserId(){
            return this.$store.state.user.userId
        },

        PostNewAptRequest() {
            patientService.CreateAppointmentRequest(this.appointment)
            .then((response) => {
                if (response.status === 200 || response.status === 201 ) {
                    alert("Appointment Submitted");
                    this.appointment = {};
                }
            })
            .catch((error) => {
                error.status;
            });
        }
    },

    created(){
      this.appointment.patientId = this.getUserId();
      patientService.GetAllDoctors()
      .then((response) => {
          this.doctors = response.data;
      });
    }

}
</script>

<style >

.submitJapanese{
    text-align: center;
    text-decoration: overline;
}
.dateTime{
    margin-top:5px ;
}
.reasonForVisitMessage{
    margin-top:20px ;
    margin-left: 10px;
}
.appointment-form{
    border: 2px solid black;
    border-radius: 10px;
    font-family: 'Courier New', Courier, monospace;
    background-image: linear-gradient(to bottom right, rgb(255, 255, 255), rgb(218, 236, 53));
       background-size:150%;
        background-repeat: no-repeat;
        background-image: fixed;
        width: 470px;
        margin: 50px;
        padding:10px;
        padding-top: 20px;
        margin-left:270px;
        margin-top:125px ;
}
</style>