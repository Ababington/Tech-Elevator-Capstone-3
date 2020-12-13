import Vue from 'vue'
import Router from 'vue-router'
import Home from '../views/Home.vue'
import Login from '../views/Login.vue'
import Logout from '../views/Logout.vue'
import Register from '../views/Register.vue'
import store from '../store/index'
import adminHome from '../views/AdminHome.vue'
import doctor from '../views/Doctor.vue'
import patient from '../views/Patient.vue'
import reviews from '../views/Reviews.vue'
import officeInfo from '../views/OfficeInfo.vue'
import officePageInfo from '../views/officePageInfo.vue'
import viewSchedule from '../views/ViewSchedule.vue'
import appointmentRequest from '../views/AppointmentRequest.vue'
import DoctorsOffices from '../views/DoctorsOfficesView'

Vue.use(Router)

/**
 * The Vue Router is used to "direct" the browser to render a specific view component
 * inside of App.vue depending on the URL.
 *
 * It also is used to detect whether or not a route requires the user to have first authenticated.
 * If the user has not yet authenticated (and needs to) they are redirected to /login
 * If they have (or don't need to) they're allowed to go about their way.
 */

const router = new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    {
      path: '/',
      name: 'home',
      component: Home,
      meta: {
        requiresAuth: true
      }
    },
    {
      path: "/login",
      name: "login",
      component: Login,
      meta: {
        requiresAuth: false
      }
    },
    {
      path: "/logout",
      name: "logout",
      component: Logout,
      meta: {
        requiresAuth: false
      }
    },
    {
      path: "/register",
      name: "register",
      component: Register,
      meta: {
        requiresAuth: false
      }
    },
    {
      path: "/doctor",
      name: "doctor",
      component: doctor,
      meta: {
        requiresAuth: false
      }
    },
    {
      path: "/patient",
      name: "patient",
      component: patient,
      meta: {
        requiresAuth: false
      }
    },
    {
      path: "/officeInfo",
      name: "officeInfo",
      component: officeInfo,
      meta: {
        requiresAuth: false
      }
    },
    {
      path: "/officePageInfo",
      name: "officePageInfo",
      component: officePageInfo,
      meta: {
        requiresAuth: false
      }
    },
    {
      path: "/appointmentRequest",
      name: "appointmentRequest",
      component: appointmentRequest,
      meta: {
        requiresAuth: false
      }
    },
    {
      path: "/reviews",
      name: "reviews",
      component: reviews,
      meta: {
        requiresAuth: false
      }
    },
    {
      path: "/viewSchedule",
      name: "viewSchedule",
      component: viewSchedule,
      meta: {
        requiresAuth: false
      }
    },
    {
      path: "/adminHome",
      name: "adminHome",
      component: adminHome,
      meta: {
        requiresAuth: true
      }
    },
    {
      path: `/patient/doctors/${id}/offices`,
      name: DoctorsOffices,
      component: DoctorsOfficesView,
      meta: {
        requiresAuth: true
      }
    }
  ]
})

router.beforeEach((to, from, next) => {
  // Determine if the route requires Authentication
  const requiresAuth = to.matched.some(x => x.meta.requiresAuth);

  // If it does and they are not logged in, send the user to "/login"
  if (requiresAuth && store.state.token === '') {
    next("/login");
  } else {
    // Else let them go to their next destination
    next();
  }
});

export default router;
