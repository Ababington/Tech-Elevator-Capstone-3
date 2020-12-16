<template>
    <form v-on:submit.prevent="PostNewAptRequest()" class = "appointmentForm">
        <h2>Appointment Application Form</h2>
        <br/>
        <label for="doctor">Doctor: </label>
        <select name="doctor" v-model="appointment.doctorId" class="feedback-input">
            <option v-for="doctor in doctors" v-bind:key="doctor.userId" v-bind:value="doctor.userId">
                Dr. {{doctor.firstName}} {{doctor.lastName}}
            </option>
        </select><br/>

        <label for="reasonForVisit">Reason for visit: </label><br/>
        <textarea cols=50 rows=10 v-model="appointment.message" placeholder="Please enter the reason for your visit here." class="feedback-input"></textarea><br>

        <label for="date">Date: </label>
        <input type = "date" v-model="appointment.date" class="feedback-input"/>

        <label for="time">Time: </label>
        <input name="time" type="time" v-model="appointment.time" class="feedback-input">
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
                else if (response.status == 409)
                {
                    alert("Doctor is unavilable at this time. Please try another time/date");
                    this.appointment.date = '';
                    this.appointment.time = '';
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
.appointmentForm{
    border: 2px solid rgb(5, 7, 88);
    margin-right:1000px ;
    margin-top: 40px;
    margin-left: 10px;
    margin-bottom: 40px;
    padding: 10px;
    padding-right: 20px;
}
.feedback-input {
  color:rgb(0, 0, 0);
  font-family: Helvetica, Arial, sans-serif;
  font-weight:500;
  font-size: 18px;
  border-radius: 5px;
  line-height: 22px;
  background-color: transparent;
  border:2px solid #CC6666;
  transition: all 0.3s;
  padding: 13px;
  margin-bottom: 15px;
  width:100%;
  box-sizing: border-box;
  outline:0;
}

.feedback-input:focus { border:2px solid #CC4949; }

textarea {
  height: 150px;
  line-height: 150%;
  resize:vertical;
}

[type="submit"] {
  font-family: 'Montserrat', Arial, Helvetica, sans-serif;
  width: 100%;
  background:#CC6666;
  border-radius:5px;
  border:0;
  cursor:pointer;
  color:white;
  font-size:24px;
  padding-top:10px;
  padding-bottom:10px;
  transition: all 0.3s;
  margin-top:-4px;
  font-weight:700;
}
[type="submit"]:hover { background:#CC4949; }
</style>