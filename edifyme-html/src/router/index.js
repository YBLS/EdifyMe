import Vue from 'vue'
import VueRouter from 'vue-router'

const home = ()=>import('../module/Home/index.vue')

Vue.use(VueRouter)
const routes = [
  {
    path: '/',
    redirect: 'home',
  },
  {
    path: '/home',
    name: 'home',
    component: home
  }
]

const router = new VueRouter({
  routes
})

export default router
