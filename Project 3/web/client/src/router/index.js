import Vue from 'vue'
import VueRouter from 'vue-router'
import loginView from '../views/login.vue'
import SignUp from '../views/signup.vue'
import mainApp from '../views/main.vue'
Vue.use(VueRouter)

  const routes = [
  {
    path: '/',
    name: 'Login',
    component: loginView
  },
  {
    path: '/signup',
    name: 'Sign Up',
    component: SignUp
  },
  {
    path: '/App',
    name: 'App',
    component: mainApp
  }
]

const router = new VueRouter({
  routes
})

export default router
